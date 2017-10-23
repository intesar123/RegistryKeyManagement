using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistryKeyManaget
{
    public partial class RegkeyManager : Form
    {
        public RegkeyManager()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void filechooser_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtprotocol.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Url Protocol.");
                    return;
                }
                if (txtexepath.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Executable Path.");
                    return;
                }
                string protocol = txtprotocol.Text.Trim();
                RegistryKey rKey = Registry.ClassesRoot.OpenSubKey(protocol, true);
                if (rKey == null)
                {
                    rKey = Registry.ClassesRoot.CreateSubKey(protocol);
                    rKey.SetValue("", "URL: " + protocol + " Protocol");
                    rKey.SetValue("URL Protocol", "");

                    rKey = rKey.CreateSubKey(@"shell\open\command");
                    rKey.SetValue("", "\"" + txtexepath.Text.Trim() + "\" %1");

                    MessageBox.Show("Successfully Created");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Url Protocol Already Exist! Do you want to delete it?", "Alert", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        string[] subkeynames = rKey.GetSubKeyNames();
                        foreach (string subkey in subkeynames)
                        {
                           // rKey.DeleteValue(subkey);
                            rKey.DeleteSubKeyTree(subkey);
                        }
                        Registry.ClassesRoot.DeleteSubKey(protocol);
                        MessageBox.Show("Successfully Deleted");
                    }
                    
                }
                if (rKey != null)
                {
                    rKey.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
        private void filechooser_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            //fd.InitialDirectory = "c:\\";
            Stream myStream = null;
            fd.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = fd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                    txtexepath.Text = fd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            //fd.InitialDirectory = "c:\\";
            Stream myStream = null;
            fd.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = fd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }

                    txtexepath1.Text = Path.GetDirectoryName(fd.FileName);
                    checkFileContent(Path.Combine(txtexepath1.Text.Trim(), "hostsetting.txt"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        public void checkFileContent(string file)
        {
            
            if (File.Exists(file))
            {
                using (StreamReader sr = File.OpenText(file))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] strarr = s.Split('|');
                        if (strarr.Length == 11)
                        {
                            txthostip.Text = strarr[0];
                            txthostport.Text = strarr[1];
                            txtserver.Text = strarr[2];
                            txtdb.Text = strarr[3];
                            txtuser.Text = strarr[4];
                            txtpassword.Text = strarr[5];
                            txttable.Text = strarr[7];
                            txtfield.Text = strarr[8];
                            txtkeyfield.Text = strarr[9];
                            if(Convert.ToInt32(strarr[6])==1)
                            {
                                chkusedb.Checked = true;
                            }
                            else
                            {
                                chkusedb.Checked = false;
                            }
                            if (Convert.ToInt32(strarr[10]) == 1)
                            {
                                chkinsert.Checked = true;
                            }
                            else
                            {
                                chkinsert.Checked = false;
                            }
                        }
                    }
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string fileName = Path.Combine(txtexepath1.Text.Trim(),"hostsetting.txt");

            try
            {
                if (txthostip.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Host IP.");
                    return;
                }
                if (txthostport.Text.Length==0)
                {
                    MessageBox.Show("Please Enter Host Port.");
                    return;
                }
                if (txtexepath1.Text.Length == 0)
                {
                    MessageBox.Show("Please Choose Directory for Host Setting.");
                    return;
                }
                int isdb = 0;
                int isinsert = 0;
                if (chkusedb.Checked)
                {
                    isdb = 1;
                    if(txtserver.Text.Length==0)
                    {
                        MessageBox.Show("Please Enter Database Server.");
                        return;
                    }
                    if (txtdb.Text.Length == 0)
                    {
                        MessageBox.Show("Please Enter Database Name.");
                        return;
                    }
                    if (txtuser.Text.Length == 0)
                    {
                        MessageBox.Show("Please Enter Database User.");
                        return;
                    }
                    if (txtpassword.Text.Length == 0)
                    {
                        MessageBox.Show("Please Enter Database Password.");
                        return;
                    }
                    if (txttable.Text.Length == 0)
                    {
                        MessageBox.Show("Please Enter Database Table Name.");
                        return;
                    }
                    if (txtfield.Text.Length == 0)
                    {
                        MessageBox.Show("Please Enter Field to Update.");
                        return;
                    }
                    if (txtkeyfield.Text.Length == 0)
                    {
                        MessageBox.Show("Please Enter Database Key Field.");
                        return;
                    }
                }
                if(chkinsert.Checked)
                {
                    isinsert = 1;
                }
                // Check if file already exists. If yes, delete it. 
                if (File.Exists(fileName))
                {
                    DialogResult dr = MessageBox.Show("File alreaady Exist!Would you recreate it?", "Alert", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        File.Delete(fileName);
                    }
                    else
                    {
                        return;
                    }
                    
                }

                // Create a new file 
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file
                    Byte[] title = new UTF8Encoding(true).GetBytes(txthostip.Text.Trim() + "|"+txthostport.Text.Trim() + "|" + txtserver.Text.Trim() + "|" + txtdb.Text.Trim() + "|" + txtuser.Text.Trim() + "|" + txtpassword.Text.Trim() + "|" + isdb + "|" + txttable.Text.Trim()+ "|" + txtfield.Text.Trim() + "|" + txtkeyfield.Text.Trim()+"|"+isinsert);
                    fs.Write(title, 0, title.Length);
                    //byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                    //fs.Write(author, 0, author.Length);
                }

                //// Open the stream and read it back.
                //using (StreamReader sr = File.OpenText(fileName))
                //{
                //    string s = "";
                //    while ((s = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(s);
                //    }
                //}
                MessageBox.Show("Saved Successfully.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void RegkeyManager_Load(object sender, EventArgs e)
        {
 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txthostip_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkusedb.Checked)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }

}
