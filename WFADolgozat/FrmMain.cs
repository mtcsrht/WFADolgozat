namespace WFADolgozat
{
    public partial class FrmMain : Form
    {
        static private Button[] operatorok;
        static private Button selectedOperator;
        public FrmMain()
        {
            InitializeComponent();
            btnWelcome.Click += BtnWelcome_Click;
            lblRed.Click += ColorChanger;
            lblBlue.Click += ColorChanger;
            lblGreen.Click += ColorChanger;

            operatorok = new Button[] { btnlOssze, btnOszt, btnSzorz, btnKivon };
            btnlOssze.Click += OPSelection;
            btnKivon.Click += OPSelection;
            btnSzorz.Click += OPSelection;
            btnOszt.Click += OPSelection;

            btnReset.Click += BtnReset_Click;
            btnClose.Click += BtnClose_Click;
            btnCalc.Click += BtnCalc_Click;
        }

        private void BtnCalc_Click(object? sender, EventArgs e)
        {
            double szamol1, szamol2;
            if (!double.TryParse(txtSzamolo1.Text, out szamol1) || !double.TryParse(txtSzamolo2.Text, out szamol2)) MessageBox.Show("Nem számokat írtál vagy valami baj van!!");
            else if (selectedOperator == null) MessageBox.Show("Nem választottál mûveletet!");
            else
            {
                switch (selectedOperator.Text)
                {
                    case "+": lblEredmeny.Text = (szamol1 + szamol2).ToString(); break;
                    case "-": lblEredmeny.Text = (szamol1 - szamol2).ToString(); break;
                    case "*": lblEredmeny.Text = (szamol1 * szamol2).ToString(); break;
                    case "/": lblEredmeny.Text = (szamol1 / szamol2).ToString(); break;
                }
            }
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            Application.Restart();
        }

        private void OPSelection(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Yellow;
            selectedOperator = (sender as Button);
            ChangeOthersToDefault();
        }

        private void ChangeOthersToDefault()
        {
            for (int i = 0; i < operatorok.Length; i++) if (operatorok[i] != selectedOperator) operatorok[i].BackColor = DefaultBackColor;
        }

        private void BtnWelcome_Click(object? sender, EventArgs e)
        {
            if (txtName.Text.Length != 0) lblWelcomeMessage.Text = $"Szia {txtName.Text}!";
            else MessageBox.Show("Hiányos a név mezõ, pótold!", "Mezõ hiány!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ColorChanger(object? sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.Red) this.BackColor = Color.Red;
            else if ((sender as Label).BackColor == Color.Green) this.BackColor = Color.Green;
            else if ((sender as Label).BackColor == Color.Blue) this.BackColor = Color.Blue;
        }

    }
}