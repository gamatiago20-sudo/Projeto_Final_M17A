using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_M17A
{
    /// <summary>
    /// Funcoes static para ler imagens, criar ficheiros de imagens
    /// e saber a pasta do programa
    /// </summary>
    internal class uteis
    {
        /// <summary>
        /// Verifica se a pasta existe e se necessario cria a pasta
        /// </summary>
        /// <param name='nome'> nome da pasta </param>
        /// <returns> devolve o caminho completos</returns>
        public static string PastaPrograma(String nome)
        {
            // caminho completo para a pasta appdata\local
            string pastainicial = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pastainicial += @"\" + nome;
            if (System.IO.Directory.Exists(pastainicial) == false)
                System.IO.Directory.CreateDirectory(pastainicial);
            return pastainicial;
        }
        //Todo: funcoes para imagens 
    }
}