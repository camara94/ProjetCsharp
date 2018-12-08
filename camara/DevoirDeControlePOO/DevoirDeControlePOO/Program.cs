﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirDeControlePOO
{
    public class Program
    {
        public static void Main()
        {
          Agenda agenda = new Agenda("agenda 1",2018,"Camara");
          Evenement ev1 = new Evenement("Randone à Mednine",DateTime.Parse("30/11/2018"),DateTime.Parse("30/11/2018"), "Visite des sites historique de Médnine");
          Evenement ev2 = new Evenement("Voyage de Tozer", DateTime.Parse("20/05/2019"), DateTime.Parse("30/05/2019"), "Visite des sites historique de Tozer");
          Evenement ev3 = new Evenement("Voyage de Tunis", DateTime.Parse("31/08/2019"), DateTime.Parse("05/09/2019"), "Visite des sites historique de Tunis");
          agenda.AjouterEvent(ev1);
          agenda.AjouterEvent(ev2);
          agenda.AjouterEvent(ev3);
          Console.WriteLine("Le nombre d'évènement :" + agenda.NbEvent());
          agenda.AfficherAgenda();
          if(agenda.SupprimerEvent("Randone à Mednine")==0)
          {
              Console.WriteLine("Vous avez supprimer l'évènement");
          }
          else
          {
              Console.WriteLine("Aucun évènement correspondant à cet titre d'évènement");
          }

          Console.WriteLine("Les évènement dont les dates correspondent aux :\n mois :{0} et jour :{1}", ev3.DATEDEDEBUT.Month, ev2.DATEDEDEBUT.Day);
          agenda.EventJour(ev2.DATEDEDEBUT.Day);
          agenda.EventMois(ev3.DATEDEDEBUT.Day);

          Evenement ev1Copie = new Evenement(ev1);
          ev1Copie.TITRE = "J'aime Djerba";
        }
    }
}
