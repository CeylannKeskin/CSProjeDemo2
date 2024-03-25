using CSProjeDemo2;

namespace PersonelMaasBordro;

class Program
{
	static void Main(string[] args)
	{
		string dosyaYolu = "personel.json";
		
		string klasorYolu = "MaasBordrolari";

		DosyaOku dosyaOku = new DosyaOku();
		List<Personel> personelListesi = dosyaOku.PersonelListesiOku(dosyaYolu);

		MaasBordro maasBordro = new MaasBordro();
		maasBordro.MaaslariHesaplaVeKaydet(personelListesi, klasorYolu);

		Console.WriteLine("Maaş bordrosu oluşturuldu ve kaydedildi.");
	}
}

