using nilnul.fs.address_.spear;
using nilnul.fs.file;
using nilnul.fs.file.be;
using nilnul.obj.str;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.documents_.included_
{
	/// <summary>
	/// as in git, folder, often referring to a child git <see cref="fs.git.IManaged"/>, is regarded as link, so here this is in fact nonlinkFiles;
	/// </summary>
	/// <remarks>
	/// excluding any unincluded files like the "packages/" which are compiled files disregarded by git the source code manager.
	/// </remarks>
	/// alias:
	///		linkless
	///		nonlink
	static public class _LinklessX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEnumerable<(string document, FileInfo info)> _Document9infoEs_0depo(string module, Git git=null)
		{
			return nilnul.fs.git.depo._werk_.documents_._IncludedX._Document9infoEs_0depo(module, git).Where(
				p => nilnul.fs.folder.destiny.be_._UnReparseX._Be_0folder_1destiny(
					module, p.document
				)
			//.file.be_.Nonlink.Singleton.Be(p.info)
			// if its linked file: the size is disregarded, and we wouldnot split it.
			);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <exception cref="documents_.upsert_.xpn_.BeyondQuotaException"/>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<(FileInfo t, long Length)> _Info9sizeEs_0depo(
			string module,  nilnul.win.prog_.Git git=null
		)
		{
			return _Document9infoEs_0depo(module, git).Select(
				 t => (
					t.info
					,
					t.info.Length
				)
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<(string document,FileInfo info, long size)> _Document9info9sizeEs_0depo(
			string module,  nilnul.win.prog_.Git git=null
		) {
			return _Document9infoEs_0depo(module, git).Select(
				 t => (
					t.document,
					t.info
					,
					t.info.Length
				)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<(string document, nilnul.fs.address_.Spear spear, long size)> _Document9spear9sizeEs_0depo(
			string module,  nilnul.win.prog_.Git git = null
		)
		{
			return _Document9info9sizeEs_0depo(module,git).Select(
				x=>(
				x.document
				, new nilnul.fs.address_.Spear(  x.info )
				,x.size
				)
			);
		}
	}
}