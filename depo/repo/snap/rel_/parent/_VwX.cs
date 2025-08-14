using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.rel_.parent
{
	/// <summary>
	/// The output is given in reverse chronological order by default.
	/// </summary>
	static public class _VwX
	{

		/// <summary>
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="snapId"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public string _Msg_0depo(
			string depo,  nilnul.os.prog_.Git git = default
		)
		{
			return nilnul.fs.git.repo.snap.rel_.parent._vw_.by_._LogX._Msg_0module(depo, git);

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,

				$"log --all --pretty=%H:%P" /*
				                           
				                          
				                          --all
Pretend as if all the refs in refs/, along with HEAD, are listed on the command line as <commit>. 
				                          %H: full hash
				%P parents separated by space


				                          
				                          */

				, git
			);
		}

		static public IEnumerable<(string snap, string[] parents)> _Parents_0depo(
			string depo, nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty (
				_Msg_0depo(depo,git)??""
			).Select(
				l => {
					var split =l.Split(':');
					var t = (
						snap:
						split[0].Trim()
						,
						parents:
						split[1].Split([' '], StringSplitOptions.RemoveEmptyEntries).ToArray()
					);
					return t;
				}
			);
		}



	}
}
