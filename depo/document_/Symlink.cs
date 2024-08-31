using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.document_
{
	/// <summary>
	/// 
	/// </summary>
	class Symlink
	{
	}
	/*


git just stores the contents of the link (i.e. the path of the file system object that it links to) in a 'blob' just like it would for a normal file. It then stores the name, mode and type (including the fact that it is a symlink) in the tree object that represents its containing directory.

When you checkout a tree containing the link, it restores the object as a symlink regardless of whether the target file system object exists or not.

If you delete the file that the symlink references it doesn't affect the git-controlled symlink in any way. You will have a dangling reference. It is up to the user to either remove or change the link to point to something valid if needed.


shareedit
 

answered Jun 5 '09 at 7:01 



 
Charles Bailey 
445k65519583 
 
 
 


251     
 
BTW. If you are on filesystem like FAT that does not support symbolic links, and your repository uses them, you can set core.symlinks configuration variable to false, and symlinks would be checked out as small plain text files that contain the link text. 
 

	the way to avoid broken links in a git repo is to always use relative paths when making the symlinks, using ../.. as needed

	The 120000 is the file mode. It would be something like 100644 for a regular file and is the mode special for links. From man git-config:


core.symlinks

If false, symbolic links are checked out as small plain files that contain the link text. git-update-index(1) and git-add(1) will not change the recorded type to regular file. 

	Use git cat-file -p to pretty-print the contents:
$ git cat-file -p 1596f9db1
/Path/referenced/by/symlink


So, that's what nilnul.win.prog_.Git does to a symbolic link: when you git checkout the symbolic link, you either get a text file with a reference to a full filesystem path, or a symlink, depending on configuration. The data referenced by the symlink is not stored in the repository.

	

8

down vote
 

Git stores the symlink, just like any other file in its version control - except for a symlink it would only store the information about the path it is symlinking to, and the file type as symlink instead of a regular file.

If the symlink points to a directory, git does not store the contents under the symlinked directory.

So there should be no harm in storing symlinks versioned under git for your case.

One more thing you need to be aware of with symlinks is that, git would only recreate the symlinks on a fresh clone, not the file or directory it is pointing at. There are chances that the symlinked path would be non-existent (say when using absolute paths).
 

	 */
}
