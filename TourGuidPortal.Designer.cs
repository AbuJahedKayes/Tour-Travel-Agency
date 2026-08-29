namespace Tour_and_Travel_agency
{
    partial class TourGuidPortal
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
            TourguidportalDataPn = new Panel();
            TourguidportalTitlebarPn = new Panel();
            PlacesLogoLbl = new Label();
            TourguidportalLogoutBtn = new Button();
            TourguidportalHomeBtn = new Button();
            TourguidportalTitlebarPn.SuspendLayout();
            SuspendLayout();
            // 
            // TourguidportalDataPn
            // 
            TourguidportalDataPn.BackColor = SystemColors.ControlDark;
            TourguidportalDataPn.Location = new Point(12, 88);
            TourguidportalDataPn.Name = "TourguidportalDataPn";
            TourguidportalDataPn.Size = new Size(776, 308);
            TourguidportalDataPn.TabIndex = 26;
            // 
            // TourguidportalTitlebarPn
            // 
            TourguidportalTitlebarPn.BackColor = SystemColors.ControlDark;
            TourguidportalTitlebarPn.Controls.Add(PlacesLogoLbl);
            TourguidportalTitlebarPn.Controls.Add(TourguidportalLogoutBtn);
            TourguidportalTitlebarPn.Controls.Add(TourguidportalHomeBtn);
            TourguidportalTitlebarPn.Location = new Point(12, 12);
            TourguidportalTitlebarPn.Name = "TourguidportalTitlebarPn";
            TourguidportalTitlebarPn.Size = new Size(776, 52);
            TourguidportalTitlebarPn.TabIndex = 24;
            // 
            // PlacesLogoLbl
            // 
            PlacesLogoLbl.AutoSize = true;
            PlacesLogoLbl.Font = new Font("Ravie", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlacesLogoLbl.ForeColor = SystemColors.ActiveCaptionText;
            PlacesLogoLbl.Location = new Point(78, 12);
            PlacesLogoLbl.Name = "PlacesLogoLbl";
            PlacesLogoLbl.Size = new Size(153, 24);
            PlacesLogoLbl.TabIndex = 21;
            PlacesLogoLbl.Text = "pother aga";
            // 
            // TourguidportalLogoutBtn
            // 
            TourguidportalLogoutBtn.Location = new Point(652, 11);
            TourguidportalLogoutBtn.Name = "TourguidportalLogoutBtn";
            TourguidportalLogoutBtn.Size = new Size(94, 29);
            TourguidportalLogoutBtn.TabIndex = 18;
            TourguidportalLogoutBtn.Text = "Log out";
            TourguidportalLogoutBtn.UseVisualStyleBackColor = true;
            // 
            // TourguidportalHomeBtn
            // 
            TourguidportalHomeBtn.Location = new Point(541, 11);
            TourguidportalHomeBtn.Name = "TourguidportalHomeBtn";
            TourguidportalHomeBtn.Size = new Size(94, 29);
            TourguidportalHomeBtn.TabIndex = 16;
            TourguidportalHomeBtn.Text = "Home";
            TourguidportalHomeBtn.UseVisualStyleBackColor = true;
            // 
            // TourGuidPortal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TourguidportalDataPn);
            Controls.Add(TourguidportalTitlebarPn);
            Name = "TourGuidPortal";
            Text = "Tour guid portal";
            Load += TourGuidPortal_Load;
            TourguidportalTitlebarPn.ResumeLayout(false);
            TourguidportalTitlebarPn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TourguidportalDataPn;
        private Panel TourguidportalTitlebarPn;
        private Button TourguidportalLogoutBtn;
        private Button TourguidportalHomeBtn;
        private Label PlacesLogoLbl;
    }
}