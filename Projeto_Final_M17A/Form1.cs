using Projeto_Final_M17A.Alunos;
using Projeto_Final_M17A.Cursos;
using Projeto_Final_M17A.Matriculas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_M17A
{
    public partial class Form1 : Form
    {
        BaseDados bd;
        public Form1()
        {
            InitializeComponent();
            bd = new BaseDados("Projeto_Final_M17");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_alunos f = new F_alunos(bd);
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_cursos f = new F_cursos(bd);
            f.Show();
        }

        private void matriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_matriculas f = new F_matriculas(bd);
            f.Show();
        }
    }
}
