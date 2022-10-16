using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage._add
{
	/// <summary>
	/// </summary>
	static public class _DryRunX
	{

		public const string arg = "add -nA";
		//public const string arg = "add -n -A";


		static public void DryRun(nilnul.win.prog_.Git git, string _module)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module, arg
			);
		}

		static public void DryRun(string _module)
		{
			DryRun(nilnul.win.prog_.Git.StaticInstance, _module);
		}


		static public string DryRun(nilnul.win.prog_.Git git, nilnul.fs.Folder _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				_module, arg
			);
		}
		static public string DryRun(nilnul.fs.Folder _module)
		{
			return DryRun(nilnul.win.prog_.Git.StaticInstance, _module);
		}

		
	}
}
