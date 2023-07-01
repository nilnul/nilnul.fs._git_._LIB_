using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_.accVaulted
{
	

	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]
	public class Typed
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

		private AccVaultedI _data;

		public AccVaultedI data
		{
			get { return _data; }
			set { _data = value; }
		}

		public string credKey => this.data.credKey4push;

		public Typed(AccVaultedI noCred)
		{
			//if (noCred is Typed x)
			//{
			//	_type = x.type;
			//	_data = x.data;
			//}
			//else
			{
				_type = noCred.GetType();
				_data = noCred;

			}
		}

		public Typed()
		{

		}

		// The special constructor is used to deserialize values.
		public Typed(SerializationInfo info, StreamingContext context)
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

		static public Typed Coerce(AccVaultedI noCredI) {
			if (noCredI is Typed x)
			{
				return x;
			}
			return new Typed(noCredI);
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
