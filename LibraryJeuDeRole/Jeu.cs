using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryJeuDeRole;
using System.Runtime;


namespace LibraryJeuDeRole
{
    public class Jeu
    {
        #region//attributs privés
        private Personnage joueur1;
        private Personnage joueur2;
        #endregion

        #region//attributs public
        public Personnage Joueur1 { get => joueur1; }
        public Personnage Joueur2 { get => joueur2; }
        #endregion

        #region//constructeur
        public Jeu(Personnage p_joueur1, Personnage p_joueur2)
        { 
            this.joueur1 = p_joueur1;
            this.joueur2 = p_joueur2;
        }
        #endregion

        #region//méthodes
        public bool FinDePartie() 
        {
            return (!joueur1.EnVie() || !joueur2.EnVie());
        }

        public void LancerLeJeu() 
        {
            Console.WriteLine("Que la partie commence !");

            int de_joueur1 = LancerLeDe();
            joueur1.SePresenter();
            int de_joueur2 = LancerLeDe();
            joueur2.SePresenter();

            int i = 0;
          
            if (de_joueur1 > de_joueur2)
            {
                i = 1;
            }
       
            while (!FinDePartie())
            {
                //Tour du joueur 1
                if (i == 0)
                {
                    Console.WriteLine("--------------- C'est au tour de " + joueur1.Nom + " appuyez sur une touche");
                    Console.ReadKey();
                    joueur1.AttaquerUnAdversaire(Joueur2, LancerLeDe());
                }

                //Tour du joueur 2
                else
                {
                    Console.WriteLine("--------------- C'est au tour de " + joueur2.Nom + " appuyez sur une touche");
                    Console.ReadKey();
                    joueur2.AttaquerUnAdversaire(Joueur1, LancerLeDe());
                }
            }
            //Annonce de la fin de la partie
            Console.WriteLine("Fin de partie");
            Console.ReadKey();
        }

        public int LancerLeDe()
        {
            Random rd = new Random();
            Thread.Sleep(300);
            return rd.Next(1, 7);
        }
        #endregion

        
    }
}
