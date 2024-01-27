using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks; 
using System.Web;
using System.Xml.Serialization;

namespace _2.ora_switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SwitchCase();
            //Feladat1();
            //Feladat2();
            //Feladat3();
            //Feladat4();
            //Feladat5();
            //Feladat6();
            //Feladat7();
            //Feladat8();
            Console.ReadLine();
        }
        public static void SwitchCase()
        {
            Console.WriteLine("Kérlek válasz egy opciót");
            Console.WriteLine("(1) köszönj a felhasználónak");
            Console.WriteLine("(2) írj egy viccet");
            Console.WriteLine("(3) megjelenítjök az aktuális időt");
            Console.WriteLine("(4) kilépés");
            char valasztas = Console.ReadKey().KeyChar; //el tárolunk egy karaktert
            switch (valasztas)
            {
                case '1':
                    Console.WriteLine();
                    Console.WriteLine("Üdv az alakalmazásban");
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine("vicc");
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine(DateTime.Now);
                    break;
                case '4':
                    Console.WriteLine();
                    Environment.Exit(0); //kilépés 
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Próbáld meg mégegyszer");
                    break;
            }
        }
        public static void Feladat1()
        {
            Console.Write("Kérem adja meg az első számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a második számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Válasz egy opciót hogy melyik műveletet hajtsa végre");
            Console.WriteLine("(1) Összeadás ");
            Console.WriteLine("(2) kivonás ");
            Console.WriteLine("(3) osztás ");
            Console.WriteLine("(4) szorzás ");
            char valasz = Console.ReadKey().KeyChar;
            switch (valasz)
            {
                case '1':
                    Console.WriteLine();
                    Console.WriteLine($"{szam1} és {szam2} ennyi az összeadás: {szam1 + szam2}");
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine($"{szam1} és {szam2} ennyi az kivonásuk: {szam1 - szam2}");
                    break;
                case '3':
                    Console.WriteLine();
                    if (szam2 == 0 || szam1 == 0)
                    {
                        Console.WriteLine("Nem lehet nulla az érték mert nullával nem lehet osztani");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{szam1} és {szam2} ennyi az osztásuk: {szam1 / szam2}");
                    }
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine($"{szam1} és {szam2} ennyi a szorzatuk: {szam1 * szam2}");
                    break;
            }
        }
        public static void Feladat2()
        {


        }
        public static void Feladat3()
        {
            Console.WriteLine("Adja a meg a hétnapjaiból egyet (angolul): ");
            string valasz1 = Console.ReadLine();
            switch (valasz1)
            {
                case "monday": // hétfő  fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char hetfo = Console.ReadKey().KeyChar;
                    switch (hetfo) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: montag");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: lunes");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: lundi");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                case "tuesday": // kedd fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char kedd = Console.ReadKey().KeyChar;
                    switch (kedd) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: dienstag");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: martes");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: mardi");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                case "wednesday": //szerda fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char szerda = Console.ReadKey().KeyChar;
                    switch (szerda) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: mittwochs");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: miércoles");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: mercredi");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                case "thursday": //szerda fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char csutortok = Console.ReadKey().KeyChar;
                    switch (csutortok) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: donnerstag");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: jueves");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: jeudi");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                case "friday": //szerda fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char pentek = Console.ReadKey().KeyChar;
                    switch (pentek) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: Freitag");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: viernes");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: vendredi");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                case "saturday": //szerda fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char szombat = Console.ReadKey().KeyChar;
                    switch (szombat) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: samstag");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: sábado");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: samedi");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                case "sunday": //szerda fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char vasarnap = Console.ReadKey().KeyChar;
                    switch (vasarnap) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: sonntag");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: domingo");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: dimanche");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("nem értelmezhető válasz");
                    break;
            }
        }
        public static void Feladat4()
        {
            Console.WriteLine("Üdvözlöm önt a nagyon fancy étterembe");
            Console.WriteLine("Ezekből az éltekből tud választani:");
            Console.WriteLine("(1) - Ránotthús fűszerezett hasább burgonyával");
            Console.WriteLine("(2) - Marharagu leves");
            Console.WriteLine("(3) - Rakott krumpli");
            Console.WriteLine("(4) - Vadas");
            Console.WriteLine("(5) - Bolognai tészta");
            Console.Write("Kérem adja meg a ételhez tartozó azonosítót amit rendelni szeretne: ");

            char valasz = Console.ReadKey().KeyChar;
            switch (valasz)
            {
                case '1':
                    Console.WriteLine();
                    Console.WriteLine("Az ön által válaszott étel a Ránotthús fűszerezett hasább burgonyával");
                    Console.WriteLine("köszönjök hogy nálunk rendelt!");
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine("Az ön által válaszott étel a Marharagu leves");
                    Console.WriteLine("köszönjök hogy nálunk rendelt!");
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine("Az ön által válaszott étel a Rakott krumpli");
                    Console.WriteLine("köszönjök hogy nálunk rendelt!");
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine("Az ön által válaszott étel a Vadas");
                    Console.WriteLine("köszönjök hogy nálunk rendelt!");
                    break;
                case '5':
                    Console.WriteLine();
                    Console.WriteLine("Az ön által válaszott étel a Bolognai tészta");
                    Console.WriteLine("köszönjök hogy nálunk rendelt!");
                    break;
                default:
                    Console.WriteLine("Nem megfelelő azonosítót adott meg");
                    break;
            }
        }
        public static void Feladat5()
        {
            Console.WriteLine("Válaszd ki a lejátszási lehetőséget:");
            Console.WriteLine("(1) lejátszás");
            Console.WriteLine("(2) szünetelés");
            Console.WriteLine("(3) Következő dal");
            Console.WriteLine("(4) Előző dal");
            char valasz = Console.ReadKey().KeyChar;
            switch (valasz)
            {
                case '1':
                    Console.WriteLine();
                    Console.WriteLine("A zene éppen lejátszás alatt van");
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine("A zene éppen szünetel");
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine("A zenelejátszó a következő dalt játsza le");
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine("A zeneletjászó az előző dalt játsza le ");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Nem megfelelő értéket adott meg");
                    break;
            }
        }
        public static void Feladat6()
        {
            Console.WriteLine("- blue");
            Console.WriteLine("- green");
            Console.WriteLine("- purple");
            Console.WriteLine("- black");
            Console.WriteLine("Adja meg egy színt a 4 választás közül (angolul): ");
            string valasz1 = Console.ReadLine();
            switch (valasz1)
            {
                case "blue": // kék  fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char blue = Console.ReadKey().KeyChar;
                    switch (blue) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: blau ");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: azul ");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: bleu ");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                case "green": // zöld fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char green = Console.ReadKey().KeyChar;
                    switch (green) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: grün");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: vert");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: verde");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                case "purple": //lila fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char purple = Console.ReadKey().KeyChar;
                    switch (purple) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: violett");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: morado");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: pourpre");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                case "black": //fekete fordítása 
                    Console.WriteLine();
                    Console.WriteLine("Válaszaki hogy melyik nyelvre legyen le fordítva");
                    Console.WriteLine("(1) Német");
                    Console.WriteLine("(2) Spanyol");
                    Console.WriteLine("(3) Francia");
                    char black = Console.ReadKey().KeyChar;
                    switch (black) // fordítás 
                    {
                        case '1':
                            Console.WriteLine();
                            Console.WriteLine("Németre fordítva: schwarz");
                            break;
                        case '2':
                            Console.WriteLine();
                            Console.WriteLine("Spanyolra fordítva: negro");
                            break;
                        case '3':
                            Console.WriteLine();
                            Console.WriteLine("Franciára fordítva: noir");
                            break;
                        default:
                            Console.WriteLine("Hát ez most nem sikerült");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Nem megfelelő színt adott meg");
                    break;

            }
        }
        public static void Feladat7()
        {
            Console.WriteLine("Adja me hogy milyen időjárás van: ");
            Console.WriteLine("(1)- naposidő");
            Console.WriteLine("(2)- esős");
            Console.WriteLine("(3)- havazik");
            Console.WriteLine("(4)- szeles");
            char valasz = Console.ReadKey().KeyChar;
            switch (valasz)
            {
                case '1': 
                    Console.WriteLine();
                    Console.WriteLine("Öltözködési tipp napos időre: Póló, rövid nadrág, baseball sapka, cipő");
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine("Öltözködési tipp esés időre: pulcsi, kabát, vizhatlan nadrág, vizhatlna cipő");
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine("Öltözködési tipp havazásra: vastag pulóver, vastag kabát, vastag gatya, bakancs");
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine("Öltözködési tipp szeles időre: hosszú nadrá és egy pulóver vagy széldzseki, cipő");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Nem megfelelő értéket adott meg");
                    break;

            }
        }
        public static void Feladat8()
        {
            Console.WriteLine("Kérem adja meg a tanuló osztályzatát?:");
            Console.WriteLine("- 1");
            Console.WriteLine("- 2");
            Console.WriteLine("- 3");
            Console.WriteLine("- 4");
            Console.WriteLine("- 5");
            char valasz = Console.ReadKey().KeyChar;
            switch (valasz)
            {
                case '1':
                    Console.WriteLine();
                    Console.WriteLine("elégtelen");
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine("elégséges");
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine("közepes");
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine("jó");
                    break;
                case '5':
                    Console.WriteLine();
                    Console.WriteLine("kitűnő");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Nem megfelelő érték");
                    break;
            }
        }
    }
}
