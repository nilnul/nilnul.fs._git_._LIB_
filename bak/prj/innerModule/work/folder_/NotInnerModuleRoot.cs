using nilnul.dev;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.bak.prj.innerModule.work.folder_
{
	/// <summary>
	/// this is a work folder.
	/// there is no .git 'cuz this is nonRoot.
	/// 
	/// there can only be NonrootWork, or Rootwork inside this.
	/// </summary>
	/// <param name="_location__nonrootWork"></param>
	/// <param name="item"></param>

	public class NotInnerModuleRoot
	{

		



		internal static void Proc(nilnul.win.prog_.Git git, string _location__nonrootWork, Io log, ref bool paused, Cfg cfg)
		{


			try
			{

				///the dir must be :
				///	1)either a plain
				///	2) or a submodule root
				foreach (var dir in System.IO.Directory.GetDirectories(_location__nonrootWork))
				{

					if (nilnul.fs.git.module.Workspace._IsRoot(dir))
					{

						RootOfInnerModule._Proc(git, dir, log, ref paused,cfg);
					}
					else
					{
						Proc(git, dir, log, ref paused,cfg);
					}

				}

			}
			catch (Exception e)
			{
				log.err.writer.WriteLine($"when processing {_location__nonrootWork} as nonrootWork inside sln: " + e.Message);
				//throw;
			}
		}
	}
}
