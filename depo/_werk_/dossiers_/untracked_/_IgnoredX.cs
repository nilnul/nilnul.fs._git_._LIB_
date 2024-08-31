using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_.untracked_
{
	/// <summary>
	/// </summary>
	static public class _IgnoredX
	{
		static public os.proc_.finished._result.CodMsgErr _Result_0depo(string gitTop, nilnul.os.prog_.Git git = null)
		{
			var result = nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(   
				gitTop, "ls-files -io --exclude-standard" //Standard ignore rules are not automatically activated; therefore, at least one of the --exclude* options is required.
				,
				git
			);
			return result;


		}
	}
}
