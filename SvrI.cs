using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git
{
	/// <summary>
	/// from client, we call the remote as svr, which ends with 'r', the initial of "remote";
	/// </summary>
	/// <remarks>
	/// client is implied in "svr";
	/// </remarks>
	public interface ISvr { }
	//[Serializable]
	public interface SvrI
	{

	}

	[Serializable]
	public abstract class SvrA:SvrI
	{
	}

	/// <summary>
	/// the type and the data.
	/// </summary>
	/// 
	//[System.Xml.Serialization.serializ.se]
	[Serializable]
	public class Svr: ISerializable
	{
		private Type _type;

		public Type type
		{
			get { return _type; }
			set { _type = value; }
		}

		private SvrI _data;

		public SvrI data
		{
			get { return _data; }
			set { _data = value; }
		}
		public Svr(SvrI data)
		{
			_type = data.GetType();
			_data = data;
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue(
				nameof(type)
				,
				type
			);
			info.AddValue(
				nameof(data)
				,
				_data
			);
			//throw new NotImplementedException();
		}
	}

	


}
