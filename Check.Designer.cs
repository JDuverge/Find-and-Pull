namespace FindAndPull
{
    partial class Check
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
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonRetry = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.textBoxDevices = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonContinue
            // 
            this.buttonContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonContinue.Location = new System.Drawing.Point(30, 169);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(122, 40);
            this.buttonContinue.TabIndex = 0;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonRetry
            // 
            this.buttonRetry.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.buttonRetry.Location = new System.Drawing.Point(181, 169);
            this.buttonRetry.Name = "buttonRetry";
            this.buttonRetry.Size = new System.Drawing.Size(122, 40);
            this.buttonRetry.TabIndex = 1;
            this.buttonRetry.Text = "Retry";
            this.buttonRetry.UseVisualStyleBackColor = true;
            this.buttonRetry.Click += new System.EventHandler(this.buttonRetry_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEnd.Location = new System.Drawing.Point(332, 169);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(122, 40);
            this.buttonEnd.TabIndex = 2;
            this.buttonEnd.Text = "End";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // textBoxDevices
            // 
            this.textBoxDevices.Location = new System.Drawing.Point(74, 108);
            this.textBoxDevices.Name = "textBoxDevices";
            this.textBoxDevices.Size = new System.Drawing.Size(341, 33);
            this.textBoxDevices.TabIndex = 3;
            this.textBoxDevices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "If you see a device listed below, \r\nselect \'Continue\'. \r\nElse, select \'End\'";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Check
            // 
            this.AcceptButton = this.buttonContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonEnd;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDevices);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonRetry);
            this.Controls.Add(this.buttonContinue);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonRetry;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.TextBox textBoxDevices;
        private System.Windows.Forms.Label label1;
    }
}