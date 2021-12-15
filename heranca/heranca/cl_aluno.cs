using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class cl_aluno:cl_pessoa
    {
        public int num_matricula { get; set; }
        public string curso { get; set; }

        public cl_aluno(string id, string nom, int mat, string cur)
        {
            idade = id;
            nome = nom;
            num_matricula = mat;
            curso = cur;
        }

        public void Exibir() {
            System.Windows.Forms.MessageBox.Show("\n Nome: " + nome + "\n Idade: " + idade.ToString() + "\n Matrícula: " + num_matricula.ToString() + "\n Curso: " + curso);
        }
    }
}
