namespace FromSqlToExcel.Domain.Models
{
    public class Links
    {
        public Izdel IzdelUp { get; set; }
        public Izdel Izdel { get; set; }
        public int Kol { get; set; }

        public override string ToString()
        {
            return $"{Izdel} входит в состав {IzdelUp} в количестве {Kol}";
        }
    }
}
