using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	/// <summary>
	/*
	shallow clone 
Mostly a synonym to shallow repository but the phrase makes it more explicit that it was created by running git clone --depth=... command. 
shallow repository 
A shallow repository has an incomplete history some of whose commits have parents cauterized away (in other words, nilnul.win.prog_.Git is told to pretend that these commits do not have the parents, even though they are recorded in the commit object). This is sometimes useful when you are interested only in the recent history of a project even though the real history recorded in the upstream is much larger. A shallow repository is created by giving the --depth option to git-clone(1), and its history can be later deepened with git-fetch(1). 

	 */
	/// </summary>
	interface ShallowCopyI
	{
	}
}
