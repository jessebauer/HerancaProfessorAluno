namespace HerancaProfessorAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadProf_Click(object sender, EventArgs e)
        {
            try
            {
                if (radProfessor.Checked)
                {
                    Professor prof = new Professor();
                    prof.Matricula = txtMatricula.Text;
                    prof.Nome = txtMatricula.Text;
                    prof.Salario = float.Parse(txtSalario.Text);

                    lblResposta.Text = $"" +
                        $"Nome: {prof.Nome}\n\n" +
                        $"Matrícula: {prof.Matricula}\n\n" +
                        $"Salário: R$ {prof.Salario}";
                }
                else
                {
                    MessageBox.Show("Selecione o tipo correto", "Erro", MessageBoxButtons.OK);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Todos os campos devem estar preenchidos", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            if (radAluno.Checked)
            {
                Aluno al = new Aluno();
                al.Matricula = txtMatricula.Text;
                al.Nome = txtNome.Text;
                al.Media = float.Parse(txtMedia.Text);
                lblResposta.Text = $"" +
                    $"Nome: {al.Nome}\n\n" +
                    $"Matrícula: {al.Matricula}\n\n" +
                    $"Média: {al.Media}";
            }
            else
            {
                MessageBox.Show("Selecione o tipo correto", "Erro");
            }
        }

        private void radProfessor_CheckedChanged(object sender, EventArgs e)
        {
            txtMedia.Visible = false;
            txtSalario.Visible = true;
            lblSalario.Visible = true;
            lblMedia.Visible = false;
        }

        private void radAluno_CheckedChanged(object sender, EventArgs e)
        {
            txtMedia.Visible = true;
            txtSalario.Visible = false;
            lblMedia.Visible = true;
            lblSalario.Visible = false;
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}