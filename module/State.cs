using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// read the state of the module, including work, index, and repo/commited
	/// </summary>
	public class State
	{

		static public string  _GetStatus(nilnul.win.prog_.Git git, string _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module
				,
				"status"
			);
		}


		static public string  _GetStatus(nilnul.win.prog_.Git git, nilnul.fs.Folder _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				_module
				,
				"status"
			);
		}

		static public string  _GetStatus( string _module)
		{
			return _GetStatus(nilnul.win.prog_.Git.StaticInstance, _module);;
		}

		static public string  _GetStatus( nilnul.fs.Folder _module)
		{
			return _GetStatus(nilnul.win.prog_.Git.StaticInstance, _module);;
		}

	}
}
