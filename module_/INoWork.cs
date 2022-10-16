using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module_
{
	/// <summary>
	/// if the work is empty, that is, only the ".git" dir exists, then the module shall be dealt as if it's a <see cref="fs.git.repo_.IBare"/>, but note, there might be uncommited indexes, which we can stach to a tmp commit to bak up.
	/// </summary>
	interface INoWork
	{
	}
}
