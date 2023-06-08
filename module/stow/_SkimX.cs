using nilnul.obj.str;
using System;
using System.Diagnostics;

namespace nilnul.fs.git.module.stow
{
	/// <summary>
	/// ensure the latest work as a snap, and an orphanated snap;
	/// </summary>
	/// alias:
	///		shim
	///		sham
	static public class _SkimX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <param name="_stowNub"></param>
		/// <param name="_skimNub"></param>
		/// <param name="git"></param>
		/// <returns>
		/// the shelf, the snap8orphan
		/// </returns>
		static public (string shelf, bool newlyCreated, string orphan,bool newSkim) _Stow9skim_addressAssumeModule_1stowNub_2skimNub(string m, string _stowNub = "stow",string _skimNub="skim", nilnul.os.prog_.Git git=null)
		{

			var shelf = nilnul.fs.git.module.stow.create._CollapseX._Branch_addressAssumeModule_assumeShelfNub(
				m, _stowNub, out var newlyCreated,git
			);

			var orphan = nilnul.fs.git.module.stow._skim.snap._CollapseX._Branch_addressAssumeModule_assumeShelfNub(
				m, shelf, _skimNub,out var newlyCreatedSkim,git
			);

			return (shelf, newlyCreated, orphan,newlyCreatedSkim);

		}
	}
}
