using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projeto_Final_M17A.Alunos
{
    internal class alunos
    {
        public int naluno {  get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string morada { get; set; }
        public string telefone { get; set; }
        public DateTime data_nascimento { get; set; }
        public string codigopostal { get; set; }
        BaseDados bd;

        public alunos(BaseDados bd)
        {
            this.bd = bd;
        }

        internal void Adicionar()
        {
            string sql = @"INSERT INTO Alunos (naluno, nome, data_nascinento, email, telefone, morada, codigopostal)
                           VALUES (@naluno, @nome, @data_nascimento, @email, @telefone, @morada, @codigopostal)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@naluno",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.naluno

                },
                new SqlParameter()
                {
                    ParameterName = "@nome",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.nome

                },
                new SqlParameter()
                {
                    ParameterName = "@data_nascimento",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.data_nascimento

                },
                new SqlParameter()
                {
                    ParameterName = "@email",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.email

                },
                new SqlParameter()
                {
                    ParameterName = "@telefone",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.telefone

                },
                new SqlParameter()
                {
                    ParameterName = "@morada",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.morada

                },
                new SqlParameter()
                {
                    ParameterName = "@codigopostal",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.codigopostal

                },

                
            };
            bd.ExecutarSQL(sql, parametros);
        }

        internal List<string> Validar()
        {
            List<string> erros = new List<string>();
            //validar o nome
            if (string.IsNullOrEmpty(nome) || nome.Length < 3)
            {
                erros.Add("O nome do aluno deve ter pelo menos 3 letras");
            }
            return erros;
        }

        public DataTable Listar()
        {
            return bd.DevolveSQL("SELECT naluno,nome,email,telefone FROM alunos order by nome ");
        }

        internal void Apagar()
        {
            // Isto é seguro porque o naluno é um inteiro e nao é inserido pelo utilizador
            string sql = "DELETE FROM alunos WHERE naluno = @naluno";
            bd.ExecutarSQL(sql);
        }

        internal DataTable Procurar(string campo, string texto_pesquisar)
        {
            string sql = "SELECT naluno, nome, email, telefone FROM alunos";
            sql += " WHERE " + campo + " LIKE @pesquisa ";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@pesquisa",
                    SqlDbType = SqlDbType.VarChar,
                    Value = "%" + texto_pesquisar + "%"
                }
            };
            return bd.DevolveSQL(sql, parametros);
        }
    }
}
