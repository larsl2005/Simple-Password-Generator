namespace Simple_Password_Generator
{
    partial class PasswordGen
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gen2File = new System.Windows.Forms.Button();
            this.PassLength = new System.Windows.Forms.NumericUpDown();
            this.Gen = new System.Windows.Forms.Button();
            this.PassResult = new System.Windows.Forms.TextBox();
            this.Special1 = new System.Windows.Forms.CheckBox();
            this.Special2 = new System.Windows.Forms.CheckBox();
            this.BulkGenAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PassLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulkGenAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Length (8-256)";
            // 
            // Gen2File
            // 
            this.Gen2File.Location = new System.Drawing.Point(0, 118);
            this.Gen2File.Name = "Gen2File";
            this.Gen2File.Size = new System.Drawing.Size(239, 32);
            this.Gen2File.TabIndex = 9;
            this.Gen2File.Text = "GENERATE TO FILE";
            this.Gen2File.UseVisualStyleBackColor = true;
            this.Gen2File.Click += new System.EventHandler(this.Gen2File_Click);
            // 
            // PassLength
            // 
            this.PassLength.Location = new System.Drawing.Point(203, 57);
            this.PassLength.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.PassLength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.PassLength.Name = "PassLength";
            this.PassLength.Size = new System.Drawing.Size(38, 20);
            this.PassLength.TabIndex = 8;
            this.PassLength.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // Gen
            // 
            this.Gen.Location = new System.Drawing.Point(-1, 156);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(239, 92);
            this.Gen.TabIndex = 7;
            this.Gen.Text = "GENERATE!";
            this.Gen.UseVisualStyleBackColor = true;
            this.Gen.Click += new System.EventHandler(this.Gen_Click);
            // 
            // PassResult
            // 
            this.PassResult.Location = new System.Drawing.Point(1, 31);
            this.PassResult.Name = "PassResult";
            this.PassResult.Size = new System.Drawing.Size(239, 20);
            this.PassResult.TabIndex = 6;
            // 
            // Special1
            // 
            this.Special1.AutoSize = true;
            this.Special1.Location = new System.Drawing.Point(0, 59);
            this.Special1.Name = "Special1";
            this.Special1.Size = new System.Drawing.Size(115, 17);
            this.Special1.TabIndex = 11;
            this.Special1.Text = "Special Characters";
            this.Special1.UseVisualStyleBackColor = true;
            // 
            // Special2
            // 
            this.Special2.AutoSize = true;
            this.Special2.Location = new System.Drawing.Point(0, 82);
            this.Special2.Name = "Special2";
            this.Special2.Size = new System.Drawing.Size(61, 17);
            this.Special2.TabIndex = 12;
            this.Special2.Text = "Diatrics";
            this.Special2.UseVisualStyleBackColor = true;
            // 
            // BulkGenAmount
            // 
            this.BulkGenAmount.Location = new System.Drawing.Point(203, 83);
            this.BulkGenAmount.Maximum = new decimal(new int[] {
            1321730048,
            465661287,
            0,
            0});
            this.BulkGenAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BulkGenAmount.Name = "BulkGenAmount";
            this.BulkGenAmount.Size = new System.Drawing.Size(38, 20);
            this.BulkGenAmount.TabIndex = 14;
            this.BulkGenAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Generate times (file only)";
            // 
            // PasswordGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 251);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BulkGenAmount);
            this.Controls.Add(this.Special2);
            this.Controls.Add(this.Special1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gen2File);
            this.Controls.Add(this.PassLength);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.PassResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PasswordGen";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.PassLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulkGenAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gen2File;
        private System.Windows.Forms.NumericUpDown PassLength;
        private System.Windows.Forms.Button Gen;
        private System.Windows.Forms.TextBox PassResult;
        private System.Windows.Forms.CheckBox Special1;
        private System.Windows.Forms.CheckBox Special2;
        private System.Windows.Forms.NumericUpDown BulkGenAmount;
        private System.Windows.Forms.Label label2;
    }
}

