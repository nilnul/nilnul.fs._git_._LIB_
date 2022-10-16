
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_.plainWorkRepo
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[Obsolete()]
	public class Io
	{


		private _plainWorkRepo.Ret _type;

		public _plainWorkRepo.Ret type
		{
			get { return _type; }
			//set { _type = value; }
		}

		private nilnul.fs.FolderI _folder;

		public nilnul.fs.FolderI folder
		{
			get { return _folder; }
			//set { _folder = value; }
		}


		private Io(
			nilnul.fs.FolderI folder
			,
			_plainWorkRepo.Ret type

		)
		{
			_type = type;
			_folder = folder;

		}



		static private Io CreateWork(
			nilnul.fs.FolderI folder)
		{
			return new Io(folder, _plainWorkRepo.Ret.Work);

		}

		static private Io CreateRepo(
			nilnul.fs.FolderI folder)
		{
			return new Io(folder, _plainWorkRepo.Ret.Repo);

		}

		static private Io CreateNone(
			nilnul.fs.FolderI folder)
		{
			return new Io(folder, _plainWorkRepo.Ret.Plain);

		}



		static public Io Eval(nilnul.fs.FolderI folder, nilnul.win.prog_.Git git=null)
		{
			//StringWriter output = new StringWriter();

			var result =win.prog_.Git.RunCmd_result(
				folder/*.container.ToString()*/,
				"rev-parse --is-inside-work-tree"
				,git

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

		static public Io Eval( string folder, nilnul.win.prog_.Git git=null)
		{
			return Eval(  nilnul.fs.Folder.FroAddress(folder),git);
		}

		//static public Io Eval( string folder)
		//{
		//	return Eval( new nilnul.fs.Folder(folder));
		//}



		static public Io Eval( nilnul.fs.Folder folder)
		{

			return Eval( folder);
		}

	}
}
