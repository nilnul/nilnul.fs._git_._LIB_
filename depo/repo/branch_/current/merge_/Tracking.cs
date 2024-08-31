using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current.merge_
{
	static public class _TrackingX
	{
		static public void Tracking(nilnul.fs.Folder _module, string remote, string branch) {
			Tracking(nilnul.win.prog_.Git.StaticInstance,_module, remote,branch);

		}

		static public void Tracking(nilnul.win.prog_.Git git,nilnul.fs.Folder _module, string remote, string branch) {
			_MergeX.Merge(git, _module, $"remotes/{remote}/{branch}");

		}

	}
}
