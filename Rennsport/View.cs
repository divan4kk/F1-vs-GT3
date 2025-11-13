using System;

namespace Rennsport
{
    public class RennfahrzeugView
    {
        public void ZeigeStatus(Rennfahrzeug fahrzeug)
        {
            Console.WriteLine($"--- {fahrzeug.Marke} ---");
            Console.WriteLine($"Baujahr: {fahrzeug.Baujahr}");
            Console.WriteLine($"Leistung: {fahrzeug.Leistung} PS");
            Console.WriteLine($"Gewicht: {fahrzeug.Gewicht} kg");
            if (fahrzeug is F1Auto f1)
                Console.WriteLine($"ERS Level: {f1.ERSLevel}, DRS: {(f1.DRS_Aktiv ? "Aktiv" : "Inaktiv")}");
            else if (fahrzeug is GT3Auto gt3)
                Console.WriteLine($"ABS: {(gt3.ABS ? "Aktiv" : "Inaktiv")}, TC: {(gt3.TractionControl ? "Aktiv" : "Inaktiv")}");
            Console.WriteLine();
        }

        public string FormatZeit(double sekunden)
        {
            int min = (int)(sekunden / 60);
            int sec = (int)(sekunden % 60);
            int ms = (int)((sekunden - (min * 60 + sec)) * 1000);
            return $"{min:D2}:{sec:D2}:{ms:D3}";
        }
    }
}
