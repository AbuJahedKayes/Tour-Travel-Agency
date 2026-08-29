namespace Tour_and_Travel_agency
{
    partial class Ticket
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
            label1 = new Label();
            TicketTr_idLbl = new Label();
            TicketDateLbl = new Label();
            TicketTimeLbl = new Label();
            TicketBusnameLbl = new Label();
            TicketBusidLbl = new Label();
            TicketTrnameLbl = new Label();
            TicketAmoutLbl = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 0;
            label1.Text = "Ticket ";
            // 
            // TicketTr_idLbl
            // 
            TicketTr_idLbl.AutoSize = true;
            TicketTr_idLbl.Location = new Point(167, 94);
            TicketTr_idLbl.Name = "TicketTr_idLbl";
            TicketTr_idLbl.Size = new Size(45, 20);
            TicketTr_idLbl.TabIndex = 1;
            TicketTr_idLbl.Text = "tr_id :";
            // 
            // TicketDateLbl
            // 
            TicketDateLbl.AutoSize = true;
            TicketDateLbl.Location = new Point(107, 141);
            TicketDateLbl.Name = "TicketDateLbl";
            TicketDateLbl.Size = new Size(46, 20);
            TicketDateLbl.TabIndex = 2;
            TicketDateLbl.Text = "date :";
            // 
            // TicketTimeLbl
            // 
            TicketTimeLbl.AutoSize = true;
            TicketTimeLbl.Location = new Point(245, 141);
            TicketTimeLbl.Name = "TicketTimeLbl";
            TicketTimeLbl.Size = new Size(49, 20);
            TicketTimeLbl.TabIndex = 3;
            TicketTimeLbl.Text = "Time :";
            // 
            // TicketBusnameLbl
            // 
            TicketBusnameLbl.AutoSize = true;
            TicketBusnameLbl.Location = new Point(162, 185);
            TicketBusnameLbl.Name = "TicketBusnameLbl";
            TicketBusnameLbl.Size = new Size(80, 20);
            TicketBusnameLbl.TabIndex = 4;
            TicketBusnameLbl.Text = "Bus name :";
            // 
            // TicketBusidLbl
            // 
            TicketBusidLbl.AutoSize = true;
            TicketBusidLbl.Location = new Point(37, 185);
            TicketBusidLbl.Name = "TicketBusidLbl";
            TicketBusidLbl.Size = new Size(56, 20);
            TicketBusidLbl.TabIndex = 5;
            TicketBusidLbl.Text = "Bus id :";
            // 
            // TicketTrnameLbl
            // 
            TicketTrnameLbl.AutoSize = true;
            TicketTrnameLbl.Location = new Point(311, 185);
            TicketTrnameLbl.Name = "TicketTrnameLbl";
            TicketTrnameLbl.Size = new Size(67, 20);
            TicketTrnameLbl.TabIndex = 6;
            TicketTrnameLbl.Text = "tr name :";
            // 
            // TicketAmoutLbl
            // 
            TicketAmoutLbl.AutoSize = true;
            TicketAmoutLbl.Location = new Point(168, 267);
            TicketAmoutLbl.Name = "TicketAmoutLbl";
            TicketAmoutLbl.Size = new Size(69, 20);
            TicketAmoutLbl.TabIndex = 7;
            TicketAmoutLbl.Text = "Amount :";
            // 
            // button1
            // 
            button1.Location = new Point(311, -1);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Print ";
            button1.UseVisualStyleBackColor = true;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 346);
            Controls.Add(button1);
            Controls.Add(TicketAmoutLbl);
            Controls.Add(TicketTrnameLbl);
            Controls.Add(TicketBusidLbl);
            Controls.Add(TicketBusnameLbl);
            Controls.Add(TicketTimeLbl);
            Controls.Add(TicketDateLbl);
            Controls.Add(TicketTr_idLbl);
            Controls.Add(label1);
            Name = "Ticket";
            Text = "Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TicketTr_idLbl;
        private Label TicketDateLbl;
        private Label TicketTimeLbl;
        private Label TicketBusnameLbl;
        private Label TicketBusidLbl;
        private Label TicketTrnameLbl;
        private Label TicketAmoutLbl;
        private Button button1;
    }
}