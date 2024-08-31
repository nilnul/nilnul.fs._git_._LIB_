using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	static public class _CherryFileX
	{
		static public void CheckOut(nilnul.win.prog_.Git git, string _module, string branch, string file) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module,
				$"checkout {branch} -- \"{file}\""
			);
		}

		static public void CheckOut( string _module, string branch, string file){
			CheckOut(nilnul.win.prog_.Git.StaticInstance, _module, branch,file);
		}

		static public void CheckOutByForce(nilnul.win.prog_.Git git, string _module, string branch, string file) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module,
				$"checkout -f {branch} -- {file}"
			);
		}

		static public void CheckOutByForce( string _module, string branch,string file) {
			CheckOutByForce(nilnul.win.prog_.Git.StaticInstance, _module,branch,file);
		}








	}
}
