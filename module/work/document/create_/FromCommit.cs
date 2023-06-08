using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.document.create_
{
	internal class FromCommit
	{
		/*
		  
		 git show HEAD^:./main.cpp > old_main.cpp

			note: the "./" before "main.cpp", otherwise <path> here is FULL path relative to the top directory of your project;

		 */

		/*
		 git cat-file blob HEAD^:main.cpp > old_main.cpp

		 */
	}
}
