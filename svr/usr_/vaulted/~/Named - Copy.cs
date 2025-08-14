using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.client.noCred
{
	/// <summary>
	/// </summary>
	///
	[Obsolete(nameof(svr.client_.accVaulted.NamedI))]
	public interface NamedI
	{
		
		string name { get; }

		nilnul.fs.git.client.NoCredI client { get; }
	}

	[Obsolete(nameof(svr.client_.accVaulted.NamedA))]

	public abstract class NamedA : NamedI
	{
		public abstract string name { get; }
		public abstract NoCredI client { get; }
	}

	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]
	[Obsolete(nameof(svr.client_.accVaulted.Named))]

	public class Named
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

		private NamedI _data;

		public NamedI data
		{
			get { return _data; }
			set { _data = value; }
		}

		public Named(NamedI noCred)
		{
			_type = noCred.GetType();
			_data = noCred;
		}

		public Named()
		{

		}

		// The special constructor is used to deserialize values.
		public Named(SerializationInfo info, StreamingContext context)
		{
			// Reset the property value using the GetValue method.
			_type =  Type.GetType((string)info.GetValue(nameof(type), typeof(string)) ) ;   // ;

			_data = (NamedI)info.GetValue(nameof(data), _type);
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
