using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.history.snaps.be_.plural_
{
	static public class _ByRecentsX
	{

		static public bool _IsPlural_0moduleAddress_1branch(
			string _addressAssumeModule
			,
			string _assumeBranch
			,
			nilnul.os.prog_.Git git = null
		)
		{

			var r = snaps_._RecentTwoX._Result_0moduleAddress_1branch(_addressAssumeModule,_assumeBranch,git);

			if (r.beErr)
			{
				throw new Exception( $"when getting recent two snaps of the history for branch:{_assumeBranch}, result:{r.ToString()}");
			}

			//var lines = (r.msg??"").Split( nilnul.character.set_.ascii_.Blank.IN_TXT.ToArray(), StringSplitOptions.RemoveEmptyEntries);
			var lines = nilnul.txt.split_._LineX.Line_removeWhite (r.msg??"");


			return lines.Count() >= 2;


		}
	}
}