using System;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Requêtes_et_listes_à_2_dimensions__.NET_
{
    class Program
    {
        static void Main(string[] args)
        {
            List< List<Personne> > Personnes= new List< List<Personne> >
            {
                new List<Personne> ()
                {
                    new Personne ("Jack","Well"),
                    new Personne ("Eman","Nola"),
                    new Personne ("Olaand","Dubov")
                },

                new List<Personne> ()
                {
                    new Personne ("Ex_1","ap12"),
                    new Personne ("Zman","Taylor"),
                    new Personne ("James","Polo")
                },

                new List<Personne> ()
                {
                    new Personne ("Samanta","oplm"),
                    new Personne ("Lorem","Ipsum"),
                    new Personne ("Kiven","Idial")
                }
            };

            // Récuperer tous les Nom dont la longueur est Supérieur à 5 .

            var LongQuery = from p in Personnes
                            from person in p
                            where person.Nom.Length > 5
                            select person;

            foreach (var Long in LongQuery)
                WriteLine("The name is: " + Long.Nom + " Le prenom: " + Long.Prenom);

            WriteLine("-------------------------------------------------------------------------");

            // Récuperer tous les Noms qui contient un "e" . 
            // Récuperer tous les Prenoms qui contient un "a" . 
            // Trie par ordre décroissant .
            // Créer un objet anonyme qui contient un attribut Identité = Nom + Prenom .

            var Contain = from p in Personnes
                          from person in p
                          where person.Nom.Contains("e")
                          where person.Prenom.Contains("a")
                          orderby person.Nom descending
                          select new { Identité = person.Nom + person.Prenom };

            foreach (var contain in Contain)
                WriteLine("The Identité is: " + contain.Identité);
        }
    }
}
