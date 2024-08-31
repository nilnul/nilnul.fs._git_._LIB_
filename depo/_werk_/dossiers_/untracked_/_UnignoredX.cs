using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_.untracked_
{

	/// <summary>
	/// For “untracked and unignored”:
	/// git ls-files --exclude-standard --others
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		included_. untracked.
	///		untracked_.unignored
	static public class _UnignoredX
	{
		private const string ARGUMENT = "ls-files -o --exclude-standard";

		static public os.proc_.finished._result.CodMsgErr _Result_0depo(string gitTop, nilnul.os.prog_.Git git = null)
		{
			var result = nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(    //note: errCode is 1.
				gitTop,
				ARGUMENT // -o
				, git
			);
			return result;


		}

		static public IEnumerable<string> _GetDossiers_0depo(
			string depo
			,
			nilnul.os.prog_.Git git = null
		)
		{
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
					depo
					,

				ARGUMENT // -o

					,
					git
				)
			);
		}
	}
}
