using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.bitBucket
{
	public class Repos
	{
		public const string DIR = "repositories";

		public static readonly string Url_1_0_ = $"{BitBucket.url1_0}/{DIR}";

		public static readonly string Url_2_0_ = $"{BitBucket.url2_0}/{DIR}";
		///rest/api/1.0/repos?name&projectname&permission&visibility
	}
}
