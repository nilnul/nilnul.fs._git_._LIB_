using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap.document.checkout_
{
	/// <summary>
	/// <see cref="git.module.work.document.create_.FromCommit"/>
	/// </summary>
	internal class AsNew
	{
		/*stackoverflow.com/questions/888414/git-checkout-older-revision-of-a-file-under-a-new-name
		 * 

 git show HEAD^:./main.cpp > old_main.cpp

	note: the "./" before "main.cpp", otherwise <path> here is FULL path relative to the top directory of your project;

 */

		/*You can get in most cases the same output using low-level (plumbing) git cat-file command:
		 git cat-file blob HEAD^:main.cpp > old_main.cpp

		 */

		/*
		 git show 4c274dd91dc:higgs/Higgs.xcodeproj/project.pbxproj > old_project.pbxproj
		 */

		/*
		 git show somebranch:./afile.cs  afile123.cs
		 */

	}
}
