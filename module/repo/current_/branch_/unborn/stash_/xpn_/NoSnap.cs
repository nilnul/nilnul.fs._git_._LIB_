using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.current_.branch_.unborn.stash_.xpn_
{
	/// <summary>
	/// when run on a branch, such as master, without any commits, for example, when on a just-initialized module, we got:
	///		You do not have the initial commit yet
	///		
	/// </summary>
	public class NoSnap
		:
		Xpn
	{
		public const string ERR = "You do not have the initial commit yet";
		/// <summary>
		/// code of description
		/// </summary>
		public const int COD = 1;
		public NoSnap()
		{
		}

		public NoSnap(string message) : base(message)
		{
		}

		public NoSnap(string message, Exception inner) : base(message, inner)
		{
		}

		protected NoSnap(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
