//using nilnul.fs.git.depo.pier.be_.clean_;
using nilnul.obj.seq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.pier.be_._dry_.by_
{
	/// <summary>
	/// nothing to commit
	/// </summary>
	/// <remarks>
	/// </remarks>
	///

	//[Obsolete(nameof(_ByDiffIndexX) + " is preferred, as the effect of this is opaque to developer at this time and time is needed for further investigation;")]

	[Obsolete(nameof(_ByStatusShortX))]
	static public class _ByDryRunX
	{
		static public bool _Be_0depo(string gitTop, nilnul.win.prog_.Git git = null)
		{
			var result = nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(    //note: errCode is 1.
				gitTop
				,
				"commit --dry-run --short -uno"  //-uno   #excluding untracked
				,
				git
			);

			if (result.exitCode == 1) // there might be untracked files shown;
			/// or:
			///		nothing to commit (create/copy files and use "git add" to track)
			{
				if (
					nilnul.txt.be_.White.Singleton.be(result.err)
				)
				{
					return _ByStatusShortX._OfTracked(result.msg);


				}

			}

			if (result.exitCode == 0)
			{
				return _ByStatusShortX._OfTracked(result.msg);

			}

			throw new nilnul.fs._git.ReportErrException(result.err + ";cod:" + result.exitCode);
			#region excluding untracked
#if false
			static IEnumerable<string> tracked(os.proc_.finished._result.CodMsgErr result)
			{
				return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
													result.msg
									).Where(
										l => !(
											l.StartsWith("??") //eg: ?? file1.ext, which means untracked.
										)
									);
			}


#endif
			#endregion
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
