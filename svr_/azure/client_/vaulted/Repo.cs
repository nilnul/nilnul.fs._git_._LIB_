using nilnul.fs.git.svr.repo;
using nilnul.web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.client_.vaulted
{
	[Serializable]

	public class Repo4pub
		: nilnul.obj.Box1<azure.client_.Vaulted>
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

		public string basis => $"https://dev.azure.com/{boxed.org}/"; 

		public void ensure(Name name)
		{

			client.teamwork.create_._PubX.Create(
				this.boxed.genAzureClient(),

				//new nilnul.fs.git.svr_.azure.client.Teamwork(this.boxed, name.ToString())
				//,
				name

			);

			//throw new NotImplementedException();
		}
		public void ensure_assumeNormed(string name)
		{

			client.teamwork.create_._PubX._Create_prjNameAssumeNormed(
				this.boxed.genAzureClient(),

				//new nilnul.fs.git.svr_.azure.client.Teamwork(this.boxed, name.ToString())
				//,
				name

			);

			//throw new NotImplementedException();
		}


		public string ensure_assumeUnnormed(Name name)
		{
			var normed = nilnul.fs.git.svr_.azure.repo.Name.Encode(name);
			ensure_assumeNormed(normed);
			return normed;
			//throw new NotImplementedException();
		}

		public Url4 url(Name name)
		{
			return web.url._ParseX4.Parse( new nilnul.fs.git.svr_.azure.client.teamwork.repo_.Defaulted(this.boxed, name.ToString()).spear4git()
			)
				;

			//throw new NotImplementedException();
		}

		public string urn(Name name)
		{
			return url(name).ToString();
			throw new NotImplementedException();
		}

	}
}
