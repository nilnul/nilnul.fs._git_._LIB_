using nilnul.fs.address_.spear;
using nilnul.fs.git.module._work_.documents_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_
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
		static public IEnumerable<string> _Dossier9submanagedEs_0depo(
			string depo
			,
			nilnul.os.prog_.Git git = null
		)
		{
			return nilnul.fs.git.depo._stow_.destinys_._IncludedX._GetDossiers_0depo(depo, git).Except(
				_werk_.destinys_.nonexist_._TrackedX._Destinies_0depo(depo, git)
			);
		}

		/// <summary>
		/// excluding child depo|repo es.
		/// including symlink folders.
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		static public IEnumerable<string> _Denotions_0depo(
			string depo
			,
			nilnul.os.prog_.Git git = null
		)
		{


			foreach (var item in _Dossier9submanagedEs_0depo(depo,git))
			{
				if (nilnul.txt.be_.fs_.EndWithDirSep.Singleton.be(item))
				{
					/// it has to be a child module.
					///
					if (nilnul.fs.folder.be_.giT_.managed_._TopX.Be_0folder(
						System.IO.Path.Combine(depo, item)

					))
					{
						continue;
					}
					else
					{
						throw new Exception(
							$"{item} in {depo} as a directory shall be a child managed git module."
						);
					}
				}


				yield return item;




			}



		}

		static public IEnumerable<(string denote, string spear)> _Denotion9spearEs_0depo(
			string depo
			,
			nilnul.os.prog_.Git git = null
		)
		{
			return _Denotions_0depo(depo, git).Select(
				d=> (
					d, System.IO.Path.Combine(depo,d)
				)
			);
		}





	}
}
