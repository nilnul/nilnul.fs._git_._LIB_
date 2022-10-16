using nilnul.dev;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.folder._commit.andDirectory_.work_
{
	public class NonrootWork
	{
		/// <summary>
		/// this is a work folder.
		/// there is no .git 'cuz this is nonRoot.
		/// 
		/// there can only be NonrootWork, or Rootwork inside this.
		/// </summary>
		/// <param name="_location__nonrootWork"></param>
		/// <param name="item"></param>

		internal static void _Proc(nilnul.win.prog_.Git git, string _location__nonrootWork, StreamWriter log, CancellationToken paused)
		{


			try
			{

				foreach (var dir in System.IO.Directory.GetDirectories(_location__nonrootWork))
				{

					if (nilnul.fs.folder_.git_.work.be_._TopX.__Be_ofAddress(dir))
					{

						RootOfInnerModule._Proc(git, dir, log,  paused);
					}
					else
					{
						_Proc(git, dir, log,  paused);
					}

				}

			}
			catch (Exception e)
			{
				log.WriteLine($"when processing {_location__nonrootWork} as nonrootWork inside given folder: " + e.Message);
				//throw;
			}
		}
	}
}
