using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.pier.add_.one_
{
	
	/// <summary>
	/// add one file by force. which is required for ignored file;
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _ByForceX
	{
		/// <summary>
		/// </summary>
		static public void _Vod_0depo_1dossier( string _module , string dossier ,nilnul.win.prog_.Git git=null)
		{
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0nulable_1address_2args(
				git
				,
				_module,

				"add"
				,
				"-f"
				,
				"--"	// keep in mind that some desityn might begin with "-", including "--"
				,
				dossier
			);
		}


	}
}
