using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.module.index.add_.allBut_
{
	/// <summary>
	/// including：
	///		removed,
	///		updated, 
	///		new but not tracked
	///	not including:
	///		ignored
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	public static class _MinWinTitledX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_module"></param>
		/// <param name="buts">will be put into .git/exclude</param>
		/// <param name="git"></param>
		/// <returns></returns>
		public static int ExitCode(nilnul.fs.git.ModuleI _module, IEnumerable<nilnul.fs._address.DivisionI> buts, nilnul.win.prog_.Git git = null)
		{
			//nilnul.fs.git.module._ignore_.exclude.put._IfLinesNonemptyX.Void(
			//	_module
			//	,
			//	buts.Select(
			//		x => x.ToString().Replace(@"\","/")
			//	)
			//);
			nilnul.fs.git.module._ignore_.exclude.put._IfLinesNonemptyX.Void(
				_module
				,
				buts
			);

			return nilnul.win.prog_.git.run_.ui._ExitCodeX.ExitCode(
				_module
				,
				$@"add -A"

				//$@"add -A {
				//	string.Join(
				//		" "
				//		,
				//		buts.Select(
				//			x => $":^{nilnul.txt.op_.unary_._QuoteIfHasSpaceTabX.Op(x.ToString())}")//not :!   for ! can be interpreted as event.
				//		)
				//}"   //--all

				,
				git
			);
		}


		public static int ExitCode(nilnul.fs.git.ModuleI _module, nilnul.win.prog_.Git git = null)
		{
			

			return nilnul.win.prog_.git.run_.ui._ExitCodeX.ExitCode(
				_module
				,
				$@"add -A"


				,
				git
			);
		}

		public static int ExitCode(string _module, IEnumerable<nilnul.fs._address.DivisionI> buts, nilnul.win.prog_.Git git = null)
		{
			return ExitCode(nilnul.fs.git.Module.FroAddress(_module), buts, git);
		}

		public static int ExitCode(string _module, IEnumerable<string> buts, nilnul.win.prog_.Git git = null)
		{
			return ExitCode(
				nilnul.fs.git.Module.FroAddress(_module)
				,
				buts.Select(x => nilnul.fs._address.DivisionA.Parse(x))
				,
				git
			);
		}



	}
}
