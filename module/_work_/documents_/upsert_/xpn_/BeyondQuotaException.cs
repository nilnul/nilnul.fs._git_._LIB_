using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_.upsert_.xpn_
{

	/// <summary>
	/// if the files to upsert are beyond quota set by some svrs
	/// </summary>
	[Serializable]
	public class BeyondQuotaException : Exception
		,
		documents_.upsert_.IXpn
	{
		public BeyondQuotaException() { }
		public BeyondQuotaException(string message) : base(message) { }
		public BeyondQuotaException(string message, Exception inner) : base(message, inner) { }
		protected BeyondQuotaException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
