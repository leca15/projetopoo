using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servico;

namespace Apresentacao
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBaseCreate.CreateDataBase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaInicial());
            //Application.Run(new FormCadCli());
            //Application.Run(new FormCadMedi());
            //Application.Run(new PesquisaCli());
            //Application.Run(new CadAnimalComCPF());
            //Application.Run(new PesquisaAnimal());
            //Application.Run(new AtdAvulso());
            //Application.Run(new ConsultaMarcar());
            //Application.Run(new ConsultasMarcadas());
            //Application.Run(new PesqArdCons());


        }
    }
}
