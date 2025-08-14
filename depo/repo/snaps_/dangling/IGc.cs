using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snaps_.dangling
{
	/*
	 dangling commits (and other unreachable objects) are removed by
		git prune
	when they're loose objects, or by a more complex pathway (repack-and-prune, mainly) when packed (but there are still more caveats here). The git gc command gives loose objects a grace period, default 14 days, before they get pruned, because Git commands that were started but haven't yet finished could be creating these loose objects right now. 14 days gives them time to finish up and get those objects into the graph.
	 So, first check if these are loose objects. If not, dig further into the pack stuff (which means looking up the .keep stuff as well). If so, check the timestamps on the loose object files, or use a gc or prune option that forces immediate pruning.*/
	internal class IGc
	{
	}
}
