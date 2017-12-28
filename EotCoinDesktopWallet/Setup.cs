using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using Foundation;
using AppKit;

namespace EotCoinDesktopWallet
{
	public partial class Setup : NSWindow
	{

        public Setup(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public Setup(NSCoder coder) : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

		//protected void GenerateWalletClick(object sender, EventArgs e)
		//{
			//if (randcharstextBox.Text.Length < 120)
			//{
			//	System.Windows.Forms.MessageBox.Show("Please enter 120 random characters");
			//}
			//else
			//{
			//string inputString = randcharstextBox.Text;
		/*	string inputString = "";
			//String Password = PasswordBox.Text;
			string Password = "abcd";
			 char[] characters = inputString.ToCharArray();

				Random rnd = new Random();
				Utilities utils = new Utilities();
				string seed = utils.generateSeed(inputString, rnd);

				List<string> keyPair = utils.getKeyPair(seed);
				string eotPrivateKey = keyPair.ElementAt(0);
				string eotAddress = keyPair.ElementAt(1);

				Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, seed);
				Utilities.FileEncrypt(seed, Password);
				utils.printWalletToFile(eotWallet);

				//MainWindow dashboardform = new MainWindow();
				//dashboardform.Show();

				//this.Hide();*/
			
		//}
	}
}
