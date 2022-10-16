using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repo.push.size
{
	/// <summary>
	/// the minimu of the limits of all svrs such that it can be accomodated by every server.
	/// </summary>
	class Limit
	{
		/// <summary>
		/// in bytes.
		/// 300MB.
		/// </summary>
		int eachFile = Math.Min(
			svr_.github.client.repo.push.size._LimitX.File_Size
			,

svr_.github.client.repo.push.size._LimitX.File_RECOMMEND_Size_IN_MB * nilnul.num_.radix_.binary_.Mega.INT32
			);

		/// <summary>
		/// 2g
		/// </summary>
		int eachPush = Math.Min(
			svr_.github.client.repo.push.size._LimitX.PUSH_IN_GIGABYTES
			,
			svr_.azure.client.repo.push.size._LimitX.PUSH_IN_GIGABYTES
		);

	}
}
