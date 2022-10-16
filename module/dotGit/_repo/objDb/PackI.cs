using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._repo.objDb
{
	/*
	 To put the loose objects into a pack, just run git repack:

$ git repack
Counting objects: 6020, done.
Delta compression using up to 4 threads.
Compressing objects: 100% (6020/6020), done.
Writing objects: 100% (6020/6020), done.
Total 6020 (delta 4070), reused 0 (delta 0)This creates a single "pack file" in .git/objects/pack/ containing all currently unpacked objects. You can then run

$ git pruneto remove any of the "loose" objects that are now contained in the pack. This will also remove any unreferenced objects (which may be created when, for example, you use git reset to remove a commit). You can verify that the loose objects are gone by looking at the .git/objects directory or by running

$ git count-objects
0 objects, 0 kilobytesAlthough the object files are gone, any commands that refer to those objects will work exactly as they did before.

The git-gc(1) command performs packing, pruning, and more for you, so is normally the only high-level command you need.


		 */
	interface PackI
	{
	}
}
