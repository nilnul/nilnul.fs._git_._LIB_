using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.workspace.category_
{
	public class RootOrNot
	{

		private git.Workspace _workspace;

		public git.Workspace workspace
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
		private RootOrNot(
			git.Workspace work
			,
			bool beRoot

			
		)
		{
			_workspace = work;
			_beRoot = beRoot;

		}


		static public RootOrNot Eval(git.Workspace obj)
		{
			var beRoot= obj.getRoot() == new DirectoryInfo(obj.folder.location).ToString();

			return new RootOrNot(obj,beRoot);
		}


	static public bool IsRoot(git.Workspace obj)
		{
			return  obj.getRoot() == new DirectoryInfo(obj.folder.location).ToString();

			
		}



	}
}
