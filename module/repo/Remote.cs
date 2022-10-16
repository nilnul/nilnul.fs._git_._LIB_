using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	 class Remote
	{

		/*
		 *For pushing updates, you have to do that to each repo manually. Push was, I think, designed with the central-repository workflow in mind.
		 * */
	



		/*
		 git remote update fetches from all remotes, not just one.Without looking at the code to see if remote update is just a shell script (possible) it, basically, runs fetch for each remote. git fetch can be much more granular.

			
You can configure which remotes to fetch when running git remote update, see git-remote manpage. – Jakub Narębski Dec 7 '09 at 0:56 
This will fetch from all of your configured remotes, assuming that you don't have remote.<name>.skipFetchAll set for them:

$ git config remotes.default 'origin mislav staging'
$ git remote update

# fetches remotes "origin", "mislav", and "staging"



If true, this remote will be skipped by default when updating using git-fetch(1) or the update subcommand of git-remote(1). — git-config documentation

if without specifying any remote group to fetch, and also not having remotes.default set in your repo configuration, and also that none of your remotes have remote.<name>.skipDefaultUpdate set to true.
 
 
Incidentally, git remote is not a shell script, but it spawns git fetch during a remote update. – mipadi Dec 7 '09 at 20:13 

			simply throw error and go on to next
*/
		static void Update(string[] args)
		{

		}
/*
 
Is there an equivalent git fetch command options for a git remote update? – tuler Mar 7 '12 at 0:25 
 

@tuler Yes: it is
git fetch --all 


		 * */
		static void FetchAll(string[] args)
		{

		}

	}
}
