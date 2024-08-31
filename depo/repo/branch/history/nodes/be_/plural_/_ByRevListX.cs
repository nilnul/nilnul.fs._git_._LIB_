using nilnul.fs.git.repo._branch.name_._vered;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.history.snaps.be_.plural_
{
	static public class _ByRevListX
	{

		static public bool _IsPlural_0moduleAddress_1branch(
			string _addressAssumeModule
			,
			string _assumeBranch
			,
			nilnul.os.prog_.Git git = null
		)
		{

			var r = nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(
				_addressAssumeModule
				,
				$"rev-list -n 2 --count {_assumeBranch}"
				,
				git
			); // if there is only 0, an error is outputted to the console;

			if (r.beErr)
			{
				throw new Exception( $"when getting recent two snaps of the history for branch:{_assumeBranch}, result:{r.ToString()}");
			}

			var c = nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(r.msg??"" );


			return c>= 2;


		}

		public static bool IsPlural(ModuleI module, Key branch, Git git)
		{
			return _IsPlural_0moduleAddress_1branch(module.top1.en.address.en.ToString(),branch.en,git);
		}

		public static bool _IsPlural_1branch(ModuleI module, string _branch, Git git)
		{
			return _IsPlural_0moduleAddress_1branch(module.top1.en.address.en.ToString(),_branch,git);

		}
	}
}