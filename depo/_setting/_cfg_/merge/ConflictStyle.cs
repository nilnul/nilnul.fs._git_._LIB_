using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.merge
{
	/*
	 * stackoverflow.com/questions/18131515/how-can-i-see-a-three-way-diff-for-a-git-merge-conflict
From git-merge,

An alternative style can be used by setting the "merge.conflictstyle" configuration variable to "diff3".

In addition to the <<<<<<<, =======, and >>>>>>> markers, it uses another ||||||| marker that is followed by the original text. ... You can sometimes come up with a better resolution by viewing the original.

This can be enabled using

git config --global merge.conflictstyle diff3

or right in ~/.gitconfigfile

[merge]
  conflictstyle = diff3	 
	 
	 */
	/// <summary>
	/// 
	/// </summary>
	internal class ConflictStyle
	{
	}
}
