using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.dossier._touched
{
	/// <summary>
	/// 
	/// </summary>
	internal enum Li_
	{
		Unchanged
			,
		/// <summary>
		/// marked for delete from stage
		/// </summary>
		Devoid

			,
		/// <summary>
		/// show status. but not entry of <see cref="depo.pier"/>
		/// </summary>
		//Untracked
	}
}
