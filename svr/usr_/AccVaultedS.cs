using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_
{
	/// <summary>
	/// </summary>
	/// 
	[Serializable]

	//[Obsolete(nameof(svr.client_.AccVaulted))]
	public class AccVaultedS : List<AccVaultedI>
	{
		public AccVaultedS(IEnumerable<AccVaultedI> enumerable):base(enumerable)
		{
		}

		public AccVaultedS()
		{

		}
	}
}
