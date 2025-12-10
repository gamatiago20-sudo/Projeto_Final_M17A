using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace Projeto_Final_M17A
{
    /// <summary>
    /// Responsável por executar comandos SQL na base de dados
    /// </summary>
    public class BaseDados
    {
        string strligacao;
        string NomeBD;
        string CaminhoBD;
        SqlConnection ligacaoSQL;
        //construtor
        // Estabelece a ligação à BD, caso não exista cria a BD
        public BaseDados(string NomeBD)
        {
            this.NomeBD = NomeBD;
            //Ler a string ligação
            strligacao = ConfigurationManager.ConnectionStrings["sql"].ToString();
            //Verificar a pasta do projeto
            CaminhoBD = uteis.PastaPrograma("Projeto_Final_M17A");
            CaminhoBD += @"\" + NomeBD + ".mdf";
            //Verificar se a bd existe
            if (System.IO.File.Exists(CaminhoBD) == false)
            {
                //Se não existir
                //criar a bd
                CriarBD();
            }
            //Ligação à bd
            ligacaoSQL = new SqlConnection(strligacao);
            ligacaoSQL.Open();
            ligacaoSQL.ChangeDatabase(this.NomeBD);
        }
        //destrutor
        ~BaseDados()
        {
            //fechar a ligação à bd
        }
        void CriarBD()
        {
            //ligação ao servidor
            ligacaoSQL = new SqlConnection(strligacao);
            ligacaoSQL.Open();

            //Verificar se a bd ja existe no catalogo
            string sql = $@"
                        IF  EXISTS(select* from master.sys.databases where name='{this.NomeBD}')
                            BEGIN
                                    USE [master];
                                    EXEC sp_detach_db {this.NomeBD};
                             END
                        ";
            SqlCommand comando = new SqlCommand(sql, ligacaoSQL);
            comando.ExecuteNonQuery();
            //criar bd
            sql = $"create database {this.NomeBD}  on  primary (name={this.NomeBD} , filename='{this.CaminhoBD}')";
            comando = new SqlCommand(sql, ligacaoSQL);
            comando.ExecuteNonQuery();
            //associa a ligacao a bd criada
            ligacaoSQL.ChangeDatabase(this.NomeBD);
            //criar tabelas
            //criar tabela livros
            sql = @"create table alunos (
            naluno INT IDENTITY(1,1) PRIMARY KEY,
            nome varchar(100) not null ,
            data_nascimento DateTime CHECK (DATEDIFF (year,data_nascimento,GETDATE())>0),
            email varchar(100) CHECK (email LIKE '%@%.%') ,
            telefone varchar(15), 
            morada varchar(200),
            codigo_postal varchar(10) CHECK (codigo_postal LIKE '[1-9][0-9][0-9][0-9]-[0-9][0-9][0-9]'), 
            ativo BIT DEFAULT 1,
            );
            CREATE TABLE Cursos(
            ncurso INT IDENTITY(1,1) PRIMARY KEY,
            nome_curso VARCHAR(100) NOT NULL,
            descricao TEXT,
            duracaomeses INT CHECK (duracaomeses > 0 AND duracaomeses <= 36),
            cargahoraria INT CHECK (cargahoraria > 0 AND cargahoraria <= 3700),
            nivel VARCHAR(13)  CHECK (nivel IN ('Básico', 'Intermediário', 'Avançado')), -- Básico, Intermediário, Avançado
            ativo BIT DEFAULT 1,

            );
            CREATE TABLE Matriculas(
            id_matricula INT IDENTITY(1,1) PRIMARY KEY,
            naluno INT NOT NULL,
            ncurso INT NOT NULL,
            ativo BIT DEFAULT 1,
            data_matricula DATE DEFAULT GETDATE(),
            data_inicio DATE,
            data_termino DATE ,
            estado BIT DEFAULT 1, -- Ex: sim ou nao
            FOREIGN KEY (naluno) REFERENCES Alunos(naluno) ON DELETE CASCADE,
            FOREIGN KEY (ncurso) REFERENCES Cursos(ncurso) ON DELETE CASCADE,

            constraint valida_data_inicio check (data_inicio >= data_matricula),
            constraint valida_data_termino check (data_termino > data_inicio),
            )";
            comando = new SqlCommand(sql, ligacaoSQL);
            comando.ExecuteNonQuery();
            comando.Dispose();

        }

        //função para executar comando sql (insert/delete/update/create/alter...)
        public void ExecutarSQL(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = new SqlCommand(sql, ligacaoSQL);
            if (parametros != null)
                comando.Parameters.AddRange(parametros.ToArray());
            comando.ExecuteNonQuery();
            comando.Dispose();
        }
        //Função para executar um select e devolver os registos da bd
        public DataTable DevolveSQL(string sql, List<SqlParameter> parametos = null)
        {
            DataTable dados = new DataTable();
            SqlCommand comando = new SqlCommand(sql, ligacaoSQL);
            if (parametos != null)
                comando.Parameters.AddRange(parametos.ToArray());
            SqlDataReader registos = comando.ExecuteReader();
            dados.Load(registos);
            registos.Close();
            comando.Dispose();
            return dados;
        }

        internal void executarComando(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
