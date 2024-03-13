// See https://aka.ms/new-console-template for more information
namespace JurnalMod4
{

    public class KodeBuah
    {
        public enum Buah
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung
        }

        public static string getKodeBuah(Buah kode)
        {
            string[] kode_buah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
            return kode_buah[(int)kode];
        }

        public enum Buah2
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika, Kurma, Durian, Anggur, Melon, Semangka
        }

        public static string getKodeBuah2(Buah2 kode2)
        {
            string[] kode_buah2 = { "A00", "B00", "C00", "D00", "E00", "K00", "L00", "M00", "N00", "O00" };
            return kode_buah2[(int)kode2];
        }
        public static void main(string[] args)
        {
            Console.WriteLine("Nama buah dam Kode buah");
            foreach (Buah kode in Enum.GetValues(typeof(Buah)))
            {
                Console.WriteLine($"{kode} - {getKodeBuah(kode)}");
            }
            Console.WriteLine("Nama buah dam Kode buah");
            foreach (Buah2 kode2 in Enum.GetValues(typeof(Buah2)))
            {
                Console.WriteLine($"{kode2} - {getKodeBuah2(kode2)}");
            }
        }
    }
    // 1302223010 % 3 = 2
    internal class program
    {
        public class PosisiKarakterGame
        {
            public enum Posisi
            {
                Berdiri, Terbang, Jongkok, Tengkurap
            }
            public static void Main(string[] args)
            {
                PosisiKarakterGame.Posisi posisi = PosisiKarakterGame.Posisi.Berdiri;
                Console.Write("Posisi sekarang adalah : Berdiri/Terbang/Jongkok/Tengkurap ");
                string masukan = Console.ReadLine();
                while (masukan != "Keluar")
                {
                    switch (posisi)
                    {
                        case PosisiKarakterGame.Posisi.Terbang:
                            if (masukan == "Jongkok")
                            {
                                posisi = PosisiKarakterGame.Posisi.Jongkok;
                                Console.WriteLine("Posisi landing");
                            }
                            break;
                        case PosisiKarakterGame.Posisi.Berdiri:
                            if (masukan == "Terbang")
                            {
                                posisi = PosisiKarakterGame.Posisi.Terbang;
                                Console.WriteLine("Posisi take off");
                            }
                            break;
                    }
                    Console.Write("Posisi lain: ");
                    masukan = Console.ReadLine();
                }
            }
        }
    }
}