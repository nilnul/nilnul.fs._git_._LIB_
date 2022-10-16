using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_.accVaulted.named
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
			//set { _type = value; }
		}

		private NamedI _data;

		public NamedI data
		{
			get { return _data; }
			set { _data = value; }
		}

		public Typed(NamedI noCred)
		{
			_type = noCred.GetType();
			_data = noCred;
		}

		public Typed()
		{

		}

		// The special constructor is used to deserialize values.
		public Typed(SerializationInfo info, StreamingContext context)
		{
			// Reset the property value using the GetValue method.
			_type =  Type.GetType((string)info.GetValue(nameof(type), typeof(string)) ) ;   // ;

			_data = (NamedI)info.GetValue(nameof(data), _type);
		}

		public Typed(string v, AccVaultedI obj):this(new Named(v,obj))
		{

		}

	

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue(nameof(type), this._type.FullName );
			info.AddValue(nameof(data), this._data );

		}

		public override string ToString()
		{
			return _data.name;
		}
	}
}
