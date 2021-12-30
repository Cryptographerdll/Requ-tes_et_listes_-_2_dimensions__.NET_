using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requêtes_et_listes_à_2_dimensions__.NET_
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;
        private char sexe;
        private bool est_ingénieur;

        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public Personne(string nom, string prenom, int age, char sexe, bool est_ingénieur) : this(nom, prenom)
        {
            this.age = age;
            this.sexe = sexe;
            this.est_ingénieur = est_ingénieur;
        }

        #region Getters & Setters

        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }

            set
            {
                this.prenom = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public char Sexe
        {
            get
            {
                return this.sexe;
            }

            set
            {
                this.sexe = value;
            }
        }

        public bool Est_Ingénieur
        {
            get
            {
                return this.est_ingénieur;
            }

            set
            {
                this.est_ingénieur = value;
            }
        }

        #endregion Getters & Setters 
    }
}
