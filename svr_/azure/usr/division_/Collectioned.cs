using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.client.division_
{
	/// <summary>
	/// aka: rsc
	/// </summary>
	static public class _CollectionedX
	{
	
		static public string GenerateUrl(string account, string areaResources, string version)
		{
			return $"{client_._OrgedX.Stem4api(account)}{areaResources}?api-version={version}";
			
		}
		static public string GenerateUrl1_0(string account, string areaResources )
		{
			return $"{client_._OrgedX.Stem4api(account)}{areaResources}?api-version={"1.0"}";
		}


		static public string GenerateUrl2_0preview(string account, string areaResources)
		{
			return GenerateUrl(account, areaResources, "2.0-preview");
		}

		static public string GenerateUrl1_0preview(string account, string areaResources)
		{
			return GenerateUrl(account, areaResources, "1.0-preview");
		}

		
	}
}
