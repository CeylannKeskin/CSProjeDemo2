using System;
using Newtonsoft.Json;

namespace CSProjeDemo2
{
	public class MaasBordro
	{
		public void MaaslariHesaplaVeKaydet(List<Personel> personelListesi, string klasorYolu)
		{
			foreach (var personel in personelListesi)
			{
				decimal maas = personel.MaasHesapla(180); 
				string tarih = DateTime.Now.ToString("MMMM yyyy"); 
				string dosyaYolu = Path.Combine(klasorYolu, $"{personel.Ad}_{tarih}.json");
				string json = JsonConvert.SerializeObject(new
				{
					PersonelIsmi = personel.Ad,
					CalismaSaati = 180,
					AnaOdeme = maas,
					Mesai = 0, 
					ToplamOdeme = maas
				}, Formatting.Indented);
				File.WriteAllText(dosyaYolu, json);
			}
		}
	}
}

