using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.depo.repo.head.assign_.ref_
{
	static public class _BranchX
	{

		static public void _Vod_0depoAddress_1branch( 
			string module, 
			string _ref, 
			nilnul.os.prog_.Git git = null
		)
		{
			fs.git.module.repo.current.assign_._ReferenceX._Vod_addressAssumeModule_assumeRef(
				module,  
				nilnul.fs.git.module.reference.construct_._BranchX.Exe(_ref) 
				,git
			);

		}
		static public void _Vod_0depoAddress_1branch( 
			string module, 
			string _ref, 
			nilnul.win.prog_.Git git = null
		)
		{
			_Vod_0depoAddress_1branch(
				module,  
				_ref 
				,
				(nilnul.os.prog_.Git)git
			);

		}

		static public void _Vod_1branch(Module module, string stowBranch, 
			nilnul.os.prog_.Git git = null)
		{
			_Vod_0depoAddress_1branch(module.top1.en.address.en.ToString(), stowBranch, git);
		}

		static public void Vod( 
			nilnul.fs.folder_.git_.work_.Top module, 
			module.repo._branch.Name _ref, 
			nilnul.win.prog_.Git git = null
		)
		{
			_Vod_0depoAddress_1branch(module.en.address.en.ToString(),_ref,git);

		}


		static public void Vod( 
			nilnul.fs.folder_.git_.Top module, 
			module.repo._branch.Name _ref, 
			nilnul.win.prog_.Git git = null
		)
		{
			_Vod_0depoAddress_1branch(module.en.address.en.ToString(),_ref,git);
			

		}

		static public void Vod( nilnul.fs.FolderI module, string _ref, nilnul.win.prog_.Git git = null)
		{
			Vod(new fs.folder_.git_.work_.Top( module), new module.repo._branch.Name(  _ref),git);

		}


		static public void Vod( string module, string _ref, nilnul.win.prog_.Git git = null)
		{
			Vod( new fs.folder_.git_.work_.Top( module), new module.repo._branch.Name(  _ref),git);

		}

	
		static public void Vod( nilnul.fs.git.Module module, string _branch, nilnul.win.prog_.Git git = null)
		{
			Vod(module.top1, new module.repo._branch.Name(  _branch),git);

		}

	}
}
