namespace Projeto_Final_M17A.Matriculas
{
    partial class F_matriculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cb_alunos = new System.Windows.Forms.ComboBox();
            this.cb_cursos = new System.Windows.Forms.ComboBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.bt_matricular = new System.Windows.Forms.Button();
            this.dtv_matriculas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_dataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataTermino = new System.Windows.Forms.DateTimePicker();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.bt_verMatriculas = new System.Windows.Forms.Button();
            this.bt_estatisticas = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_matriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_alunos
            // 
            this.cb_alunos.FormattingEnabled = true;
            this.cb_alunos.Location = new System.Drawing.Point(140, 40);
            this.cb_alunos.Name = "cb_alunos";
            this.cb_alunos.Size = new System.Drawing.Size(350, 24);
            this.cb_alunos.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cb_alunos, "Selecione o aluno a matricular");
            // 
            // cb_cursos
            // 
            this.cb_cursos.FormattingEnabled = true;
            this.cb_cursos.Location = new System.Drawing.Point(140, 80);
            this.cb_cursos.Name = "cb_cursos";
            this.cb_cursos.Size = new System.Drawing.Size(350, 24);
            this.cb_cursos.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cb_cursos, "Selecione o curso");
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // bt_matricular
            // 
            this.bt_matricular.Location = new System.Drawing.Point(220, 220);
            this.bt_matricular.Name = "bt_matricular";
            this.bt_matricular.Size = new System.Drawing.Size(128, 51);
            this.bt_matricular.TabIndex = 5;
            this.bt_matricular.Text = "Matricular";
            this.bt_matricular.UseVisualStyleBackColor = true;
            this.bt_matricular.Click += new System.EventHandler(this.bt_matricular_Click);
            // 
            // dtv_matriculas
            // 
            this.dtv_matriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_matriculas.Location = new System.Drawing.Point(520, 40);
            this.dtv_matriculas.Name = "dtv_matriculas";
            this.dtv_matriculas.RowHeadersWidth = 51;
            this.dtv_matriculas.RowTemplate.Height = 24;
            this.dtv_matriculas.Size = new System.Drawing.Size(515, 365);
            this.dtv_matriculas.TabIndex = 8;
            this.dtv_matriculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dtv_matriculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_matriculas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aluno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data término";
            // 
            // dtp_dataInicio
            // 
            this.dtp_dataInicio.Location = new System.Drawing.Point(140, 118);
            this.dtp_dataInicio.Name = "dtp_dataInicio";
            this.dtp_dataInicio.Size = new System.Drawing.Size(200, 22);
            this.dtp_dataInicio.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtp_dataInicio, "Data de início do curso");
            // 
            // dtp_dataTermino
            // 
            this.dtp_dataTermino.Location = new System.Drawing.Point(140, 158);
            this.dtp_dataTermino.Name = "dtp_dataTermino";
            this.dtp_dataTermino.Size = new System.Drawing.Size(200, 22);
            this.dtp_dataTermino.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dtp_dataTermino, "Data prevista de término");
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Checked = true;
            this.chk_estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_estado.Location = new System.Drawing.Point(43, 196);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(115, 20);
            this.chk_estado.TabIndex = 4;
            this.chk_estado.Text = "Matrícula ativa";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // bt_verMatriculas
            // 
            this.bt_verMatriculas.Location = new System.Drawing.Point(520, 420);
            this.bt_verMatriculas.Name = "bt_verMatriculas";
            this.bt_verMatriculas.Size = new System.Drawing.Size(150, 40);
            this.bt_verMatriculas.TabIndex = 6;
            this.bt_verMatriculas.Text = "Ver matrículas";
            this.bt_verMatriculas.UseVisualStyleBackColor = true;
            this.bt_verMatriculas.Click += new System.EventHandler(this.bt_verMatriculas_Click);
            // 
            // bt_estatisticas
            // 
            this.bt_estatisticas.Location = new System.Drawing.Point(700, 420);
            this.bt_estatisticas.Name = "bt_estatisticas";
            this.bt_estatisticas.Size = new System.Drawing.Size(180, 40);
            this.bt_estatisticas.TabIndex = 7;
            this.bt_estatisticas.Text = "Estatísticas por curso";
            this.bt_estatisticas.UseVisualStyleBackColor = true;
            this.bt_estatisticas.Click += new System.EventHandler(this.bt_estatisticas_Click);
            // 
            // F_matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bt_estatisticas);
            this.Controls.Add(this.bt_verMatriculas);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.dtp_dataTermino);
            this.Controls.Add(this.dtp_dataInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtv_matriculas);
            this.Controls.Add(this.bt_matricular);
            this.Controls.Add(this.cb_cursos);
            this.Controls.Add(this.cb_alunos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_matriculas";
            this.Text = "Matrículas";
            this.Load += new System.EventHandler(this.F_matriculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_matriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_alunos;
        private System.Windows.Forms.ComboBox cb_cursos;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button bt_matricular;
        private System.Windows.Forms.DataGridView dtv_matriculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_dataInicio;
        private System.Windows.Forms.DateTimePicker dtp_dataTermino;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Button bt_verMatriculas;
        private System.Windows.Forms.Button bt_estatisticas;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
