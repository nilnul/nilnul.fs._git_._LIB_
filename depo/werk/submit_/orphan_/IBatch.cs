using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.werk.submit_.orphan_
{
	/// todo: bak in batches; <see cref="depo.stow.submits_.IHotBatching"/>
	/// <summary>
	/// if we commit in one batch, that batch might be beyond the limit imposed by some servers.
	/// Hence, we commit to a str of snaps, such that each time, the snap's size is not beyond the limit;
	/// </summary>
	internal class IBatch
	{
		/// todo: see the tested method.
	}
}
