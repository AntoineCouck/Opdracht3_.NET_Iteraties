namespace Oef1
{
    internal class Persoon
    {
        private string Naam { get; set; }
        private int Leeftijd { get; set; }

        public Persoon(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }
        public override string ToString()
        {
            return "ik noem " + Naam + " en ik ben " + Leeftijd;
        }

        
       
    }
}
