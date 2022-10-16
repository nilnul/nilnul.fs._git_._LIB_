using nilnul.dev.git;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.module.cfg.remote.url
{
	public class Change
	{
		/*
		 $ git remote set-url sofake https://github.com/octocat/Spoon-Knife

		Changes URLs for the remote. Sets first URL for remote <name> that matches regex <oldurl> (first URL if no <oldurl> is given) to <newurl>. If <oldurl> doesn’t match any URL, an error occurs and nothing is changed. 


With --push, push URLs are manipulated instead of fetch URLs.


With --add, instead of changing existing URLs, new URL is added.


With --delete, instead of changing existing URLs, all URLs matching regex <url> are deleted for remote <name>. Trying to delete all non-push URLs is an error.


Note that the push URL and the fetch URL, even though they can be set differently, must still refer to the same place. What you pushed to the push URL should be what you would see if you immediately fetched from the fetch URL. If you are trying to fetch from one place (e.g. your upstream) and push to another (e.g. your publishing repository), use two separate remotes.


		 */

		static public void ChangeUrl(Folder folder, string remote, string newUrl, string oldUrl)
		{

			ChangeUrl(folder.git,folder.location,remote,newUrl,oldUrl);
		}

		static public void ChangeUrl(nilnul.win.prog_.Git git, string module, string remote, string newUrl, string oldUrl)
		{

			git.runCmd_throwErr(
				module,
				$"remote set-url {remote} {newUrl} {oldUrl}"	
			);
		}


		static public void ChangeUrl( string module, string remote, string newUrl, string oldUrl)
		{

			ChangeUrl(nilnul.win.prog_.Git.StaticInstance,module,remote,newUrl,oldUrl);
		}


	}


}
