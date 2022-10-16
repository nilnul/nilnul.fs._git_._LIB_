using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs
{
	public class Projects
	{
		static public   string GenerateUrl(string account) {

			return 


			Client.GenerateUrl1_0(account,"projects");
		}
		static public   string GenerateUrl1(string account,string version) {

			return 

				svr_.VisualStudio.GenerateUrl(account,"projects",version);
		}

		static public   string GenerateUrl2_0preview(string account) {

			return 


			Client.GenerateUrl2_0preview(account,"projects");
		}


	}
}
