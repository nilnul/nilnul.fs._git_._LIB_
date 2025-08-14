using System;
using System.Linq;

namespace nilnul.fs.git.svrs_._aagg
{
	/// <summary>
	/// 
	/// </summary>
	public class LimitX
	{
		

		static public long BlobInBytes {
			get {
				

				return (long) LimitInMbyteX.Blob * nilnul.num_.radix_.binary_.Mega.INT32;


			}

		}
		static public long PushInBytes {
			get {
				

				return (long) LimitInMbyteX.Push * nilnul.num_.radix_.binary_.Mega.INT32;


			}

		}





	}
}
