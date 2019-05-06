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
            //Loading input file information
            txtFormat.Text = "CSV";
            txtNumberofRecords.Text = "3";
            txtFileName.Text = "C:\\Projects\\ReadWriteFile\\ReadWriteFile\\bin\\Debug\\InputFile.CSV";
            lblOutput.Text = "";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {            
            //read text file using StreamReader
            StreamReader reader = new StreamReader(txtFileName.Text);
            rtxData.Text = reader.ReadToEnd();           
            reader.Close();            
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string[] lines = this.rtxData.Lines;
            string correctFormatFile = "OutputFileCorrectFormated.csv";
            string inCorrectFormatFile = "OutputFileInCorrectFormated.csv";
            string rootFolder = "C:\\Projects\\ReadWriteFile\\ReadWriteFile\\bin\\Debug\\";
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(rootFolder, correctFormatFile)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(rootFolder, correctFormatFile));
                }

                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(rootFolder, inCorrectFormatFile)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(rootFolder, inCorrectFormatFile));
                }

                // Write to the output files form rtxData
                for (int i = 1; i < lines.Length; i++)
                {
                    string lineOfText = lines[i];
                    //Split word with ','
                    string[] wordArray = lineOfText.Split(',');
                    //If the line has more than 2 fields. ex: Jane, Taylor, Doe. Write to correctFormatFile
                    if (wordArray.Length > 2)
                    {
                        //Write correctly formatted record to OutputFileCorrectFormated.csv
                        StreamWriter swCorrectFormated = new StreamWriter(correctFormatFile, true);
                        swCorrectFormated.WriteLine(lines[i]);
                        swCorrectFormated.Close();
                    }
                    //if the line has equal or less than 2 fields. ex: Chris, Lee. Write to InCorrectFormatFile                    
                    else
                    {
                        //Write incorrectly formatted record to OutputFileInCorrectFormated.csv                    
                        StreamWriter swInCorrectFormated = new StreamWriter(inCorrectFormatFile, true);
                        swInCorrectFormated.WriteLine(lines[i]);
                        swInCorrectFormated.Close();
                    }
                }            
               
                lblOutput.Text = "The output files are successfully saved at bin/debug folder.";
            }
            catch (Exception ex)
            {
                throw new ApplicationException(string.Format("I cannot write the file {0} to {1}", "InputFile.CSV", "bin/debug"), ex);
            }            
        }
    }
}
