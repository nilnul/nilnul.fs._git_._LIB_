using nilnul.fs.git.folder._categorized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder
{
	/// <summary>
	/// 
	/// </summary>
	public class CategorizedOfLocation
	{


		private _categorized.PlainWorkRepo _type;

		public _categorized.PlainWorkRepo type
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


		private CategorizedOfLocation(
			nilnul.fs.Folder folder
			,
			_categorized.PlainWorkRepo type

		)
		{
			_type = type;
			_folder = folder;

		}



		static private CategorizedOfLocation CreateWork(
			nilnul.fs.Folder folder)
		{
			return new CategorizedOfLocation(folder, PlainWorkRepo.Work);

		}

		static private CategorizedOfLocation CreateRepo(
			nilnul.fs.Folder folder)
		{
			return new CategorizedOfLocation(folder, PlainWorkRepo.Repo);

		}

		static private CategorizedOfLocation CreateNone(
			nilnul.fs.Folder folder)
		{
			return new CategorizedOfLocation(folder, PlainWorkRepo.Plain);

		}



		static public CategorizedOfLocation Eval(Git git, nilnul.fs.Folder folder)
		{
			//StringWriter output = new StringWriter();

			var result = git.runCmd__returnResult(
							folder.avowed.ToString(),
			 "rev-parse --is-inside-work-tree"

			);

			if (result.beErr)
			{
				return new CategorizedOfLocation(folder, PlainWorkRepo.Plain);
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


		static public CategorizedOfLocation Eval( nilnul.fs.Folder folder)
		{

			return Eval(Git.StaticInstance, folder);
		}

		static public _categorized.PlainWorkRepo _Eval( string folder)
		{
			return _Eval(Git.StaticInstance, folder);

		}


		static public _categorized.PlainWorkRepo _Eval(Git git, string folder)
		{
			//StringWriter output = new StringWriter();

			var result = git.runCmd__returnResult(
							folder,
			 "rev-parse --is-inside-work-tree"

			);

			if (result.beErr)
			{
				return _categorized.PlainWorkRepo.Plain;
			}
			else
			{

				if (result.msg.ToString().Trim().ToLower() == "true")
				{
					return _categorized.PlainWorkRepo.Work;
				}
				return _categorized.PlainWorkRepo.Repo;

			}
		}




	}
}
