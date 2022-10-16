using nilnul.fs.git.svr.repo;
using nilnul.web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.amazon.client_.vaulted
{
	[Serializable]

	public class Repo4pub
		: nilnul.obj.Box1<amazon.client_.AccInVault>
		,
		nilnul.fs.git.svr.client.RepoI
	{
		[NonSerialized]
		Amazon.CodeCommit.AmazonCodeCommitClient _client;
		public Repo4pub(AccInVault val) : base(val)
		{
			_client=val.genAmazonClient();
		}
		public Repo4pub():this(new AccInVault())
		{

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

		public amazon.client_.AccInVault vaulted { get { return boxed; } }
		public svr.ClientI connection => boxed;

		public string basis => $"{svr_.amazon_._RegionX.Origion(boxed._region)}/v1/repos/"; 

		public void ensure(Name name)
		{
			svr_.amazon.client.repo.create._EnsureX.Ret(
				this._client
				,name
			); ;
		}
		public string ensure_assumeUnnormed(Name name)
		{
			ensure(name);
			return name;

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
