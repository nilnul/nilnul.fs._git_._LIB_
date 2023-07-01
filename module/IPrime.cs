using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// preparing our repo before interacting(pump) with remote svrs.
	/// </summary>
	/// alias:
	///		prep
	///			before distribute
	///		ready
	///			set, before remote or redistribute
	///		prime
	///			before pump
	///		integrated
	///			before distributing.
	class IPrime
	{
	}

	///github.blog/2020-07-27-highlights-from-git-2-28/
	/// <summary>
	/// Git 2.28 now warns you of this case (specifically, when pull.rebase is unset, and you didn’t explicitly specify --[no-]rebase as an argument to git pull).
	/// </summary>
	interface IPull { }
}
