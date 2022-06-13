namespace JKLauncher
{
    partial class ConfirmationBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.labeltittle = new System.Windows.Forms.Label();
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton2 = new Guna.UI2.WinForms.Guna2Button();
            this.labelsubtitle = new System.Windows.Forms.Label();
            this.icoLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icoLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // labeltittle
            // 
            this.labeltittle.AutoSize = true;
            this.labeltittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltittle.Location = new System.Drawing.Point(24, 13);
            this.labeltittle.Name = "labeltittle";
            this.labeltittle.Size = new System.Drawing.Size(61, 21);
            this.labeltittle.TabIndex = 0;
            this.labeltittle.Text = "lbltitle";
            // 
            // confirmButton
            // 
            this.confirmButton.BorderRadius = 6;
            this.confirmButton.CheckedState.Parent = this.confirmButton;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.CustomImages.Parent = this.confirmButton;
            this.confirmButton.FillColor = System.Drawing.Color.LimeGreen;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.HoverState.Parent = this.confirmButton;
            this.confirmButton.Location = new System.Drawing.Point(73, 179);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(131, 47);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton2
            // 
            this.cancelButton2.BorderRadius = 6;
            this.cancelButton2.CheckedState.Parent = this.cancelButton2;
            this.cancelButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton2.CustomImages.Parent = this.cancelButton2;
            this.cancelButton2.FillColor = System.Drawing.Color.Silver;
            this.cancelButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton2.ForeColor = System.Drawing.Color.White;
            this.cancelButton2.HoverState.Parent = this.cancelButton2;
            this.cancelButton2.Location = new System.Drawing.Point(231, 179);
            this.cancelButton2.Name = "cancelButton2";
            this.cancelButton2.ShadowDecoration.Parent = this.cancelButton2;
            this.cancelButton2.Size = new System.Drawing.Size(131, 47);
            this.cancelButton2.TabIndex = 2;
            this.cancelButton2.Text = "Cancel";
            this.cancelButton2.Click += new System.EventHandler(this.cancelButton2_Click);
            // 
            // labelsubtitle
            // 
            this.labelsubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsubtitle.Location = new System.Drawing.Point(24, 39);
            this.labelsubtitle.Name = "labelsubtitle";
            this.labelsubtitle.Size = new System.Drawing.Size(393, 78);
            this.labelsubtitle.TabIndex = 3;
            this.labelsubtitle.Text = "lbltitle";
            // 
            // icoLabel
            // 
            this.icoLabel.Location = new System.Drawing.Point(175, 99);
            this.icoLabel.Name = "icoLabel";
            this.icoLabel.Size = new System.Drawing.Size(72, 70);
            this.icoLabel.TabIndex = 4;
            this.icoLabel.TabStop = false;
            // 
            // ConfirmationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 238);
            this.Controls.Add(this.icoLabel);
            this.Controls.Add(this.labelsubtitle);
            this.Controls.Add(this.cancelButton2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.labeltittle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfirmationBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmationBox";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.icoLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button cancelButton2;
        private Guna.UI2.WinForms.Guna2Button confirmButton;
        private System.Windows.Forms.Label labeltittle;
        private System.Windows.Forms.PictureBox icoLabel;
        private System.Windows.Forms.Label labelsubtitle;
    }
}