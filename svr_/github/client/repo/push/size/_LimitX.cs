using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.client.repo.push.size
{
	/// <summary>
	/// fatal: pack exceeds maximum allowed size (2.00 GiB)
	/// fatal: sha1 file '<stdout>' write error: Broken pipe
	/// error: remote unpack failed: index-pack abnormal exit
	/// </summary>
	static public class _LimitX
	{
		/*
		 File 7.mp4 is 325.35 MB; this exceeds GitHub's file size limit of 100.00 MB
remote: error: GH001: Large files detected. You may want to try Git Large File Storage - https://git-lfs.github.com.

		 */

		public const int File_Size = 100 * nilnul.num_.radix_.binary_.Mega.INT32;

		/// <summary>
		/// when file exceeds 50M, github would issue a warning as follows:
		/// warning: File 1.mp4 is 78 MB; this is larger than GitHub's recommended maximum file size of 50.00 MB
		/// remote: warning: GH001: Large files detected.You may want to try Git Large File Storage - https://git-lfs.github.com.
		/// </summary>
		public const int File_RECOMMEND_Size_IN_MB = 50;

		/// <summary>
	/// fatal: pack exceeds maximum allowed size (2.00 GiB)
		/// </summary>
		/// <remarks>
		/// int.max= 2^31-1 = 2G -1
		/// </remarks>
		public const int _PUSH_IN_GIGABYTES_PER_MANUAL =			2
			;

		public const long _PUSH_IN_OCTETS_PER_MANUAL =			_PUSH_IN_GIGABYTES_PER_MANUAL * nilnul.num_.radix_.binary_.Giga.LONG
			;

		/// <summary>
		/// per practice, keep the push not above 500Moctets lest some errors, such as those concerning transporting, pop out;
		/// </summary>
		public const int PUSH_IN_MEGABYTES =	500	;

		public const int PUSH_IN_OCTETS =	PUSH_IN_MEGABYTES *	nilnul.num_.radix_.binary_.Mega.INT32;


	}
}
