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

namespace Projeto_Final_M17A.Alunos
{
    public partial class F_alunos : Form
    {
        BaseDados bd;
        int naluno = 0;


        public F_alunos(object bd)
        {
            InitializeComponent();
           
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
            // criar um objeto do tipo livro
            alunos novo = new alunos(bd);
            // preencher os dados do livro
            novo.nome = tb_nome.Text;
            novo.idaluno = tb_idaluno.Text;
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
            tb_idaluno.Text = "";
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

        }

        private void dgv_alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
