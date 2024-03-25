using System;
using Newtonsoft.Json;

namespace CSProjeDemo2
{
	public class DosyaOku
	{
		public List<Personel> PersonelListesiOku(string dosyaYolu)
		{
			string json = File.ReadAllText(dosyaYolu);
			List<Personel> personelListesi = JsonConvert.DeserializeObject<List<Personel>>(json);
			return personelListesi;
		}
	}
}

