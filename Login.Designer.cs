namespace Tour_and_Travel_agency
{
    partial class LogIn
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
            LoginUsernameTextBox = new TextBox();
            LoginUserNameLbl = new Label();
            LoginPasswordLbl = new Label();
            LoginPasswordTextBox = new TextBox();
            LoginLoginBtn = new Button();
            LoginShowPasswordCb = new CheckBox();
            PackageTitlebarPn = new Panel();
            pictureBox1 = new PictureBox();
            PackagesLogoLbl = new Label();
            PackageTitlebarPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginUsernameTextBox
            // 
            LoginUsernameTextBox.Location = new Point(214, 68);
            LoginUsernameTextBox.Margin = new Padding(3, 2, 3, 2);
            LoginUsernameTextBox.Name = "LoginUsernameTextBox";
            LoginUsernameTextBox.Size = new Size(143, 23);
            LoginUsernameTextBox.TabIndex = 0;
            // 
            // LoginUserNameLbl
            // 
            LoginUserNameLbl.AutoSize = true;
            LoginUserNameLbl.Location = new Point(122, 68);
            LoginUserNameLbl.Name = "LoginUserNameLbl";
            LoginUserNameLbl.Size = new Size(65, 15);
            LoginUserNameLbl.TabIndex = 1;
            LoginUserNameLbl.Text = "User Name";
            // 
            // LoginPasswordLbl
            // 
            LoginPasswordLbl.AutoSize = true;
            LoginPasswordLbl.Location = new Point(122, 106);
            LoginPasswordLbl.Name = "LoginPasswordLbl";
            LoginPasswordLbl.Size = new Size(57, 15);
            LoginPasswordLbl.TabIndex = 3;
            LoginPasswordLbl.Text = "Password";
            // 
            // LoginPasswordTextBox
            // 
            LoginPasswordTextBox.Location = new Point(214, 106);
            LoginPasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            LoginPasswordTextBox.Size = new Size(143, 23);
            LoginPasswordTextBox.TabIndex = 2;
            // 
            // LoginLoginBtn
            // 
            LoginLoginBtn.Location = new Point(275, 172);
            LoginLoginBtn.Margin = new Padding(3, 2, 3, 2);
            LoginLoginBtn.Name = "LoginLoginBtn";
            LoginLoginBtn.Size = new Size(82, 22);
            LoginLoginBtn.TabIndex = 4;
            LoginLoginBtn.Text = "Log In";
            LoginLoginBtn.UseVisualStyleBackColor = true;
            LoginLoginBtn.Click += LoginLoginBtn_Click;
            // 
            // LoginShowPasswordCb
            // 
            LoginShowPasswordCb.AutoSize = true;
            LoginShowPasswordCb.Location = new Point(242, 131);
            LoginShowPasswordCb.Margin = new Padding(3, 2, 3, 2);
            LoginShowPasswordCb.Name = "LoginShowPasswordCb";
            LoginShowPasswordCb.Size = new Size(108, 19);
            LoginShowPasswordCb.TabIndex = 5;
            LoginShowPasswordCb.Text = "Show Password";
            LoginShowPasswordCb.UseVisualStyleBackColor = true;
            LoginShowPasswordCb.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // PackageTitlebarPn
            // 
            PackageTitlebarPn.BackColor = Color.LightSeaGreen;
            PackageTitlebarPn.Controls.Add(pictureBox1);
            PackageTitlebarPn.Controls.Add(PackagesLogoLbl);
            PackageTitlebarPn.Location = new Point(9, 5);
            PackageTitlebarPn.Margin = new Padding(3, 2, 3, 2);
            PackageTitlebarPn.Name = "PackageTitlebarPn";
            PackageTitlebarPn.Size = new Size(524, 39);
            PackageTitlebarPn.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._400790499_1527115948050384_7047906146044062449_n__1_1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // PackagesLogoLbl
            // 
            PackagesLogoLbl.AutoSize = true;
            PackagesLogoLbl.Font = new Font("Ravie", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PackagesLogoLbl.ForeColor = SystemColors.ActiveCaptionText;
            PackagesLogoLbl.Location = new Point(51, 6);
            PackagesLogoLbl.Name = "PackagesLogoLbl";
            PackagesLogoLbl.Size = new Size(133, 21);
            PackagesLogoLbl.TabIndex = 19;
            PackagesLogoLbl.Text = "pother aga";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 230);
            Controls.Add(PackageTitlebarPn);
            Controls.Add(LoginShowPasswordCb);
            Controls.Add(LoginLoginBtn);
            Controls.Add(LoginPasswordLbl);
            Controls.Add(LoginPasswordTextBox);
            Controls.Add(LoginUserNameLbl);
            Controls.Add(LoginUsernameTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogIn";
            Text = "Log In";
            PackageTitlebarPn.ResumeLayout(false);
            PackageTitlebarPn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginUsernameTextBox;
        private Label LoginUserNameLbl;
        private Label LoginPasswordLbl;
        private TextBox LoginPasswordTextBox;
        private Button LoginLoginBtn;
        private CheckBox LoginShowPasswordCb;
        private Panel PackageTitlebarPn;
        private PictureBox pictureBox1;
        private Label PackagesLogoLbl;
    }
}