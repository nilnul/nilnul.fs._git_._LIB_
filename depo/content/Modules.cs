using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _DirectInnerModulesX
	{

		static public IEnumerable<nilnul.fs._address.DivI> Divs(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.prog_.Git git=null
		) {
			///todo: bare repo is not considered.
			return nilnul.fs.folder_.git_.work_.top.modules_._InnerDirectlyX._Divs(module.top.en,git);
		}

		static public IEnumerable<nilnul.fs._address.DivI> Divs_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git=null
		) {
			return Divs(nilnul.fs.git.Module.FroAddress(module));
		}

		static public IEnumerable<nilnul.fs._address.DivI> DivsAsArray_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git=null

		) {
			return Divs_ofAddress(module,git).ToArray();
		}
	}
}
