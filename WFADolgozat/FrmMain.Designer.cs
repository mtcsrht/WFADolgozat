namespace WFADolgozat
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            txtName = new TextBox();
            btnWelcome = new Button();
            lblWelcomeMessage = new Label();
            lblRed = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            btnlOssze = new Button();
            btnKivon = new Button();
            btnOszt = new Button();
            btnSzorz = new Button();
            txtSzamolo1 = new TextBox();
            txtSzamolo2 = new TextBox();
            label1 = new Label();
            lblEredmeny = new Label();
            btnCalc = new Button();
            btnClose = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(29, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "név:";
            // 
            // txtName
            // 
            txtName.Location = new Point(47, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // btnWelcome
            // 
            btnWelcome.Location = new Point(169, 6);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(75, 23);
            btnWelcome.TabIndex = 2;
            btnWelcome.Text = "Köszönj!";
            btnWelcome.UseVisualStyleBackColor = true;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.BackColor = Color.Khaki;
            lblWelcomeMessage.Location = new Point(12, 51);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(232, 38);
            lblWelcomeMessage.TabIndex = 3;
            lblWelcomeMessage.Text = "###UDVOZLES###";
            lblWelcomeMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed
            // 
            lblRed.BackColor = Color.Red;
            lblRed.ForeColor = Color.White;
            lblRed.Location = new Point(629, 6);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(49, 51);
            lblRed.TabIndex = 4;
            lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            lblGreen.BackColor = Color.Green;
            lblGreen.ForeColor = Color.White;
            lblGreen.Location = new Point(684, 6);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(49, 51);
            lblGreen.TabIndex = 4;
            lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            lblBlue.BackColor = Color.Blue;
            lblBlue.ForeColor = Color.White;
            lblBlue.Location = new Point(739, 6);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(49, 51);
            lblBlue.TabIndex = 4;
            lblBlue.Text = "Blue";
            // 
            // btnlOssze
            // 
            btnlOssze.Location = new Point(247, 205);
            btnlOssze.Name = "btnlOssze";
            btnlOssze.Size = new Size(30, 30);
            btnlOssze.TabIndex = 5;
            btnlOssze.Text = "+";
            btnlOssze.UseVisualStyleBackColor = true;
            // 
            // btnKivon
            // 
            btnKivon.Location = new Point(283, 205);
            btnKivon.Name = "btnKivon";
            btnKivon.Size = new Size(30, 30);
            btnKivon.TabIndex = 5;
            btnKivon.Text = "-";
            btnKivon.UseVisualStyleBackColor = true;
            // 
            // btnOszt
            // 
            btnOszt.Location = new Point(283, 241);
            btnOszt.Name = "btnOszt";
            btnOszt.Size = new Size(30, 30);
            btnOszt.TabIndex = 5;
            btnOszt.Text = "/";
            btnOszt.UseVisualStyleBackColor = true;
            // 
            // btnSzorz
            // 
            btnSzorz.Location = new Point(247, 241);
            btnSzorz.Name = "btnSzorz";
            btnSzorz.Size = new Size(30, 30);
            btnSzorz.TabIndex = 5;
            btnSzorz.Text = "*";
            btnSzorz.UseVisualStyleBackColor = true;
            // 
            // txtSzamolo1
            // 
            txtSzamolo1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtSzamolo1.Location = new Point(139, 217);
            txtSzamolo1.Name = "txtSzamolo1";
            txtSzamolo1.Size = new Size(74, 43);
            txtSzamolo1.TabIndex = 6;
            // 
            // txtSzamolo2
            // 
            txtSzamolo2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtSzamolo2.Location = new Point(355, 217);
            txtSzamolo2.Name = "txtSzamolo2";
            txtSzamolo2.Size = new Size(74, 43);
            txtSzamolo2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(476, 220);
            label1.Name = "label1";
            label1.Size = new Size(35, 37);
            label1.TabIndex = 7;
            label1.Text = "=";
            // 
            // lblEredmeny
            // 
            lblEredmeny.BackColor = Color.White;
            lblEredmeny.BorderStyle = BorderStyle.FixedSingle;
            lblEredmeny.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEredmeny.Location = new Point(556, 223);
            lblEredmeny.Name = "lblEredmeny";
            lblEredmeny.Size = new Size(106, 34);
            lblEredmeny.TabIndex = 8;
            lblEredmeny.Text = "#eredmeny#";
            lblEredmeny.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(138, 302);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(522, 34);
            btnCalc.TabIndex = 9;
            btnCalc.Text = "Számolj!";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(713, 404);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 34);
            btnClose.TabIndex = 10;
            btnClose.Text = "Kilépés";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(614, 404);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(93, 34);
            btnReset.TabIndex = 10;
            btnReset.Text = "Alaphelyzet";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnClose);
            Controls.Add(btnCalc);
            Controls.Add(lblEredmeny);
            Controls.Add(label1);
            Controls.Add(txtSzamolo2);
            Controls.Add(txtSzamolo1);
            Controls.Add(btnSzorz);
            Controls.Add(btnOszt);
            Controls.Add(btnKivon);
            Controls.Add(btnlOssze);
            Controls.Add(lblBlue);
            Controls.Add(lblGreen);
            Controls.Add(lblRed);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(btnWelcome);
            Controls.Add(txtName);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WFA Dolgozat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TextBox txtName;
        private Button btnWelcome;
        private Label lblWelcomeMessage;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private Button btnlOssze;
        private Button btnKivon;
        private Button btnOszt;
        private Button btnSzorz;
        private TextBox txtSzamolo1;
        private TextBox txtSzamolo2;
        private Label label1;
        private Label lblEredmeny;
        private Button btnCalc;
        private Button btnClose;
        private Button btnReset;
    }
}