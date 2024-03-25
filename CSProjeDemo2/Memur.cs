using System;
namespace CSProjeDemo2
{
	public class Memur:Personel
	{
		public int Derece { get; set; }
		public override decimal SaatlikUcret => 500 * Derece; 

		public override decimal MaasHesapla(int calismaSaati)
		{
			decimal maas = base.MaasHesapla(calismaSaati);
			if (calismaSaati > 180)
			{
				int ekMesaiSaatleri = calismaSaati - 180;
				decimal ekMesaiUcreti = SaatlikUcret * 1.5m; 
				maas += ekMesaiSaatleri * ekMesaiUcreti;
			}
			return maas;
		}
	}
}

