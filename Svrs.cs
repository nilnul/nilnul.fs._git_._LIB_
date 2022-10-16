using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git
{

	public class _Svrs
	{
		IEnumerable<Type> Names = new[] {
			typeof(svr_.BitBucket)
			,

		};

	}
	/// <summary>
	/// used to store in settings
	/// </summary>
	/// 
	[SerializableAttribute]
	public class Svrs:List<SvrI>
	{

	}
}
