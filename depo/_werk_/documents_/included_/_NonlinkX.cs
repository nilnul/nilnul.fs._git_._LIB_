using nilnul.fs.address_.spear;
using nilnul.fs.file;
using nilnul.fs.file.be;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.documents_.included_
{
	/// <summary>
	/// as in git, folder, often referring to a child git <see cref="fs.git.IManaged"/>, is regarded as link, so here this is in fact nonlinkFiles;
	/// </summary>
	static public class _NonlinkX
	{
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <exception cref="documents_.upsert_.xpn_.BeyondQuotaException"
		static public IEnumerable<(FileInfo t, long Length)> _Info9sizeEs_0depo(
			string module,  nilnul.win.prog_.Git git=null
		) {
			return nilnul.fs.git.depo._werk_.documents_._IncludedX._Document9infoEs_0depo(module, git).Where(
				p => 		nilnul.fs.file.be_.Nonlink.Singleton.Be(p.info) // if its linked file: the size is disregarded, and we wouldnot split it.
			).Select(
				 t => (
					t.info
					,
					t.info.Length
				)
			);
		}

		static public IEnumerable<(string document,FileInfo info, long size)> _Document9info9sizeEs_0depo(
			string module,  nilnul.win.prog_.Git git=null
		) {
			return nilnul.fs.git.depo._werk_.documents_._IncludedX._Document9infoEs_0depo(module, git).Where(
				p => 		nilnul.fs.file.be_.Nonlink.Singleton.Be(p.info) // if its linked file: the size is disregarded, and we wouldnot split it.
			).Select(
				 t => (
					t.document,
					t.info
					,
					t.info.Length
				)
			);
		}

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