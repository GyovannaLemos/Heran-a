using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class cl_professor:cl_pessoa
    {
        public string salario { get; set; }
        public string disciplina { get; set; }

        public cl_professor(string id, string nom, string sal, string disc)
        {
            idade = id;
            nome = nom;
            salario = sal;
            disciplina = disc;
        }

        public void Exibir()
        {
            System.Windows.Forms.MessageBox.Show("\nNome: " + nome + "\nIdade: " + idade + "\nSálario: " + salario + "\nDisciplina: " + disciplina);
        }
    }
}
