using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.gc_
{
	internal class _AutoX
	{
		static public string _Msg_0depo(
			string depo, nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,

				$"gc {
					"--auto"		/// With this option, git gc checks whether any housekeeping is required; if not, it exits without performing any work. Some git commands run git gc --auto after performing operations that could create many loose objects.
				}"

				, git
			);
		}

	}
}
