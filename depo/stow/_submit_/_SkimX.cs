using nilnul.obj.str;
using System;
using System.Diagnostics;

namespace nilnul.fs.git.module.stow
{
	/// <summary>
	/// commit index, and also:
	/// ensure the latest work as a snap, and an orphanated snap;
	/// </summary>
	/// alias:
	///		shim
	///		sham
	///		submit
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
		static public (string stow, bool newlyStow, string werk,bool newlyWerk) _Stow9skim_addressAssumeModule_1stowNub_2skimNub(string m, string _stowNub = "stow",string _skimNub="skim", nilnul.os.prog_.Git git=null)
		{

			var shelf = nilnul.fs.git.module.stow.create._CollapseX._Branch_addressAssumeModule_assumeShelfNub(
				m, _stowNub, out var newlyCreated,git
			);

			var orphan = nilnul.fs.git.module.work.commit_.orphan._CollapseX._Branch_addressAssumeModule_assumeShelfNub(
				m, shelf, _skimNub,out var newlyCreatedSkim,git
			);

			return (shelf, newlyCreated, orphan,newlyCreatedSkim);

		}
	}
}
