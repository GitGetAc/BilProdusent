namespace BilProdusent
{
    internal class Del
    {
        public Del(string type, int mengde)
        {
            Type = type;
            Mengde = mengde;
        }

        public string Type { get; set; } = string.Empty;
        public int Mengde { get; set; }

        public override string ToString()
        {
            return $"Type: {Type} Mengde: {Mengde}";
        }

    }
}
/*En bil kan bestå av bildeler(motor, understell, karosseri), og dekk(=4!), og drivstoff(40L).*/