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

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

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

        private bool ValidateLineNumberText()
        {
            bool bStatus = true;
            bool isNumber = false;

            isNumber = int.TryParse(this.textBox3.Text, out int n);

            if (string.IsNullOrEmpty(this.textBox3.Text) || !isNumber)
            {
                errorProvider1.SetError(textBox3, "Please enter a valid number");
                bStatus = false;
            }

            return bStatus;
        }

        private bool ValidateFolderText()
        {
            bool bStatus = true;


            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Please select a valid folder");
                bStatus = false;
            }

            return bStatus;
        }

        private bool ValidateExText()
        {
            bool bStatus = true;


            if (string.IsNullOrEmpty(this.textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Please enter a file extension e.g. *.txt");
                bStatus = false;
            }

            return bStatus;
        }


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

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            ValidateLineNumberText();
        }

        private bool ValidateForm()
        {
            bool result = false;
            bool bValidLineNumber = ValidateLineNumberText();
            bool bValidateExText = ValidateExText();
            bool bValidateFolderText = ValidateFolderText();

            if (bValidLineNumber && bValidateExText && bValidateFolderText)
            {
                result = true;
            }

            return result;
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            ValidateExText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateFolderText();
        }
    }
}