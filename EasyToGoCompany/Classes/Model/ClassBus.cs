using System;

namespace EasyToGoCompany.Classes.Model
{
    public class Bus : Base
    {
        public string RefCompagnie { get; set; }

        public string RefNumeroPos { get; set; }

        public string Numero { get; set; }

        public string Etat { get; set; }

        public string Plaque { get; set; }

        public string Marque { get; set; }

        public int Place { get; set; }

        public DateTime MiseEnCirculation { get; set; }

        public string Kilometrage { get; set; }

        public string AnneeFabrication { get; set; }
    }
}
