
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.plainWorkRepo
{
	/// <summary>
	/// 
	/// </summary>
	public class Io
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


		private Io(
			nilnul.fs.Folder folder
			,
			_plainWorkRepo.Ret type

		)
		{
			_type = type;
			_folder = folder;

		}



		static private Io CreateWork(
			nilnul.fs.Folder folder)
		{
			return new Io(folder, _plainWorkRepo.Ret.Work);

		}

		static private Io CreateRepo(
			nilnul.fs.Folder folder)
		{
			return new Io(folder, _plainWorkRepo.Ret.Repo);

		}

		static private Io CreateNone(
			nilnul.fs.Folder folder)
		{
			return new Io(folder, _plainWorkRepo.Ret.Plain);

		}



		static public Io Eval(nilnul.win.prog_.Git git, nilnul.fs.Folder folder)
		{
			//StringWriter output = new StringWriter();

			var result = git.runCmd__returnResult(
							folder.ed.ToString(),
			 "rev-parse --is-inside-work-tree"

			);

			if (result.beErr)
			{
				return new Io(folder, _plainWorkRepo.Ret.Plain);
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

		static public Io Eval(nilnul.win.prog_.Git git, string folder)
		{
			return Eval(git, new nilnul.fs.Folder(folder));
		}

		static public Io Eval( string folder)
		{
			return Eval(nilnul.win.prog_.Git.StaticInstance, new nilnul.fs.Folder(folder));
		}



		static public Io Eval( nilnul.fs.Folder folder)
		{

			return Eval(nilnul.win.prog_.Git.StaticInstance, folder);
		}

	}
}
