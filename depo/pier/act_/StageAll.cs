using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.stage.act_
{
	/// <summary>
	/// 
	/// </summary>
	class StageAll
	{
		/*git add -A*/
		void ExeWholeWork() { }
		/* git add -A .          #  note the dot.*/
		void ExeDirectory() { }
		/*
		 git add .   #stages new and modified, without deleted
			 */
		void ExeDirectory_newModified_noDeleted() { }
		/*
		 git add -u
			 */
		void ExeWholeWork_modifiedDeleted_noNew() { }

		/* git add -u .        # note: the dot       */
		void ExeDirectory_noNew() { }

		/*git add --ignore-removal .           # note the dot */
		void ExeDirecotry_noDeleted() { }
	}
}
