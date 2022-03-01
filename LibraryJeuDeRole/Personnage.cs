using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryJeuDeRole;
using System.Runtime;


namespace LibraryJeuDeRole
{
    public class Personnage
    {
        #region//--attributs privés --
        private string nom;
        private int pointsDeVie;
        private int positionX, positionY;//position
        private Arme arme;
        #endregion

        #region //--Attributs publiques
        public string Nom { get => nom; set => nom = value; }
        public Arme Arme {get=> arme;set =>arme= value; }

        public int PointsDeVie { get => pointsDeVie; }
        public int PositionX { get => positionX; }
        public int PositionY { get => positionY; }
        #endregion

        #region// -- CONSTRUCTEUR --
            /// <summary>
            /// Constructeur de la classe "Personnage"
            /// </summary>
            /// <param name="p_nom"></param>
            /// <param name="p_arme"></param>
            public Personnage(string p_nom,Arme p_arme)
            { //valeurs par defaut
                this.positionX = 0;
                this.positionY = 0;
                this.pointsDeVie = 100;
                //argument
                this.nom = p_nom;
                this.arme = p_arme;
            }
            #endregion

        #region// -- METHODES --

        public void AttaquerUnAdversaire(Personnage victime, int des) 
        {
            victime.RecevoirDesDegats(des * 10);
            Console.WriteLine(victime + " a perdu " + des * 10 + " points de vie");
        }

        public bool EnVie() 
        {
            return (pointsDeVie > 0);
        }

        public void RecevoirDesDegats(int nombre)
        {
            pointsDeVie = pointsDeVie - nombre;
        }

        public void SeDeplacer() { }

        public void SePresenter() 
        {
            Console.WriteLine("Je m'appelle" + nom + " j'ai une arme du nom de " + arme);
        }
        #endregion
    }
}
