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
        public int naluno { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string morada { get; set; }
        public bool ativo { get; set; }
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
            string sql = @"INSERT INTO Alunos ( nome, data_nascimento, email, telefone, morada, codigo_postal)
                           VALUES ( @nome, @data_nascimento, @email, @telefone, @morada, @codigo_postal)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@nome",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.nome

                },
                new SqlParameter()
                {
                    ParameterName = "@data_nascimento",
                    SqlDbType = System.Data.SqlDbType.DateTime,
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
                    ParameterName = "@codigo_postal",
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
            return bd.DevolveSQL("SELECT naluno,nome,data_nascimento,email,telefone,morada,codigo_postal, ativo FROM alunos order by nome ");
        }

        internal void Apagar()
        {
            // Isto é seguro porque o naluno é um inteiro e nao é inserido pelo utilizador
            string sql = "DELETE FROM alunos WHERE naluno =" + naluno;
            bd.ExecutarSQL(sql);
        }

        public override string ToString()
        {
            return this.nome;
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

        internal void Atualizar()
        {
            string sql = @"UPDATE alunos SET nome=@nome,data_nascimento=@data_nascimento,
                            email=@email,telefone=@telefone,morada=@morada,
                            codigo_postal=@codigo_postal WHERE naluno=@naluno";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {


                new SqlParameter()
                {
                    ParameterName = "@nome",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.nome

                },
                new SqlParameter()
                {
                    ParameterName = "@data_nascimento",
                    SqlDbType = System.Data.SqlDbType.DateTime,
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
                    ParameterName = "@codigo_postal",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.codigopostal

                },
                new SqlParameter()
                {
                    ParameterName = "@naluno",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = this.naluno

                }

            };
            bd.ExecutarSQL(sql, parametros);
        }

        internal void Procurar()
        {
            string sql = "SELECT * FROM alunos WHERE naluno=" + naluno;
            DataTable temp = bd.DevolveSQL(sql);
            if (temp != null && temp.Rows.Count > 0)
            {
                DataRow linha = temp.Rows[0];
                this.nome = linha["nome"].ToString();
                this.email = linha["email"].ToString();
                this.telefone = linha["telefone"].ToString();
                this.data_nascimento = DateTime.Parse(linha["data_nascimento"].ToString());
                this.morada = linha["morada"].ToString();
                this.codigopostal = linha["codigo_postal"].ToString();

            }
        }

    }
}
