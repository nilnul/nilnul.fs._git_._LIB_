using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.state
{
	/// <summary>
	/// read the state of the module, including work, index, and repo/commited
	/// </summary>
	static public class _VwX
	{

		static public string  Vw( string _module, nilnul.win.prog_.Git git=null)
		{
			return Vw(nilnul.fs.Folder.FroAddress(_module),git);
		}


		static public string  Vw( nilnul.fs.FolderI _module, nilnul.win.prog_.Git git=null)
		{
			return Vw(new nilnul.fs.folder_.git_.Top(_module),git);
		}


		static public string  Vw( nilnul.fs.folder_.git_.Top _module, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				_module
				,
				"status"
			);
		}

		

	}
}
