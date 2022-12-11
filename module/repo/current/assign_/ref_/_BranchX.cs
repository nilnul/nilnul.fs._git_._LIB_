using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.head.set_.ref_
{
	static public class _BranchX
	{


		static public void Exe( 
			nilnul.fs.folder_.git_.work_.Top module, 
			module.repo._branch.Name _ref, 
			nilnul.win.prog_.Git git = null
		)
		{
			head.set_._ReferenceX.Exe(
				module,  
				nilnul.fs.git.module.reference.construct_._BranchX.Exe(_ref) 
				,git
			);

		}

		static public void Exe( 
			nilnul.fs.folder_.git_.Top module, 
			module.repo._branch.Name _ref, 
			nilnul.win.prog_.Git git = null
		)
		{
			head.set_._ReferenceX.Exe(
				module,  
				nilnul.fs.git.module.reference.construct_._BranchX.Exe(_ref) 
				,git
			);

		}

		static public void Exe( nilnul.fs.FolderI module, string _ref, nilnul.win.prog_.Git git = null)
		{
			Exe(new fs.folder_.git_.work_.Top( module), new repo._branch.Name(  _ref),git);

		}


		static public void Exe( string module, string _ref, nilnul.win.prog_.Git git = null)
		{
			Exe( new fs.folder_.git_.work_.Top( module), new repo._branch.Name(  _ref),git);

		}

	
		static public void Exe( nilnul.fs.git.Module module, string _branch, nilnul.win.prog_.Git git = null)
		{
			Exe(module.top1, new repo._branch.Name(  _branch),git);

		}

	




	}
}
