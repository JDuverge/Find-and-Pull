namespace FindAndPull
{
    partial class Preferences
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
            this.labelSave = new System.Windows.Forms.Label();
            this.labelFind = new System.Windows.Forms.Label();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogSave = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonFileBrowse = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Location = new System.Drawing.Point(24, 51);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(405, 22);
            this.labelSave.TabIndex = 0;
            this.labelSave.Text = "Choose default location on PC to save files:";
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(24, 130);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(421, 22);
            this.labelFind.TabIndex = 1;
            this.labelFind.Text = "Choose default location on phone to search:";
            // 
            // textBoxSave
            // 
            this.helpProvider.SetHelpString(this.textBoxSave, "Choose where on the PC you\'d like to save the pulled files.");
            this.textBoxSave.Location = new System.Drawing.Point(24, 76);
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.ReadOnly = true;
            this.helpProvider.SetShowHelp(this.textBoxSave, true);
            this.textBoxSave.Size = new System.Drawing.Size(408, 31);
            this.textBoxSave.TabIndex = 2;
            // 
            // buttonFileBrowse
            // 
            this.buttonFileBrowse.Image = global::FindAndPull.Properties.Resources.folder;
            this.buttonFileBrowse.Location = new System.Drawing.Point(438, 51);
            this.buttonFileBrowse.Name = "buttonFileBrowse";
            this.buttonFileBrowse.Size = new System.Drawing.Size(57, 56);
            this.buttonFileBrowse.TabIndex = 4;
            this.buttonFileBrowse.UseVisualStyleBackColor = true;
            this.buttonFileBrowse.Click += new System.EventHandler(this.buttonFileBrowse_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(74, 379);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(92, 36);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.Validating += new System.ComponentModel.CancelEventHandler(this.buttonOK_Validating);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(352, 379);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 36);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReset
            // 
            this.helpProvider.SetHelpKeyword(this.buttonReset, "reset");
            this.helpProvider.SetHelpString(this.buttonReset, "Changes PC location to \"C:\" and Phone location to \".\".");
            this.buttonReset.Location = new System.Drawing.Point(213, 379);
            this.buttonReset.Name = "buttonReset";
            this.helpProvider.SetShowHelp(this.buttonReset, true);
            this.buttonReset.Size = new System.Drawing.Size(92, 36);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 200;
            this.errorProvider.ContainerControl = this;
            // 
            // comboBoxFind
            // 
            this.comboBoxFind.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.comboBoxFind, "Choose location on device to search for files.");
            this.comboBoxFind.Items.AddRange(new object[] {
            ".",
            "./cache",
            "./cache/dalvik-cache",
            "./data",
            "./data/app",
            "./data/data",
            "./etc",
            "./sd-ext",
            "./sdcard",
            "./system",
            "./system/app",
            "./system/bin",
            "./system/etc",
            "./system/framework",
            "./system/lib",
            "./system/media",
            "./system/xbin"});
            this.comboBoxFind.Location = new System.Drawing.Point(24, 155);
            this.comboBoxFind.Name = "comboBoxFind";
            this.helpProvider.SetShowHelp(this.comboBoxFind, true);
            this.comboBoxFind.Size = new System.Drawing.Size(408, 30);
            this.comboBoxFind.TabIndex = 8;
            // 
            // numericUpDown
            // 
            this.helpProvider.SetHelpString(this.numericUpDown, "Positive number: Modified days greater than number chosen. Negative number: Modif" +
                    "ied days less than number chosen. Zero: no time limit at all.");
            this.numericUpDown.Location = new System.Drawing.Point(178, 229);
            this.numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericUpDown.Name = "numericUpDown";
            this.helpProvider.SetShowHelp(this.numericUpDown, true);
            this.numericUpDown.Size = new System.Drawing.Size(162, 31);
            this.numericUpDown.TabIndex = 10;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(24, 204);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(312, 22);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Choose date limits for the search:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(28, 287);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(329, 22);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "Choose what type of file to search:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Files",
            "Directories"});
            this.comboBoxType.Location = new System.Drawing.Point(178, 312);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(162, 30);
            this.comboBoxType.TabIndex = 12;
            // 
            // Preferences
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(519, 462);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxFind);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonFileBrowse);
            this.Controls.Add(this.textBoxSave);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.labelSave);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(535, 500);
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSave;
        private System.Windows.Forms.Button buttonFileBrowse;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox comboBoxFind;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
    }
}