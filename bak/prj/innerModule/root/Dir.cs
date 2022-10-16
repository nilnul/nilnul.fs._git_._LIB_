using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.bak.prj.innerModule.root
{
	public class Dir
	{
		public static void _Proc(nilnul.win.prog_.Git git, string _location, Io io, ref bool paused, bak.Cfg cfg)
		{
			if (paused)
			{
				io.err.writeRec(
					$"paused at innerModule root dir: {_location}"
				);
				return;
			}
			try
			{
				if (nilnul.fs.git.module.root.dir.Categorize._IsNotRepo(git, _location))
				{
					if (nilnul.fs.git.module.root.dir.en_.NotRepo._IsSubModule(_location))
					{
						innerModule.RootOfInnerModule._Proc(git, _location, io, ref paused, cfg);
					}
					else
					{
						nilnul.fs.git.bak.prj.innerModule.work.folder_.NotInnerModuleRoot.Proc(git, _location, io, ref paused, cfg);
					}
				}
				else
				{
				}
			}
			catch (Exception e)
			{
				io.err.writer.WriteLine($"when precessing {_location} as innerModule root dir: " + e.Message);
			}
		}
	}
}
