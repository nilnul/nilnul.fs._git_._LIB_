using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg.remote.urls
{
	public class Show
	{

		/*
		 If referential integrity has been broken:
git config --get remote.origin.url


If referential integrity is intact:
git remote show origin


		 */

		static public string ByRemoteShow(Folder folder, string remote)
		{

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"remote show -n {remote}");   //With -n it will not fetch remote heads (AKA branches). You don't need that type of info, right?



		}

		static public string ByRemoteShowRemoteRefs(Folder folder, string remote)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder,  $"remote show {remote}");



		}
static public string ByCfgGetLast(Folder folder, string remote)
		{

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"config --get remote.{remote}.url");



		}


		static public IEnumerable< string> ByCfgGet(Folder folder, string remote)
		{

			return 
				nilnul.txt.str.fro._lines.X.ToLines_trimmedAndRemoveWhites(
				 nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder,  $"config --get-all remote.{remote}.url"));


		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="remote"></param>
		/// <returns></returns>
		/// <remarks>
		/// Note git config --get remote.origin.url retrieves the original URL which was set with git remote add ... or git remote set-url ... while git ls-remote --get-url origin retrieves the URL which is actually used to access the remote - which might be different in presence of git config --global url.XXX.insteadOf YYY. So both outputs may differ! 
		/// 
		/// Also note that 
		/// git ls-remote --get-url (without origin) does not neccessarily retrieve origin, instead it shows the tracked upstream, so it will fail for example in detached HEAD state.
		/// </remarks>
		static public string ByLsRemote4trackedUpstream(Folder folder, string remote)
		{

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"ls-remote --get-url {remote}");



		}

		

		/*
		 git remote get-url origin



Expanding insteadOf is a part of ls-remote --url and there is no way to expand pushInsteadOf as well.
 Add a get-url subcommand to be able to query both as well as a way to get all configured URLs.
get-url:



Retrieves the URLs for a remote.
 Configurations for insteadOf and pushInsteadOf are expanded here.
 By default, only the first URL is listed.
•With '--push', push URLs are queried rather than fetch URLs.
•With '--all', all URLs for the remote will be listed.


			 */
		static public IEnumerable<string> ByRemoteGetUrl(Folder folder, string remote)
		{

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"remote get-url --all {remote}").Split(new[] { '\n','\r'},StringSplitOptions.RemoveEmptyEntries );


		}



	}
}
