using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_
{
	/// <summary>
	/// 
	/// </summary>
	public class PlainWorkRepo
	{

		static public _plainWorkRepo.Ret _Eval( string folder)
		{
			return _Eval(nilnul.win.prog_.Git.StaticInstance, folder);
		}

		static public _plainWorkRepo.Ret _Eval( nilnul.fs.Folder folder)
		{
			return _Eval(nilnul.win.prog_.Git.StaticInstance, folder);
		}


		static public _plainWorkRepo.Ret _Eval(nilnul.win.prog_.Git git, string folder)
		{
			//StringWriter output = new StringWriter();

			var result = git.runCmd__returnResult(
							folder,
			 "rev-parse --is-inside-work-tree"

			);

			if (result.beErr)
			{
				return _plainWorkRepo.Ret.Plain;
			}
			else
			{

				if (result.msg.ToString().Trim().ToLower() == "true")
				{
					return _plainWorkRepo.Ret.Work;
				}
				return _plainWorkRepo.Ret.Repo;

			}
		}

		static public _plainWorkRepo.Ret _Eval(nilnul.win.prog_.Git git, nilnul.fs.Folder folder)
		{
			//StringWriter output = new StringWriter();

			var result = git.runCmd__returnResult(
							folder,
			 "rev-parse --is-inside-work-tree"

			);

			if (result.beErr)
			{
				return _plainWorkRepo.Ret.Plain;
			}
			else
			{

				if (result.msg.ToString().Trim().ToLower() == "true")
				{
					return _plainWorkRepo.Ret.Work;
				}
				return _plainWorkRepo.Ret.Repo;

			}
		}


	}
}
