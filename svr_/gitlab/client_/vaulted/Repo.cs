using nilnul.fs.git.svr.repo;
using nilnul.web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.client_.vaulted
{
	[Serializable]

	public class Repo4pub
		: nilnul.obj.Box1<gitlab.client_.AccInVault>
		,
		nilnul.fs.git.svr.client.RepoI
	{
		[NonSerialized]
		svr.ClientI _client;
		public Repo4pub(AccInVault val) : base(val)
		{
			_client=val.genClient();
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue(
				"boxed",
				this.boxed
				,
				this.boxed.GetType()
			);
		}

		// The special constructor is used to deserialize values.
		public Repo4pub(SerializationInfo info, StreamingContext context)
				: base(null)
		{
			// Reset the property value using the GetValue method.
			this.boxed = (AccInVault)info.GetValue("boxed", typeof(AccInVault));
		}

		public AccInVault _connection => boxed;
		public svr.ClientI connection => boxed;

		public string basis => $"https://gitlab.com/{boxed.usr}/"; 

		public void ensure(Name name)
		{
			svr_.gitlab.client.prjs.Add.ByPrivateToken_useWebRequest(
				this.boxed.getToken()
				,name
			); ;
		}
		public string ensure_assumeUnnormed(Name name)
		{
			var normed = svr_.gitlab.repo._NameX.Encode(name);
			svr_.gitlab.client.prj._CreationX._ByWebReq_assumesNormed(
				this.boxed.getToken()
				,normed
			);
			return normed;

		}


		public Url4 url(Name name)
		{
			return web.url._ParseX4.Parse(
				$"{basis}{name}.git"
			);
		}

		public string urn(Name name)
		{
			return url(name).ToString();
		}

	}
}
