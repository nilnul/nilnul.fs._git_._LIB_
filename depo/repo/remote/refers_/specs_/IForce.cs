using nilnul.fs.git.module.cfg;
using nilnul.web.Properties.settings._url;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.remote.refers_.specs_
{
	///
	/// The + tells Git to update the reference even if it isn’t a fast-forward.
	/// ^ git-scm.com/book/en/v2/Git-Internals-The-Refspec
	///
	/// If you want Git instead to pull down only the master branch each time, and not every other branch on the remote server, you can change the fetch line to refer to that branch only:
	///		fetch = +refs/heads/master:refs/remotes/origin/master
	///
	/// You can also specify multiple refspecs. On the command line, you can pull down several branches like so:
	/// $ git fetch origin master:refs/remotes/origin/mymaster \
	/// topic:refs/remotes/origin/topic
	///
	/// From git @github.com:schacon/simplegit
	/// ! [rejected] master     -> origin/mymaster  (non fast forward)
	/// *[new branch] topic      -> origin/topic
	/// In this case, the master branch pull was rejected because it wasn’t listed as a fast-forward reference. You can override that by specifying the + in front of the refspec.
	/// 
	/// You can also specify multiple refspecs for fetching in your configuration file. If you want to always fetch the master and experiment branches from the origin remote, add two lines:
	/// [remote "origin"]
	/// url = https://github.com/schacon/simplegit-progit
	/// fetch = +refs/heads/master:refs/remotes/origin/master
	/// fetch = +refs / heads / experiment:refs/remotes/origin/experiment
	///
	/// Since Git 2.6.0 you can use partial globs in the pattern to match multiple branches, so this works:
	/// fetch = +refs / heads / qa *:refs/remotes/origin/qa*
	///
	/// You can also use the refspec to delete references from the remote server by running something like this:
	/// $ git push origin :topic
	/// Because the refspec is <src>:<dst>, by leaving off the<src> part, this basically says to make the topic branch on the remote nothing, which deletes it.
	/// Or you can use the newer syntax (available since Git v1.7.0):
	/// $ git push origin --delete topic
	/// 
	/// <summary>
	/// eg:
	/// 
	/// +refs/heads/*:refs/remotes/Github/*
	/// ,where '+' means forceful, not only fast-forward.
	/// </summary>
	/// <!---->
	internal class IForce
	{
	}
}
