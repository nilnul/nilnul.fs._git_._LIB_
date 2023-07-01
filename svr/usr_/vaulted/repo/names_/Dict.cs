using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_.vaulted.repo.names_
{
	/// <summary>
	/// 
	/// </summary>
	/// custom check might be needed to ensure Repos are not overlapping.
	[Serializable]

	public class Dict
		:

		Dictionary<
			string
			,
			fs.git.svr.client.RepoI
		>

	//,ISerializable

	{
		public Dict()
		{
		}

		public Dict(int capacity) : base(capacity)
		{
		}

		public Dict(IEqualityComparer<string> comparer) : base(comparer)
		{
		}

		public Dict(IDictionary<string, client.RepoI> dictionary) : base(dictionary)
		{
		}

		public Dict(int capacity, IEqualityComparer<string> comparer) : base(capacity, comparer)
		{
		}

		public Dict(IDictionary<string, client.RepoI> dictionary, IEqualityComparer<string> comparer) : base(dictionary, comparer)
		{
		}

		protected Dict(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
