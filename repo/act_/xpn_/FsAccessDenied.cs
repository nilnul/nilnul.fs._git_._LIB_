using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.act_.xpn_
{

	/// <summary>
	/// cannot rename the file such as abc.lock, cuz due to, say, the target name is occupied;
	/// cannot create a file due to, say, the target name is occupied;
	/// </summary>
	[Serializable]
	public class FsAccessDenied: Exception
		,IXpn
	{
		public FsAccessDenied() { }
		public FsAccessDenied(string message) : base(message) { }
		public FsAccessDenied(string message, Exception inner) : base(message, inner) { }
		protected FsAccessDenied(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
