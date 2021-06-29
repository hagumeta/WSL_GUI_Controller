using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WslPortfowardLauncher
{
    class PortfowardLauncher
    {
        const string command = "bash /var/opt/portfoward.sh";

        public CommandResult AddPortfoward(string destribution, int port)
        {
            CommandResult commandResult = new CommandResult();
            commandResult.exitCode = WslController.ExecCommand(
                command + " add " + port.ToString(), 
                out commandResult.stdOut, 
                out commandResult.stdErr,
                destribution
               );
            return commandResult;
        }

        public CommandResult DeletePortfoward(string destribution, int port)
        {
            CommandResult commandResult = new CommandResult();
            commandResult.exitCode = WslController.ExecCommand(
                command + " del " + port.ToString(),
                out commandResult.stdOut,
                out commandResult.stdErr,
                destribution
               );
            return commandResult;
        }

        public CommandResult ListPortfoward(string destribution, int port)
        {
            CommandResult commandResult = new CommandResult();
            commandResult.exitCode = WslController.ExecCommand(
                command + " del " + port.ToString(),
                out commandResult.stdOut,
                out commandResult.stdErr
               );
            return commandResult;
        }
    }

    struct CommandResult
    {
        public int exitCode;
        public string stdOut;
        public string stdErr;
    }
}
