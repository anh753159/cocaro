namespace Server
{
    partial class FormServer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbActivityHis = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btCloseServ = new System.Windows.Forms.Button();
            this.btOpenServ = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbActivityHis);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbActivityHis
            // 
            this.tbActivityHis.BackColor = System.Drawing.Color.Khaki;
            this.tbActivityHis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbActivityHis.Location = new System.Drawing.Point(0, 10);
            this.tbActivityHis.Name = "tbActivityHis";
            this.tbActivityHis.Size = new System.Drawing.Size(329, 250);
            this.tbActivityHis.TabIndex = 0;
            this.tbActivityHis.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btClose);
            this.groupBox3.Controls.Add(this.btCloseServ);
            this.groupBox3.Controls.Add(this.btOpenServ);
            this.groupBox3.Location = new System.Drawing.Point(352, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(43, 116);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(118, 26);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCloseServ
            // 
            this.btCloseServ.Location = new System.Drawing.Point(43, 58);
            this.btCloseServ.Name = "btCloseServ";
            this.btCloseServ.Size = new System.Drawing.Size(118, 26);
            this.btCloseServ.TabIndex = 2;
            this.btCloseServ.Text = "Đóng Server";
            this.btCloseServ.UseVisualStyleBackColor = true;
            this.btCloseServ.Visible = false;
            this.btCloseServ.Click += new System.EventHandler(this.button3_Click);
            // 
            // btOpenServ
            // 
            this.btOpenServ.Location = new System.Drawing.Point(43, 87);
            this.btOpenServ.Name = "btOpenServ";
            this.btOpenServ.Size = new System.Drawing.Size(118, 26);
            this.btOpenServ.TabIndex = 0;
            this.btOpenServ.Text = "Mở Server";
            this.btOpenServ.UseVisualStyleBackColor = true;
            this.btOpenServ.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 285);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormServer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tbActivityHis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btOpenServ;
        private System.Windows.Forms.Button btCloseServ;
    }
}

