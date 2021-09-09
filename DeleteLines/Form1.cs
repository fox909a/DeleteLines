using DeleteLines.Domain;
using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DeleteLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(this.textBox1.Text);

            string rawList = this.textBox2.Text;
            string[] splits = rawList.Split(',');

            this.listBox1.Items.Clear();

            foreach (string split in splits)
            {
                foreach (FileInfo fileInfo in di.GetFiles(split, SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Add(fileInfo.Name);
                }
            }
        }

        /// <summary>
        /// Checks if the line number textbox is valid
        /// </summary>
        /// <returns>Returns true if line number textbox is populated</returns>
        private bool ValidateLineNumberText()
        {
            bool bStatus = DeleteLineValidator.ValidateTextBox(textBox3, errorProvider1, "Please enter a valid number", true);

            return bStatus;
        }

        /// <summary>
        /// Checks if the folder textbox is valid
        /// </summary>
        /// <returns>Returns true if folder textbox is populated</returns>
        private bool ValidateFolderText()
        {
            bool bStatus = DeleteLineValidator.ValidateTextBox(textBox1, errorProvider1, "Please select a folder!", false);

            return bStatus;
        }

        /// <summary>
        /// Checks if the File Extension textbox is valid
        /// </summary>
        /// <returns>Returns true if File Extension textbox is populated</returns>
        private bool ValidateExText()
        {
            bool bStatus = DeleteLineValidator.ValidateTextBox(textBox2, errorProvider1, "Please enter a file extension e.g. *.txt", false);

            return bStatus;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string backupLocation = this.textBox1.Text + @"\backups";
                string loc = this.textBox1.Text;

                if (checkBox1.CheckState == CheckState.Checked)
                {
                    System.IO.Directory.CreateDirectory(backupLocation);

                    foreach (string fileLocation in listBox1.Items)
                    {
                        System.IO.File.Copy(this.textBox1.Text + @"\" + fileLocation, backupLocation + @"\" + fileLocation, true);
                    }
                }

                foreach (string fileLocation in listBox1.Items)
                {
                    string filename = loc + @"\" + fileLocation;

                    StringBuilder sb = new StringBuilder();
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        int Countup = 0;
                        while (!sr.EndOfStream)
                        {
                            Countup++;
                            if (Countup != int.Parse(this.textBox3.Text))
                            {
                                using (StringWriter sw = new StringWriter(sb))
                                {
                                    sw.WriteLine(sr.ReadLine());
                                }
                            }
                            else
                            {
                                sr.ReadLine();
                            }
                        }
                    }

                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        sw.Write(sb.ToString());
                    }
                }
                MessageBox.Show("Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Validates the form
        /// </summary>
        /// <returns>Returns True if the form is valid</returns>
        private bool ValidateForm()
        {
            bool result = false;

            bool bValidLineNumber = DeleteLineValidator.ValidateTextBox(textBox3, errorProvider1, "Please enter a valid number", true);
            bool bValidateExText = DeleteLineValidator.ValidateTextBox(textBox1, errorProvider1, "Please select a folder!", false);
            bool bValidateFolderText = DeleteLineValidator.ValidateTextBox(textBox2, errorProvider1, "Please enter a file extension e.g. *.txt", false);

            if (bValidLineNumber && bValidateExText && bValidateFolderText)
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateFolderText();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            ValidateExText();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            ValidateLineNumberText();
        }
    }
}