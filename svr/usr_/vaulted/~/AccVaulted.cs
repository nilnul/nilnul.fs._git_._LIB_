using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_
{
	

	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]

	[Obsolete(nameof(accVaulted.Typed))]
	public class AccVaulted
		:

		AccVaultedI
		,
		ISerializable
	{
		private Type _type;

		public Type type
		{
			get { return _type; }
			set { _type = value; }
		}

		private AccVaultedI _data;

		public AccVaultedI data
		{
			get { return _data; }
			set { _data = value; }
		}

		public string credKey4push => this.data.credKey4push;

		public AccVaulted(AccVaultedI noCred)
		{
			if (noCred is AccVaulted x)
			{
				_type = x.type;
				_data = x.data;
			}
			else
			{
				_type = noCred.GetType();
				_data = noCred;

			}
		}

		public AccVaulted()
		{

		}

		// The special constructor is used to deserialize values.
		public AccVaulted(SerializationInfo info, StreamingContext context)
		{
			// Reset the property value using the GetValue method.
			_type =  Type.GetType((string)info.GetValue(nameof(type), typeof(string)) ) ;   // ;

			_data = (AccVaultedI)info.GetValue(nameof(data), _type);
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue(nameof(type), this._type.FullName );
			info.AddValue(nameof(data), this._data );

		}

		static public AccVaulted Coerce(AccVaultedI noCredI) {
			if (noCredI is AccVaulted x)
			{
				return x;
			}
			return new AccVaulted(noCredI);
		}

		public string gitUrl(string repo)
		{
			return this.data.gitUrl(repo);
		}

		public ClientI genClient()
		{
			return this.data;//.genClient();
		}
	}
}
