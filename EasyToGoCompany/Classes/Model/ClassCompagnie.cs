namespace EasyToGoCompany.Classes.Model
{
    public class Compagnie : Base
    {
        public string Noms { get; set; }

        public string Description { get; set; }

        public string Adresse { get; set; }

        public string Rccm { get; set; }

        public byte[] Photo { get; set; }
    }
}
