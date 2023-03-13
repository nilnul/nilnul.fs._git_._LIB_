using nilnul.obj.str;
using System;
using System.Diagnostics;

namespace nilnul.fs.git.module.stow
{
	static public class _SkimX
	{
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
