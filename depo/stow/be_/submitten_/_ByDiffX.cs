using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.stow.be_.submitten_
{
	/* 
	 * 
	 git diff --exit-code will return nonzero if there are any changes; git diff --quiet is the same with no output. Since you want to check for the working tree and the index, use

git diff --quiet && git diff --cached --quiet
Or

git diff --quiet HEAD

	or

git diff --no-ext-diff --quiet --exit-code

git diff --no-ext-diff --quiet   #You can omit the --exit-code because it is implied by --quiet
	,where no-ext-diff mean no external diff drivers;
	,where, however, untracked files are accounted for;


		*/
		
	///<summary>
	/// 
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// 
	static class _ByDiffX
	{




	}
}
