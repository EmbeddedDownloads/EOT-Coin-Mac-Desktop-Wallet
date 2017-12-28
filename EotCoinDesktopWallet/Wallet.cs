using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EotCoinDesktopWallet
{
	class Wallet
	{
		public string eotPrivateKey { get; }
		public string eotAddress { get; }
		public double eotBalance { get; }
		public string eotSeed { get; }


		public Wallet(string priKey, string address, string seed)
		{
			eotPrivateKey = priKey;
			eotAddress = address;
			eotBalance = 0.0;
			eotSeed = seed;
		}

		public Wallet(string priKey, string address, string seed, double balance)
		{
			eotPrivateKey = priKey;
			eotAddress = address;
			eotBalance = balance;
			eotSeed = seed;
		}
	}
}