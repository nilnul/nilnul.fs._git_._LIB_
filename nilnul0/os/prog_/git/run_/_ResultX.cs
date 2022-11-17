using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.git.run_
{
	static public class _ResultX
	{
		static public nilnul.win.prog.run_._result.Data Result(
			nilnul.fs.git.ModuleI module, 
			string arg,
			nilnul.win.prog_.Git git=null
			) {
			return nilnul.win.prog.run_._ResultX.Result(
				module.top.en.ToString()
				,
				nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
				,
				arg
			);
		}

		static public nilnul.win.prog.run_._result.Data Result(
			nilnul.fs.address_.ShieldI module, 
			string arg,
			nilnul.win.prog_.Git git=null
			) {
			return nilnul.win.prog.run_._ResultX.Result(
				module.ToString()
				,
				nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
				,
				arg
			);
		}

	}
}
