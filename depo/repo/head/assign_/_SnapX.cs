using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.current.assign_
{
	
	/// 
	/// <summary>
	/// make it to be in detach mode when the HEAD directly contains the snapId;
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// vs:
	///		<see cref="depo.repo.branch_.current.snap._AssignX"/>
	static public class _SnapX
	{
		static public void _Vod_addressAssumeModule_assumeSnap(string _addressAssumeModule, string _assumeSnap
			,
			nilnul.os.prog_.Git git=null
		) {

			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(_addressAssumeModule, $"symbolic-ref HEAD {_assumeSnap}", git);

			
		}
	}
}
