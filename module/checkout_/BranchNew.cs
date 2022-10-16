using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.program_.Git;

namespace nilnul.fs.git.module.checkout_
{
	[Obsolete("this is not a real checkout in that a new branch is simply created and the head points to the new branch")]
	static public class _BranchNewX
	{

		static public void _Checkout2NewBranch( nilnul.fs.folder_.git_.Top module, _branch.Name _branch_new, nilnul.win.program_.Git git=null)
		{
			G.RunCmd_retVoid(module, "checkout -b " + _branch_new);
		}

		static public void _Checkout2NewBranch( string module, string _branch_new, nilnul.win.program_.Git git=null)
		{
			_Checkout2NewBranch(new fs.folder_.git_.Top(module),new _branch.Name(_branch_new));
		}

	}
}
