using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.bb.client_
{

	/*https://github.com/Microsoft/Git-Credential-Manager-for-Windows/blob/master/Docs/Bitbucket.md
	 
		 Unlike the GitHub implementation within the nilnul.win.prog_.Git Credential Manager, the Bitbucket implementation stores 'secrets', passwords, app-specific passwords, or OAuth tokens, with usernames in the Windows Credential Manager vault.

Depending on the circumstances this means either saving an explicit username in to the Windows Credential Manager/Vault or including the username in the URL used as the identifying key of entries in the Windows Credential Manager vault, i.e. using a key such as git:https://mminns@bitbucket.org/ rather than git:https://bitbucket.org. This means that the Bitbucket implementation in the GCM can support multiple accounts, and usernames, for a single user against Bitbucket, e.g. a personal account and a work account.

 When the GCM is instructed to store credentials for a Bitbucket URL the GCM will try and store default credentials for the host, i.e. for git:https://bitbucket.org/, with a username. This effectively copies user specific credentials to the default host credentials. The GCM will also then check for a user specific refresh token, if it exists it will copy it to a new default host refresh token entry.*/
	public class Cfged : nilnul.fs.git.svr_.bb.Client
		{



			static public System.Net.NetworkCredential Credential = nilnul.win.app_._CredManX.Ensure(_ApiX.DOMAIN);


			public Cfged(

			) : base(Credential)
			{
			}



			static public Cfged Singleton
			{
				get
				{
					return nilnul.Singleton1<Cfged>.Instance;
				}
			}






		}
	}
