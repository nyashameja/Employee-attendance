namespace multilogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.usertype = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.login = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Show_Hide = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(14, 46);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(75, 20);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(14, 91);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 20);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // usertype
            // 
            this.usertype.AutoSize = true;
            this.usertype.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype.Location = new System.Drawing.Point(14, 137);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(71, 20);
            this.usertype.TabIndex = 2;
            this.usertype.Text = "User type";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(126, 46);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(134, 27);
            this.txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(126, 91);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(134, 27);
            this.txtpass.TabIndex = 4;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Amin",
            "User"});
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBox1.Location = new System.Drawing.Point(126, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // login
            // 
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Location = new System.Drawing.Point(104, 195);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 34);
            this.login.TabIndex = 6;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cancel
            // 
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Location = new System.Drawing.Point(185, 195);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 34);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(303, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 197);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(324, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ATTENDANCE SYSTEM";
            // 
            // checkBox_Show_Hide
            // 
            this.checkBox_Show_Hide.AutoSize = true;
            this.checkBox_Show_Hide.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Show_Hide.Location = new System.Drawing.Point(281, 93);
            this.checkBox_Show_Hide.Name = "checkBox_Show_Hide";
            this.checkBox_Show_Hide.Size = new System.Drawing.Size(58, 21);
            this.checkBox_Show_Hide.TabIndex = 10;
            this.checkBox_Show_Hide.Text = "Show";
            this.checkBox_Show_Hide.UseVisualStyleBackColor = true;
            this.checkBox_Show_Hide.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkBlue;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(564, 136);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(15, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkBlue;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(159, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_Show_Hide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label usertype;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Show_Hide;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

