namespace Tour_and_Travel_agency
{
    partial class Places
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
            PlaceNameTxt = new TextBox();
            label1 = new Label();
            label4 = new Label();
            PlaceTakaTxt = new TextBox();
            PlaceAddBtn = new Button();
            InformationTitlebarPn = new Panel();
            pictureBox2 = new PictureBox();
            PlacesLogoLbl = new Label();
            InformationContactBtn = new Button();
            InformationTitlebarPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PlaceNameTxt
            // 
            PlaceNameTxt.Location = new Point(141, 108);
            PlaceNameTxt.Name = "PlaceNameTxt";
            PlaceNameTxt.Size = new Size(100, 23);
            PlaceNameTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 111);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Place Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 114);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Taka :";
            // 
            // PlaceTakaTxt
            // 
            PlaceTakaTxt.Location = new Point(397, 111);
            PlaceTakaTxt.Name = "PlaceTakaTxt";
            PlaceTakaTxt.Size = new Size(100, 23);
            PlaceTakaTxt.TabIndex = 6;
            // 
            // PlaceAddBtn
            // 
            PlaceAddBtn.Location = new Point(443, 204);
            PlaceAddBtn.Name = "PlaceAddBtn";
            PlaceAddBtn.Size = new Size(75, 23);
            PlaceAddBtn.TabIndex = 8;
            PlaceAddBtn.Text = "Add";
            PlaceAddBtn.UseVisualStyleBackColor = true;
            PlaceAddBtn.Click += PlaceAddBtn_Click;
            // 
            // InformationTitlebarPn
            // 
            InformationTitlebarPn.BackColor = SystemColors.ControlDark;
            InformationTitlebarPn.Controls.Add(pictureBox2);
            InformationTitlebarPn.Controls.Add(PlacesLogoLbl);
            InformationTitlebarPn.Controls.Add(InformationContactBtn);
            InformationTitlebarPn.Location = new Point(1, 11);
            InformationTitlebarPn.Margin = new Padding(3, 2, 3, 2);
            InformationTitlebarPn.Name = "InformationTitlebarPn";
            InformationTitlebarPn.Size = new Size(534, 39);
            InformationTitlebarPn.TabIndex = 29;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._400790499_1527115948050384_7047906146044062449_n__1_1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // PlacesLogoLbl
            // 
            PlacesLogoLbl.AutoSize = true;
            PlacesLogoLbl.Font = new Font("Ravie", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlacesLogoLbl.ForeColor = SystemColors.ActiveCaptionText;
            PlacesLogoLbl.Location = new Point(53, 7);
            PlacesLogoLbl.Name = "PlacesLogoLbl";
            PlacesLogoLbl.Size = new Size(133, 21);
            PlacesLogoLbl.TabIndex = 21;
            PlacesLogoLbl.Text = "pother aga";
            // 
            // InformationContactBtn
            // 
            InformationContactBtn.Location = new Point(549, 8);
            InformationContactBtn.Margin = new Padding(3, 2, 3, 2);
            InformationContactBtn.Name = "InformationContactBtn";
            InformationContactBtn.Size = new Size(82, 22);
            InformationContactBtn.TabIndex = 17;
            InformationContactBtn.Text = "contact us";
            InformationContactBtn.UseVisualStyleBackColor = true;
            // 
            // Places
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 241);
            Controls.Add(InformationTitlebarPn);
            Controls.Add(PlaceAddBtn);
            Controls.Add(label4);
            Controls.Add(PlaceTakaTxt);
            Controls.Add(label1);
            Controls.Add(PlaceNameTxt);
            Name = "Places";
            Text = "Place";
            InformationTitlebarPn.ResumeLayout(false);
            InformationTitlebarPn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PlaceNameTxt;
        private Label label1;
        private Label label4;
        private TextBox PlaceTakaTxt;
        private Button PlaceAddBtn;
        private Panel InformationTitlebarPn;
        private PictureBox pictureBox2;
        private Label PlacesLogoLbl;
        private Button InformationContactBtn;
    }
}