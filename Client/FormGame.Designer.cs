namespace Client
{
    partial class FormGame
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
            this.plroom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbdanhsachphonggame = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btntaophongmoi = new System.Windows.Forms.Button();
            this.pnlgame = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbidphong = new System.Windows.Forms.Label();
            this.rtbchat = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbcontentchat = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plroom.SuspendLayout();
            this.pnlgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plroom
            // 
            this.plroom.BackgroundImage = global::Client.Properties.Resources.bgcaro1;//RE4wyS2;
            this.plroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plroom.Controls.Add(this.label1);
            this.plroom.Controls.Add(this.ltbdanhsachphonggame);
            this.plroom.Controls.Add(this.button2);
            this.plroom.Controls.Add(this.btntaophongmoi);
            this.plroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plroom.Location = new System.Drawing.Point(0, 0);
            this.plroom.Name = "plroom";
            this.plroom.Size = new System.Drawing.Size(802, 541);
            this.plroom.TabIndex = 10;
            this.plroom.Paint += new System.Windows.Forms.PaintEventHandler(this.plroom_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(303, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH PHÒNG";
            // 
            // ltbdanhsachphonggame
            // 
            this.ltbdanhsachphonggame.FormattingEnabled = true;
            this.ltbdanhsachphonggame.Location = new System.Drawing.Point(274, 63);
            this.ltbdanhsachphonggame.Name = "ltbdanhsachphonggame";
            this.ltbdanhsachphonggame.Size = new System.Drawing.Size(525, 407);
            this.ltbdanhsachphonggame.TabIndex = 5;
            this.ltbdanhsachphonggame.SelectedIndexChanged += new System.EventHandler(this.ltbdanhsachphonggame_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(44, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btntaophongmoi
            // 
            this.btntaophongmoi.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaophongmoi.Location = new System.Drawing.Point(44, 166);
            this.btntaophongmoi.Name = "btntaophongmoi";
            this.btntaophongmoi.Size = new System.Drawing.Size(162, 44);
            this.btntaophongmoi.TabIndex = 0;
            this.btntaophongmoi.Text = "Tạo Phòng";
            this.btntaophongmoi.UseVisualStyleBackColor = true;
            this.btntaophongmoi.Click += new System.EventHandler(this.btntaophongmoi_Click);
            // 
            // pnlgame
            // 
            this.pnlgame.BackgroundImage = global::Client.Properties.Resources.bgcaro;
            this.pnlgame.Controls.Add(this.pictureBox3);
            this.pnlgame.Controls.Add(this.lbidphong);
            this.pnlgame.Controls.Add(this.rtbchat);
            this.pnlgame.Controls.Add(this.pictureBox2);
            this.pnlgame.Controls.Add(this.pictureBox1);
            this.pnlgame.Controls.Add(this.panel1);
            this.pnlgame.Controls.Add(this.rtbcontentchat);
            this.pnlgame.Location = new System.Drawing.Point(0, 0);
            this.pnlgame.Name = "pnlgame";
            this.pnlgame.Size = new System.Drawing.Size(802, 545);
            this.pnlgame.TabIndex = 9;
            this.pnlgame.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Client.Properties.Resources.thoa;
            this.pictureBox3.Location = new System.Drawing.Point(734, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 51);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lbidphong
            // 
            this.lbidphong.AutoSize = true;
            this.lbidphong.BackColor = System.Drawing.Color.Transparent;
            this.lbidphong.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidphong.ForeColor = System.Drawing.Color.White;
            this.lbidphong.Location = new System.Drawing.Point(301, 32);
            this.lbidphong.Name = "lbidphong";
            this.lbidphong.Size = new System.Drawing.Size(33, 31);
            this.lbidphong.TabIndex = 9;
            this.lbidphong.Text = "0";
            // 
            // rtbchat
            // 
            this.rtbchat.BackColor = System.Drawing.Color.LightCyan;
            this.rtbchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbchat.Location = new System.Drawing.Point(635, 516);
            this.rtbchat.Name = "rtbchat";
            this.rtbchat.Size = new System.Drawing.Size(165, 28);
            this.rtbchat.TabIndex = 7;
            this.rtbchat.Text = "";
            this.rtbchat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbchat_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(186, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 401);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // rtbcontentchat
            // 
            this.rtbcontentchat.BackColor = System.Drawing.Color.LightCyan;
            this.rtbcontentchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbcontentchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbcontentchat.Location = new System.Drawing.Point(634, 390);
            this.rtbcontentchat.Name = "rtbcontentchat";
            this.rtbcontentchat.Size = new System.Drawing.Size(166, 123);
            this.rtbcontentchat.TabIndex = 6;
            this.rtbcontentchat.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Client.Properties.Resources.bgchat;
            this.pictureBox2.Location = new System.Drawing.Point(679, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 49);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.bgchat;
            this.pictureBox1.Location = new System.Drawing.Point(44, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 541);
            this.Controls.Add(this.plroom);
            this.Controls.Add(this.pnlgame);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.plroom.ResumeLayout(false);
            this.plroom.PerformLayout();
            this.pnlgame.ResumeLayout(false);
            this.pnlgame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbcontentchat;
        private System.Windows.Forms.RichTextBox rtbchat;
        private System.Windows.Forms.Panel pnlgame;
        private System.Windows.Forms.Label lbidphong;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel plroom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ltbdanhsachphonggame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntaophongmoi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}