using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.git.module._ignore_.exclude._create
{
	/* extern alias obj;*/
	/// <summary>
	/// ofModule
	/// </summary>
	static public class _ForceX
	{
		

		static public void Force(nilnul.fs.git.ModuleI targetAddress, IEnumerable<string> lines) {

			nilnul.fs.address_.spear_.exist._ForceX._Force(
				exclude._AddressX.Spear(targetAddress)
				,
				nilnul.txt.accumulate_.join_._LineSeparatedX.ToWinLines(lines)
			);

			
		}

		
	
		public static void Force(string targetAddress, IEnumerable<string> lines)
		{
			Force(nilnul.fs.git.Module.FroAddress(targetAddress),lines  );

			//throw new NotImplementedException();
		}


	}
}