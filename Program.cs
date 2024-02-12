namespace BilProdusent
{
    internal class Program
    {
        static void Main()
        {
            Eier eier = new();

            eier.KjøpeBildeler();

            eier.FerdigKjør();
        }
    }
}

/*Lag en app som kan bygge biler. En bil kan bestå av bildeler(motor, understell, karosseri), og dekk(=4!), og drivstoff(40L).
Eieren trenger å bestille montering fra en bilmekaniker. En bil er ikke ferdig og ikke kjørbar hvis ikke alle bildeler, dekk, og drivstoff er på plass. Eieren skal kunne legge til de forskjellige delene til bilen.
Når bilen(e) er ferdig(e), skal applikasjonen printe ut informasjon om hvilke deler bilen(e) består av.*/


/*Implementalni: 
 * 1. En bil er ikke ferdig og ikke kjørbar hvis ikke alle bildeler
 * 2. Når bilen(e) er ferdig(e), skal applikasjonen printe ut informasjon om hvilke deler bilen(e) består av.
 3. Esetleg tøbb billel is megcsinalni (utannanezni hogy hogyan kell kurvagyorsan klassekat es konstruktørøket letrehozni )*/