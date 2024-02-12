namespace BilProdusent
{
    internal class BilMekaniker
    {
        public List<Del> FerdigBil = new List<Del>();

        public List<Del> LageBil(List <Del> deler)
        {
            Console.WriteLine("\nBilmekanikeren har fått delene til en ny bil og begynner å jobbe på bilen....\n");
            Thread.Sleep(1500);

            foreach (Del del in deler)
            {
                Thread.Sleep(1500);
                FerdigBil.Add(del); 
                Console.WriteLine( del.ToString() + "===> NyBil");
            }
            Thread.Sleep(1500);
            Console.WriteLine("\nBilen er ferdig!");

            return FerdigBil;
        }

    }
}
/*Når bilen(e) er ferdig(e), skal applikasjonen printe ut informasjon om hvilke deler bilen(e) består av.*/
/*Bygge biler*/
/*En bil er ikke ferdig og ikke kjørbar hvis ikke alle bildeler, dekk, og drivstoff er på plass.*/
