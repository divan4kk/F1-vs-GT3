using System;

namespace Rennsport
{
    class Rennfahrzeug
    {
        public string Marke { get; set; }
        public int Baujahr { get; set; }
        public int Leistung { get; set; }
        public int Gewicht { get; set; }
        public bool MotorAn { get; private set; }

        public Rennfahrzeug(string marke, int baujahr, int leistung, int gewicht)
        {
            Marke = marke;
            Baujahr = baujahr;
            Leistung = leistung;
            Gewicht = gewicht;
            MotorAn = false;
        }

        public void StarteMotor() => MotorAn = true;
        public void StoppeMotor() => MotorAn = false;
    }

    class F1Auto : Rennfahrzeug
    {
        public int ERSLeistung { get; set; }
        public bool DRS_Aktiv { get; private set; }

        public F1Auto(string marke, int baujahr, int leistung, int gewicht, int ersLeistung)
            : base(marke, baujahr, leistung, gewicht)
        {
            ERSLeistung = ersLeistung;
            DRS_Aktiv = false;
        }

        public void AktiviereDRS() => DRS_Aktiv = true;
        public void DeaktiviereDRS() => DRS_Aktiv = false;
    }

    class GT3Auto : Rennfahrzeug
    {
        public bool ABS { get; set; }
        public bool TractionControl { get; set; }

        public GT3Auto(string marke, int baujahr, int leistung, int gewicht, bool abs, bool tractionControl)
            : base(marke, baujahr, leistung, gewicht)
        {
            ABS = abs;
            TractionControl = tractionControl;
        }

        public void AktiviereABS() => ABS = true;
        public void DeaktiviereABS() => ABS = false;
    }
}