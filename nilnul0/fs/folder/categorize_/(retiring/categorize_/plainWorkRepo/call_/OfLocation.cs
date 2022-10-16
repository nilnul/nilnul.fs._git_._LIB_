using nilnul.fs.git.folder._categorized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder.categorize_.plainWorkRepo.call_
{
	/// <summary>
	/// 
	/// </summary>
	public class OfLocation
	{


		private _plainWorkRepo.Ret _type;

		public _plainWorkRepo.Ret type
		{
			get { return _type; }
			//set { _type = value; }
		}

		private nilnul.fs.Folder _folder;

		public nilnul.fs.Folder folder
		{
			get { return _folder; }
			//set { _folder = value; }
		}


		private OfLocation(
			nilnul.fs.Folder folder
			,
			_plainWorkRepo.Ret type

		)
		{
			_type = type;
			_folder = folder;

		}



		static private OfLocation CreateWork(
			nilnul.fs.Folder folder)
		{
			return new OfLocation(folder, _plainWorkRepo.Ret.Work);

		}

		static private OfLocation CreateRepo(
			nilnul.fs.Folder folder)
		{
			return new OfLocation(folder, _plainWorkRepo.Ret.Repo);

		}

		static private OfLocation CreateNone(
			nilnul.fs.Folder folder)
		{
			return new OfLocation(folder, _plainWorkRepo.Ret.Plain);

		}



		static public OfLocation Eval(Git git, nilnul.fs.Folder folder)
		{
			//StringWriter output = new StringWriter();

			var result = git.runCmd__returnResult(
							folder.avowed.ToString(),
			 "rev-parse --is-inside-work-tree"

			);

			if (result.beErr)
			{
				return new OfLocation(folder, _plainWorkRepo.Ret.Plain);
			}
			else
			{

				if (result.msg.ToString().Trim().ToLower() == "true")
				{
					return CreateWork(folder);
				}
				return CreateRepo(folder);

			}
		}

		static public OfLocation Eval(Git git, string folder)
		{
			return Eval(git, new location_.Folder(folder));
		}

		static public OfLocation Eval( string folder)
		{
			return Eval(Git.StaticInstance, new location_.Folder(folder));
		}



		static public OfLocation Eval( nilnul.fs.Folder folder)
		{

			return Eval(Git.StaticInstance, folder);
		}

	}
}
