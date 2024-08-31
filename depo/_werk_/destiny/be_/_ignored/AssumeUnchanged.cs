using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore_
{
	/*
	Ignore changes to committed files
Temporarily ignore changes
During development it's convenient to stop tracking file changes to a file committed into your git repo. This is very convenient when customizing settings or configuration files that are part of your project source for your own work environment.

> git update-index --assume-unchanged <file>
Resume tracking files with:

> git update-index --no-assume-unchanged <file>
		 */
	class AssumeUnchanged
	{
	}
}
