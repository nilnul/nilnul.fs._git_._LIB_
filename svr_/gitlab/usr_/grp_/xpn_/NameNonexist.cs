using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.usr_.grp_.xpn_
{

	[Serializable]
	public class NameNonexistException : Exception
		,
		IXpn
	{

		public NameNonexistException() { }
		public NameNonexistException(string message) : base(message) { }
		public NameNonexistException(string message, Exception inner) : base(message, inner) { }
		protected NameNonexistException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		static public NameNonexistException OfGrpName(string grpName) {

			return new NameNonexistException($"{grpName} doesnot exist or not viewable to you.");
		}
	}

}
