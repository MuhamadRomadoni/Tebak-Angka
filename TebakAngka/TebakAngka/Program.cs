namespace TebakAngka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool GameStart = false;
            char start;
            int min = 0;
            int max = 100;
            int angka;
            int tebakan;
            int JumlahTebakan;
            char mengulang;
            string nama = "";

            Console.Write("Masukan Nama: ");
            nama = Console.ReadLine();
            Console.WriteLine("Hello " + nama + ", Mari bermain tebak angka? (Y/N)");
            start = Convert.ToChar(Console.ReadLine());

            if (start == 'Y' || start == 'y')
            {
                GameStart = true;
            }
            else
            {
                GameStart = false;
                return;
            }

            while (GameStart)
            {
                angka = 0;
                JumlahTebakan = 0;
                tebakan = random.Next(min, max + 1);

                while (angka != tebakan)
                {
                    Console.Write("Tebak angka dari " + min + " - " + max + " : ");
                    angka = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Angka: " + angka);

                    if (angka > tebakan)
                    {
                        Console.WriteLine(angka + " Itu terlalu besar!");
                    }
                    else if (angka < tebakan)
                    {
                        Console.WriteLine(angka + " Itu terlalu kecil!");
                    }
                    JumlahTebakan++;
                }

                Console.WriteLine("Tebak angka: " + tebakan);
                Console.WriteLine("Selamat Anda Benar");
                Console.WriteLine("Jumlah tebakan: " + JumlahTebakan);

                Console.Write("Apakah anda ingin bermain lagi? (Y/N) ");
                mengulang = Convert.ToChar(Console.ReadLine());

                if (mengulang == 'Y' || mengulang == 'y')
                {
                    GameStart = true;
                }
                else
                {
                    GameStart = false;
                }
            }
            Console.WriteLine("Terima Kasih sudah bermain!");
        }
    }
}