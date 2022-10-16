using Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.amazon_
{
	static public class _RegionX
	{
		public static string Region => nilnul.fs.git.Properties.Settings.Default.svr_amazon__region ?? throw new NullReferenceException($"{nameof(nilnul.fs.git.Properties.Settings.Default.svr_amazon__region)} is not configed");

		public static string CredRsc => $"git-codecommit.{  Region }.amazonaws.com";

		public static string Domain(string region) => $"git-codecommit.{  region }.amazonaws.com";

			
		public static string Origion(string region) => $"https://{Domain(region)}";
	


	}
}