using nilnul.fs.git.svr.repo;
using nilnul.web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.client_.vaulted
{
	[Serializable]

	public class Repo4pub
		: nilnul.obj.Box1<github.client_.Vaulted>
		,
		nilnul.fs.git.svr.client.RepoI
	{
		public Repo4pub(Vaulted val) : base(val)
		{
		}

		/// <summary>
		/// required for deserializaion
		/// </summary>
		public Repo4pub():this(new Vaulted())
		{

		}



		//public void GetObjectData(SerializationInfo info, StreamingContext context)
		//{
		//	info.AddValue(
		//		"boxed",
		//		this.boxed
		//		,
		//		this.boxed.GetType()
		//	);
		//}

		//// The special constructor is used to deserialize values.
		//public Repo4pub(SerializationInfo info, StreamingContext context)
		//		: base(null)
		//{
		//	// Reset the property value using the GetValue method.
		//	this.boxed = (Vaulted)info.GetValue("boxed", typeof(Vaulted));
		//}
		
		public Vaulted _connection => boxed;
		public svr.ClientI connection => boxed;

		public string basis =>  $"https://{git.svr_.Github.Singleton.host}/{boxed.username}/";

		public void ensure(Name name)
		{

			client.repo._CreateX.EnsurePublic(
				this.boxed
				,
				name
			);

		}
		public string ensure_assumeUnnormed(Name name)
		{
			ensure(name);
			return name;
		}

		public Url4 url(Name name)
		{
			return web.url._ParseX4.Parse(
				nilnul.fs.git.svr_.github.client.repo._UrlX.Url_withCred(
					
					this.boxed.username, name.ToString()
				)
			)
			;

			//throw new NotImplementedException();
		}

		public string urn(Name name)
		{
			return url(name).ToString();
			//throw new NotImplementedException();
		}

		public string urn4ssh(nilnul.fs.git.svr.repo.Name name)
		{
			return this.boxed.urn4ssh(name);
			


		}

	}
}
