using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.remote._push
{
	/// <summary>
	/// </summary>
	internal class ICfg
	{
		/// remote:
		/// git config remote.pushdefault svr1
		///
		/// branch:
		///		git config push.default current
		///		, push the current branch.
		///

		/*
		 [remote "publish"] # or whatever it is named
    url = http://some.url/repo1.git
    push = :
    push = +refs/tags/*:refs/tags/*

		#
Meaning it pushes every branch that's already there, plus tags. It does not force push, and it does not push branch that you didn't push manually.


		 */
	}
}
