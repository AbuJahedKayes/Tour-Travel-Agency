namespace Tour_and_Travel_agency
{
    partial class AdminPortal
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
            AdminPortalTitlebarPn = new Panel();
            PlacesLogoLbl = new Label();
            AdminPortalLogoutBtn = new Button();
            AdminPortalHomeBtn = new Button();
            AdminPortalDataPn = new Panel();
            AdminPortalTravelersBtn = new Button();
            AdminportalTourguidBtn = new Button();
            AdminPortalPackagesBtn = new Button();
            AdminPortalEditBtn = new Button();
            AdminPortalAddBtn = new Button();
            AdminPortalView = new DataGridView();
            AdminPortalTitlebarPn.SuspendLayout();
            AdminPortalDataPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminPortalView).BeginInit();
            SuspendLayout();
            // 
            // AdminPortalTitlebarPn
            // 
            AdminPortalTitlebarPn.BackColor = Color.CornflowerBlue;
            AdminPortalTitlebarPn.Controls.Add(PlacesLogoLbl);
            AdminPortalTitlebarPn.Controls.Add(AdminPortalLogoutBtn);
            AdminPortalTitlebarPn.Controls.Add(AdminPortalHomeBtn);
            AdminPortalTitlebarPn.Location = new Point(10, 9);
            AdminPortalTitlebarPn.Margin = new Padding(3, 2, 3, 2);
            AdminPortalTitlebarPn.Name = "AdminPortalTitlebarPn";
            AdminPortalTitlebarPn.Size = new Size(679, 39);
            AdminPortalTitlebarPn.TabIndex = 15;
            // 
            // PlacesLogoLbl
            // 
            PlacesLogoLbl.AutoSize = true;
            PlacesLogoLbl.Font = new Font("Ravie", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlacesLogoLbl.ForeColor = SystemColors.ActiveCaptionText;
            PlacesLogoLbl.Location = new Point(66, 9);
            PlacesLogoLbl.Name = "PlacesLogoLbl";
            PlacesLogoLbl.Size = new Size(133, 21);
            PlacesLogoLbl.TabIndex = 21;
            PlacesLogoLbl.Text = "pother aga";
            // 
            // AdminPortalLogoutBtn
            // 
            AdminPortalLogoutBtn.Location = new Point(584, 8);
            AdminPortalLogoutBtn.Margin = new Padding(3, 2, 3, 2);
            AdminPortalLogoutBtn.Name = "AdminPortalLogoutBtn";
            AdminPortalLogoutBtn.Size = new Size(82, 22);
            AdminPortalLogoutBtn.TabIndex = 18;
            AdminPortalLogoutBtn.Text = "Log Out";
            AdminPortalLogoutBtn.UseVisualStyleBackColor = true;
            // 
            // AdminPortalHomeBtn
            // 
            AdminPortalHomeBtn.Location = new Point(484, 8);
            AdminPortalHomeBtn.Margin = new Padding(3, 2, 3, 2);
            AdminPortalHomeBtn.Name = "AdminPortalHomeBtn";
            AdminPortalHomeBtn.Size = new Size(82, 22);
            AdminPortalHomeBtn.TabIndex = 16;
            AdminPortalHomeBtn.Text = "home";
            AdminPortalHomeBtn.UseVisualStyleBackColor = true;
            // 
            // AdminPortalDataPn
            // 
            AdminPortalDataPn.BackColor = Color.Coral;
            AdminPortalDataPn.Controls.Add(AdminPortalTravelersBtn);
            AdminPortalDataPn.Controls.Add(AdminportalTourguidBtn);
            AdminPortalDataPn.Controls.Add(AdminPortalPackagesBtn);
            AdminPortalDataPn.Location = new Point(10, 59);
            AdminPortalDataPn.Margin = new Padding(3, 2, 3, 2);
            AdminPortalDataPn.Name = "AdminPortalDataPn";
            AdminPortalDataPn.Size = new Size(679, 39);
            AdminPortalDataPn.TabIndex = 19;
            // 
            // AdminPortalTravelersBtn
            // 
            AdminPortalTravelersBtn.Location = new Point(31, 8);
            AdminPortalTravelersBtn.Margin = new Padding(3, 2, 3, 2);
            AdminPortalTravelersBtn.Name = "AdminPortalTravelersBtn";
            AdminPortalTravelersBtn.Size = new Size(82, 22);
            AdminPortalTravelersBtn.TabIndex = 19;
            AdminPortalTravelersBtn.Text = "Travelers";
            AdminPortalTravelersBtn.UseVisualStyleBackColor = true;
            AdminPortalTravelersBtn.Click += AdminPortalTravelersBtn_Click;
            // 
            // AdminportalTourguidBtn
            // 
            AdminportalTourguidBtn.Location = new Point(572, 8);
            AdminportalTourguidBtn.Margin = new Padding(3, 2, 3, 2);
            AdminportalTourguidBtn.Name = "AdminportalTourguidBtn";
            AdminportalTourguidBtn.Size = new Size(82, 22);
            AdminportalTourguidBtn.TabIndex = 18;
            AdminportalTourguidBtn.Text = "Tour Guid";
            AdminportalTourguidBtn.UseVisualStyleBackColor = true;
            AdminportalTourguidBtn.Click += AdminportalTourguidBtn_Click;
            // 
            // AdminPortalPackagesBtn
            // 
            AdminPortalPackagesBtn.Location = new Point(283, 8);
            AdminPortalPackagesBtn.Margin = new Padding(3, 2, 3, 2);
            AdminPortalPackagesBtn.Name = "AdminPortalPackagesBtn";
            AdminPortalPackagesBtn.Size = new Size(82, 22);
            AdminPortalPackagesBtn.TabIndex = 16;
            AdminPortalPackagesBtn.Text = "Packages";
            AdminPortalPackagesBtn.UseVisualStyleBackColor = true;
            AdminPortalPackagesBtn.Click += AdminPortalPackagesBtn_Click;
            // 
            // AdminPortalEditBtn
            // 
            AdminPortalEditBtn.Location = new Point(607, 334);
            AdminPortalEditBtn.Margin = new Padding(3, 2, 3, 2);
            AdminPortalEditBtn.Name = "AdminPortalEditBtn";
            AdminPortalEditBtn.Size = new Size(82, 22);
            AdminPortalEditBtn.TabIndex = 20;
            AdminPortalEditBtn.Text = "Edit";
            AdminPortalEditBtn.UseVisualStyleBackColor = true;
            // 
            // AdminPortalAddBtn
            // 
            AdminPortalAddBtn.Location = new Point(507, 334);
            AdminPortalAddBtn.Margin = new Padding(3, 2, 3, 2);
            AdminPortalAddBtn.Name = "AdminPortalAddBtn";
            AdminPortalAddBtn.Size = new Size(82, 22);
            AdminPortalAddBtn.TabIndex = 19;
            AdminPortalAddBtn.Text = "Add";
            AdminPortalAddBtn.UseVisualStyleBackColor = true;
            AdminPortalAddBtn.Click += AdminPortalAddBtn_Click;
            // 
            // AdminPortalView
            // 
            AdminPortalView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminPortalView.Location = new Point(12, 122);
            AdminPortalView.Name = "AdminPortalView";
            AdminPortalView.Size = new Size(676, 207);
            AdminPortalView.TabIndex = 21;
            // 
            // AdminPortal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 362);
            Controls.Add(AdminPortalView);
            Controls.Add(AdminPortalEditBtn);
            Controls.Add(AdminPortalAddBtn);
            Controls.Add(AdminPortalDataPn);
            Controls.Add(AdminPortalTitlebarPn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminPortal";
            Text = "Admin Portal";
            AdminPortalTitlebarPn.ResumeLayout(false);
            AdminPortalTitlebarPn.PerformLayout();
            AdminPortalDataPn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdminPortalView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel AdminPortalTitlebarPn;
        private Button AdminPortalLogoutBtn;
        private Button AdminPortalHomeBtn;
        private Panel AdminPortalDataPn;
        private Button AdminPortalTravelersBtn;
        private Button AdminportalTourguidBtn;
        private Button AdminPortalPackagesBtn;
        private Button AdminPortalEditBtn;
        private Button AdminPortalAddBtn;
        private Label PlacesLogoLbl;
        private DataGridView AdminPortalView;
    }
}