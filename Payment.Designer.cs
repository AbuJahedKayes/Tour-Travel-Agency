namespace Tour_and_Travel_agency
{
    partial class Payment
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
            PaymentBkashTextBox = new TextBox();
            PaymentBkashLbl = new Label();
            PaymentSubmitBtn = new Button();
            pictureBox1 = new PictureBox();
            PackagesLogoLbl = new Label();
            PaymentNextBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PaymentBkashTextBox
            // 
            PaymentBkashTextBox.Location = new Point(234, 81);
            PaymentBkashTextBox.Margin = new Padding(3, 2, 3, 2);
            PaymentBkashTextBox.Name = "PaymentBkashTextBox";
            PaymentBkashTextBox.Size = new Size(110, 23);
            PaymentBkashTextBox.TabIndex = 22;
            // 
            // PaymentBkashLbl
            // 
            PaymentBkashLbl.AutoSize = true;
            PaymentBkashLbl.Location = new Point(153, 81);
            PaymentBkashLbl.Name = "PaymentBkashLbl";
            PaymentBkashLbl.Size = new Size(61, 15);
            PaymentBkashLbl.TabIndex = 21;
            PaymentBkashLbl.Text = "Bkash no :";
            // 
            // PaymentSubmitBtn
            // 
            PaymentSubmitBtn.Location = new Point(261, 123);
            PaymentSubmitBtn.Margin = new Padding(3, 2, 3, 2);
            PaymentSubmitBtn.Name = "PaymentSubmitBtn";
            PaymentSubmitBtn.Size = new Size(82, 22);
            PaymentSubmitBtn.TabIndex = 23;
            PaymentSubmitBtn.Text = "submit ";
            PaymentSubmitBtn.UseVisualStyleBackColor = true;
            PaymentSubmitBtn.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._400790499_1527115948050384_7047906146044062449_n__1_1;
            pictureBox1.Location = new Point(27, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // PackagesLogoLbl
            // 
            PackagesLogoLbl.AutoSize = true;
            PackagesLogoLbl.Font = new Font("Ravie", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PackagesLogoLbl.ForeColor = SystemColors.ActiveCaptionText;
            PackagesLogoLbl.Location = new Point(80, 16);
            PackagesLogoLbl.Name = "PackagesLogoLbl";
            PackagesLogoLbl.Size = new Size(133, 21);
            PackagesLogoLbl.TabIndex = 29;
            PackagesLogoLbl.Text = "pother aga";
            // 
            // PaymentNextBtn
            // 
            PaymentNextBtn.Location = new Point(423, 216);
            PaymentNextBtn.Name = "PaymentNextBtn";
            PaymentNextBtn.Size = new Size(75, 23);
            PaymentNextBtn.TabIndex = 30;
            PaymentNextBtn.Text = "Next";
            PaymentNextBtn.UseVisualStyleBackColor = true;
            PaymentNextBtn.Click += PaymentNextBtn_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 252);
            Controls.Add(PaymentNextBtn);
            Controls.Add(PackagesLogoLbl);
            Controls.Add(pictureBox1);
            Controls.Add(PaymentSubmitBtn);
            Controls.Add(PaymentBkashTextBox);
            Controls.Add(PaymentBkashLbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Payment";
            Text = "Payment";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PaymentBkashTextBox;
        private Label PaymentBkashLbl;
        private Button PaymentSubmitBtn;
        private PictureBox pictureBox1;
        private Label PackagesLogoLbl;
        private Button PaymentNextBtn;
    }
}