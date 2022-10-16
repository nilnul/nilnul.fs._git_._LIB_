using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_.accVaulted
{
	/// <summary>
	/// </summary>
	//[Serializable]
	//[SettingsSerializeAs(SettingsSerializeAs.Binary)]
	public interface NamedI
	{
		
		string name { get; }

		nilnul.fs.git.svr.client_.AccVaultedI client { get; }
	}
	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]

	public abstract class NamedA : NamedI
	{
		public abstract string name { get; }
		public abstract AccVaultedI client { get; }
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

		private AccVaultedI _client;

		public override AccVaultedI client
		{
			get {
				return _client;
			}

		}

		public  AccVaultedI clientSetter
		{
			
			set {
				_client = value;
			}
		}


		public Named(string name, AccVaultedI client)
		{
			_name = name;
			_client = client;
		}


		/// <summary>
		/// required for xml serialization.
		/// </summary>
		public Named()
		{

		}
	}


}
