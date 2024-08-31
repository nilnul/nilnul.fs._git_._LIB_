using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work._merge.tool_
{
	/*
	 Download and install kdiff3

Either add this to your gitconfig:

[merge]
	tool = kdiff3
[mergetool "kdiff3"]
	cmd = \"C:\\\\Program Files (x86)\\\\KDiff3\\\\kdiff3\" $BASE $LOCAL $REMOTE -o $MERGED


Or run These at the command line:

git config --global merge.tool kdiff3
git config --global mergetool.kdiff3.cmd '"C:\\Program Files (x86)\\KDiff3\\kdiff3" $BASE $LOCAL $REMOTE -o $MERGED'


Now you will be able to resolve your conflicts the command line via

git mergetool


		 */
	class Kdiff3
	{
	}
}
