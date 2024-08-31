using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore_
{
	/*
	Permanently ignore changes to a file
If a file is already tracked by nilnul.win.prog_.Git, adding that file to your .gitignore is not enough to ignore changes to the file. You also need to remove the information about the file from nilnul.win.prog_.Git's index:

These steps will not delete the file from your system. They just tell nilnul.win.prog_.Git to ignore future updates to the file.

Add the file in your .gitignore.

Run the following:

> git rm --cached <file>
Commit the removal of the file and the updated .gitignore to your repo.

		Cleaning Ignored Files
In three steps, you can clean up your repository and make sure your ignored items are indeed ignored:

$ git rm -r --cached .
$ git add .
$ git commit -m "Clean up ignored files"
		 */
	class IgnoreTracked
	{
	}
}
