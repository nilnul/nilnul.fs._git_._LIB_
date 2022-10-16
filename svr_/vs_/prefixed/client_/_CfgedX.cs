using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs_.prefixed.client_
{
	static public class _CfgedX
	{
		public static string Prefix => nilnul.fs.git.Properties.Settings.Default.svr_vs__prefix ?? throw new NullReferenceException("svr_vs__prefix is not configed");

		public static string CredRsc => Prefix + ".visualstudio.com";

		static public nilnul.fs.git.svr_.vs_.prefixed.Client GetClient() => new nilnul.fs.git.svr_.vs_.prefixed.Client(
			nilnul.win.app_._CredManX.Ensure(
				CredRsc
			)
		);


	}
}