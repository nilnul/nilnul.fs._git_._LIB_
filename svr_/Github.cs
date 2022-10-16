using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_
{
	[Serializable]
	public class Github
	{
		public nilnul.web._url._origin._authority._socket.Host3 _host=new web._url._origin._authority._socket.Host3("github.com");

		public nilnul.web._url._origin._authority._socket.Host3 host {
			get {
				return _host;
			}
		} 



		static public Github Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Github>.Instance;
			}
		}

	}
}
