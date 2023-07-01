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
	/// 
	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]
	[PartialImplementation]

	public class Nameds : List<Named>

		//,ISerializable

	{
		public Nameds(IEnumerable<Named> enumerable):base(enumerable)
		{
		}

		public Nameds()
		{

		}

		//public void GetObjectData(SerializationInfo info, StreamingContext context)
		//{
		//	throw new NotImplementedException();
		//}
	}
}
