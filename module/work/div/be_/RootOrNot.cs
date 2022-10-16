using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.div.be_
{
	public class _RootX
	{

		private git.module.Workspace _workspace;

		public git.module.Workspace workspace
		{
			get { return _workspace; }
			//set { _workspace = value; }
		}

		private bool _beRoot;

		public bool beRoot
		{
			get { return _beRoot; }
			//set { _beRoot = value; }
		}
		private _RootX(
			git.module.Workspace work
			,
			bool beRoot

			
		)
		{
			_workspace = work;
			_beRoot = beRoot;

		}


		static public _RootX Eval(git.module.Workspace obj)
		{
			var beRoot= obj.getRoot() == new DirectoryInfo(obj.avowed.folder.address.ToString()).ToString();

			return new _RootX(obj,beRoot);
		}


	static public bool IsRoot(git.module.Workspace obj)
		{
			return  obj.getRoot() == new DirectoryInfo(obj.avowed.folder.address.ToString()).ToString();

			
		}



	}
}
