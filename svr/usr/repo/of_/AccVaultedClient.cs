using nilnul.fs.git.svr.client_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repo.of_
{
	public class AccVaultedClient
		: OfI<fs.git.svr.client_.AccVaultedI>
	{
		public RepoI op(AccVaultedI client)
		{

			switch (client)
			{
				case null:
					return null;
					break;
				case nilnul.fs.git.svr_.amazon.client_.AccInVault amazon:
					return new svr_.amazon.client_.vaulted.Repo4pub(amazon);
					break;
				case nilnul.fs.git.svr_.azure.client_.Vaulted azure00:
					return new fs.git.svr_.azure.client_.vaulted.Repo4pub(azure00);
					break;
				case nilnul.fs.git.svr_.gitlab.client_.AccInVault gitlab:
					return new svr_.gitlab.client_.vaulted.Repo4pub(gitlab);
					break;
				case nilnul.fs.git.svr_.github.client_.vaulted_.ForOrg  github:
					return new nilnul.fs.git.svr_.github.client_.vaulted_.orged.Repo4pub(github);
					break;
				case nilnul.fs.git.svr_.github.client_.Vaulted github:
					return new nilnul.fs.git.svr_.github.client_.vaulted.Repo4pub(github);
					break;
				case nilnul.fs.git.svr_.vs.client_.AccInVault vs:
					return new nilnul.fs.git.svr_.vs.client_.vaulted.Repo(vs);
					break;
				default:
					throw new UnexpectedTypeException(
						client.ToString()
					);
					//throw new NotImplementedException();
			}
		}


		static public AccVaultedClient Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<AccVaultedClient>.Instance;
			}
		}
		static public AccVaultedClient Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<AccVaultedClient>.Instance;
			}
		}


	}
}
