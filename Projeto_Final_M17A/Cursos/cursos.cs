using Microsoft.Data.SqlClient;
using Projeto_Final_M17A.Alunos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_M17A.Cursos
{
    internal class cursos
    {
        public int ncurso { get; set; }
        public string nome_curso { get; set; }
        public string descricao { get; set; }
        public string nivel { get; set; }
        public string duracaomeses { get; set; }
        public string cargahoraria { get; set; }
        public string codigopostal { get; set; }
        public  bool ativo { get; set; }
        BaseDados bd;

        public cursos(BaseDados bd)
        {
            this.bd = bd;
        }

        internal void Adicionar()
        {
            string sql = @"INSERT INTO cursos ( nome_curso, descricao, nivel, duracaomeses, cargahoraria)
                           VALUES ( @nome_curso, @descricao, @nivel, @duracaomeses, @cargahoraria)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@nome_curso",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.nome_curso

                },
                new SqlParameter()
                {
                    ParameterName = "@descricao",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.descricao

                },
                new SqlParameter()
                {
                    ParameterName = "@nivel",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.nivel

                },
                new SqlParameter()
                {
                    ParameterName = "@duracaomeses",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.duracaomeses

                },
                new SqlParameter()
                {
                    ParameterName = "@cargahoraria",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.cargahoraria

                },


            };
            bd.ExecutarSQL(sql, parametros);
        }

        internal List<string> Validar()
        {
            List<string> erros = new List<string>();
            //validar o nome
            if (string.IsNullOrEmpty(nome_curso) || nome_curso.Length < 3)
            {
                erros.Add("O nome do curso deve ter pelo menos 3 letras");
            }
            return erros;
        }

        public override string ToString()
        {
            return this.nome_curso;
        }

        internal object Procurar(string campo2, string texto_pesquisar2)
        {
            string sql = "SELECT ncurso, nome_curso, descricao, nivel FROM cursos";
            sql += " WHERE " + campo2 + " LIKE @pesquisa ";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@pesquisa",
                    SqlDbType = SqlDbType.VarChar,
                    Value = "%" + texto_pesquisar2 + "%"
                }
            };
            return bd.DevolveSQL(sql, parametros);
        }

        internal DataTable Listar()
        {
            return bd.DevolveSQL("SELECT ncurso, nome_curso, descricao, duracaomeses, cargahoraria FROM cursos order by nome_curso ");
        }

        internal void Apagar()
        {
            // Isto é seguro porque o naluno é um inteiro e nao é inserido pelo utilizador
            string sql = "DELETE FROM cursos WHERE ncurso =" + ncurso;
            bd.ExecutarSQL(sql);
        }

        internal void Atualizar()
        {
            string sql = @"UPDATE cursos SET nome_curso=@nome_curso,descricao=@descricao,
                            duracaomeses=@duracaomeses,cargahoraria=@cargahoraria,nivel=@nivel
                            WHERE ncurso=@ncurso";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {


                new SqlParameter()
                {
                    ParameterName = "@nome_curso",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.nome_curso

                },
                new SqlParameter()
                {
                    ParameterName = "@descricao",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.descricao

                },
                new SqlParameter()
                {
                    ParameterName = "@duracaomeses",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.duracaomeses

                },
                new SqlParameter()
                {
                    ParameterName = "@cargahoraria",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.cargahoraria

                },
                new SqlParameter()
                {
                    ParameterName = "@nivel",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.nivel

                },

                new SqlParameter()
                {
                    ParameterName = "@ncurso",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = this.ncurso

                }

            };
            bd.ExecutarSQL(sql, parametros);
        }

        internal void Procurar()
        {
            string sql = "SELECT * FROM cursos WHERE ncurso=" + ncurso;
            DataTable temp = bd.DevolveSQL(sql);
            if (temp != null && temp.Rows.Count > 0)
            {
                DataRow linha = temp.Rows[0];
                this.nome_curso = linha["nome_curso"].ToString();
                this.descricao = linha["descricao"].ToString();
                this.duracaomeses = linha["duracaomeses"].ToString();
                this.cargahoraria = linha["cargahoraria"].ToString();
                this.nivel = linha["nivel"].ToString();
            }
        }
    }
}
