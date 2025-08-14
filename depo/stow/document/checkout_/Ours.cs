using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.stow.document.checkout_
{
	/// <summary>
	/// run git checkout --ours -- path/to/file.
	/// This git checkout gets the file from the index—in this case, from index slot 2.
	/// Since this is already in the index, Git does not write to the index, just to the work-tree.
	/// So the file is not resolved!
	/// </summary>
	internal class Ours
	{
	}

}
