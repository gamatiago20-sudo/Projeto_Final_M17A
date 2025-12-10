using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_M17A.Matriculas
{
    internal class matriculas
    {
        public int id_matricula { get; set; }
        public int naluno { get; set; }
        public int ncurso { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_termino { get; set; }
        public bool estado { get; set; }

        BaseDados bd;
        public matriculas(BaseDados bd)
        {
            this.bd = bd;
        }

        public void RegistarMatricula()
        {
            // inserir na tabela Matriculas
            string SQL = "INSERT INTO Matriculas(naluno,ncurso,data_inicio,data_termino,estado) VALUES (@naluno,@ncurso,@data_inicio,@data_termino,@estado)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@naluno",
                    SqlDbType = SqlDbType.Int,
                    Value = this.naluno,
                },
                new SqlParameter()
                {
                    ParameterName = "@ncurso",
                    SqlDbType = SqlDbType.Int,
                    Value = this.ncurso,
                },
                new SqlParameter()
                {
                    ParameterName = "@data_inicio",
                    SqlDbType = SqlDbType.Date,
                    Value = this.data_inicio,
                },
                new SqlParameter()
                {
                    ParameterName = "@data_termino",
                    SqlDbType = SqlDbType.Date,
                    Value = this.data_termino,
                },
                new SqlParameter()
                {
                    ParameterName = "@estado",
                    SqlDbType = SqlDbType.Bit,
                    Value = this.estado,
                }
            };
            bd.ExecutarSQL(SQL, parametros);

            // atualizar tabela alunos (o aluno deixa de estar disponível para nova matrícula)
            SQL = "UPDATE alunos SET ativo = 0 WHERE naluno=@naluno";
            parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@naluno",
                    SqlDbType = SqlDbType.Int,
                    Value = this.naluno,
                }
            };
            bd.ExecutarSQL(SQL, parametros);
        }

        public void RegistarDevolucao()
        {
            // terminar a matrícula
            string SQL = "UPDATE Matriculas SET ativo = 0, data_termino=@data_termino, estado=0 WHERE id_matricula=@id_matricula";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@id_matricula",
                    SqlDbType = SqlDbType.Int,
                    Value = this.id_matricula,
                },
                new SqlParameter()
                {
                    ParameterName = "@data_termino",
                    SqlDbType = SqlDbType.Date,
                    Value = this.data_termino,
                }
            };
            bd.ExecutarSQL(SQL, parametros);

            // voltar a marcar o aluno como ativo
            SQL = "UPDATE alunos SET ativo = 1 WHERE naluno=@naluno";
            parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@naluno",
                    SqlDbType = SqlDbType.Int,
                    Value = this.naluno,
                }
            };
            bd.ExecutarSQL(SQL, parametros);
        }

        internal void Procurar()
        {
            string sql = "SELECT * FROM Matriculas WHERE id_matricula=" + id_matricula;
            DataTable temp = bd.DevolveSQL(sql);
            if (temp != null && temp.Rows.Count > 0)
            {
                DataRow linha = temp.Rows[0];
                this.naluno = int.Parse(linha["naluno"].ToString());
                this.ncurso = int.Parse(linha["ncurso"].ToString());

                if (linha["data_inicio"] != DBNull.Value)
                    this.data_inicio = Convert.ToDateTime(linha["data_inicio"]);
                else
                    this.data_inicio = DateTime.MinValue;

                if (linha["data_termino"] != DBNull.Value)
                    this.data_termino = Convert.ToDateTime(linha["data_termino"]);
                else
                    this.data_termino = DateTime.MinValue;

                if (linha.Table.Columns.Contains("estado") && linha["estado"] != DBNull.Value)
                    this.estado = Convert.ToBoolean(linha["estado"]);
            }
        }

        public DataTable Listar()
        {
            string sql = @"
                SELECT id_matricula,
                       alunos.nome AS Aluno,
                       cursos.nome_curso  AS Curso,
                       matriculas.data_matricula,
                       matriculas.data_inicio,
                       matriculas.data_termino,
                       matriculas.estado
                FROM Matriculas 
                INNER JOIN Alunos  alunos ON matriculas.naluno = alunos.naluno
                INNER JOIN Cursos  cursos ON matriculas.ncurso = cursos.ncurso
                WHERE matriculas.ativo = 1
                ORDER BY matriculas.data_matricula DESC";
            return bd.DevolveSQL(sql);
        }

        public DataTable ContarMatriculasPorCurso()
        {
            string sql = @"
                SELECT cursos.nome_curso AS Curso,
                       COUNT(*)     AS TotalMatriculas
                FROM Matriculas 
                INNER JOIN Cursos cursos ON matriculas.ncurso = cursos.ncurso
                WHERE matriculas.ativo = 1
                GROUP BY cursos.nome_curso
                ORDER BY TotalMatriculas DESC";
            return bd.DevolveSQL(sql);
        }

        internal void Apagar()
        {
            // Isto é seguro porque o id_matricula é um inteiro e nao é inserido pelo utilizador
            string sql = "DELETE FROM Matriculas WHERE id_matricula =" + id_matricula;
            bd.ExecutarSQL(sql);
        }
    }
}
