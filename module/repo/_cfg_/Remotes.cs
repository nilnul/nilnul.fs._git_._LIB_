using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg
{
	/// <summary>
	/// 
	/// </summary>
	/// 

	public class Remotes
	{

		/*
		 (1) create the remote repository
git remote add origin https://{your_username}:{your_password}@github.com/{your_username}/repo.git


Note: If your password contains '@' sign use '%40' instead of that

			 */


		//public static void Add(Folder folder, string remote, string url)
		//{
		//	folder.runCmd_throwErr($"remote add {remote} {url}");

		//}



		/*
		 git remote rm
			 */
		static void Del(string[] args)
		{

		}

		/*
		 git remote rename 
			 */

		static void Rename(string[] args)
		{

		}

		/*
		 git remote -v
*/
		static void ListInfo(string[] args)
		{

		}
		/*
		 git remote set-url origin --push --add user1@repo1
git remote set-url origin --push --add user2@repo2
*/
		static void AddOfPush(string[] args)
		{

		}
		/*
		 [remote "Origin"]
    url = git@github.com:Paws/Paws.o.git
    url = git@codaset.com:elliottcable/paws-o.git


Once I’ve done this, when I git push Origin Master, it will push to both Paws/Master and Codaset/Master sequentially, making life a little easier.

	*/
		static void AddUrl(string[] args)
		{

		}

		/*
		 [remote "GitHub"]
    url = git@github.com:elliottcable/Paws.o.git
    fetch = +refs/heads/*:refs/remotes/GitHub/*
[branch "Master"]
    remote = GitHub
    merge = refs/heads/Master

		 *  */
		static void RemoteFetch(string[] args)
		{

		}
	


		/*
		 		 If the QA team wants to push their master branch to qa/master on the remote server, they can run
$ git push origin master:refs/heads/qa/master

If they want nilnul.win.prog_.Git to do that automatically each time they run git push origin, they can add a push value to their config file:
[remote "origin"]
	url = https://github.com/schacon/simplegit-progit
	fetch = +refs/heads/*:refs/remotes/origin/*
	push = refs/heads/master:refs/heads/qa/master

		 */

		static void Namespace(string[] args)
		{

		}

		/*
		 You could tell git to store your credentials using the following command:
git config --global credential.helper store


Using this method, you only need to enter your username and password once and git will never ask for it again. But please note that your password will be stored in plaintext which is not great in terms of security.

Cache Password

You can also go for caching instead which will store your password after having typed it once in a session for some period of time.
git config --global credential.helper cache


This is more secure as your password won't be stored on disk - just temporarily in memory. You can set the timeout yourself if your not happy with the default:
git config --global credential.helper 'cache --timeout=600'


Once again this is not always ideal.

		 */
		static void StorePassPlain(string[] args)
		{

		}
		


	}
}
