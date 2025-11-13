using System;
using Rennsport;

namespace RennsportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //F1 Beschreibung
            F1Auto redBull = new F1Auto(
                "Red Bull Racing RB20",
                2024,
                1050,
                798,
                160
            );

            //GT3 Beschreibung
            GT3Auto ferrariGT3 = new GT3Auto(
                "Ferrari 296 GT3",
                2023,
                600,
                1250,
                true,
                true
            );

            RennfahrzeugView view = new RennfahrzeugView();

            redBull.StarteMotor();
            redBull.AktiviereDRS();

            ferrariGT3.StarteMotor();
            ferrariGT3.AktiviereABS();

            view.ZeigeStatus(redBull);
            view.ZeigeStatus(ferrariGT3);
        }
    }
}