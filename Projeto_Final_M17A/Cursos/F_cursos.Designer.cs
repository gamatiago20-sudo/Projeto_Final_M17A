namespace Projeto_Final_M17A.Cursos
{
    partial class F_cursos
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
            this.dgv_cursos = new System.Windows.Forms.DataGridView();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_horario = new System.Windows.Forms.TextBox();
            this.tb_duracao = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_nomecurso = new System.Windows.Forms.TextBox();
            this.lb_feedback2 = new System.Windows.Forms.Label();
            this.tb_pesquisa2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cb_nivel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cursos
            // 
            this.dgv_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cursos.Location = new System.Drawing.Point(300, 31);
            this.dgv_cursos.Name = "dgv_cursos";
            this.dgv_cursos.RowHeadersWidth = 51;
            this.dgv_cursos.Size = new System.Drawing.Size(466, 319);
            this.dgv_cursos.TabIndex = 0;
            this.dgv_cursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cursos_CellClick);
            this.dgv_cursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cursos_CellContentClick);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(300, 376);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(106, 61);
            this.bt_guardar.TabIndex = 1;
            this.bt_guardar.Text = "Adicionar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Location = new System.Drawing.Point(660, 377);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(106, 60);
            this.bt_remover.TabIndex = 2;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(480, 378);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(106, 60);
            this.bt_editar.TabIndex = 3;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "duraçao meses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "nivel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "carga horaria";
            // 
            // tb_horario
            // 
            this.tb_horario.Location = new System.Drawing.Point(135, 187);
            this.tb_horario.Name = "tb_horario";
            this.tb_horario.Size = new System.Drawing.Size(125, 20);
            this.tb_horario.TabIndex = 11;
            // 
            // tb_duracao
            // 
            this.tb_duracao.Location = new System.Drawing.Point(149, 162);
            this.tb_duracao.Name = "tb_duracao";
            this.tb_duracao.Size = new System.Drawing.Size(111, 20);
            this.tb_duracao.TabIndex = 12;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(111, 104);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(149, 20);
            this.tb_descricao.TabIndex = 14;
            // 
            // tb_nomecurso
            // 
            this.tb_nomecurso.Location = new System.Drawing.Point(80, 76);
            this.tb_nomecurso.Name = "tb_nomecurso";
            this.tb_nomecurso.Size = new System.Drawing.Size(180, 20);
            this.tb_nomecurso.TabIndex = 15;
            // 
            // lb_feedback2
            // 
            this.lb_feedback2.AutoSize = true;
            this.lb_feedback2.Location = new System.Drawing.Point(132, 240);
            this.lb_feedback2.Name = "lb_feedback2";
            this.lb_feedback2.Size = new System.Drawing.Size(0, 13);
            this.lb_feedback2.TabIndex = 16;
            // 
            // tb_pesquisa2
            // 
            this.tb_pesquisa2.Location = new System.Drawing.Point(300, 5);
            this.tb_pesquisa2.Name = "tb_pesquisa2";
            this.tb_pesquisa2.Size = new System.Drawing.Size(466, 20);
            this.tb_pesquisa2.TabIndex = 17;
            this.tb_pesquisa2.TextChanged += new System.EventHandler(this.tb_pesquisa2_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(75, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 88);
            this.button4.TabIndex = 18;
            this.button4.Text = "Ver Matriculas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cb_nivel
            // 
            this.cb_nivel.FormattingEnabled = true;
            this.cb_nivel.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.cb_nivel.Location = new System.Drawing.Point(75, 132);
            this.cb_nivel.Name = "cb_nivel";
            this.cb_nivel.Size = new System.Drawing.Size(185, 21);
            this.cb_nivel.TabIndex = 19;
            this.cb_nivel.SelectedIndexChanged += new System.EventHandler(this.cb_nivel_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 376);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // F_cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_nivel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tb_pesquisa2);
            this.Controls.Add(this.lb_feedback2);
            this.Controls.Add(this.tb_nomecurso);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.tb_duracao);
            this.Controls.Add(this.tb_horario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.dgv_cursos);
            this.Name = "F_cursos";
            this.Text = "F_cursos";
            this.Load += new System.EventHandler(this.F_cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cursos;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_horario;
        private System.Windows.Forms.TextBox tb_duracao;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.TextBox tb_nomecurso;
        private System.Windows.Forms.Label lb_feedback2;
        private System.Windows.Forms.TextBox tb_pesquisa2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cb_nivel;
        private System.Windows.Forms.Button button1;
    }
}