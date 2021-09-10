using DeleteLines.Domain;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DeleteLines
{
    public partial class MainFrm : Form
    {
        //create logger
        private static NLog.ILogger logger = LogManager.GetLogger("Nlog.config");

        public MainFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.helpProvider1.HelpNamespace = "DeleteLineHelp.chm";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseBTN_Click(object sender, EventArgs e)
        {
            logger.Info("Clicked browse file button");

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.folderTXTBX.Text = this.folderBrowserDialog1.SelectedPath;
                logger.Info("folderTXTBX.Text set to " + this.folderTXTBX.Text);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileScanBTN_Click(object sender, EventArgs e)
        {
            logger.Info("Clicked scan file button");
            logger.Info("Folder scan performed on " + this.folderTXTBX.Text);

            if (ValidateFolderText() && ValidateExText())
            {
                string folder = this.folderTXTBX.Text;
                string exts = this.extensionsTXTBX.Text;
                bool result = false;

                result = DeleteLineUtil.PopulateListBoxWithFileNames(folder, exts, this.fileListLSTBOX);

                if (!result)
                {
                    MessageBox.Show("Sorry there was an Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            logger.Info("Clicked delete button");

            if (ValidateForm())
            {
                string folder = this.folderTXTBX.Text;
                bool createBackup = true;
                bool result = false;
                int lineNumber = int.Parse(lineTXTBX.Text);
                List<string> filenames = new List<string>();

                foreach (string x in this.fileListLSTBOX.Items)
                {
                    filenames.Add(x);
                }

                if (this.checkBox1.CheckState == CheckState.Unchecked)
                {
                    createBackup = false;
                }

                result = DeleteLineUtil.PerformDelete(folder, createBackup, filenames, lineNumber);

                if (result)
                {
                    MessageBox.Show("Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sorry there was an Error, No delete performed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void folderTXTBX_Validating(object sender, EventArgs e)
        {
            ValidateFolderText();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void extensionsTXTBX_Validating(object sender, CancelEventArgs e)
        {
            ValidateExText();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lineTXTBX_Validating(object sender, CancelEventArgs e)
        {
            ValidateLineNumberText();
        }

        /// <summary>
        /// Validates the form
        /// </summary>
        /// <returns>Returns True if the form is valid</returns>
        private bool ValidateForm()
        {
            bool result = false;

            bool bValidLineNumber = DeleteLineValidator.ValidateTextBox(lineTXTBX, errorProvider1, "Please enter a valid number", true);
            bool bValidateExText = DeleteLineValidator.ValidateTextBox(folderTXTBX, errorProvider1, "Please select a folder!", false);
            bool bValidateFolderText = DeleteLineValidator.ValidateTextBox(extensionsTXTBX, errorProvider1, "Please enter a file extension e.g. *.txt", false);

            if (bValidLineNumber && bValidateExText && bValidateFolderText)
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Checks if the File Extension textbox is valid
        /// </summary>
        /// <returns>Returns true if File Extension textbox is populated</returns>
        private bool ValidateExText()
        {
            bool bStatus = DeleteLineValidator.ValidateTextBox(extensionsTXTBX, errorProvider1, "Please enter a file extension e.g. *.txt", false);

            return bStatus;
        }

        /// <summary>
        /// Checks if the line number textbox is valid
        /// </summary>
        /// <returns>Returns true if line number textbox is populated</returns>
        private bool ValidateLineNumberText()
        {
            bool bStatus = DeleteLineValidator.ValidateTextBox(lineTXTBX, errorProvider1, "Please enter a valid number", true);

            return bStatus;
        }

        /// <summary>
        /// Checks if the folder textbox is valid
        /// </summary>
        /// <returns>Returns true if folder textbox is populated</returns>
        private bool ValidateFolderText()
        {
            bool bStatus = DeleteLineValidator.ValidateTextBox(folderTXTBX, errorProvider1, "Please select a folder!", false);

            return bStatus;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Info("Close menu item clicked");
            this.Close();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Info("About menu item clicked");
            AboutBoxFrm aboutBox = new AboutBoxFrm();
            aboutBox.ShowDialog();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}