namespace FromSqlToExcel.Domain.Models
{
    public class Links
    {
        public Izdel IzdelUp { get; set; }
        public Izdel Izdel { get; set; }
        public int Kol { get; set; }

        public override string ToString()
        {
            return $"Входит в состав {IzdelUp} в количестве {Kol}";
        }
    }
}
