using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work_.xpn_.size_
{
	/// <summary>
	/// some svr sets a limit of the total size;
	/// 
	/// </summary>
	[Serializable]
	public class TooLargeException : Exception
	{
		/// <summary>
		/// 0.9 of the strict size to allow some misc files such as .settings or symlinks;
		/// </summary>
		public static int SafeSizeInMoctets = (int) (
			svrs_._aagg.LimitInMbyteX.Repo *
				0.9	// we allow some misc files to be added;
		);
		public static long SafeSizeInOctets =( (long)SafeSizeInMoctets )
			*
			nilnul.num_.radix_.binary_.Mega.INT32
			//1048576
		;


		public TooLargeException() { }
		public TooLargeException(string message) : base(message) { }
		public TooLargeException(string message, Exception inner) : base(message, inner) { }
		protected TooLargeException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
