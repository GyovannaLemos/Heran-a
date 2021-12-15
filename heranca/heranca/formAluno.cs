using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heranca
{
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }

        List<cl_aluno> ListaAluno = new List<cl_aluno>();

        public void AtualizaAluno()
        {
            // limpa o datagridview
            dataGridView1.DataSource = null;
            //alimenta o data com a lista aluno
            dataGridView1.DataSource = ListaAluno;

            txtNome.Clear();
            txtMatricula.Clear();
            txtIdade.Clear();
            txtCurso.Clear();
            txtNome.Focus();
        }

        public void total()
        {
            txtTotal.Text = ListaAluno.Count.ToString();
        }

        public void adicionarAluno()
        {
            cl_aluno objAluno = new cl_aluno(txtIdade.Text, txtNome.Text, int.Parse(txtMatricula.Text), txtCurso.Text);
            ListaAluno.Add(objAluno);

            AtualizaAluno();
            total();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            adicionarAluno();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            ListaAluno.RemoveAt(a);
            AtualizaAluno();
            total();
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita números", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita números", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsLetter(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita letras", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita letras", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            formPrincipal principal = new formPrincipal();
            principal.ShowDialog();
        }
    }
}
