using System;
namespace CSProjeDemo2
{
	public abstract class Personel
	{
		public string Ad { get; set; }
		public abstract decimal SaatlikUcret { get; }

		public virtual decimal MaasHesapla(int calismaSaati)
		{
			return calismaSaati * SaatlikUcret;
		}
	}
}

