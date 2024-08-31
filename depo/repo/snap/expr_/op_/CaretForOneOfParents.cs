using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap.of_
{
	/// <summary>
	/// eg:
	///		snap1^2
	///			the 2nd of the parents
	///		snap1^
	///			where "^" is the same as ^1
	///	eg:
	///		HEAD^
	///		HEAD^1
	///		HEAD^2
	///	note: in windows shell, you may need "^^" as an escape for "^"
	///		HEAD^^
	///			,the first parent of the first parent of HEAD. This would be the same as HEAD~2
	/// </summary>
	///
	/// todo:
	///		commitish^{}
	internal class CaretForOneOfParents
	{
	}
}
