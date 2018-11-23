using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCitationDb
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //context 
            dbContext _dbContext_Citation = new dbContext("C:/_dev/fleurdesel/FleurDeSel/CreateCitationDb/db/citations.db");
            string[] lines = File.ReadAllLines(@"C:\_dev\fleurdesel\FleurDeSel\CreateCitationDb\db\manger.txt", Encoding.UTF8);

            string ok_citation = "";
            string ok_autheur = "";
            string ok_source = "";
            string auteur = "";
            string citation = "";
            string pp = "";
            string sp = "";
            string src= "";

            List<Citation> Citations = new List<Citation>();

            for (int i = 0; i < lines.Length-1; i = i + 2)
            {
                citation = lines[i];
                string start = citation.Substring(0, 1);
                string end = citation.Substring(citation.Length-1,1);
                if(start == "“" && end == "”")
                {
                    citation = citation.Substring(1, citation.Length - 2);
                    ok_citation = citation;
                }
                auteur = lines[i + 1];
                if (auteur.Contains("De"))
                {
                    int index = auteur.IndexOf("De");
                    pp = auteur.Substring(0, index);
                    ok_autheur = pp.Trim();
                    sp = auteur.Substring(index + 2, auteur.Length - index - 2);
                    if (sp.Contains("/"))
                    {
                        src = sp.Split('/')[1];
                        ok_source = src.Trim();
                    }
                    else
                    {
                        ok_source = "";
                    }
                }

                Citation _curent = new Citation(ok_autheur, ok_citation, ok_source, "manger");
                Console.Clear();
                Console.WriteLine(ok_citation);
                Console.WriteLine("   - " + ok_autheur);
                Console.WriteLine("   - " + ok_source);
                //Console.ReadKey();
                Citations.Add(_curent);
            }

            //save citations database
            _dbContext_Citation.Upsert<Citation>(Citations);

        }
    }
}
