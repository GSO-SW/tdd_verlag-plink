using System.Diagnostics.CodeAnalysis;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

        public string Autor
        {
            set
            {
                autor = value;
            }
            get
            {
                return autor;
            }
        }

            public string Titel
        {
            get
            {
                return titel;
            }
        }

        public int Auflage
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Auflage darf nicht kleiner als 1 sein.");
                }
                else
                {
                    this.auflage= value;
                }
            }
            get
            {
                return auflage;
            }
        }

        public Buch(string autor, string titel, int auflage)
        {
            this.autor = autor;
            this.titel = titel;
            Auflage = auflage;
        }
    }
}
