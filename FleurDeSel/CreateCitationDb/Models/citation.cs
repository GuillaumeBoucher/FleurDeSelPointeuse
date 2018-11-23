using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCitationDb
{
    public class Citation
    {
        public int Id { get; set; }
        public string Auteur { get; set; }
        public string Texte { get; set; }
        public string Source { get; set; }
        public string Theme { get; set; }

        public Citation(string A, string C, string S, string T)
        {
            this.Auteur = A;
            this.Texte = C;
            this.Source = S;
            this.Theme = T;
        }
    }
}
