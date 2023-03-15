// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

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


    public enum gerakState
    {
        TENGKURAP, JONGKOK, BERDIRI, TERBANG
    }

    public enum Trigger
    {
        TOMBOL_W, TOMBOL_X, TOMBOL_S
    }

    public class PosisiKarakterGame
    {
        public gerakState currentState = gerakState.BERDIRI;

        public class Transition
        {
            public gerakState stateAwal;
            public gerakState stateAkhir;
            public Trigger trigger;

            public Transition(gerakState stateAwal, gerakState stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }

        Transition[] transisi =
        {
            new Transition(gerakState.TENGKURAP, gerakState.JONGKOK, Trigger.TOMBOL_W),
            new Transition(gerakState.JONGKOK, gerakState.TENGKURAP, Trigger.TOMBOL_S),
            new Transition(gerakState.JONGKOK, gerakState.BERDIRI, Trigger.TOMBOL_W),
            new Transition(gerakState.BERDIRI, gerakState.JONGKOK, Trigger.TOMBOL_S),
            new Transition(gerakState.BERDIRI, gerakState.TERBANG, Trigger.TOMBOL_W),
            new Transition(gerakState.TERBANG, gerakState.BERDIRI, Trigger.TOMBOL_S),
            new Transition(gerakState.TERBANG, gerakState.JONGKOK, Trigger.TOMBOL_X)
        };

        public void GetStateBerikutnya_1302213089(gerakState stateAwal, Trigger trigger)
        {
            gerakState stateAkhir = stateAwal;

            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];

                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }

            Console.WriteLine("State sekarang adalah : " + stateAkhir);

            if (stateAwal == gerakState.TERBANG && stateAkhir == gerakState.JONGKOK)
            {
                Console.WriteLine("Posisi standby");
            }
            else if (stateAwal == gerakState.BERDIRI && stateAkhir == gerakState.TERBANG)
            {
                Console.WriteLine("Posisi takeoff");
            }
        }
    }


    private static void Main(string[] args)
    {
        Buah buah = Buah.Blackberry;
        string kodebuah = KodeBuah.getKodeBuah_1302213089(buah);
        Console.WriteLine("Buah " + buah + " memiliki kode buah : " + kodebuah + "\n");

        PosisiKarakterGame objGame = new PosisiKarakterGame();

        objGame.GetStateBerikutnya_1302213089(gerakState.TERBANG, Trigger.TOMBOL_S);
        objGame.GetStateBerikutnya_1302213089(gerakState.BERDIRI, Trigger.TOMBOL_S);
        objGame.GetStateBerikutnya_1302213089(gerakState.JONGKOK, Trigger.TOMBOL_S);
        objGame.GetStateBerikutnya_1302213089(gerakState.TENGKURAP, Trigger.TOMBOL_W);
        objGame.GetStateBerikutnya_1302213089(gerakState.JONGKOK, Trigger.TOMBOL_W);
        objGame.GetStateBerikutnya_1302213089(gerakState.BERDIRI, Trigger.TOMBOL_W);
        objGame.GetStateBerikutnya_1302213089(gerakState.TERBANG, Trigger.TOMBOL_X);


    }

}
