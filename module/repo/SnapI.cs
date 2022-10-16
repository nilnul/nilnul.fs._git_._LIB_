using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	/// <summary>
	/// per the index, create a new snap, and move the current branch
	/// </summary>
	public interface SnapI
	{
		/// <summary>
		/// a commit can have zero parent, making it the initial commit.
		/// </summary>
		IEnumerable<SnapI> parents { get; }

	}
}
