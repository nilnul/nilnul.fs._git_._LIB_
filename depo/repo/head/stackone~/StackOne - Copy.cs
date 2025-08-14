using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.head
{
	[Obsolete()]
	public class StackOne
	{
		Git git;
		string module;


		string _oldRef;

		public StackOne(nilnul.win.prog_.Git git, string module, string oldRef)
		{
			this.module = module;
			this.git = git;

			_oldRef = oldRef;


		}


		

		public void pop() {
			
			Head.Set2Ref(git, module, _oldRef);

		}

		static public StackOne Put(nilnul.win.prog_.Git git, string module, string newBranch) {

			var _oldRef=Head.GetHeadContent(git,module);

			Head._Checkout2NewBranch(git, module, newBranch);

			return new StackOne(git,module,_oldRef );

		} 



		static public StackOne Put(git.Folder folder, string newBranch) {

			return Put(folder.git, folder.address.ToString(), newBranch);

		} 


		static public StackOne Put( string folder, string newBranch) {

			return Put(nilnul.win.prog_.Git.StaticInstance, folder, newBranch);

		} 







		


	}
}
