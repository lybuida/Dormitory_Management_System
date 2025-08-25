public class ThietBi
{
    public int Mathietbi { get; set; }
    public string Maphong { get; set; }
    public string Tenthietbi { get; set; }
    public int Soluong { get; set; }
    public string Tinhtrang { get; set; }

    public ThietBi() { }

    public ThietBi(int mathietbi, string maphong, string tenthietbi, int soluong, string tinhtrang)
    {
        Mathietbi = mathietbi;
        Maphong = maphong;
        Tenthietbi = tenthietbi;
        Soluong = soluong;
        Tinhtrang = tinhtrang;
    }

    public ThietBi(string maphong, string tenthietbi, int soluong, string tinhtrang)
    {
        Maphong = maphong;
        Tenthietbi = tenthietbi;
        Soluong = soluong;
        Tinhtrang = tinhtrang;
    }

}
