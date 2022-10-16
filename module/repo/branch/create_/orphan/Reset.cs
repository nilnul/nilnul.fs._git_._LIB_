using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._branch.create_.orphan
{
	static public class _ResetX
	{

		static public void _Exe(nilnul.fs.Folder _module, string _branch, nilnul.win.prog_.Git git=null )
		{
			NoHistory._Exe( _module, _branch, git);
			nilnul.fs.git.module.index._ResetX._Exe( _module, git);

		}
	}
}
