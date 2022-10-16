using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.svr_.vs
{
	public class Processes
	{
		static public string GenerateUrl(string account) {

			return VisualStudio.GenerateUrl( account,"process/processes","2.2" );
		}
	}
}
