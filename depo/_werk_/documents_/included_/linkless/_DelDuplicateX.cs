using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.documents_.included_.linkless
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="nilnul.fs.git.depo._werk_.documents_."/>
	/// alias:
	///		dedup
	static public class _DelDuplicateX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Dedup_0depo(
			string folder

			,
			TraceSource log

		)
		{

			nilnul.fs.files.dedup_.inSym_._TraceSrcX._Void(
				nilnul.fs.git.depo._werk_.documents_.included_._LinklessX._Document9infoEs_0depo(folder)
				.Select(x=>x.info.FullName)
				//.Where(

				//	f=>
				//	! ((string[])[".txt",".cs",".aspx",".ashx"]).Contains( System.IO.Path.GetExtension(f) )
				//	/// or whitelist
				//)			/// for code, we may copy that for revising
				.ToArray()
				 /// the most underneath iteration would be executed; but the upheld ones might be iterated one by one on demand. As we are going to change, let's materialze it.
				, log

			);

		}

	}
}
