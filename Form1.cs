using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin.Properties;

namespace WslPortfowardLauncher
{
    public partial class Form1 : MaterialForm
    {
        protected enum DataColumn : ushort
        {
            WinPort = 0,
            WslIp = 1,
            WslPort = 2,
            deleteButton = 3
        }

        CoreController coreController;
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.Columns[DataColumn.WinPort.ToString()].ValueType = typeof(int);
            this.dataGridView1.Columns[DataColumn.WslIp.ToString()].ValueType = typeof(string);
            this.dataGridView1.Columns[DataColumn.WslPort.ToString()].ValueType = typeof(int);

            this.coreController = new CoreController();
            this.LoadPortfowardList();
        }

        public void LoadPortfowardList()
        {
            coreController.Init();
            this.dataGridView1.Rows.Clear();
            int index = 0;
            foreach (var portfoward in coreController.Portfowards)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[DataColumn.WinPort.ToString()].Value = portfoward.WindowsPort;
                this.dataGridView1.Rows[index].Cells[DataColumn.WslIp.ToString()].Value = portfoward.WslIp;
                this.dataGridView1.Rows[index].Cells[DataColumn.WslPort.ToString()].Value = portfoward.WslPort;
                index++;
            }
        }

        public void ApplyPortfoward()
        {
            List<Portfoward> newPortfowards = new List<Portfoward>();
            for (var i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                if (
                    this.dataGridView1.Rows[i].Cells[DataColumn.WinPort.ToString()].Value != null
                    && this.dataGridView1.Rows[i].Cells[DataColumn.WslPort.ToString()].Value != null
                    )
                {
                    var portfoward = new Portfoward();
                    portfoward.WindowsPort = Int32.Parse(
                        this.dataGridView1.Rows[i].Cells[DataColumn.WinPort.ToString()].Value.ToString()
                        );
                    portfoward.WslPort = Int32.Parse(
                        this.dataGridView1.Rows[i].Cells[DataColumn.WslPort.ToString()].Value.ToString()
                        );
                    newPortfowards.Add(portfoward);
                }
            }
            this.coreController.ApplyPortfoward(newPortfowards);
            this.LoadPortfowardList();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            this.LoadPortfowardList();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.ApplyPortfoward();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (int)DataColumn.deleteButton)
            {
                if (e.RowIndex + 1 < this.dataGridView1.RowCount)
                {
                    this.dataGridView1.Rows.Remove(this.dataGridView1.Rows[e.RowIndex]);
                }
            }
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
        }
        private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (!dgv.IsCurrentCellDirty)
            {
                return;
            }
            if (e.ColumnIndex == (int)DataColumn.WinPort 
                || e.ColumnIndex == (int)DataColumn.WslPort)
            {
                int val;
                Int32.TryParse(e.FormattedValue.ToString(), out val);
                if (! (0 < val && val <= 65535) )
                {
                    //ポート番号エラー
                    dgv.CancelEdit();
                }
            }

        }
    }
}
