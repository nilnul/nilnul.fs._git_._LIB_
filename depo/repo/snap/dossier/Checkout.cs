using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap.document
{
	public class _CheckoutX
	{
		static public void Checkout(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.repo._branch.Name branch
			,
			nilnul.fs._address.DocumentI document
			,
			nilnul.win.prog_.Git git=null
			
		) {

			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				module, 
				$@"checkout {branch} -- {
					nilnul.fs._address.document.phrase_.QuoteIfHasSpaceOrTab.Singleton.phrase(document)
					//nilnul.txt.op_.unary_._QuoteIfHasSpaceTabX.Op(document.ToString())
					}"		//note the "--" is optional
				,
				git
			);


		}

		static public void Checkout(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.repo._branch.Name branch
			,
			string document
			,
			nilnul.win.prog_.Git git=null

			
		) {
			Checkout(module,branch, nilnul.fs._address.Document.Parse(document) ,git);
		}

		static public void Checkout(
			nilnul.fs.git.ModuleI module
			,
			string branch
			,
			string document
			,
			nilnul.win.prog_.Git git=null

			
		) {
			Checkout(module, new git.repo._branch.Name( branch), (document) ,git);
		}

		static public void Checkout_ofModuleAddress(
			string module
			,
			string branch
			,
			string document
			,
			nilnul.win.prog_.Git git=null

			
		) {
			Checkout(nilnul.fs.git.Module.FroAddress( module), ( branch), (document) ,git);
		}
		static public void Checkout_ofModuleSub(
			string module
			,
			string branch
			,
			string document
			,
			nilnul.win.prog_.Git git=null

			
		) {
			Checkout(nilnul.fs.git.Module.OvInnerDivAddress( module), ( branch), (document) ,git);
		}

	}
}
