using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._push
{
	/*
	 arning: You did not specify any refspecs to push, and the current remote
warning: has not configured any push refspecs. The default action in this
warning: case is to push all matching refspecs, that is, all branches
warning: that exist both locally and remotely will be updated.  This may
warning: not necessarily be what you want to happen.
warning:
warning: You can specify what action you want to take in this case, and
warning: avoid seeing this message again, by configuring 'push.default' to:
warning:   'nothing'  : Do not push anything
warning:   'matching' : Push all matching branches (default)
warning:   'tracking' : Push the current branch to whatever it is tracking
warning:   'current'  : Push the current branch

		You could use (from git config):
 git config --add push.default current
to specify what you want to push by default.
or:
 git config --global push.default matching
if you have many repositories.
current: push the current branch to a branch of the same name.
		 */
	class Cfg
	{
	}
}
