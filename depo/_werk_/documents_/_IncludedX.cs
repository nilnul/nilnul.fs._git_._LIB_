using nilnul.fs.address_.spear;
using nilnul.fs.git.module._work_.documents_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.documents_
{
	/// git ls-files is defaulted to list pier files; it seems there is no option to list werk files directly. 
	/// <summary>
	/// tracked(even if it's ignored) or unignored;
	/// excluding:
	///		tracked, but not in werk;
	/// </summary>
	/// <remarks>
	/// tracked0unignored
	/// </remarks>
	/// vs:
	///		if a file is removed from the werk, but still in the head snapshort, then the file is still listed in <see cref="fs.git.depo._stow_.destinys_._IncludedX"/>. hence we should remove them here.
	/// 
	/// alias:
	///

	/// todo: correct?
	static public class _IncludedX
	{

		static public IEnumerable<string> _Documents_0depo(
			string depo
			,
			nilnul.os.prog_.Git git=null
		) {


			return dossiers_._IncludedX._Denotions_0depo(depo,git).Where(
			 item=>nilnul.fs.address_.spear.be_.File.Singleton.Be1(
					System.IO.Path.Combine(
						depo
						,
						item
					)
				) // else it's a symlink folder.
			);


			

		}

		static public IEnumerable<(string document,string address)> _Document9addressEs_0depo(
			string depo
			,
			nilnul.os.prog_.Git git=null
		) {

			return dossiers_._IncludedX._Denotion9spearEs_0depo(depo,git).Where(
			 item=>nilnul.fs.address_.spear.be_.File.Singleton.Be1(
					item.spear
				) // else it's a symlink folder.
			);
		}
		static public IEnumerable<(string document,fs.address_.Spear spear)> _Document9spearEs_0depo(
			string depo
			,
			nilnul.os.prog_.Git git=null
		) {

			return _Document9addressEs_0depo(depo,git).Select(
			 item=>(item.document, nilnul.fs.address_.Spear.Parse( item.address) )
			);
		}
		static public IEnumerable<(string document,FileInfo info)> _Document9infoEs_0depo(
			string depo
			,
			nilnul.os.prog_.Git git=null
		) {

			return _Document9addressEs_0depo(depo,git).Select(
			 item=>(item.document, new FileInfo( item.address) )
			);
		}



	}
}
