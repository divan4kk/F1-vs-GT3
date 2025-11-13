namespace Rennsport
{
    public class Rennfahrzeug
    {
        public string Marke { get; set; }
        public int Baujahr { get; set; }
        public int Leistung { get; set; }
        public int Gewicht { get; set; }

        public Rennfahrzeug(string marke, int baujahr, int leistung, int gewicht)
        {
            Marke = marke;
            Baujahr = baujahr;
            Leistung = leistung;
            Gewicht = gewicht;
        }
    }

    public class F1Auto : Rennfahrzeug
    {
        public int ERSLeistung { get; set; }
        public bool DRS_Aktiv { get; private set; }
        public int ERSLevel { get; private set; } = 100;

        public F1Auto(string marke, int baujahr, int leistung, int gewicht, int ersLeistung)
            : base(marke, baujahr, leistung, gewicht)
        {
            ERSLeistung = ersLeistung;
        }

        public void AktiviereDRS() => DRS_Aktiv = true;
        public void DeaktiviereDRS() => DRS_Aktiv = false;

        public void NutzeERS(int wert)
        {
            if (ERSLevel >= wert)
                ERSLevel -= wert;
        }
    }

    public class GT3Auto : Rennfahrzeug
    {
        public bool ABS { get; private set; }
        public bool TractionControl { get; private set; }

        public GT3Auto(string marke, int baujahr, int leistung, int gewicht, bool abs, bool tractionControl)
            : base(marke, baujahr, leistung, gewicht)
        {
            ABS = abs;
            TractionControl = tractionControl;
        }

        public void SetFahrhilfen(bool abs, bool tc)
        {
            ABS = abs;
            TractionControl = tc;
        }
    }
}
