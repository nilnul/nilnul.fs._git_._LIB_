using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_.vaulted.repo
{
	/// <summary>
	/// </summary>
	//[Serializable]
	//[SettingsSerializeAs(SettingsSerializeAs.Binary)]
	public interface NamedI
	{
		
		string name { get; }

		nilnul.fs.git.svr.client.RepoI client4repo { get; }
	}
	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]

	public abstract class NamedA : NamedI
	{
		public abstract string name { get; }
		public abstract client.RepoI client4repo { get; }
	}
	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]

	public class Named : NamedA
	{
		private string _name;

		public override string name
		{
			get { return _name; }
		}

		private  client.RepoI _client4repo ;

		public override client.RepoI client4repo => _client4repo;
	

		public client.RepoI client4repoSetter
		{
			
			set {
				_client4repo = value;
			}
		}


		public Named(string name, client.RepoI client)
		{
			_name = name;
			_client4repo = client;
		}


	}


}
