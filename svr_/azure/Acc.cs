using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure
{
	[Obsolete()]
	public class Acc
	{
		public static string Cfged => nilnul.fs.git.Properties.Settings.Default.svrAzureAcc?? throw new NullReferenceException($"{nameof(nilnul.fs.git.Properties.Settings.Default.svrAzureAcc)} is not configed");


	}
}
