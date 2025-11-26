namespace Projeto_Final_M17A.Alunos
{
    partial class F_alunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_alunos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_naluno = new System.Windows.Forms.TextBox();
            this.tb_morada = new System.Windows.Forms.TextBox();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_codigopostal = new System.Windows.Forms.TextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.lb_feedback = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "codigo postal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "data nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "morada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "id aluno";
            // 
            // tb_naluno
            // 
            this.tb_naluno.Location = new System.Drawing.Point(112, 30);
            this.tb_naluno.Name = "tb_naluno";
            this.tb_naluno.Size = new System.Drawing.Size(215, 20);
            this.tb_naluno.TabIndex = 7;
            // 
            // tb_morada
            // 
            this.tb_morada.Location = new System.Drawing.Point(109, 157);
            this.tb_morada.Name = "tb_morada";
            this.tb_morada.Size = new System.Drawing.Size(218, 20);
            this.tb_morada.TabIndex = 8;
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(109, 130);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(218, 20);
            this.tb_telefone.TabIndex = 9;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(91, 106);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(236, 20);
            this.tb_email.TabIndex = 10;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(91, 56);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(236, 20);
            this.tb_nome.TabIndex = 12;
            // 
            // tb_codigopostal
            // 
            this.tb_codigopostal.Location = new System.Drawing.Point(152, 183);
            this.tb_codigopostal.Name = "tb_codigopostal";
            this.tb_codigopostal.Size = new System.Drawing.Size(175, 20);
            this.tb_codigopostal.TabIndex = 13;
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(171, 82);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(156, 20);
            this.dtp_data.TabIndex = 14;
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.Location = new System.Drawing.Point(417, 30);
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.Size = new System.Drawing.Size(346, 173);
            this.dgv_alunos.TabIndex = 15;
            this.dgv_alunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alunos_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(43, 238);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(101, 33);
            this.bt_guardar.TabIndex = 17;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // lb_feedback
            // 
            this.lb_feedback.AutoSize = true;
            this.lb_feedback.Location = new System.Drawing.Point(1, 304);
            this.lb_feedback.Name = "lb_feedback";
            this.lb_feedback.Size = new System.Drawing.Size(0, 13);
            this.lb_feedback.TabIndex = 18;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(171, 238);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(91, 33);
            this.bt_cancelar.TabIndex = 19;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(43, 277);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(101, 31);
            this.bt_editar.TabIndex = 20;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(171, 277);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(91, 31);
            this.bt_eliminar.TabIndex = 21;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.Location = new System.Drawing.Point(417, 4);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(346, 20);
            this.tb_pesquisa.TabIndex = 22;
            this.tb_pesquisa.TextChanged += new System.EventHandler(this.tb_pesquisa_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 43);
            this.button2.TabIndex = 23;
            this.button2.Text = "Ver Cursos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // F_alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_pesquisa);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.lb_feedback);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_alunos);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.tb_codigopostal);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.tb_morada);
            this.Controls.Add(this.tb_naluno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_alunos";
            this.Text = "F_alunos";
            this.Load += new System.EventHandler(this.F_alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_naluno;
        private System.Windows.Forms.TextBox tb_morada;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_codigopostal;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label lb_feedback;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.Button button2;
    }
}