using nilnul.dev;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.str;
using nilnul;
using System.Threading;

namespace nilnul.fs.folder._commit.andDirectory_.top_.work_
{
	/// <summary>
	/// dataforlder that is : 
	///		work; and 
	///		the root of the work
	/// </summary>
	public class Root
	{


		public static void _Proc(nilnul.win.prog_.Git git, string _location, StreamWriter log, CancellationToken paused)
		{

			try
			{
				if (paused.IsCancellationRequested)
				{
					return;
				}

				andDirectory_.work_.RootOfInnerModule._Proc(git, _location, log,  paused);
			}
			catch (Exception e)
			{
				log.WriteLine($"when processing {_location} as folderRoot and WorkspaceRoot: " + e.Message);
				//throw;
			}
		}
	}
}
