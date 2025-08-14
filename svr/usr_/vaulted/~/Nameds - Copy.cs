using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.client.noCred
{
	/// <summary>
	/// </summary>
	/// 
	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]
	[Obsolete(nameof(svr.client_.accVaulted.Nameds))]

	public class Nameds : List<Named>
	{
		public Nameds(IEnumerable<Named> enumerable):base(enumerable)
		{
		}

		public Nameds()
		{

		}
	}
}
