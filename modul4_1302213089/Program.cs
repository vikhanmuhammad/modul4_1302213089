// See https://aka.ms/new-console-template for more information
internal class Program
{
    public enum Buah{
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
        Kurma,
        Durian,
        Anggur,
        Melon,
        Semangka
    }

    public class KodeBuah
    {
        public static string getKodeBuah_1302213089(Buah inputBuah)
        {
            string[] outputKodeBuah = {"A00", "B00", "C00", "D00", "E00", "F00",
            "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};
            int inputInt = (int)inputBuah;
            return outputKodeBuah[inputInt];
        }
    }


    private static void Main(string[] args)
    {
        Buah buah = Buah.Blackberry;
        string kodebuah = KodeBuah.getKodeBuah_1302213089(buah);
        Console.WriteLine("Buah " + buah + " memiliki kode buah : " + kodebuah + "\n");
    }



}
