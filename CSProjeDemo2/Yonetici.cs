using System;
namespace CSProjeDemo2
{
	public class Yonetici:Personel
	{
		public override decimal SaatlikUcret => 500;

		public override decimal MaasHesapla(int calismaSaati)
		{
			decimal maas = base.MaasHesapla(calismaSaati);
			decimal bonus = 1000;
			return maas + bonus;
		}
	}
}

