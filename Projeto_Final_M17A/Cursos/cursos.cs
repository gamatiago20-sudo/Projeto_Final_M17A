using Microsoft.Data.SqlClient;
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
        public string nomecurso { get; set; }
        public string descrição { get; set; }
        public string nivel { get; set; }
        public string duracaomeses { get; set; }
        public string cargahoraria { get; set; }
        public string codigopostal { get; set; }
        BaseDados bd;

        public cursos(BaseDados bd)
        {
            this.bd = bd;
        }

        internal void Adicionar()
        {
            string sql = @"INSERT INTO cursos (ncurso, nomecurso, descrição, nivel, duracaomeses, cargahoraria)
                           VALUES (@ncuro, @nomecurso, @descrição, @nivel, @duracaomeses, @cargahoraria)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@ncurso",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.ncurso

                },
                new SqlParameter()
                {
                    ParameterName = "@nomecurso",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.nomecurso

                },
                new SqlParameter()
                {
                    ParameterName = "@descrição",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.descrição

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
            if (string.IsNullOrEmpty(nomecurso) || nomecurso.Length < 3)
            {
                erros.Add("O nome do curso deve ter pelo menos 3 letras");
            }
            return erros;
        }

        internal object Procurar(string campo2, string texto_pesquisar2)
        {
            string sql = "SELECT ncurso, nomecurso, descricao, nivel FROM cursos";
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

        internal object Listar()
        {
            return bd.DevolveSQL("SELECT ncurso,nomecurso,descricao,nivel FROM cursos order by nomecurso ");
        }

        internal void Apagar()
        {
            // Isto é seguro porque o naluno é um inteiro e nao é inserido pelo utilizador
            string sql = "DELETE FROM cursos WHERE ncurso = @ncurso";
            bd.ExecutarSQL(sql);
        }
    }
}
