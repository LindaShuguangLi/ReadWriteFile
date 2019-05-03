namespace ReadWriteFile
{
    partial class ReadWriteForm
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.lblFileFormat = new System.Windows.Forms.Label();
            this.lblNoFields = new System.Windows.Forms.Label();
            this.txtNumberofRecords = new System.Windows.Forms.TextBox();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.lblFileLocation = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.rtxData = new System.Windows.Forms.RichTextBox();
            this.lblInputData = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(690, 215);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(690, 261);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // lblFileFormat
            // 
            this.lblFileFormat.AutoSize = true;
            this.lblFileFormat.Location = new System.Drawing.Point(86, 90);
            this.lblFileFormat.Name = "lblFileFormat";
            this.lblFileFormat.Size = new System.Drawing.Size(117, 13);
            this.lblFileFormat.TabIndex = 4;
            this.lblFileFormat.Text = "File Format (CSV/TSV):";
            // 
            // lblNoFields
            // 
            this.lblNoFields.AutoSize = true;
            this.lblNoFields.Location = new System.Drawing.Point(86, 126);
            this.lblNoFields.Name = "lblNoFields";
            this.lblNoFields.Size = new System.Drawing.Size(189, 13);
            this.lblNoFields.TabIndex = 6;
            this.lblNoFields.Text = "Numbers of fields each record contain:";
            
            // 
            // txtNumberofRecords
            // 
            this.txtNumberofRecords.Location = new System.Drawing.Point(339, 123);
            this.txtNumberofRecords.Name = "txtNumberofRecords";
            this.txtNumberofRecords.Size = new System.Drawing.Size(293, 20);
            this.txtNumberofRecords.TabIndex = 7;
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(339, 90);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(293, 20);
            this.txtFormat.TabIndex = 8;
            // 
            // lblFileLocation
            // 
            this.lblFileLocation.AutoSize = true;
            this.lblFileLocation.Location = new System.Drawing.Point(86, 52);
            this.lblFileLocation.Name = "lblFileLocation";
            this.lblFileLocation.Size = new System.Drawing.Size(70, 13);
            this.lblFileLocation.TabIndex = 9;
            this.lblFileLocation.Text = "File Location:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(339, 49);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(293, 20);
            this.txtFileName.TabIndex = 10;
            // 
            // rtxData
            // 
            this.rtxData.Location = new System.Drawing.Point(339, 166);
            this.rtxData.Name = "rtxData";
            this.rtxData.Size = new System.Drawing.Size(293, 118);
            this.rtxData.TabIndex = 12;
            this.rtxData.Text = "";
            // 
            // lblInputData
            // 
            this.lblInputData.AutoSize = true;
            this.lblInputData.Location = new System.Drawing.Point(89, 225);
            this.lblInputData.Name = "lblInputData";
            this.lblInputData.Size = new System.Drawing.Size(105, 13);
            this.lblInputData.TabIndex = 13;
            this.lblInputData.Text = "Data From Input File:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(89, 304);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 14;
            // 
            // ReadWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 355);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInputData);
            this.Controls.Add(this.rtxData);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileLocation);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.txtNumberofRecords);
            this.Controls.Add(this.lblNoFields);
            this.Controls.Add(this.lblFileFormat);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Name = "ReadWriteForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label lblFileFormat;
        private System.Windows.Forms.Label lblNoFields;
        private System.Windows.Forms.TextBox txtNumberofRecords;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label lblFileLocation;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.RichTextBox rtxData;
        private System.Windows.Forms.Label lblInputData;
        private System.Windows.Forms.Label lblOutput;
    }
}

