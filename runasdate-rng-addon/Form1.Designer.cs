
namespace runasdate_rng_addon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InitialSeedInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectRunAsDateDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectRunAsDateButton = new System.Windows.Forms.Button();
            this.RunAsDateDirectoryLabel = new System.Windows.Forms.Label();
            this.VBADirectoryLabel = new System.Windows.Forms.Label();
            this.SelectVBAButton = new System.Windows.Forms.Button();
            this.SelectVBADialog = new System.Windows.Forms.OpenFileDialog();
            this.RunButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InitialSeedInput)).BeginInit();
            this.SuspendLayout();
            // 
            // InitialSeedInput
            // 
            this.InitialSeedInput.Hexadecimal = true;
            this.InitialSeedInput.Location = new System.Drawing.Point(73, 22);
            this.InitialSeedInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.InitialSeedInput.Name = "InitialSeedInput";
            this.InitialSeedInput.Size = new System.Drawing.Size(59, 20);
            this.InitialSeedInput.TabIndex = 0;
            this.InitialSeedInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InitialSeedInput.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(116, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 20);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seed: 0x";
            // 
            // SelectRunAsDateDialog
            // 
            this.SelectRunAsDateDialog.DefaultExt = "exe";
            this.SelectRunAsDateDialog.FileName = "RunAsDate.exe";
            this.SelectRunAsDateDialog.Filter = "Executable Files|*.exe|All files|*.*";
            this.SelectRunAsDateDialog.Title = "Select RunAsDate.exe";
            // 
            // SelectRunAsDateButton
            // 
            this.SelectRunAsDateButton.Location = new System.Drawing.Point(27, 54);
            this.SelectRunAsDateButton.Name = "SelectRunAsDateButton";
            this.SelectRunAsDateButton.Size = new System.Drawing.Size(206, 22);
            this.SelectRunAsDateButton.TabIndex = 4;
            this.SelectRunAsDateButton.Text = "Select RunAsDate";
            this.SelectRunAsDateButton.UseVisualStyleBackColor = true;
            this.SelectRunAsDateButton.Click += new System.EventHandler(this.SelectRunAsDateButton_Click);
            // 
            // RunAsDateDirectoryLabel
            // 
            this.RunAsDateDirectoryLabel.AutoSize = true;
            this.RunAsDateDirectoryLabel.Location = new System.Drawing.Point(24, 79);
            this.RunAsDateDirectoryLabel.Name = "RunAsDateDirectoryLabel";
            this.RunAsDateDirectoryLabel.Size = new System.Drawing.Size(116, 13);
            this.RunAsDateDirectoryLabel.TabIndex = 5;
            this.RunAsDateDirectoryLabel.Text = "RunAsDate Directory...";
            // 
            // VBADirectoryLabel
            // 
            this.VBADirectoryLabel.AutoSize = true;
            this.VBADirectoryLabel.Location = new System.Drawing.Point(24, 126);
            this.VBADirectoryLabel.Name = "VBADirectoryLabel";
            this.VBADirectoryLabel.Size = new System.Drawing.Size(91, 13);
            this.VBADirectoryLabel.TabIndex = 7;
            this.VBADirectoryLabel.Text = "VBA-rr Directory...";
            // 
            // SelectVBAButton
            // 
            this.SelectVBAButton.Location = new System.Drawing.Point(27, 101);
            this.SelectVBAButton.Name = "SelectVBAButton";
            this.SelectVBAButton.Size = new System.Drawing.Size(206, 22);
            this.SelectVBAButton.TabIndex = 6;
            this.SelectVBAButton.Text = "Select VBA-rr";
            this.SelectVBAButton.UseVisualStyleBackColor = true;
            this.SelectVBAButton.Click += new System.EventHandler(this.SelectVBAButton_Click);
            // 
            // SelectVBADialog
            // 
            this.SelectVBADialog.DefaultExt = "exe";
            this.SelectVBADialog.FileName = "VBA-rr-svn480.exe";
            this.SelectVBADialog.Filter = "Executable Files|*.exe|All files|*.*";
            this.SelectVBADialog.Title = "Select VBA-rr";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(123, 21);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 22);
            this.RunButton.TabIndex = 8;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 161);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.VBADirectoryLabel);
            this.Controls.Add(this.SelectVBAButton);
            this.Controls.Add(this.RunAsDateDirectoryLabel);
            this.Controls.Add(this.SelectRunAsDateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InitialSeedInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RunAsDate RNG Helper";
            ((System.ComponentModel.ISupportInitialize)(this.InitialSeedInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown InitialSeedInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog SelectRunAsDateDialog;
        private System.Windows.Forms.Button SelectRunAsDateButton;
        private System.Windows.Forms.Label RunAsDateDirectoryLabel;
        private System.Windows.Forms.Label VBADirectoryLabel;
        private System.Windows.Forms.Button SelectVBAButton;
        private System.Windows.Forms.OpenFileDialog SelectVBADialog;
        private System.Windows.Forms.Button RunButton;
    }
}

