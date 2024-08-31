using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_.included_
{

	/// <summary>
	/// <see cref="IChanged"/>;
	/// with reference to stage;
	/// 
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	///
	static public class _ChangedVsPierX
	{
		/// <summary>
		/// untracked - ignored = <see cref="depo._werk_.dossiers_.untracked_.IUnignored"/>
		/// with:
		///		<see cref="depo._werk_.dossiers_.tracked_.IRevised"/>
		/// </summary>
		/// <remarks>
		/// this will list child manageds, such as: msagl(!Bak/
		///		,note the "/" at the end.
		/// </remarks>
		public const string ARGUMENT = "ls-files -om --exclude-standard";

		/// <summary>
		/// note that symlink would be listed 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <returns>
		///
		/// </returns>
		
		static public IEnumerable<string> Document0symlinkEs(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var arg = ARGUMENT; //o:inserted; m: downgraded(modified0removed)

			var result =nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress
				(
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

			foreach (var item in nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(result.msg))
			{
				if (nilnul.txt.be_.fs_.EndWithDirSep.Singleton.be(item) )
				{
					/// it has to be a child module.
					///
					if (nilnul.fs.folder.be_.giT_.managed_._TopX.Be_0folder(
						System.IO.Path.Combine(module, item)

					))
					{
						continue;
					}
					else
					{
						throw new Exception(
							$"{item} in {module} as a directory shall be a child managed git module."
						);
					}
				}
				
				yield return item;

			}

			//return 	nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(result.msg);

		}




	}
}
