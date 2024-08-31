using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap._vw_
{
	internal class IBy
	{
		///
		///git cat-file -p commit_id
		///
		/// For the full details:
		/// git log 4c7036e807fa18a3e21a5182983c7c0f05c5936e^ -1
		///
		/// git log 4c7036e807fa18a3e21a5182983c7c0f05c5936e^ -1 --pretty=%H
		///
		/// 
		///git rev-list --parents -n 1 <commit-ish>
		///
		/// 
		///git rev-parse $commit^1
		///
		///git rev-parse <commit-ish>^@
		///
		/// git show <SHA>^
		///git show -p <commit-ish>^{} --pretty=%P --no-patch
		///git show --pretty=%P <commit>
		///
		///

	}
}
