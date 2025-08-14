using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.module.cfg.remote.urls
{
	public class AddPushUrl
	{

		/*
		 git remote set-url origin --push --add user1@repo1
git remote set-url origin --push --add user2@repo2

		 */

		/*
		 Junio C. Hamano, the Git maintainer, explained it's how it was designed. Doing 
		 
		git remote set-url --add --push <remote_name> <url>
		
		adds a pushurl for a given remote, which overrides the default URL for pushes. However, you may add multiple pushurls for a given remote, which then allows you to push to multiple remotes using a single git push. You can verify this behavior below:
$ git clone git://original/repo.git
$ git remote -v
origin  git://original/repo.git (fetch)
origin  git://original/repo.git (push)
$ git config -l | grep '^remote\.'
remote.origin.url=git://original/repo.git
remote.origin.fetch=+refs/heads/*:refs/remotes/origin/*


		 */
	}
}
