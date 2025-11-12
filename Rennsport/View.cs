using System;

namespace Rennsport
{
    class RennfahrzeugView
    {
        public void ZeigeStatus(Rennfahrzeug fahrzeug)
        {
            Console.WriteLine($"--- {fahrzeug.Marke} ---");
            Console.WriteLine($"Baujahr: {fahrzeug.Baujahr}");
            Console.WriteLine($"Leistung: {fahrzeug.Leistung} PS");
            Console.WriteLine($"Gewicht: {fahrzeug.Gewicht} kg");
            Console.WriteLine($"Motor: {(fahrzeug.MotorAn ? "An" : "Aus")}");

            if (fahrzeug is F1Auto f1)
                Console.WriteLine($"ERS Leistung: {f1.ERSLeistung} PS, DRS: {(f1.DRS_Aktiv ? "Aktiv" : "Inaktiv")}");
            else if (fahrzeug is GT3Auto gt3)
                Console.WriteLine($"ABS: {(gt3.ABS ? "Aktiv" : "Inaktiv")}, TractionControl: {(gt3.TractionControl ? "Aktiv" : "Inaktiv")}");

            Console.WriteLine();
        }
    }
}