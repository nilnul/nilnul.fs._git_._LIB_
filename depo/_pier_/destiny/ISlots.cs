using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier_.destiny
{
	/// <summary>
	/// slots
	/// </summary>
	/// vs:
	///		entry means the destiny itself.
	/// 
	internal class ISlots
	{
		/*
		 * 
For every staged file in your work-tree, the index has up to four entries, rather than just one entry. At most three of these are ever actually in use, but there are four slots, which are numbered, 0 through 3.

Slot zero is used for resolved files. When you're working with Git and not doing merges, only slot zero gets used. When you edit a file in the work tree, it has "unstaged changes", and then you git add the file and the changes are written to the repository, updating slot zero; your changes are now "staged".

Slots 1-3 are used for unresolved files. When git merge has to stop with a merge conflict, it leaves slot zero empty, and writes everything to slots 1, 2, and 3. The merge base version of the file is recorded in slot 1, the --ours version is recorded in slot 2, and the --theirs version is recorded in slot 3. These nonzero slot entries are how Git knows that the file is unresolved.

As you resolve files, you git add them, which erases all the slot 1-3 entries and writes a slot-zero, staged-for-commit entry. This is how Git knows the file is resolved and ready for a new commit. (Or, in some cases, you git rm the file, in which case Git writes a special "removed" value to slot zero, again erasing slots 1-3.


		There are a few cases where one of these three slots is also empty. Suppose file new does not exist in the merge base and is added in both ours and theirs. Then :1:new is left empty and :2:new and :3:new record the add/add conflict. Or, suppose file f does exist in the base, is modified in our HEAD branch, and is removed in their branch. Then :1:f records the base file, :2:f records our version of the file, and :3:f is empty, recording the modify/delete conflict.

For modify/modify conflicts, all three slots are occupied; only when one file is missing is one of these slots empty. It's actually impossible to have two empty slots: there's no such thing as a delete/delete conflict, nor a nocreate/add conflict. But in any case it's the existence of some value(s) in slots 1, 2, and/or 3 that mark the file as unresolved.
		 */

		/*
The commit command works the same way as it always does: it turns the index contents into tree objects and writes a new commit. The only thing special about a merge commit is that it has more than one parent commit ID.

Note that in all cases, the new commit's contents are determined by the index's contents. 
Moreover, once the new commit is done, the index is still full: it still contains the same contents.it just is full of the same thing as the HEAD commit.
		
		 
		 */
	}

}
