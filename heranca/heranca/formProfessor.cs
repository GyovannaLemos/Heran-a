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
    public partial class formProfessor : Form
    {
        public formProfessor()
        {
            InitializeComponent();
        }

        List<cl_professor> ListaProfessor = new List<cl_professor>();

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            AdicionarProf();
        }

        public void AtualizaProf()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaProfessor;

            txtIdade.Clear();
            txtNome.Clear();
            txtSalario.Clear();
            txtDisciplina.Clear();
            txtNome.Focus();
        }

        public void total()
        {
            txtTotal.Text = ListaProfessor.Count.ToString();
        }

        public void AdicionarProf()
        {
            cl_professor objProfessor = new cl_professor(txtIdade.Text, txtNome.Text, txtSalario.Text, txtDisciplina.Text);
            ListaProfessor.Add(objProfessor);

            AtualizaProf();
            total();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            ListaProfessor.RemoveAt(a);

            AtualizaProf();
            total();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita letras", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDisciplina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita letras", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita números", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita números", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formProfessor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            formPrincipal principal = new formPrincipal();
            principal.ShowDialog();
        }
    }
}
