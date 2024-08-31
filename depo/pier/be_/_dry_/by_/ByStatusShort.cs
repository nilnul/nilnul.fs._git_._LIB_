using nilnul.obj.seq.be_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.pier.be_._dry_.by_
{
	/// <summary>
	/// git status -s
	/// the out put is like <see cref="_ByDryRunX"/>
	/// </summary>
	/// <remarks>
	/// XY ORIG_PATH -> PATH
	/// where ORIG_PATH is where the renamed/copied contents came from. ORIG_PATH is only shown when the entry is renamed or copied.
	/// C = copied (if config option status.renames is set to "copies")
	///</remarks>
	static public class _ByStatusShortX
	{
		static public bool _Be_0depo(string gitTop, nilnul.win.prog_.Git git = null)
		{
			return _Be_0depo(gitTop, (nilnul.os.prog_.Git)git);
		}
		static public bool _Be_0depo(string gitTop)
		{
			return _Be_0depo(gitTop, (nilnul.os.prog_.Git)null);
		}
		static public bool _Be_0depo(string gitTop, nilnul.os.prog_.Git git = null)
		{
			var result = nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(    //note: errCode is 1.
				gitTop
				,
				"status -s -uno"  //-uno   #excluding untracked
				/*
				 per manual, "!!" in result means ignored file;
				per tryout, ignored files are not shown;

							   that is cuz:
			  Ignored files are not listed unless --ignored is used; if it is, ignored files are indicated by !!.

				 */
				,
				git
			);




			if (result.exitCode == 0)
			{
				return _OfTracked(result.msg);


			}

			throw new nilnul.fs._git.ReportErrException(result.err + ";cod:" + result.exitCode);

		}
		static internal bool _OfTracked(string msg) {
				return nilnul.txt.split_._LineX.Line_removeWhite(
													msg
									).All(
										l => (
											l.StartsWith(" ") //space means nonchange in index.
										)
									);

		}

		static public bool Be(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git = null)
		{
			return _Be_0depo(gitTop.en.address.en.ToString(), git);



		}

		public static bool _Be_0depo(DirectoryInfo depo, nilnul.win.prog_.Git git = null)
		{
			return _Be_0depo(depo.FullName, git);

		}

	}
}
