using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stash_
{

	[Serializable]
	public class Xpn : Exception
	{
		public Xpn() { }
		public Xpn(string message) : base(message) { }
		public Xpn(string message, Exception inner) : base(message, inner) { }
		protected Xpn(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
