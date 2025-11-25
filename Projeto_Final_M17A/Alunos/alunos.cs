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
        public string idaluno {  get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string morada { get; set; }
        public string telefone { get; set; }
        public DateTime data_nascimento { get; set; }
        public string codigopostal { get; set; }
        private BaseDados bd;

        public alunos(BaseDados bd)
        {
            this.bd = bd;
        }

        internal void Adicionar()
        {
            string sql = @"INSERT INTO Alunos (idaluno, nome, data_nascinento, email, telefone, morada, codigopostal)
                           VALUES (@idaluno, @nome, @data_nascimento, @email, @telefone, @morada, @codigopostal)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@idaluno",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.idaluno

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
        }

        internal List<string> Validar()
        {
            List<string> erros = new List<string>();
            //validar o nome
            if (string.IsNullOrEmpty(nome) || nome.Length < 3)
            {
                erros.Add("O título do livro deve ter pelo menos 3 letras");
            }
            return erros;
        }

        public DataTable Listar()
        {
            return bd.DevolveSQL("SELECT idaluno,nome,email,telefone FROM alunos order by nome ");
        }
    }
}
