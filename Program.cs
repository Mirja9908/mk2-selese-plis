namespace LatihannOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Mengisi Object lebih dari 1

            Handphone hp1 = new Handphone();

            //menambahkan data object hp1
            hp1.NamaHP = "Samsung Galaxy S25";
            hp1.HargaHP = 14999000;
            hp1.MerkHP = "Samsung";
            hp1.TahunRilis = 2025;

            Handphone hp2 = new Handphone();

            //menambahkan data object hp2
            hp2.NamaHP = "iPhone 16 Pro";
            hp2.HargaHP = 22000000;
            hp2.MerkHP = "Apple";
            hp2.TahunRilis = 2024;

            Handphone hp3 = new Handphone();

            //menambahkan data object hp3
            hp3.NamaHP = "Xiaomi 15 Ultra";
            hp3.HargaHP = 12500000;
            hp3.MerkHP = "Xiaomi";
            hp3.TahunRilis = 2025;

            // Menampilkan semua data
            hp1.TampilData();
            hp2.TampilData();
            hp3.TampilData();

            Console.ReadLine();
        }
    }
}
