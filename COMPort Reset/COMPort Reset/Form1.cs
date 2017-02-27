using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using Microsoft.Win32;
using System.IO.Ports;
using System.Diagnostics;



namespace COMPort_Reset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (string s in SerialPort.GetPortNames())
            {
                listBox1.Items.Add(s);
            }
        }

        /* function not expressly needed for v0.1, plan on expanding at later date so placed in own function */

        public void reStart()
        {
            Shutdown.Restart();

        }

        public static bool IsAdministrator()
        {
            
           return GetTokenInfo.IsProcessElevated;


        }
        private void RefreshComs()
        {

            listBox1.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                listBox1.Items.Add(s);
            }
        }

        public void FolderSelect(ref string[] FolderSelect)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                string folderName = folderBrowserDialog1.SelectedPath;
                string FullPath = folderName + "\\ExportedRegValue.reg";


                string regKey = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\COM Name Arbiter";
                string partRegKey = "SYSTEM\\CurrentControlSet\\Control\\COM Name Arbiter";

                FolderSelect[0] = FullPath;
                FolderSelect[1] = regKey;
                FolderSelect[2] = partRegKey;



            }
        }

        #region Export/Import Functions

        public static void ReadKey(string ExportedRegKey, string partRegPath, string fullRegPath)
        {

                RegistryKey key = Registry.LocalMachine.OpenSubKey(partRegPath);
                if (key != null)
                {
                    byte[] o = (byte[])key.GetValue("ComDB");
                    if (o != null)
                    {
                        string path = "\"" + ExportedRegKey + "\"";
                        string key2 = "\"" + fullRegPath + "\"";
                        Process proc = new Process();

                        try
                        {
                            proc.StartInfo.FileName = "regedit.exe";
                            proc.StartInfo.UseShellExecute = false;

                            proc = Process.Start("regedit.exe", "/e " + path + " " + key2);
                            proc.WaitForExit();
                        }
                        catch (Exception)
                        {
                            proc.Dispose();
                        }


                    }
                    else
                    {
                        MessageBox.Show("No Value in COM Name Arbiter");
                    }
                }
          


        }

        #region Import

        public void ImportKey()
        {
            var button = MessageBoxButtons.YesNoCancel;
            string msg = "Do you wish to export the current value stored in registry before importing?  (recommended)";
            string caption = "Export Check";

            
            switch (MessageBox.Show(msg, caption, button))
            {
                case DialogResult.Yes:
                    goto Export;
                case DialogResult.No:
                    goto Import;
                case DialogResult.Cancel:
                    goto Exit;
                   
            }

        Import:
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string FullPath = openFileDialog1.FileName;

                    MessageBox.Show(Convert.ToString(FullPath));

                    Process regeditProcess = Process.Start("regedit.exe", "/s \"" + FullPath +"\"");
                    regeditProcess.WaitForExit();
                }
                
                
                
                return;
            }

        #endregion

        #region Export

        Export:
            {
                string[] exportArray = new string[] { "0", "0", "0" };
                FolderSelect(ref exportArray);

                string ExportedRegKey = exportArray[0];
                string regPath = exportArray[1];
                string partRegPath = exportArray[2];

                MessageBox.Show(ExportedRegKey + "\n" + partRegPath + "\n" + regPath);

                ReadKey(ExportedRegKey, partRegPath, regPath);

                MessageBox.Show("Com Arbiter Registry Key Saved");
                goto Import;

            }

        #endregion

        Exit:
            {
                return;
            }

        }

            


        


        #endregion

        #region ComClear

        private void ComClear()
        {
            /* Start COM Clear */

            string userRoot = "HKEY_LOCAL_MACHINE";
            string subkey = "SYSTEM\\CurrentControlSet\\Control\\COM Name Arbiter";
            string keyName = userRoot + "\\" + subkey;

            RegistryKey key = Registry.LocalMachine.OpenSubKey(subkey);
            byte[] Data = (byte[])key.GetValue("ComDB");

            byte[] ImportData = { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 
                00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 };


            Registry.SetValue(keyName, "ComDB", ImportData, RegistryValueKind.Binary);


            /* End COM Clear */

            /* Prompt for Restart */

            var button = MessageBoxButtons.YesNoCancel;
            string msg = "A restart is required to complete the COM Reset.  Would you like to Restart Now?";
            string caption = "Restart Required";

            
            switch (MessageBox.Show(msg, caption, button))
            {
                case DialogResult.Yes:
                    reStart();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    break;

            /* End Prompt for Restart */
            }
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            bool admin = IsAdministrator();


            if (admin == true)
            {
                Form2 frm = new Form2();
                frm.ShowDialog();
            }
            else {
                MessageBox.Show("This application requires elevated (Administrator) permissions \n Please run this application as an Administrator.");
                Application.Exit();

            }

        }

        private void btnRefreshCOM_Click(object sender, EventArgs e)
        {
            RefreshComs();
        }

        #region Export/Import/Clear Buttons

        private void btnF1RegistryExport_Click(object sender, EventArgs e)
        {
            string[] exportArray = new string[] {"0","0","0"};
            FolderSelect(ref exportArray);

            string ExportedRegKey = exportArray[0];
            string regPath = exportArray[1];
            string partRegPath = exportArray[2];

            MessageBox.Show(ExportedRegKey + "\n" + partRegPath + "\n" + regPath);

            ReadKey(ExportedRegKey, partRegPath, regPath);

        }

        private void btnF1ImportReg_Click(object sender, EventArgs e)
        {
            ImportKey();
        }

        private void btnF1COMClear_Click(object sender, EventArgs e)
        {
            ComClear();
        }

        #endregion


        #region ToolBar

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshComs();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] exportArray = new string[] { "0", "0", "0" };
            FolderSelect(ref exportArray);

            string ExportedRegKey = exportArray[0];
            string regPath = exportArray[1];
            string partRegPath = exportArray[2];

            MessageBox.Show(ExportedRegKey + "\n" + partRegPath + "\n" + regPath);

            ReadKey(ExportedRegKey, partRegPath, regPath);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportKey();
        }

        private void clearCOMPortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComClear();
        }

        #endregion



       
    }
}
