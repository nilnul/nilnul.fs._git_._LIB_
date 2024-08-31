using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_
{

	/// <summary>
	/// modified, created, or removed;
	/// 
	/// </summary>
	/// <remarks>
	/// updated, inserted or deleted;
	///
	/// </remarks>
	/// alias:
	///		changeVsPier
	///
	[Obsolete(nameof(fs.git.depo._werk_.dossiers_.included_._ChangedVsPierX))]
	static public class _ChangeX
	{
		/// <summary>
		/// untracked - ignored = <see cref="depo._werk_.dossiers_.untracked_.IUnignored"/>
		/// with:
		///		<see cref="depo._werk_.dossiers_.tracked_.IRevised"/>
		/// </summary>
		public const string ARGUMENT = "ls-files -om --exclude-standard";

		/// <summary>
		/// note that symlink would be listed 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		
		static public IEnumerable<string> Document0symlinkEs(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return fs.git.depo._werk_.dossiers_.included_._ChangedVsPierX.Document0symlinkEs(module, git);



		}


		[Obsolete(nameof(Document0symlinkEs))]
		static public IEnumerable<string> Documents(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return fs.git.depo._werk_.dossiers_.included_._ChangedVsPierX.Document0symlinkEs(module, git);


			var arg = ARGUMENT; 
			var result = nilnul.win.prog_.git.run._ResultX1._Result_assumeAddress(
				module
				,
				 arg  /* git config --global core.quotePath false
												must be set
										*/
				, git
			);
			if (result.beErr)
			{
				throw new Exception(
					$"git {arg} @ {module}:cod: {result.exitCode}; err: {result.err}."
				);
			}

			return 	nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(result.msg);

		}


	}
}
