namespace ToggleButtonControl
{
    partial class ToggleButton
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
            this.SwitchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToggleButtonLabel
            // 
            this.ToggleButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToggleButtonLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.ToggleButtonLabel.Location = new System.Drawing.Point(100, 0);
            this.ToggleButtonLabel.Name = "ToggleButtonLabel";
            this.ToggleButtonLabel.Size = new System.Drawing.Size(78, 26);
            this.ToggleButtonLabel.TabIndex = 0;
            this.ToggleButtonLabel.Text = "ON";
            this.ToggleButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SwitchPanel
            // 
            this.SwitchPanel.BackColor = System.Drawing.Color.GreenYellow;
            this.SwitchPanel.Controls.Add(this.SwitchButton);
            this.SwitchPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SwitchPanel.Location = new System.Drawing.Point(0, 0);
            this.SwitchPanel.Name = "SwitchPanel";
            this.SwitchPanel.Size = new System.Drawing.Size(100, 26);
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
            this.SwitchButton.Size = new System.Drawing.Size(50, 26);
            this.SwitchButton.TabIndex = 0;
            this.SwitchButton.UseVisualStyleBackColor = false;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // ToggleButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ToggleButtonLabel);
            this.Controls.Add(this.SwitchPanel);
            this.Name = "ToggleButton";
            this.Size = new System.Drawing.Size(178, 26);
            this.SwitchPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ToggleButtonLabel;
        private System.Windows.Forms.Panel SwitchPanel;
        private System.Windows.Forms.Button SwitchButton;
    }
}
