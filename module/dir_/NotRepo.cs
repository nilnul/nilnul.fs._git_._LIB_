using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.module.rootChildFolder_
{
	/// <summary>
	/// a root child that is inside a module (maybe the submodule, or , if not a submodule,  the parent module)
	/// </summary>
	public class NotRepo
	{
		
		static public bool _IsSubModule(


			string _rootChildFolderLocation_notRepo


		)
		{
			return _IsSubModule(nilnul.win.prog_.Git.StaticInstance, _rootChildFolderLocation_notRepo);
		}


		static public bool _IsSubModule(

			Module parentModule,

			string _rootChildFolderLocation_notRepo


		) {

			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
				
				_GetRoot(parentModule, _rootChildFolderLocation_notRepo) , 

				new DirectoryInfo(_rootChildFolderLocation_notRepo).FullName
				
			
			);
		}


		static public bool _IsSubModule(

			Git git,

			string _rootChildFolderLocation_notRepo


		) {

			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
				
				_GetRoot(git, _rootChildFolderLocation_notRepo) , 

				new DirectoryInfo(_rootChildFolderLocation_notRepo).FullName
				
			
			);
		}

		static public bool _IsNotSubmodule(
				Module parentModule,

			string _rootChildFolderLocation_notRepo
		
			) {

			return !_IsSubModule(parentModule, _rootChildFolderLocation_notRepo);

		}

	}
}
