namespace BedenKitleEndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu Giriniz:");
            int Kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu Giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());
            double indeks = (Kilo / (boy * boy)); 
           
            Console.WriteLine("Vücut Kitle Endeksiniz:" + indeks);
            if (indeks == 18 || indeks < 18)
            {
                Console.WriteLine("İdeal Kilonuzun Altındasınız.");
            }
            else if (indeks > 18 && indeks < 25)
            {
                Console.WriteLine("Normal Kiloya Sahipsiniz");
            }
            else
            {
                Console.WriteLine("Obezsiniz");
            }

        }
    }
}