using Projeto_Final_M17A.Alunos;
using Projeto_Final_M17A.Cursos;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Final_M17A.Matriculas
{
    public partial class F_matriculas : Form
    {
        BaseDados bd;
        int id_matricula = 0;

        public F_matriculas(BaseDados bd)
        {
            InitializeComponent();
            this.bd = bd;
            PreencheCBAlunos();
            PreencheCBCursos();
            ListarMatriculas();
        }

        void PreencheCBAlunos()
        {
            cb_alunos.Items.Clear();
            Alunos.alunos l = new Alunos.alunos(bd);
            DataTable dados = l.Listar();
            foreach (DataRow dr in dados.Rows)
            {
                Alunos.alunos novo = new Alunos.alunos(bd);
                novo.naluno = int.Parse(dr["naluno"].ToString());
                novo.nome = dr["nome"].ToString();
                novo.ativo = bool.Parse(dr["ativo"].ToString());
                if (novo.ativo == true)
                    cb_alunos.Items.Add(novo);
            }
        }

        void PreencheCBCursos()
        {
            cb_cursos.Items.Clear();
            Cursos.cursos l = new Cursos.cursos(bd);
            DataTable dados = l.Listar();
            foreach (DataRow dr in dados.Rows)
            {
                Cursos.cursos n = new Cursos.cursos(bd);
                n.ncurso = int.Parse(dr["ncurso"].ToString());
                n.nome_curso = dr["nome_curso"].ToString();
                cb_cursos.Items.Add(n);
            }
        }

        private void ListarMatriculas()
        {
            dtv_matriculas.AllowUserToAddRows = false;
            dtv_matriculas.AllowUserToDeleteRows = false;
            dtv_matriculas.ReadOnly = true;
            dtv_matriculas.MultiSelect = false;
            dtv_matriculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            matriculas m = new matriculas(bd);
            dtv_matriculas.DataSource = m.Listar();

            if (dtv_matriculas.Columns.Count > 0)
            {
                // esconder o id da matrícula na grelha
                dtv_matriculas.Columns[0].Visible = false;
            }
        }

        private void F_matriculas_Load(object sender, EventArgs e)
        {
            dtp_dataInicio.Value = DateTime.Today;
            dtp_dataTermino.Value = DateTime.Today.AddMonths(1);
        }

        private void bt_matricular_Click(object sender, EventArgs e)
        {
            if (cb_alunos.SelectedIndex == -1 || cb_cursos.SelectedIndex == -1)
            {
                MessageBox.Show("Deve selecionar um Aluno e um Curso.");
                return;
            }

            DateTime dataInicio = dtp_dataInicio.Value.Date;
            DateTime dataTermino = dtp_dataTermino.Value.Date;

            if (dataInicio < DateTime.Today.Date)
            {
                MessageBox.Show("A data de início não pode ser anterior à data de hoje.");
                return;
            }

            if (dataTermino <= dataInicio)
            {
                MessageBox.Show("A data de término deve ser posterior à data de início.");
                return;
            }

            Cursos.cursos cursoSelecionado = (Cursos.cursos)cb_cursos.SelectedItem;
            Alunos.alunos alunoSelecionado = (Alunos.alunos)cb_alunos.SelectedItem;
            matriculas mat = new matriculas(bd);
            mat.naluno = alunoSelecionado.naluno;
            mat.ncurso = cursoSelecionado.ncurso;
            mat.data_inicio = dataInicio;
            mat.data_termino = dataTermino;
            mat.estado = chk_estado.Checked;
            mat.RegistarEmprestimo();

            PreencheCBAlunos();
            ListarMatriculas();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dtv_matriculas.CurrentCell.RowIndex;
            if (linha == -1)
                return;

            id_matricula = int.Parse(dtv_matriculas.Rows[linha].Cells[0].Value.ToString());

            matriculas m = new matriculas(bd);
            m.id_matricula = id_matricula;
            m.Procurar();

            // selecionar o aluno correspondente no combobox
            var aluno = cb_alunos.Items.Cast<Alunos.alunos>().FirstOrDefault(a => a.naluno == m.naluno);
            if (aluno != null)
                cb_alunos.SelectedItem = aluno;

            // selecionar o curso correspondente no combobox
            var curso = cb_cursos.Items.Cast<Cursos.cursos>().FirstOrDefault(c => c.ncurso == m.ncurso);
            if (curso != null)
                cb_cursos.SelectedItem = curso;

            if (m.data_inicio != DateTime.MinValue)
                dtp_dataInicio.Value = m.data_inicio;

            if (m.data_termino != DateTime.MinValue)
                dtp_dataTermino.Value = m.data_termino;

            chk_estado.Checked = m.estado;
        }

        private void dtv_matriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bt_verMatriculas_Click(object sender, EventArgs e)
        {
            ListarMatriculas();
        }

        private void bt_estatisticas_Click(object sender, EventArgs e)
        {
            matriculas m = new matriculas(bd);
            dtv_matriculas.DataSource = m.ContarMatriculasPorCurso();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
