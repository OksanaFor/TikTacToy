namespace TikTacToy.View
{
    partial class Registration
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
            this.reg = new System.Windows.Forms.Button();
            this.auth = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.loginTag = new System.Windows.Forms.Label();
            this.passTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(89, 76);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(141, 35);
            this.reg.TabIndex = 0;
            this.reg.Text = "Registration";
            this.reg.UseVisualStyleBackColor = true;
            // 
            // auth
            // 
            this.auth.Location = new System.Drawing.Point(262, 76);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(163, 35);
            this.auth.TabIndex = 1;
            this.auth.Text = "Authorization";
            this.auth.UseVisualStyleBackColor = true;
            this.auth.Click += new System.EventHandler(this.ClickOpenGame);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 31);
            this.textBox2.TabIndex = 3;
            // 
            // loginTag
            // 
            this.loginTag.AutoSize = true;
            this.loginTag.Location = new System.Drawing.Point(272, 158);
            this.loginTag.Name = "loginTag";
            this.loginTag.Size = new System.Drawing.Size(58, 25);
            this.loginTag.TabIndex = 4;
            this.loginTag.Text = "login";
            this.loginTag.UseWaitCursor = true;
            // 
            // passTag
            // 
            this.passTag.AutoSize = true;
            this.passTag.Location = new System.Drawing.Point(272, 226);
            this.passTag.Name = "passTag";
            this.passTag.Size = new System.Drawing.Size(104, 25);
            this.passTag.TabIndex = 5;
            this.passTag.Text = "password";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passTag);
            this.Controls.Add(this.loginTag);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.auth);
            this.Controls.Add(this.reg);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Button auth;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label loginTag;
        private System.Windows.Forms.Label passTag;
    }
}