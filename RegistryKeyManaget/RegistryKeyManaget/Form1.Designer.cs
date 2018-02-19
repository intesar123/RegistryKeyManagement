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
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dbtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label4);
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
            this.dbtab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbtab.Location = new System.Drawing.Point(0, 0);
            this.dbtab.Name = "dbtab";
            this.dbtab.SelectedIndex = 0;
            this.dbtab.Size = new System.Drawing.Size(879, 505);
            this.dbtab.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(384, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "for more info visit intesar.in";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // RegkeyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 508);
            this.Controls.Add(this.dbtab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegkeyManager";
            this.Text = "Window Registery Key Editor";
            this.Load += new System.EventHandler(this.RegkeyManager_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dbtab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Label label4;
    }
}

