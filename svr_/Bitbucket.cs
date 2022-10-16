using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_
{
	public class BitBucket
	{
		public const string DOMAIN = "bitbucket.org";
		private nilnul.web._credential.Slots _credential;

		public nilnul.web._credential.Slots credential
		{
			get { return _credential; }
			set { _credential = value; }
		}

		public BitBucket( nilnul.web._credential.Slots credential)
		{
			_credential = credential;
		}

		

		public BitBucket(string username, string password)
			:this(new web._credential.Slots(username,password))
		{

		}


		public const string url_beforeVer= "https://api.bitbucket.org/";



		public const string url1_0 = "https://api.bitbucket.org/1.0";
		public const string url2_0 = url_beforeVer +"2.0";


		/*
		 curl -k -X POST --user user:pass "https://api.bitbucket.org/1.0/repositories" -d "name=project_name"
			 */

		[Obsolete("",true)]
		static async void _______________CreateRepoAync(string user, string pass, string repo)
		{
			//HttpClient client = new HttpClient();
			WebClient wc = new WebClient();

			var req = WebRequest.CreateHttp("https://api.bitbucket.org/1.0/repositories");

			req.Credentials = new NetworkCredential(user, pass);
			var data = new NameValueCollection();
			data["name"] = repo;

			//data["password"] = "myPassword";
			using (var client = new HttpClient())
			{
				var values = new Dictionary<string, string>
				{
				   { "name", repo }
					//,
				 //  { "thing2", "world" }
				};

				var content = new FormUrlEncodedContent(values);

				var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);

				var responseString = await response.Content.ReadAsStringAsync();


			}







		}
		/*
		 use UploadValues
			 */
		static public void _______________UploadValues(string[] args)
		{
			var url = "";
			using (var wb = new WebClient())
			{
				var data = new NameValueCollection();
				data["username"] = "myUser";

				data["password"] = "myPassword";

				var response = wb.UploadValues(url, "POST", data);
			}
		}

		[Obsolete("", true)]

		static public string AddRepo(string user,string pass,string repoName)
		{
			using (WebClient client = new WebClient())
			{

				client.Credentials = new NetworkCredential(user, pass);

				byte[] response =
				client.UploadValues(
					url1_0
					,
					new NameValueCollection()
					{
					   { "name", repoName }
						//,
					  // { "favorite+flavor", "flies" }
					}
				);

				string result = System.Text.Encoding.UTF8.GetString(response);

				return result;
			}
		}
	}
}
