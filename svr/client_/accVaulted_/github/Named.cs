using nilnul.fs.git.svr.client_.accVaulted;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_.accVaulted_.github
{
	[Serializable]
	public class Named :svr.client_.accVaulted.NamedI

		//: ISerializable
	{


		string _name;
		public string name => _name;

		private Github _client;
		public Github client => _client;

		AccVaultedI NamedI.client => _client;

		public Named( string name, Github github)
		{
			this._name = name;

			_client = github;


		}

		public Named( string name, string header) :this(name, new Github(header))
		{

		}

		public void ini() {
			_client.ini();
			
		}




		public Named()
		{

		}

	
	}
}
