using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Final_M17A.Cursos;

namespace Projeto_Final_M17A.Alunos
{
    public partial class F_alunos : Form
    {
        BaseDados bd;
        int naluno = 0;


        public F_alunos(BaseDados bd)
        {
            InitializeComponent();
           
            this.bd = bd;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            impressora i = new impressora();
            i.imprimeGrelha(printDocument1, e, dgv_alunos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.ShowDialog();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            // criar um objeto do tipo aluno
            alunos novo = new alunos(bd);
            // preencher os dados do aluno
            novo.nome = tb_nome.Text;
            novo.data_nascimento = dtp_data.Value;
            novo.email = tb_email.Text;
            novo.telefone = tb_telefone.Text;
            novo.morada = tb_morada.Text;
            novo.codigopostal = tb_codigopostal.Text;
            // validar os dados
            List<string> erros = novo.Validar();
            // se nao tiver erros nos dados
            if (erros.Count > 0)
            {
                string mensagem = "";
                foreach (string erro in erros)
                    mensagem += erro + "; ";
                lb_feedback.Text = mensagem;
                lb_feedback.ForeColor = Color.Red;
                return;
            }
            // guardar os dados na base de dados
            novo.Adicionar();

            // limpar o formulario
            limparForm();
            // atualizar a lista de livros
            Listaralunos();
            // feedback user
            lb_feedback.Text = "Aluno adicionado com sucesso!";
            lb_feedback.ForeColor = Color.Red;
        }

        private void limparForm()
        {
            tb_nome.Text = "";
            tb_email.Text = "";
            tb_morada.Text = "";
            tb_telefone.Text = "";
            tb_codigopostal.Text = "";
            dtp_data.Value = DateTime.Now;

        }

        private void Listaralunos()
        {
            dgv_alunos.AllowUserToAddRows = false;
            dgv_alunos.AllowUserToDeleteRows = false;
            dgv_alunos.ReadOnly = true;
            dgv_alunos.MultiSelect = false;
            dgv_alunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            alunos l = new alunos(bd);
            dgv_alunos.DataSource = l.Listar();
        }

        private void F_alunos_Load(object sender, EventArgs e)
        {
            Listaralunos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limparForm();
            naluno = 0;
            bt_editar.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // criar um objeto do tipo aluno
            alunos novo = new alunos(bd);
            novo.naluno = naluno;
            // preencher os dados do aluno
            novo.nome = tb_nome.Text;
            novo.data_nascimento = dtp_data.Value;
            novo.email = tb_email.Text;
            novo.telefone = tb_telefone.Text;
            novo.morada = tb_morada.Text;
            novo.codigopostal = tb_codigopostal.Text;
            // validar os dados
            List<string> erros = novo.Validar();
            // se nao tiver erros nos dados
            if (erros.Count > 0)
            {
                string mensagem = "";
                foreach (string erro in erros)
                    mensagem += erro + "; ";
                lb_feedback.Text = mensagem;
                lb_feedback.ForeColor = Color.Red;
                return;
            }
            // guardar os dados na base de dados
            novo.Atualizar();

            // limpar o formulario
            limparForm();
            // atualizar a lista de alunos
            Listaralunos();
            // feedback user
            lb_feedback.Text = "Aluno atualizado com sucesso!";
            lb_feedback.ForeColor = Color.Red;
        }

        private void dgv_alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            EliminarAluno();
            
        }

        private void EliminarAluno()
        {
            if (naluno == 0)
            {
                MessageBox.Show("Selecione um aluno para eliminar.");
                return;
            }

            //confirmacao
            if (MessageBox.Show("Confirmar", "Tem a certeza que pretende eliminar o aluno selecionado?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                alunos apagar = new alunos(bd);
                apagar.naluno = naluno ;
                apagar.Apagar();
                Listaralunos();
                naluno = 0;
            }
        }

        private void tb_pesquisa_TextChanged(object sender, EventArgs e)
        {
            alunos a = new alunos(bd);
            dgv_alunos.DataSource = a.Procurar("nome", tb_pesquisa.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            F_cursos tela = new F_cursos(bd);
            tela.Show();
            this.Hide();
        }

        private void dgv_alunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgv_alunos.CurrentCell.RowIndex;
            if (linha == -1)
                return;
            naluno = int.Parse(dgv_alunos.Rows[linha].Cells[0].Value.ToString());
            //esconder o botão de adicionar novo
            bt_guardar.Visible = false;
            //preencher os form com os dados do livro selecionado
            alunos l = new alunos(bd);
            l.naluno = naluno;
            l.Procurar();
            tb_nome.Text = l.nome;
            tb_email.Text = l.email;
            tb_codigopostal.Text = l.codigopostal;
            tb_morada.Text = l.morada;
            tb_telefone.Text = l.telefone;
            dtp_data.Value = l.data_nascimento;


            //mostrar os botões editar/eliminar/cancelar
            bt_editar.Visible = true;
            bt_eliminar.Visible = true;
        }
    }
    
}
