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
	/// <remarks>
	/// for <see cref="fs.git.depo.stow.bak_.werk8orphan_._AnatomyLargeX"/>, as we bak it in batches on a new branch, hence the size limit is applied on the werk, not on the depo including werk,pier&repo
	/// </remarks>
	[Serializable]
	public class TooLargeException : Exception
	{
		/// <summary>
		/// 0.9 of the strict size to allow some misc files such as .settings;
		/// (current symlinks are already considered as part of depo size)
		/// </summary>
		public static int SafeSizeInMoctets = (int) (
			svrs_._aagg.LimitInMbyteX.Repo *
				0.96	// for 5G, we subtract about 200Mb
						// we allow some misc files to be added;
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
