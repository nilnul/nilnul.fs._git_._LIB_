using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.root.dir.en_
{
	/// <summary>
	/// a root child that is inside a module (maybe the submodule, or , if not a submodule,  the parent module)
	/// </summary>
	public class NotRepo
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="module">the parent folder of this folder, which is the root of a module</param>
		/// <param name="_rootChildFolderLocation_notRepo">
		/// a folder that is not ".git"; so this folder is either a plain child folder of the parent folder module, or the root of a submodule itself.
		/// </param>
		/// <returns></returns>
		static public string  _GetRoot(
			Module parentModule,
			
			string _rootChildFolderLocation_notRepo

		) {


			///note: in ".git", the following command returns empty. 
			///		in submodule, the following command returns the root of the submodule.

			var result = parentModule.git.runCmd__returnResult(_rootChildFolderLocation_notRepo,  "rev-parse --show-toplevel");

			if (result.notBeErr)
			{
				
				return new DirectoryInfo(
					 result.msg.ToString().Trim()
					).FullName;
			}
			else
			{
				throw new _git.ReportErrException(
					result.err

				);

			}

		}
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

		private static string _GetRoot(nilnul.win.prog_.Git git, string _rootChildFolderLocation_notRepo)
		{
			///note: in ".git", the following command returns empty. 
			///		in submodule, the following command returns the root of the submodule.

			var result = git.runCmd__returnResult(_rootChildFolderLocation_notRepo, "rev-parse --show-toplevel");

			if (result.notBeErr)
			{

				return new DirectoryInfo(
					 result.msg.ToString().Trim()
					).FullName;
			}
			else
			{
				throw new _git.ReportErrException(
					result.err

				);

			}

		}

		static public bool _IsNotSubmodule(
				Module parentModule,

			string _rootChildFolderLocation_notRepo
		
			) {

			return !_IsSubModule(parentModule, _rootChildFolderLocation_notRepo);

		}

	}
}
