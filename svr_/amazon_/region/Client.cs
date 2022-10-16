using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.amazon_.region
{
	/// <remarks>
	/// </remarks>

	public class Client:nilnul.fs.git.svr.ClientI
	{
		


		private nilnul.web._credential.Slots _credential ;
		public nilnul.web._credential.Slots credential 
		{
			get { return _credential; }
			set { _credential = value; }
		}

		public Client( nilnul.web._credential.Slots credential)
		{
			_credential = credential;
		}

		public Client(System.Net.NetworkCredential credential)
			:this(credential.UserName,credential.Password)
		{

		}

		public Client( string username, string password)
			:this( new web._credential.Slots(username,password))
		{

			
		}

		static public nilnul.fs.git.svr_.amazon_.region.Client GetClient() => new Client(
			nilnul.win.app_._CredManX.Ensure(
				_RegionX.CredRsc
			)
		);


	}
}
