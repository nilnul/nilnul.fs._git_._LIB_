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

		/// <summary>
		/// assume unnormed;
		/// </summary>
		/// <param name="name"></param>
		public void ensure(Name name)
		{

			ensure_assumeUnnormed(name);
			//svr_.gitlab.client.prjs.Add.ByPrivateToken_useWebRequest(
			//	this.boxed.getToken()
			//	,name
			//); 
		}
		public string ensure_assumeUnnormed(Name name)
		{
			var normed = svr_.gitlab.repo._NameX.Encode(name);
			try
			{
				nilnul.fs.git.svr_.gitlab.usr_.grp.repo.create_.pub_._OfGrpNameX._ByWebReq_1repoNameNormalized
				(
					boxed.usr
					,
					normed
					,
					this.boxed.getToken()
				);
			}
			catch (
				System.Net.WebException e //远程服务器返回错误: (400) 错误的请求。
			)
			{
				// if the name is already there, we just need to return		;
				// also later when push, the repo name is autocreated if it doesnot exist.
			}
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
