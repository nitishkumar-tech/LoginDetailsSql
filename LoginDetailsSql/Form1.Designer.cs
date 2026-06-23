namespace LoginDetailsSql
{
    partial class Form1
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
            this.lblusrnm = new System.Windows.Forms.Label();
            this.txtusrnme = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lblpasswrd = new System.Windows.Forms.Label();
            this.txtpasswrd = new System.Windows.Forms.TextBox();
            this.lblmsg1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusrnm
            // 
            this.lblusrnm.AutoSize = true;
            this.lblusrnm.Location = new System.Drawing.Point(181, 102);
            this.lblusrnm.Name = "lblusrnm";
            this.lblusrnm.Size = new System.Drawing.Size(67, 16);
            this.lblusrnm.TabIndex = 0;
            this.lblusrnm.Text = "username";
            // 
            // txtusrnme
            // 
            this.txtusrnme.Location = new System.Drawing.Point(301, 96);
            this.txtusrnme.Name = "txtusrnme";
            this.txtusrnme.Size = new System.Drawing.Size(100, 22);
            this.txtusrnme.TabIndex = 1;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsubmit.ForeColor = System.Drawing.Color.Red;
            this.btnsubmit.Location = new System.Drawing.Point(301, 231);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 2;
            this.btnsubmit.Text = "Insert";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lblpasswrd
            // 
            this.lblpasswrd.AutoSize = true;
            this.lblpasswrd.Location = new System.Drawing.Point(181, 162);
            this.lblpasswrd.Name = "lblpasswrd";
            this.lblpasswrd.Size = new System.Drawing.Size(67, 16);
            this.lblpasswrd.TabIndex = 3;
            this.lblpasswrd.Text = "Password";
            // 
            // txtpasswrd
            // 
            this.txtpasswrd.Location = new System.Drawing.Point(301, 162);
            this.txtpasswrd.Name = "txtpasswrd";
            this.txtpasswrd.Size = new System.Drawing.Size(100, 22);
            this.txtpasswrd.TabIndex = 4;
            // 
            // lblmsg1
            // 
            this.lblmsg1.AutoSize = true;
            this.lblmsg1.Location = new System.Drawing.Point(193, 278);
            this.lblmsg1.Name = "lblmsg1";
            this.lblmsg1.Size = new System.Drawing.Size(44, 16);
            this.lblmsg1.TabIndex = 5;
            this.lblmsg1.Text = "label1";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btndelete.ForeColor = System.Drawing.Color.Purple;
            this.btndelete.Location = new System.Drawing.Point(425, 231);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnupdate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnupdate.Location = new System.Drawing.Point(559, 231);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.lblmsg1);
            this.Controls.Add(this.txtpasswrd);
            this.Controls.Add(this.lblpasswrd);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtusrnme);
            this.Controls.Add(this.lblusrnm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusrnm;
        private System.Windows.Forms.TextBox txtusrnme;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lblpasswrd;
        private System.Windows.Forms.TextBox txtpasswrd;
        private System.Windows.Forms.Label lblmsg1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
    }
}

