using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryJeuDeRole;
using System.Runtime;


namespace LibraryJeuDeRole
{
    public class Arme
    {
        #region//-- attributs privés --
        private string nom;
        private int degats;
        #endregion

        #region//-- attributs public --
        public string Nom { get => nom; set => nom = value; }
        public int Degats { get => degats; set => degats = value; }
        #endregion

        #region// -- Constructeur --
        public Arme(string nom)
        {
            this.nom = nom;
            this.degats = 20;
        }
        #endregion




    }
}
