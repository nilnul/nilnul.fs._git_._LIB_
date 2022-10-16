using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo_.bare
{
	static public class _SizeX
	{
		/*
		 For nilnul.win.prog_.Git, you can use the following command:

git count-objects -v 
This should return a result similar to this:

$ git count-objects -v 
count: 0
size: 0
in-pack: 478
packs: 1
size-pack: 92
prune-packable: 0
garbage: 0
The size-pack value is the size of your repository when it is pushed to a remote server like Bitbucket. The size-pack value is in kilobytes.  So, in the above example the repository is not even 1 MB.  
		 */
		/*
		git count-objects -vH
		  appends unit Human readable
			*/

		public static win.prog._run.Result Result(nilnul.fs.git.repo_.IBare module, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run._ResultX.Result_ofAddress(module.ToString(), "count-objects -vH", git);

		}

		public static int _Kb_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git=null
		) {

			var msg = nilnul.win.prog_.git.run.result._MsgX.OfAddress(
				module
				,
				"count-objects"
				,
				git
			);

			return int.Parse(
			nilnul.txt.split_.Comma.Singleton.split(msg).Last().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First().Trim()
			);
		}

		public static int Kb(
			nilnul.fs.git.repo_.IBare module
			,
			nilnul.win.prog_.Git git=null
		) {

			var msg = nilnul.win.prog_.git.run.result._MsgX.OfAddress(
				module.ToString()
				,
				"count-objects"
				,
				git
			);

			return int.Parse(
			nilnul.txt.split_.Comma.Singleton.split(msg).Last().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First().Trim()
			);
		}

		public static int _Kb(Folder f)
		{
			return _Kb_ofAddress(f.en.ToString());
		}
	}
}
