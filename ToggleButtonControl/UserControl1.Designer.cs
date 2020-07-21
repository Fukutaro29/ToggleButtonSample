namespace ToggleButtonControl
{
    partial class ToggleButtonUserForm
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ToggleButtonLabel = new System.Windows.Forms.Label();
            this.SwitchPanel = new System.Windows.Forms.Panel();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SwitchPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToggleButtonLabel
            // 
            this.ToggleButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToggleButtonLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.ToggleButtonLabel.Location = new System.Drawing.Point(86, 0);
            this.ToggleButtonLabel.Name = "ToggleButtonLabel";
            this.ToggleButtonLabel.Size = new System.Drawing.Size(45, 24);
            this.ToggleButtonLabel.TabIndex = 0;
            this.ToggleButtonLabel.Text = "ON";
            this.ToggleButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SwitchPanel
            // 
            this.SwitchPanel.BackColor = System.Drawing.Color.GreenYellow;
            this.SwitchPanel.Controls.Add(this.SwitchButton);
            this.SwitchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchPanel.Location = new System.Drawing.Point(3, 3);
            this.SwitchPanel.Name = "SwitchPanel";
            this.SwitchPanel.Size = new System.Drawing.Size(77, 18);
            this.SwitchPanel.TabIndex = 1;
            // 
            // SwitchButton
            // 
            this.SwitchButton.BackColor = System.Drawing.Color.White;
            this.SwitchButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SwitchButton.FlatAppearance.BorderSize = 0;
            this.SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchButton.Location = new System.Drawing.Point(0, 0);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(42, 18);
            this.SwitchButton.TabIndex = 0;
            this.SwitchButton.UseVisualStyleBackColor = false;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.SwitchPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ToggleButtonLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(134, 24);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ToggleButtonUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ToggleButtonUserForm";
            this.Size = new System.Drawing.Size(134, 24);
            this.SwitchPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ToggleButtonLabel;
        private System.Windows.Forms.Panel SwitchPanel;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
