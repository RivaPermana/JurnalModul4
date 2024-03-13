// See https://aka.ms/new-console-template for more information
public class KodeBuah
{
    public enum Buah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung
    }

    public static string getKodeBuah(Buah kode)
    {
        string[] kode_buah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
        return kode_buah;
    }

    public enum Buah2
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Kurma, Durian, Anggur, Melon, Semangka
    }

    public static string getKodeBuah2(Buah2 kode2)
    {
        string[] kode_buah2 = { "A00", "B00", "C00", "D00", "E00", "K00", "L00", "M00", "N00", "O00" };
        return kode_buah2;
    }

}
