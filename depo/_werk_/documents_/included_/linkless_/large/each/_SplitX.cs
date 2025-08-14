using nilnul.fs.address_;
using nilnul.fs.address_.spear;
using nilnul.fs.file;
using nilnul.obj.str;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.documents_.included_.nonlink_.large.each
{
	/// <summary>
	/// 
	/// </summary>
	static public class _SplitX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <exception cref="documents_.upsert_.xpn_.BeyondQuotaException"/>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _SplitLarge_0depo(
			string module, nilnul.win.prog_.Git git=null
		) {

			_LargeX._Info9sizeEs_0depo(module,out var threshold,git).Each(
				t=>
				nilnul.fs.file.split_._ThinToeX._Folder0nul_Split1drop_assumeFile_assumePositive(
					t.Item1
					,
					threshold
				)
			);

			/// todo: do we need to update the index? as some in index might be removed from werk due to the split; some in index might be added or updated but removed from werk.
			/// , see git update-index

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  void _SplitLarge_0larges( IEnumerable< Spear> larges,long threshold, Git git)
		{
			larges.Each(
				t=>
				nilnul.fs.file.split_._ThinToeX._Folder0nul_Split1drop_assumeFile_assumePositive(
					t.ToString()
					,
					threshold
				)
			);

			/// todo: do we need to update the index? as some in index might be removed from werk due to the split; some in index might be added or updated but removed from werk.
			/// , see git update-index

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  void _SplitLarge_0larges( IEnumerable< FileInfo> larges,long threshold, Git git)
		{
			larges.Each(
				t=>
				nilnul.fs.file.split_._ThinToeX._Folder0nul_Split1drop_assumeFile_assumePositive(
					t.FullName
					,
					threshold
				)
			);

			/// todo: do we need to update the index? as some in index might be removed from werk due to the split; some in index might be added or updated but removed from werk.
			/// , see git update-index

		}

	}
}
