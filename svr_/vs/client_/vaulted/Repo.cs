using nilnul.fs.git.svr.repo;
using nilnul.web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.client_.vaulted
{
	[Serializable]

	public class Repo
		: nilnul.obj.Box1<vs.client_.AccInVault>
		,
		nilnul.fs.git.svr.client.RepoI
	{
		[NonSerialized]
		svr_.vs.Client _client;
		public Repo(AccInVault val) : base(val)
		{
			_client = val.genOfficialClient();
		}

		public AccInVault _connection => boxed;
		public svr.ClientI connection => boxed;

		public string basis => $"https://{_client.account}.visualstudio.com/DefaultCollection/_git/";

		public void ensure(Name name)
		{
			svr_.vs.client.teamwork.create_.pub._EnsureX.Ret_assumeNormed(
				this._client
				, name
			); ;
		}
		public void ensure_assumeNormed(string name)
		{
			svr_.vs.client.teamwork.create_.pub._EnsureX.Ret_assumeNormed(
				this._client
				, name
			); ;
		}


		public string ensure_assumeUnnormed(Name name)
		{
			var normed = svr_.azure.repo.Name.Encode(name);
			ensure_assumeNormed(normed);
			return normed;
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
		public Repo(SerializationInfo info, StreamingContext context)
				: base(null)
		{
			// Reset the property value using the GetValue method.
			this.boxed = (AccInVault)info.GetValue("boxed", typeof(AccInVault));
		}
		public Url4 url(Name name)
		{
			return web.url._ParseX4.Parse(
				$"{basis}{name}"
			);
		}

		public string urn(Name name)
		{
			return url(name).ToString();
		}

	}
}
