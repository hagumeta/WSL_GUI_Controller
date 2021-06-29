
namespace WslGuiController.Views
{
    partial class PortfowardForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WinPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WslIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WslPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonReload = new MaterialSkin.Controls.MaterialButton();
            this.buttonApply = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Azure;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WinPort,
            this.WslIp,
            this.WslPort,
            this.DeleteButton});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(6, 115);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4);
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(553, 199);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridView1_CellValidating);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            // 
            // WinPort
            // 
            this.WinPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(3);
            this.WinPort.DefaultCellStyle = dataGridViewCellStyle17;
            this.WinPort.FillWeight = 20.12436F;
            this.WinPort.HeaderText = "Windows ポート";
            this.WinPort.Name = "WinPort";
            // 
            // WslIp
            // 
            this.WslIp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.WslIp.DefaultCellStyle = dataGridViewCellStyle18;
            this.WslIp.FillWeight = 250F;
            this.WslIp.HeaderText = "WSL IP (Internal)";
            this.WslIp.Name = "WslIp";
            this.WslIp.ReadOnly = true;
            this.WslIp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WslIp.Width = 150;
            // 
            // WslPort
            // 
            this.WslPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(3);
            this.WslPort.DefaultCellStyle = dataGridViewCellStyle19;
            this.WslPort.FillWeight = 20.12436F;
            this.WslPort.HeaderText = "WSL ポート";
            this.WslPort.Name = "WslPort";
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle20.NullValue = "削除";
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle20;
            this.DeleteButton.FillWeight = 0.6869307F;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 50;
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonReload.Depth = 0;
            this.buttonReload.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReload.HighEmphasis = true;
            this.buttonReload.Icon = null;
            this.buttonReload.Location = new System.Drawing.Point(445, 70);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonReload.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(113, 36);
            this.buttonReload.TabIndex = 7;
            this.buttonReload.Text = "設定を再読込";
            this.buttonReload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonReload.UseAccentColor = false;
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonApply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonApply.Depth = 0;
            this.buttonApply.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonApply.HighEmphasis = true;
            this.buttonApply.Icon = null;
            this.buttonApply.Location = new System.Drawing.Point(495, 323);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(64, 36);
            this.buttonApply.TabIndex = 8;
            this.buttonApply.Text = "適用";
            this.buttonApply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonApply.UseAccentColor = false;
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // PortfowardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 368);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PortfowardForm";
            this.Text = "WSL Portfoward Setting";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton buttonReload;
        private MaterialSkin.Controls.MaterialButton buttonApply;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn WslIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn WslPort;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}

