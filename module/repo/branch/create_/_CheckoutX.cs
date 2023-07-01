using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.branch.create_
{
	static public class _CheckoutX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="addressOfModule"></param>
		/// <param name="bakBranch"></param>
		/// <param name="git"></param>
		/// <returns>
		/// 0:success
		/// 128:
		///		there might be a .git/"head.lock", which prevents the checking-out;
		///	255:
		///		if there exists head.lock per a run on the command line;
		/// </returns>
		static public int _Cod_assumeModuleAddress_assumeBranch(
			string addressOfModule
			,
			string bakBranch, nilnul.os.prog_.Git git=null
		) {
			return os.prog_.git.run_.exit._CodX._Cod_ofDir9argument9cmd(
				addressOfModule, $"checkout -b {bakBranch}", git
			);
		}

		static public void _Vod_assumeModuleAddress_assumeBranch(
			string addressOfModule
			,
			string bakBranch, nilnul.os.prog_.Git git=null
		) {
			var argument = $"checkout -b {bakBranch}";
			var cod= os.prog_.git.run_.exit._CodX._Cod_ofDir9argument9cmd(
				addressOfModule, argument, git
			);
			switch (cod)
			{
				case 0:
					return;
				case 128:
					throw new os.prog_.git.run_.Xpn4GitRun(
						$"{argument} at {addressOfModule}: maybe there is a head.lock?"
					);
				case 255:
					throw new os.prog_.git.run_.Xpn4GitRun(
						$"{argument} at {addressOfModule}: maybe there is a head.lock?"
					);

				default:
					throw new os.prog_.git.run_.Xpn4GitRun(
						$"{argument} at {addressOfModule}:cod:{cod}; rerun to see the details;"
					);
			}
		}
	}
}