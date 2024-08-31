using nilnul.fs.git.repo._branch.name_._vered;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.history.snaps.be_
{
	/// <summary>
	///  there is only one snap in the history;
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	///		solo.
	///		lone;
	///		lonely
	///		alone
	///		only
	/// 
	static public class _NonPluralX
	{

		static public bool _IsNonPlural_0moduleAddress_1branch(
			string _addressAssumeModule
			,
			string _assumeBranch
			,
			nilnul.os.prog_.Git git = null
		)
		{

			return !plural_._ByLogX._IsPlural_0moduleAddress_1branch(_addressAssumeModule,_assumeBranch,git);

		}

		public static bool IsNonPlural(ModuleI module, Key branch, Git git)
		{
			return _IsNonPlural_0moduleAddress_1branch(module.top1.en.address.en.ToString(),branch.en,git);
		}

		public static bool _IsNonPlural_1branch(ModuleI module, string _branch, Git git)
		{
			return _IsNonPlural_0moduleAddress_1branch(module.top1.en.address.en.ToString(),_branch,git);

		}
	}
}