using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._setting._ignore
{
	class Pattern
	{

		//		/*
		//		 Before version 1.8.2, ** didn't have any special meaning in the .gitignore. As of 1.8.2 git supports ** to mean zero or more sub-directories (see release notes).
		//		 * The patterns in .gitignore and .gitattributes files can have **/, 
		//    as a pattern that matches 0 or more levels of subdirectory.
		//    E.g. "foo/** /bar" matches "bar" in "foo" itself or in a 
		//    subdirectory of "foo". 
		//		 */


		//A leading slash indicates that the ignore entry is only to be valid with respect to the directory in which the .gitignore file resides. Specifying *.o would ignore all .o files in this directory and all subdirs, while /*.o would just ignore them in that dir, while again, /foo/*.o would only ignore them in /foo/*.o.

	}
}
