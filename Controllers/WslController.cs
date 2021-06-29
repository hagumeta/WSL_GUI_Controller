using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace WslGuiController.Controllers
{
    using Models;

    public static class WslController
    {
        private static int ExecWslCommand(string command, out string stdOut, out string stdErr, Encoding encoding = null)
        {
            int exitCode;

            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.StandardOutputEncoding = encoding ?? Encoding.Default;
            processInfo.Arguments = "/c wsl " + command;
            Process process = Process.Start(processInfo);
            process.WaitForExit();
            stdOut = process.StandardOutput.ReadToEnd();
            stdErr = process.StandardError.ReadToEnd();
            exitCode = process.ExitCode;
            process.Close();

            return exitCode;
        }

        public static int ExecCommand(string executeCommand, out string stdOut, out string stdErr, string distribution="")
        {
            int exitCode;

            var cmd = " --distribution " + distribution + " --exec " + executeCommand;
            exitCode = ExecWslCommand(cmd, out stdOut, out stdErr);
            
            return exitCode;
        }

        public static List<Destribution> GetDestributions()
        {
            string stdOut, stdErr;
            var cmd = " --list ";
            ExecWslCommand(cmd, out stdOut, out stdErr, Encoding.Unicode);
            string[] delimiter = { "\r\n" };
            var names = stdOut.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            names[1] = names[1].Replace("(既定)", "");
            List<Destribution> destributions = new List<Destribution>();
            var ip = GetWslIp();
            foreach (var dest in names.Skip(1).ToList<String>())
            {
                var _dest = dest.Trim();
                destributions.Add(new Destribution(_dest, ip));
            }
            return destributions;
        }

        public static string GetWslIp()
        {
            string stdOut, stdErr;
            var cmd = "ip a show dev eth0 ^| grep ^'inet ^' ^| awk ^'{print $2}^' ^| awk -F ^'/^' ^'{print $1}^'";
            ExecWslCommand(cmd, out stdOut, out stdErr);
            return stdOut.Trim();
        }

        public static List<Portfoward> GetPortfowards()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.StandardOutputEncoding = Encoding.Default;
            processInfo.Arguments = "/c netsh interface portproxy show v4tov4";
            Process process = Process.Start(processInfo);
            process.WaitForExit();

            string stdOut = process.StandardOutput.ReadToEnd();
            process.Close();

            List<Portfoward> portfowards = new List<Portfoward>();
            string[] del = { "\r\n" };
            var lines = stdOut.Split(del, StringSplitOptions.RemoveEmptyEntries);
            foreach (var portproxy in lines.Skip(3))
            {
                string[] delimiter = { " " };
                var list = portproxy.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                Portfoward portfoward = new Portfoward(Int32.Parse(list[1]), list[2], Int32.Parse(list[3]));
                portfowards.Add(portfoward);
            }
            return portfowards;
        }

        public static void AddPortfoward(Portfoward portfoward)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("netsh.exe");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.Verb = "runas";
            processInfo.ErrorDialog = true;
            processInfo.ErrorDialogParentHandle = Application.OpenForms[0].Handle;

            var wslIp = GetWslIp();
            Process process = new Process();
            process.StartInfo = processInfo;
            processInfo.Arguments = "interface portproxy add v4tov4 " +
                "listenport=" + portfoward.WindowsPort +
                " connectport=" + portfoward.WslPort +
                " connectaddress=" + wslIp;
            process.Start();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                throw new Exception();
            }
            process.Close();
        }

        public static void DeletePortfoward(Portfoward portfoward)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("netsh.exe");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.Verb = "runas";
            processInfo.ErrorDialog = true;
            processInfo.ErrorDialogParentHandle = Application.OpenForms[0].Handle;

            processInfo.Arguments = "interface portproxy delete v4tov4 " +
                "listenport=" + portfoward.WindowsPort;
            Process process = Process.Start(processInfo);
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                throw new Exception();
            }
            process.Close();
        }
    }
}
