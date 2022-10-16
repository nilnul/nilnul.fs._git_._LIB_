using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.stage.act_
{
	/// <summary>
	/// git reset [--mixed] HEAD~
	/// 
	/// is equiv to:
	///		git reset --soft HEAD~
	///		and
	///		update stage with the HEAD~ commit
	/// </summary>
	class MoveStageBackWithBranch
	{
	}
}
