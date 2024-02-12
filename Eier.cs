namespace BilProdusent
{
    internal class Eier
    {
        BilMekaniker bilMekaniker;
        List<Del> bildeler;
        List<Del> ferdigBil;
        Del del;

        public Eier()
        {
            bildeler = new();
            bilMekaniker = new();
            ferdigBil = new();
        }


        public void KjøpeBildeler()
        {
            Console.WriteLine("Bestill deler til bilen din! Type/Mengde");
            Console.WriteLine("Du trenger: Motor, understell, karosszeri, dekk, drivstoff!");

            for (int i = 1; i <= 5; i++)
            {
                string Type;
                int Mengde;

                Console.Write("Type: ");
                Type = Console.ReadLine()!;
                Console.Write("Mengde: ");
                Mengde = Convert.ToInt16(Console.ReadLine());

                del = new(Type, Mengde);

                bildeler.Add(del);
            }

            Kvitering();

            BestillProduksjon(bildeler);
        }

        public void BestillProduksjon(List <Del> deler) 
        {
            ferdigBil = bilMekaniker.LageBil(deler);
        }

        private void Kvitering()
        {
            Console.WriteLine("\nDu kjøpte: \n");

            foreach (var item in bildeler)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void FerdigKjør()
        {
            Console.WriteLine("Bilen består av: \n");

            foreach(var item in ferdigBil)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\nEieren kjørte fra bilprodusenten...");
        }

    }
}

/*En bil kan bestå av bildeler(motor, understell, karosseri), og dekk(=4!), og drivstoff(40L).*/
/*Eieren skal kunne legge til de forskjellige delenee til bilen.*/
/*Eieren trenger å bestille montering fra en bilmekaniker.*/