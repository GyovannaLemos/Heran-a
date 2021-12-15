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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            formProfessor professor = new formProfessor();
            professor.ShowDialog();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            frmAluno aluno = new frmAluno();
            aluno.ShowDialog();
        }
    }
}
