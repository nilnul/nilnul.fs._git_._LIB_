using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.git.svr.repo;
using nilnul.web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace nilnul.fs.git.svr_.github.client_.vaulted_.orged
{
	[Serializable]
	public class Repo4pub
			:
		nilnul.obj.Box1<github.client_.vaulted_.ForOrg>
			,
			nilnul.fs.git.svr.client.RepoI
	{
		public github.client_.vaulted_.ForOrg client {
			get { return boxed; }
		}
		public string org
		{
			get { return boxed.org; }
		}
		public Repo4pub(ForOrg val) : base(val)
		{
		}


		public Repo4pub(Vaulted val,string org) : this(
			new ForOrg( val,org)
		)
		{
		}


		/// <summary>
		/// required for deserialization
		/// </summary>
		public Repo4pub():base(new ForOrg())
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
		//		: base(info,context)
		//{
		//	// Reset the property value using the GetValue method.
		//	this.boxed = (ForOrg)info.GetValue("boxed", typeof(ForOrg));
		//}

		public svr.ClientI connection => boxed;

		public string basis =>      $"https://{git.svr_.Github.Singleton.host}/{this.org}";


		public void ensure(Name name)
		{

			github.client.org.repo._CreateX.EnsurePublic(
				this.boxed
				,
				this.boxed.org 
				,
				name
			);

		}

		public string ensure_assumeUnnormed(Name name)
		{
			ensure(name);
			return name;

		}


		public void tryEnsure(Name name)
		{

			try
			{
				ensure(name);

			}
			catch (Exception)
			{

				//throw;
			}

		}


		public Url4 url(Name name)
		{
			return web.url._ParseX4.Parse(
				nilnul.fs.git.svr_.github.client.org.repo._UrlX.Url_withUsername(
					this.boxed.org
					,
					name.ToString()
					,
					this.boxed.username
				)
			);
			//throw new NotImplementedException();
		}

		public string urn(Name name)
		{
			return boxed.urn(name);
			return (
				nilnul.fs.git.svr_.github.client.org.repo._UrlX.Ssh_withUsername(
					this.boxed.org
					,
					name.ToString()
					
				)
			)
			;


		}

	}
}
