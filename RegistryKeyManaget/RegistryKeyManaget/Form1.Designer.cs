namespace RegistryKeyManaget
{
    partial class RegkeyManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegkeyManager));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkusedb = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtexepath1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txthostport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthostip = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtexepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprotocol = new System.Windows.Forms.TextBox();
            this.filechooser = new System.Windows.Forms.Button();
            this.dbtab = new System.Windows.Forms.TabControl();
            this.label11 = new System.Windows.Forms.Label();
            this.txttable = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtfield = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtkeyfield = new System.Windows.Forms.TextBox();
            this.chkinsert = new System.Windows.Forms.CheckBox();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dbtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(871, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Host Setting";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.chkinsert);
            this.panel2.Controls.Add(this.chkusedb);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtexepath1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txthostport);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txthostip);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 375);
            this.panel2.TabIndex = 0;
            // 
            // chkusedb
            // 
            this.chkusedb.AutoSize = true;
            this.chkusedb.Location = new System.Drawing.Point(19, 98);
            this.chkusedb.Name = "chkusedb";
            this.chkusedb.Size = new System.Drawing.Size(242, 17);
            this.chkusedb.TabIndex = 18;
            this.chkusedb.Text = "Use Database to save scanned Image";
            this.chkusedb.UseVisualStyleBackColor = true;
            this.chkusedb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtkeyfield);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtfield);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txttable);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtpassword);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtuser);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtdb);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtserver);
            this.panel3.Location = new System.Drawing.Point(19, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 134);
            this.panel3.TabIndex = 17;
            this.panel3.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(126, 97);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(298, 20);
            this.txtpassword.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "User";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(126, 69);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(298, 20);
            this.txtuser.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Database";
            // 
            // txtdb
            // 
            this.txtdb.Location = new System.Drawing.Point(126, 43);
            this.txtdb.Name = "txtdb";
            this.txtdb.Size = new System.Drawing.Size(298, 20);
            this.txtdb.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Server";
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(126, 13);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(298, 20);
            this.txtserver.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Executable Path";
            // 
            // txtexepath1
            // 
            this.txtexepath1.Location = new System.Drawing.Point(122, 65);
            this.txtexepath1.Name = "txtexepath1";
            this.txtexepath1.Size = new System.Drawing.Size(298, 20);
            this.txtexepath1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(426, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Choose File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(541, 63);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(109, 23);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Port";
            // 
            // txthostport
            // 
            this.txthostport.Location = new System.Drawing.Point(122, 39);
            this.txthostport.Name = "txthostport";
            this.txthostport.Size = new System.Drawing.Size(298, 20);
            this.txthostport.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Host IP Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txthostip
            // 
            this.txthostip.Location = new System.Drawing.Point(122, 9);
            this.txthostip.Name = "txthostip";
            this.txthostip.Size = new System.Drawing.Size(298, 20);
            this.txthostip.TabIndex = 9;
            this.txthostip.TextChanged += new System.EventHandler(this.txthostip_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Key Management";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtexepath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtprotocol);
            this.panel1.Controls.Add(this.filechooser);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 126);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "e.g to Open exe form webpage. <a href=\"Url Protocol:OpenForm?id=111\">";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(422, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Executable Path";
            // 
            // txtexepath
            // 
            this.txtexepath.Location = new System.Drawing.Point(118, 47);
            this.txtexepath.Name = "txtexepath";
            this.txtexepath.Size = new System.Drawing.Size(298, 20);
            this.txtexepath.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Url Protocol";
            // 
            // txtprotocol
            // 
            this.txtprotocol.Location = new System.Drawing.Point(118, 11);
            this.txtprotocol.Name = "txtprotocol";
            this.txtprotocol.Size = new System.Drawing.Size(298, 20);
            this.txtprotocol.TabIndex = 7;
            // 
            // filechooser
            // 
            this.filechooser.BackColor = System.Drawing.Color.Lavender;
            this.filechooser.Location = new System.Drawing.Point(422, 45);
            this.filechooser.Name = "filechooser";
            this.filechooser.Size = new System.Drawing.Size(109, 23);
            this.filechooser.TabIndex = 6;
            this.filechooser.Text = "Choose File";
            this.filechooser.UseVisualStyleBackColor = false;
            this.filechooser.Click += new System.EventHandler(this.filechooser_Click_1);
            // 
            // dbtab
            // 
            this.dbtab.Controls.Add(this.tabPage1);
            this.dbtab.Controls.Add(this.tabPage2);
            this.dbtab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbtab.Location = new System.Drawing.Point(0, 0);
            this.dbtab.Name = "dbtab";
            this.dbtab.SelectedIndex = 0;
            this.dbtab.Size = new System.Drawing.Size(879, 505);
            this.dbtab.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(442, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Table Name";
            // 
            // txttable
            // 
            this.txttable.Location = new System.Drawing.Point(548, 13);
            this.txttable.Name = "txttable";
            this.txttable.Size = new System.Drawing.Size(232, 20);
            this.txttable.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(442, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Field To Update";
            // 
            // txtfield
            // 
            this.txtfield.Location = new System.Drawing.Point(548, 39);
            this.txtfield.Name = "txtfield";
            this.txtfield.Size = new System.Drawing.Size(232, 20);
            this.txtfield.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(442, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Key Field";
            // 
            // txtkeyfield
            // 
            this.txtkeyfield.Location = new System.Drawing.Point(548, 69);
            this.txtkeyfield.Name = "txtkeyfield";
            this.txtkeyfield.Size = new System.Drawing.Size(232, 20);
            this.txtkeyfield.TabIndex = 30;
            // 
            // chkinsert
            // 
            this.chkinsert.AutoSize = true;
            this.chkinsert.Location = new System.Drawing.Point(279, 98);
            this.chkinsert.Name = "chkinsert";
            this.chkinsert.Size = new System.Drawing.Size(93, 17);
            this.chkinsert.TabIndex = 19;
            this.chkinsert.Text = "Insert Mode";
            this.chkinsert.UseVisualStyleBackColor = true;
            this.chkinsert.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // RegkeyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 508);
            this.Controls.Add(this.dbtab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegkeyManager";
            this.Text = "Application Setting";
            this.Load += new System.EventHandler(this.RegkeyManager_Load);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dbtab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkusedb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtexepath1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthostport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthostip;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtexepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprotocol;
        private System.Windows.Forms.Button filechooser;
        private System.Windows.Forms.TabControl dbtab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtkeyfield;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtfield;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttable;
        private System.Windows.Forms.CheckBox chkinsert;
    }
}

