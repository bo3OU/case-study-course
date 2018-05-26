using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Client
    {
        private string Nom;
        private string Prenom;
        private int Id;

        public void setNom(string nom) {
            Nom = nom;
        }
        public void setPrenom(string prenom)
        {
            Prenom = prenom;
        }
        public string getNom()
        {
            return Nom;
        }
        public string getPrenom()
        {
            return Prenom;
        }
        public int returnId()
        {
            return Id;
        }
        public Client(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

    }
}
