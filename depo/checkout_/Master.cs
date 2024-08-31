using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.checkout_
{
	static public class _MasterX
	{

		static public void Checkout(nilnul.fs.folder_.git_.Top module, nilnul.win.prog_.Git git=null ) {

			_CheckoutX.CheckOut(module,  "master", git);

		}

		static public void Checkout(nilnul.fs.Folder module, nilnul.win.prog_.Git git=null ) {

			Checkout(new fs.folder_.git_.Top(  module),  git);

		}

	}
}
