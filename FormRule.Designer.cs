namespace Client
{
    partial class FormRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRule));
            this.rbRule = new System.Windows.Forms.RichTextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbRule
            // 
            this.rbRule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRule.Location = new System.Drawing.Point(13, 13);
            this.rbRule.Name = "rbRule";
            this.rbRule.Size = new System.Drawing.Size(647, 158);
            this.rbRule.TabIndex = 0;
            this.rbRule.Text = resources.GetString("rbRule.Text");
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(287, 189);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // FormRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 224);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.rbRule);
            this.Name = "FormRule";
            this.Text = "Rule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbRule;
        private System.Windows.Forms.Button btOk;
    }
}