using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        private string isbn;

        public Buch(string autor, string titel) 
        {
            Autor = autor;
            this.titel = titel;
            this.auflage = 1;
        }

        public Buch(string autor, string titel,int auflage) : this(autor,titel)
        {
            this.Auflage = auflage;
        }

        public string ISBN
        {
            set
            {
                isbn = value;
            }
            get { return isbn; }
        }

        public string Autor
        {
            get { return autor; }

            set 
            {
                List<char> unerlaubtezeichen = new List<char>();
                unerlaubtezeichen.Add('#');
                unerlaubtezeichen.Add(';');
                unerlaubtezeichen.Add('§');
                unerlaubtezeichen.Add('%');

                foreach(char c in unerlaubtezeichen)
                {
                    if (value.Contains(c))
                    {
                        throw new ArgumentException();
                    }
                    else if(value == null)
                    {
                        throw new ArgumentNullException();
                    }
                }
                autor = value;
            }
        }

        public string Titel
        {
            get { return titel; }
        }

        public int Auflage
        {
            get { return auflage; }
            set 
            {
                if (value > 0)
                {
                    
                    auflage = value;
                }
                else throw new ArgumentOutOfRangeException();

            }
        }
    }
}