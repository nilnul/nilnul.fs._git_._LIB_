using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo.head
{
	public class StackOne1
	{
		nilnul.fs.folder_.git_.Top module;
		nilnul.fs.git.repo._reference.Name _oldRef;
		nilnul.win.prog_.Git _git;

		public StackOne1(nilnul.fs.folder_.git_.Top module, nilnul.fs.git.repo._reference.Name oldRef, nilnul.win.prog_.Git git=null)
		{
			this.module = module;

			_oldRef = oldRef;

			_git = git?? nilnul.win.prog_.Git.StaticInstance;
		}

		public StackOne1( string module, string oldRef, nilnul.win.prog_.Git git=null)
			:this( nilnul.fs.folder_.git_.Top.FroAddress(module), new nilnul.fs.git.repo._reference.Name(oldRef),git)
		{
			
		}



		public StackOne1(Top module, string oldRef1, G git):this(module,new git.repo._reference.Name(oldRef1),git)
		{
		}

		public void pop() {
			
			Head1.Set2Ref( module, _oldRef);

		}

		static public StackOne1 Put(nilnul.fs.folder_.git_.Top module, nilnul.fs.git.module.repo._branch.Name newBranch, G git = null) {

			var _oldRef=repo.current._VwX.Txt(module,git);

			Head1._Checkout2NewBranch( module, newBranch,git);

			return new StackOne1(module,_oldRef,git );

		} 

		
		static public StackOne1 Put(nilnul.fs.folder_.git_.Top module, string newBranch, G git = null) {

			

			return Put(module,new _branch.Name(newBranch),git );

		} 


		static public StackOne1 Put( string module, string newBranch,G git=null) {

			return Put( Top.FroAddress(module),new _branch.Name(newBranch),git);

		} 


		static public StackOne1 Put(nilnul.fs.Folder folder, string newBranch, G git) {

			return Put(new Top( folder),  newBranch,git);

		} 


		







		


	}
}
