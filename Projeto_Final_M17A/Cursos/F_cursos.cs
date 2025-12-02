using Projeto_Final_M17A.Alunos;
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

namespace Projeto_Final_M17A.Cursos
{
    public partial class F_cursos : Form
    {
        BaseDados bd;
        int ncurso =0;
        
        public F_cursos(BaseDados bd)
        {
            InitializeComponent();
            this.bd = bd;
            
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            // criar um objeto do tipo curso
            cursos novo = new cursos(bd);
            novo.ncurso = ncurso;
            // preencher os dados do curso
            
            novo.nome_curso = tb_nomecurso.Text;
            novo.descricao = tb_descricao.Text;
            novo.nivel = cb_nivel.Text;
            novo.duracaomeses = tb_duracao.Text;
            novo.cargahoraria = tb_horario.Text;
            // validar os dados
            List<string> erros = novo.Validar();
            // se nao tiver erros nos dados
            if (erros.Count > 0)
            {
                string mensagem = "";
                foreach (string erro in erros)
                    mensagem += erro + "; ";
                lb_feedback2.Text = mensagem;
                lb_feedback2.ForeColor = Color.Red;
                return;
            }
            // guardar os dados na base de dados
            novo.Atualizar();

            // limpar o formulario
            limparForm();
            // atualizar a lista de cursos
            Listarcursos();
            // feedback user
            lb_feedback2.Text = "Curso atualizado com sucesso!";
            lb_feedback2.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // criar um objeto do tipo curso
            cursos novo = new cursos(bd);
            // preencher os dados do curso
            
            novo.nome_curso = tb_nomecurso.Text;
            novo.nivel = cb_nivel.Text;
            novo.descricao = tb_descricao.Text;
            novo.duracaomeses = tb_duracao.Text;
            novo.cargahoraria = tb_horario.Text;
            // validar os dados
            List<string> erros = novo.Validar();
            // se nao tiver erros nos dados
            if (erros.Count > 0)
            {
                string mensagem = "";
                foreach (string erro in erros)
                    mensagem += erro + "; ";
                lb_feedback2.Text = mensagem;
                lb_feedback2.ForeColor = Color.Red;
                return;
            }
            // guardar os dados na base de dados
            novo.Adicionar();

            // limpar o formulario
            limparForm();
            // atualizar a lista de cursos
            Listarcursos();
            // feedback user
            lb_feedback2.Text = "Curso adicionado com sucesso!";
            lb_feedback2.ForeColor = Color.Red;
        }


        private void limparForm()
        {
            
            tb_nomecurso.Text = "";
            cb_nivel.Text = "";
            tb_horario.Text = "";
            tb_duracao.Text = "";
            tb_descricao.Text = "";
           
        }

        private void F_cursos_Load(object sender, EventArgs e)
        {
            Listarcursos();
        }

        private void Listarcursos()
        {
            dgv_cursos.AllowUserToAddRows = false;
            dgv_cursos.AllowUserToDeleteRows = false;
            dgv_cursos.ReadOnly = true;
            dgv_cursos.MultiSelect = false;
            dgv_cursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursos c = new cursos(bd);
            dgv_cursos.DataSource = c.Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Eliminarcurso();

        }

        private void Eliminarcurso()
        {
            if (ncurso == 0)
            {
                MessageBox.Show("Selecione um curso para eliminar.");
                return;
            }

            //confirmacao
            if (MessageBox.Show("Confirmar", "Tem a certeza que pretende eliminar o aluno selecionado?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cursos apagar = new cursos(bd);
                apagar.ncurso = ncurso;
                apagar.Apagar();
                Listarcursos();
                ncurso = 0;
            }
        }

        private void dgv_cursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tb_pesquisa2_TextChanged(object sender, EventArgs e)
        {
            cursos a = new cursos(bd);
            dgv_cursos.DataSource = a.Procurar("nome_curso", tb_pesquisa2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F_matriculas tela = new F_matriculas(bd);
            tela.Show();
            this.Hide();
        }

        private void dgv_cursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgv_cursos.CurrentCell.RowIndex;
            if (linha == -1)
                return;
            ncurso = int.Parse(dgv_cursos.Rows[linha].Cells[0].Value.ToString());
            //esconder o botão de adicionar novo
            bt_guardar.Visible = false;
            //preencher os form com os dados do curso selecionado
            cursos l = new cursos(bd);
            l.ncurso = ncurso;
            l.Procurar();
            tb_descricao.Text = l.descricao;
            tb_duracao.Text = l.duracaomeses;
            tb_horario.Text = l.cargahoraria;
            tb_nomecurso.Text = l.nome_curso;
            cb_nivel.Text = l.nivel;


            //mostrar os botões editar/eliminar/cancelar
            bt_editar.Visible = true;
            bt_remover.Visible = true;
        }

        private void cb_nivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limparForm();
            ncurso = 0;
            bt_editar.Visible = false;

        }
    }
    
}
