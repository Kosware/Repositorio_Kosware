using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor.ModeloDominio
{
    class Agenda
    {
        DateTime DataAtual = DateTime.Now;
        DateTime UltimaVisita;
        DateTime ProximaVisita;
      
        public void CadastraVisita()
        {
            UltimaVisita = DateTime.Now;
            AgendarProximaVisita();
        }
        public void AgendarProximaVisita()
        {
            ProximaVisita = UltimaVisita.AddDays(30);
        }
        public string Notificador()
        {
           string notificacao = " "; 
           if  (DataAtual == ProximaVisita)
           {
                notificacao = "Próxima Visita: Hoje";
           }
           else if (DataAtual != ProximaVisita)
           {
               notificacao = "Não há visitas marcadas para hoje";
           }
           return notificacao;
        }  
    }
}

    

