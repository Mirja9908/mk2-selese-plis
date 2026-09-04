namespace LatihannOOP
{
    internal class Handphone
    {
        // 2. Membuat Properti
        public string NamaHP { get; set; }
        public long HargaHP { get; set; }
        public string MerkHP { get; set; }
        public int TahunRilis { get; set; }

        // 3. Membuat Method: Tampil Data
        public void TampilData()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Nama HP     : " + NamaHP);
            Console.WriteLine("Harga HP    : Rp" + HargaHP.ToString("N0"));
            Console.WriteLine("Merk HP     : " + MerkHP);
            Console.WriteLine("Tahun Rilis : " + TahunRilis);
            Console.WriteLine("================================");
        }
    }
}
