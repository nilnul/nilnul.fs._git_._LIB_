using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	static public class _CheckoutX
	{
		static public void CheckOut(nilnul.win.prog_.Git git, string _module, string branch) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module,
				$"checkout {branch}"
			);
		}

		static public void CheckOut(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string branch) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				_module,
				$"checkout {branch}"
				,
				git
			);
		}

		static public void CheckOut( nilnul.fs.folder_.git_.Top _module, string branch, nilnul.win.prog_.Git git=null) {

			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(
				_module,
				$"checkout {branch}"
			);
		}




		static public void CheckOut( nilnul.fs.Folder _module, string branch) {
			CheckOut(nilnul.win.prog_.Git.StaticInstance, _module, branch);
		}


		static public void CheckOutByForce(nilnul.win.prog_.Git git, string _module, string branch) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module,
				$"checkout -f {branch}"
			);
		}

		static public void CheckOutByForce(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string branch) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				_module,
				$"checkout -f {branch}"
			);
		}

		static public void CheckOutByForce( nilnul.fs.Folder _module, string branch) {
			CheckOutByForce(nilnul.win.prog_.Git.StaticInstance, _module, branch);
		}


		static public void CheckOutByForce( string _module, string branch="master") {
			CheckOutByForce(nilnul.win.prog_.Git.StaticInstance, _module,branch);
		}





		static public void CheckOut( string _module, string branch="master") {
			CheckOut(nilnul.win.prog_.Git.StaticInstance, _module,branch);
		}





	}
}
