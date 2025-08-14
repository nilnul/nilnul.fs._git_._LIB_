using nilnul.dev.git.folder._category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.folder
{
	[Obsolete(nameof(nilnul.fs.folder.categorize_.git_.PlainWorkRepo))]
	public class Category
	{


		private _category.NoneWorkRepo _type;

		public _category.NoneWorkRepo type
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


		private Category(
			Folder folder
			,
			_category.NoneWorkRepo type

		)
		{
			_type = type;
			_folder = folder;

		}



		static private Category CreateWork(Folder folder)
		{
			return new Category(folder, NoneWorkRepo.Work);

		}

		static private Category CreateRepo(Folder folder)
		{
			return new Category(folder, NoneWorkRepo.Repo);

		}

		static private Category CreateNone(Folder folder)
		{
			return new Category(folder, NoneWorkRepo.None);

		}


		static public Category Eval(Folder folder)
		{
			//StringWriter output = new StringWriter();

			var result = folder.git.runCmd__returnResult(
							folder.location,
			 "rev-parse --is-inside-work-tree"

			);

			if (result.isErr)
			{
				return new Category(folder, NoneWorkRepo.None);
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


		static public _category.NoneWorkRepo _Eval( string folder)
		{
			return _Eval(nilnul.win.prog_.Git.StaticInstance, folder);

		}


		static public _category.NoneWorkRepo _Eval(nilnul.win.prog_.Git git, string folder)
		{
			//StringWriter output = new StringWriter();

			var result = git.runCmd__returnResult(
							folder,
			 "rev-parse --is-inside-work-tree"

			);

			if (result.isErr)
			{
				return _category.NoneWorkRepo.None;
			}
			else
			{

				if (result.msg.ToString().Trim().ToLower() == "true")
				{
					return _category.NoneWorkRepo.Work;
				}
				return _category.NoneWorkRepo.Repo;

			}
		}




	}
}
