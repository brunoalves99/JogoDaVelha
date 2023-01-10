namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string vez = "X";

        public void MudaVez()
        {
            if (vez == "X")
            {
                vez = "O";
            } else
            {
                vez = "X";
            }
        }

        public void VerificaEmpate()
        {
            if (button1.Enabled == false &&
                button2.Enabled == false &&
                button3.Enabled == false &&
                button4.Enabled == false &&
                button5.Enabled == false &&
                button6.Enabled == false &&
                button7.Enabled == false &&
                button8.Enabled == false &&
                button9.Enabled == false)
            {
                labelVez.Text = "Empate!";
                MessageBox.Show("Empate!");
                AtivaBtn();
                vez = "X";
                labelVez.Text = $"Vez do {vez}";
            }
        }

        public void AtivaBtn()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "?";
            button2.Text = "?";
            button3.Text = "?";
            button4.Text = "?";
            button5.Text = "?";
            button6.Text = "?";
            button7.Text = "?";
            button8.Text = "?";
            button9.Text = "?";
        }

        public void XWin()
        {
            labelVez.Text = "'X' venceu!";
            MessageBox.Show("O jogador 'X' venceu!");
            vez = "X";
            labelVez.Text = $"Vez do {vez}";
            AtivaBtn();
        }

        public void OWin()
        {
            labelVez.Text = "'O' venceu!";
            MessageBox.Show("O jogador 'O' venceu!");
            vez = "X";
            labelVez.Text = $"Vez do {vez}";
            AtivaBtn();
        }

        public void VerificaVitoria()
        {
            // Linhas
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                XWin();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                OWin();
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                XWin();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                OWin();
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                XWin();
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                OWin();
            }
            // Colunas
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                XWin();
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                OWin();
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                XWin();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                OWin();
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                XWin();
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                OWin();
            }
            // Cruzado
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                XWin();
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                OWin();
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                XWin();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                OWin();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = vez;
            MudaVez();
            labelVez.Text = $"Vez do {vez}";
            button1.Enabled = false;
            VerificaVitoria();
            VerificaEmpate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = vez;
            MudaVez();
            labelVez.Text = $"Vez do {vez}";
            button2.Enabled = false;
            VerificaVitoria();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = vez;
            MudaVez();
            labelVez.Text = $"Vez do {vez}";
            button3.Enabled = false;
            VerificaVitoria();
            VerificaEmpate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = vez;
            MudaVez();
            labelVez.Text = $"Vez do {vez}";
            button4.Enabled = false;
            VerificaVitoria();
            VerificaEmpate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = vez;
            MudaVez();
            labelVez.Text = $"Vez do {vez}";
            button5.Enabled = false;
            VerificaVitoria();
            VerificaEmpate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = vez;
            MudaVez();
            labelVez.Text = $"Vez do {vez}";
            button6.Enabled = false;
            VerificaVitoria();
            VerificaEmpate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = vez;
            MudaVez();
            labelVez.Text = $"Vez do {vez}";
            button7.Enabled = false;
            VerificaVitoria();
            VerificaEmpate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = vez;
            MudaVez();
            labelVez.Text = $"Vez do {vez}";
            button8.Enabled = false;
            VerificaVitoria();
            VerificaEmpate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = vez;
            MudaVez();
            labelVez.Text = $"Vez do {vez}";
            button9.Enabled = false;
            VerificaVitoria();
            VerificaEmpate();
        }
    }
}