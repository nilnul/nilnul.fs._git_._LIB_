﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap_.current.copy_
{
	/*
	 https://stackoverflow.com/questions/51814990/git-how-do-you-replace-your-current-working-directory-with-a-previous-commit-wi


	To create a new commit, restoring the content of an old commit, you can:

First, mark the current HEAD of your branch (assuming master here): we will need to move that HEAD without modifying master, so let's create a new temporary branch called 'tmp' where master is.

git checkout -b tmp

(yes, that is against the "without branching" of the question, but you will delete that tmp branch soon)




move back tmp HEAD to where master is, but without modifying the index or the working tree (which are representing what we need for a new commit)

git reset --soft master


	///<see cref="work._Commit2branchX" />

make a new commit, on top of master/tmp HEAD, which represents the right content (the old commit).

git commit -m "new commit, image of an old one"

Finally, force master to be where tmp is: one new commit later.

git branch -M tmp master
 Note also that git branch -M tmp master leaves you on master and deletes tmp
	 */
	/// <summary>
	/// 
	/// </summary>
	public interface IToBranch
	{
	}
}
