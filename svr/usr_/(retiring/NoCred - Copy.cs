using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.client
{
	/// <summary>
	/// client (both svr and cred and all needed to access svr) excuding credential (which is stored separately in OS credential manager)
	/// in some cases we might include accName in client; we store only password in credential manager and the url there will include the username such as zhangsan@example.com
	/// </summary>
	//[Serializable]

	[Obsolete(nameof( git.svr.client_.AccVaultedI))]
	public interface NoCredI
	{
		/// <summary>
		/// key stored in windows vault(credential manager); we use this key to fetch password.
		/// </summary>
		string credKey { get; }
		//string createRepo(string repo);
		string gitUrl(string repo);

		nilnul.fs.git.ClientI genClient();
	}

	[Obsolete(nameof( git.svr.client_.AccVaultedA))]
	public abstract class NoCredA : NoCredI
	{
		public abstract string credKey { get; }

		public abstract ClientI genClient();

		//public abstract string createRepo(string repo);
		public abstract string gitUrl(string repo);
	}

	[Obsolete(nameof( git.svr.client_.AccVaulted))]
	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Xml)]
	public class NoCred
		:
		
		//NoCredI
		//,
		ISerializable
	{
		private Type _type;

		public Type type
		{
			get { return _type; }
			set { _type = value; }
		}

		private NoCredI _data;

		public NoCredI data
		{
			get { return _data; }
			set { _data = value; }
		}

		public NoCred(NoCredI noCred)
		{
			_type = noCred.GetType();
			_data = noCred;
		}

		public NoCred()
		{

		}

		// The special constructor is used to deserialize values.
		public NoCred(SerializationInfo info, StreamingContext context)
		{
			// Reset the property value using the GetValue method.
			_type =  Type.GetType((string)info.GetValue(nameof(type), typeof(string)) ) ;   // ;

			_data = (NoCredI)info.GetValue(nameof(data), _type);
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue(nameof(type), this._type.FullName );
			info.AddValue(nameof(data), this._data );

		}
	}
}
