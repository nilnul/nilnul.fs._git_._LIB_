using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.url_.push
{
	class Drop
	{
		/*
git remote set-url --add --push [remote] [original repo URL]
git remote set-url --add --push [remote] [second repo URL]

git config –add remote.all.url  http://domain.com/repo.git
git config –add remote.all.url  ssh://user@host/repos/repo.git

[remote "origin"]
	url = git@git.hyperlane.co:team/company/project.git
	fetch = +refs/heads/*:refs/remotes/origin/*
	pushurl = git@git.hyperlane.co:team/company/project.git
	pushurl = git@github.com:company/project.git


		git remote set-url --delete origin git@github.com:company/project.git

also --push parameter should be specified while deleting url, if that url was set using --push parameter

git remote set-url --delete --push origin git@github.com:company/project.git

		 */
	}
}
