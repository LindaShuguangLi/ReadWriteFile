using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteFile
{
    public partial class ReadWriteForm : Form
    {
        public ReadWriteForm()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {            
            this.txtFormat.Text = "CSV";
            this.txtNumberofRecords.Text = "3";
            this.txtFileName.Text = "C:\\Projects\\ReadWriteFile\\ReadWriteFile\\bin\\Debug\\InputFile.CSV";
            this.lblOutput.Text = "";
        }
       

        private void btnRead_Click(object sender, EventArgs e)
        {         
            //read text file using StreamReader
            StreamReader reader = new StreamReader(this.txtFileName.Text);
            rtxData.Text = reader.ReadToEnd();
            reader.Close();          
         }   

        

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //Write text file using StreamWriter
            //correctly formatted record to OutputFileCorrectFormated.csv
            StreamWriter sw = new StreamWriter("OutputFileCorrectFormated.csv", true);             
            string[] lines = this.rtxData.Lines;
            for (int i = 1; i < lines.Length; i++)
            {
                string lineOfText = lines[i];
                //Split word with ','
                string[] wordArray = lineOfText.Split(',');
                //ex: Jane, Taylor, Doe
                if (wordArray.Length > 2)
                {
                    sw.WriteLine(lines[i]);                    
                }                
            }            
            sw.Close();

            //Write incorrectly formatted record to OutputFileInCorrectFormated.csv
            StreamWriter sw2 = new StreamWriter("OutputFileInCorrectFormated.csv", true);           
            string[] lines2 = this.rtxData.Lines;
            for (int i = 1; i < lines.Length; i++)
            {
                string lineOfText2= lines2[i];
                string[] wordArray2 = lineOfText2.Split(',');
                //ex: Chris, Lee
                if (wordArray2.Length <= 2)
                {
                    sw2.WriteLine(lines2[i]);
                }                
            }            
            sw2.Close();
            lblOutput.Text = "The output files are successfully saved at bin/debug folder.";
        }
    }
}
