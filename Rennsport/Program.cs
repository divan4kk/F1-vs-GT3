using System;
using Rennsport;

namespace RennsportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            F1Auto redBull = new F1Auto("Red Bull Racing RB20", 2024, 1050, 798, 160);
            GT3Auto ferrariGT3 = new GT3Auto("Ferrari 296 GT3", 2023, 600, 1250, true, true);

            RennfahrzeugView view = new RennfahrzeugView();

            redBull.AktiviereDRS();
            ferrariGT3.SetFahrhilfen(true, true);

            Console.WriteLine("=== Qualifikation – Monza (1 Runde) ===\n");

            double[] sektorF1 = { 26.26, 26.48, 26.05 };
            double[] sektorGT3 = { 32.5, 35.2, 37.222 };

            double gesamtF1 = 0, gesamtGT3 = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{redBull.Marke} Sektor {i + 1}: {view.FormatZeit(sektorF1[i])}");
                gesamtF1 += sektorF1[i];

                Console.WriteLine($"{ferrariGT3.Marke} Sektor {i + 1}: {view.FormatZeit(sektorGT3[i])}");
                gesamtGT3 += sektorGT3[i];

                System.Threading.Thread.Sleep(500);
            }

            Console.WriteLine("\n=== Endergebnisse ===");
            view.ZeigeStatus(redBull);
            view.ZeigeStatus(ferrariGT3);

            Console.WriteLine($"{redBull.Marke}: Gesamtzeit {view.FormatZeit(gesamtF1)}");
            Console.WriteLine($"{ferrariGT3.Marke}: Gesamtzeit {view.FormatZeit(gesamtGT3)}");
        }
    }
}
