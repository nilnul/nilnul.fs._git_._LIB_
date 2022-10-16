using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.branch_.noncurrent.fetch_
{
	/// <summary>
	/// if a '+' is prepended, that means non fastford merge is allowed. But it will fail if there are conflicts, as conflicts can only stay in the workspace.
	/// eg:
	/// in cfg:
	///		[remote "github-n"]
	///		url = https://w@github.com/nilnul/_nilnul_._LINQ_.git
	///		fetch = +refs/heads/*:refs/remotes/github-n/*
	/// </summary>
	class NonFast1forward
	{

	}
}
