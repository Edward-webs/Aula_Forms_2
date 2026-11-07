namespace Aula_Forms_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtAnoNascimento.Text.Trim() == "" || txtAnoAniversario.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                int anoNascimento = int.Parse(txtAnoNascimento.Text);
                int anoAniversario = int.Parse(txtAnoAniversario.Text);

                if (anoAniversario <= anoNascimento)
                {
                    MessageBox.Show("O ano do último aniversário deve ser superior ao ano de nascimento!");
                }
                else
                {
                    int idade = anoAniversario - anoNascimento;

                    if (idade >= 5 && idade <= 7)
                    {
                        lblCategoriaAluno.Text = "INFANTIL A";
                    }
                    else if (idade >= 8 && idade <= 10)
                    {
                        lblCategoriaAluno.Text = "INFANTIL B";
                    }
                    else if (idade >= 11 && idade <= 13)
                    {
                        lblCategoriaAluno.Text = "JUVENIL A";
                    }
                    else if (idade >= 14 && idade <= 17)
                    {
                        lblCategoriaAluno.Text = "JUVENIL B";
                    }
                    else if (idade >= 18)
                    {
                        lblCategoriaAluno.Text = "ADULTO";
                    }
                    else
                    {
                        lblCategoriaAluno.Text = "IDADE NÃO CLASSIFICADA";
                    }
                }
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("Informe o ano de nascimento corretamente!");

                txtAnoNascimento.Focus();
            }
        }
    }
}
