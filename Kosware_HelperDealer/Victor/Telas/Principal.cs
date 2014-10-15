using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Victor.ModeloDominio;

namespace Victor.Telas
{
    class Principal
    {
        public static void Main()
        {
            Agenda agenda = new Agenda();
            string notifica = agenda.Notificador();

            Console.WriteLine(" -- {0}", notifica);

        }
 
    }
}
