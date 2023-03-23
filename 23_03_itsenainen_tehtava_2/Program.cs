using System;

namespace _23_03_itsenainen_tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region f: Alkusanat e: Introduction

            /*
             * 23.03.2023 C# Perusrakenteet, Itsenäinen Tehtävä 2
             * 
             * Lauri Liukkonen
             * 
             * Pinta-alalaskuri
             * 
             * 
             */

            #endregion


            #region f: Asetukset e: Config

            double unit_multiplier = 1;

            // f: Metrinen e: Metric
            int unit_Metric_ID = 1;
            string unit_Metric_UOM = "metriä";
            string unit_Metric_menu = "Metrit";
            string unit_Metric_menu_char = "A";
            string unit_Metric_menu_s_char = "a";
            string unit_Metric_shortUOM = "m";
            string unit_Metric_unicode = "m2"; //\u33A1
            double unit_Metric_value = 1.0;

            // f: Imperiaalinen e: Imperialic
            int unit_Imperial_ID = 2;
            string unit_Imperial_UOM = "jalkaa";
            string unit_Imperial_menu = "Jalat";
            string unit_Imperial_menu_char = "B";
            string unit_Imperial_menu_s_char = "b";
            string unit_Imperial_shortUOM = "ft";
            string unit_Imperial_unicode = "ft2"; //\u23CD
            double unit_Imperial_value = 3.28;

            // f: Separaattori e: Separator
            string separator = "-------------------------------------------------------------";

            // f: Ohjelman tiedot e: Software info
            string soft_name = "              PINTA-ALAMITTARI";
            string soft_v = "v0.0.0.1";

            bool selection_done = false;
            int unit = 1;

            #endregion

            #region f: MENU: Yksikön valinta e: MENU: Unit selection

            // f: looppi kunnes käyttäjä valitsee yksikön e: loop until user selects unit
            while (!selection_done)

            {
                Console.Clear(); // f: Konsolin nollaus e: Clearing the console
                Console.ForegroundColor = ConsoleColor.Cyan; // f: Otsikko keltaisella e: Header yellow
                Console.WriteLine("Valitse yksikkö");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(separator);
                Console.ResetColor(); // Color reset

                //f: Valikko printti e: Print of menu
                Console.WriteLine($"({unit_Metric_menu_char}){unit_Metric_menu} | ({unit_Imperial_menu_char}){unit_Imperial_menu} {soft_name}{soft_v}");
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine(separator);
                Console.ResetColor(); // Color reset
                string unit_selection = Convert.ToString(Console.ReadLine());




                // f: Ehdot loopista ulos e: Conditions to exit loop
                if (unit_selection == unit_Metric_menu_char || unit_selection == unit_Metric_menu_s_char)
                {
                    Console.WriteLine("Metrit valittu.");
                    unit = unit_Metric_ID;
                    selection_done = true; 
                }
                else if (unit_selection == unit_Imperial_menu_char || unit_selection == unit_Imperial_menu_s_char)
                {
                    Console.WriteLine("Jalat valittu.");
                    unit = unit_Imperial_ID;
                    selection_done = true;
                }
                else
                {
                    Console.WriteLine($"Anteeksi, mutta valintaasi {unit_selection} ei ole olemassa. Yritä uudelleen. \n Jatka painamalla mitä tahansa näppäintä.");
                    Console.ReadKey();
                }


            }
            #endregion
            #region F: määrityksiä käyttäjän inputin perusteella E: definements based on user input
            // f: yksiköiden määritys valinnan perusteella e: unit definement based on user input
            string unit_UOM = "m";
            string unit_2_UOM = "ft";

            if (unit == unit_Metric_ID)
            {
                unit_UOM = unit_Metric_shortUOM;
                unit_2_UOM = unit_Imperial_shortUOM;
            }
            else if (unit == unit_Imperial_ID)
            {
                unit_UOM = unit_Imperial_shortUOM;
                unit_2_UOM = unit_Metric_shortUOM;

            }
            else 
            {
                unit_UOM = "yksikköä";
            }


            double length_Value_final = 0.00;
            double width_Value_final = 0.00;

            bool values_given = false;
            // f: yksiköiden syöttö looppaa samalla tavalla kunnes käyttäjä antaa mitat e: unit input loops same way until user gives measurements
            #endregion
            #region f: MENU - mittojen syöttö e: MENU - measure input

            while (!values_given)

            {

                // f: pituus imputin "grafiikat" e: legth input "graphics"

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan; // f: Otsikko keltaisella e: Header yellow
                Console.WriteLine("Syötä seuraavat arvot:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(separator);
                Console.ResetColor(); // Color reset
                Console.WriteLine("            <");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("----------- ");
                Console.WriteLine("|         | ");
                Console.WriteLine("|         | ");
                Console.WriteLine("|         | ");
                Console.WriteLine("----------- ");
                Console.ResetColor(); // Color reset
                Console.WriteLine($"            <Pituus ({unit_UOM}) \n\n Huom: Jos käytät desimaaleja erottele ne .(piste) eikä ,(pilkku).\n");
                
                double length_Value = Convert.ToDouble(Console.ReadLine());

                // f: leveys imputin "grafiikat" e: width input "graphics"
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan; // f: Otsikko keltaisella e: Header yellow
                Console.WriteLine("Syötä seuraavat arvot:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(separator);
                Console.ResetColor(); // Color reset
                Console.WriteLine("             ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("----------- ");
                Console.WriteLine("|         | ");
                Console.WriteLine("|         | ");
                Console.WriteLine("|         | ");
                Console.WriteLine("----------- ");
                Console.ResetColor(); // Color reset
                Console.WriteLine($">            <Leveys ({unit_UOM}) \n\n Huom: Jos käytät desimaaleja erottele ne .(piste) eikä ,(pilkku).\n");

                double width_Value = Convert.ToDouble(Console.ReadLine());

                if (length_Value >= 0.0001 && width_Value >= 0.0001)
                {
                    values_given = true;
                    length_Value_final = length_Value;
                    width_Value_final = width_Value;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Jokin meni pieleen. Antamiasi arvoja pituus: {length_Value} ja leveys: {width_Value} ei voi laskea yhteen.");
                    Console.WriteLine("Paina mitä tahansa näppäintä yrittääksesi uudelleen.");
                    Console.ReadKey();
                }

            }

            #endregion

            #region f: Yhteenlaskuja ja loppuraportti e: Calcuclations and final report
            // f: yhteenlaskut e: calcuclations

            double surf_area = length_Value_final * width_Value_final;
            double multiplier_unit = 1;
            string oppositeunit = "";
            string oppositeshort = "";
            string oppositeunicode = "";

            double length_multiply = 0;
            double width_multiply = 0; 

            // f: yksiköiden arvojen määritys loppuprinttiin käyttäjän valinnan perusteella e: unit value definement based on user selection

            if (unit == unit_Metric_ID) // f: jos metrit e: if metric
            {
                length_multiply = Convert.ToDouble(length_Value_final * unit_Imperial_value);
                width_multiply = Convert.ToDouble(length_Value_final * unit_Imperial_value);

                oppositeunit = unit_Imperial_menu; // f: sovellus laskee convert-raporttiin jalat e: software counts feet on convert report
                oppositeshort = unit_Imperial_shortUOM;
                oppositeunicode = unit_Imperial_unicode;
            }
            else if (unit == unit_Imperial_ID) // f: jos jalat e: if imperial
            {
                length_multiply = length_Value_final / unit_Imperial_value;
                width_multiply = length_Value_final / unit_Imperial_value;

                oppositeunit = unit_Metric_menu;
                oppositeshort = unit_Metric_shortUOM; //f: sovellus laskee convert - raporttiin metrit e: software counts meters on convert report
                oppositeunicode = unit_Metric_unicode;
            }
            else

            {


            }

            //f : loppuraportti e: final report

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan; // f: Otsikko keltaisella e: Header yellow
            Console.WriteLine("Tulokset:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(separator);
            Console.ResetColor(); // Color reset
            Console.WriteLine($"Syöttämäsi arvot:\nPituus:{length_Value_final}{unit_UOM} ja leveys: {width_Value_final}{unit_UOM}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Kokonaispinta-ala on {surf_area}{unit_UOM}.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(separator);
            Console.ResetColor(); // Color reset
            Console.WriteLine($"Käännettynä yksikköön:{oppositeunit}\nPituus:{length_multiply}{oppositeunicode} ja leveys: {width_multiply}{oppositeunicode}");

            //f: tuplatarkistus ennen sulkua (estää vahingossa sulkemisen) e: double check before closing (prevents accidental closedown)

            Console.WriteLine("\n Paina mitä tahansa nappia sulkiaksesi sovelluksen");
            Console.ReadKey();

            Console.WriteLine("\n Oletko varma että haluat lopettaa? (varmistus, paina vielä kerran)");
            Console.ReadKey();


            #endregion
        }
    }
}
