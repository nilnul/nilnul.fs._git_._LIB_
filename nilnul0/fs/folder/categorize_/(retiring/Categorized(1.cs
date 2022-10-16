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
	public class Categorized
	{


		private _categorized.PlainWorkRepo _type;

		public _categorized.PlainWorkRepo type
		{
			get { return _type; }
			//set { _type = value; }
		}

		private Folder _folder;

		public Folder folder
		{
			get { return _folder; }
			//set { _folder = value; }
		}


		private Categorized(
			Folder folder
			,
			_categorized.PlainWorkRepo type

		)
		{
			_type = type;
			_folder = folder;

		}



		static private Categorized CreateWork(Folder folder)
		{
			return new Categorized(folder, PlainWorkRepo.Work);

		}

		static private Categorized CreateRepo(Folder folder)
		{
			return new Categorized(folder, PlainWorkRepo.Repo);

		}

		static private Categorized CreateNone(Folder folder)
		{
			return new Categorized(folder, PlainWorkRepo.Plain);

		}



		static public Categorized Eval(Folder folder)
		{
			//StringWriter output = new StringWriter();

			var result = folder.git.runCmd__returnResult(
							folder.address.ToString(),
			 "rev-parse --is-inside-work-tree"

			);

			if (result.beErr)
			{
				return new Categorized(folder, PlainWorkRepo.Plain);
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
