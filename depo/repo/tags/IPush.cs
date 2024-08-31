using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.tags
{
	/// <summary>
	/// git push --tags
	///		,discouraged in that people continue to push the old bad tags they have locally every time they want to push a new tag, and old tags cannot be cleaned for ever;
	/// </summary>
	/// <remarks>
	/// git push --tags 
	/// </remarks>
	class IPush
	{

	}

	static public class _PushX
	{
		static public string _Msg_0depo_1remote(
			string depo
					,
			string remote
					,
			nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,
				$"push --tags {remote}"
				,
				git
			);
		}
	}

}
