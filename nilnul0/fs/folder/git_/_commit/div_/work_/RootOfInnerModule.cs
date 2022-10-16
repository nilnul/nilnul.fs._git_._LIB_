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
	/// <summary>
	/// a module root inside a datafolder:
	/// it may be the dataFolder itself if it's the module root;
	/// or the root of submodule.
	/// 
	/// exclude: if dataFolder is inside a module , but not the root of it, then it's excluded.
	/// 
	/// </summary>
	public class RootOfInnerModule
	{
		/// <summary>
		/// Note: the remote is configured in git config.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_location"></param>
		/// <param name="log"></param>
		/// <param name="err"></param>

		internal static void _Proc(nilnul.win.prog_.Git git, string _location, StreamWriter log, CancellationToken paused)
		{
			try
			{
				foreach (var child in System.IO.Directory.GetDirectories(_location))
				{
					if (paused.IsCancellationRequested)
					{
						return;
					}
					if (nilnul.fs.git.module.dir.be_._WorkX._Be_ofAddress( child,git))
					{
						if (nilnul.fs.git.module.dir_.work.be_._TopX._Be(child))
						{
							_Proc(git, child, log, paused);
						}
						else
						{
							NonrootWork._Proc(git, child, log,  paused);
						}
					}
					else
					{
					}
				}

				_CommitThis(git, _location, log,  paused);

			}
			catch (Exception e)
			{

				log.WriteLine($"when precessing {_location} as WorkRoot inside sln: " + e.Message);
			}
		}

		private static void _CommitThis(nilnul.win.prog_.Git git, string _location, StreamWriter log,  CancellationToken paused)
		{
			try
			{

				

				nilnul.fs.git.module.index.commit._AddAllFirstX.__Void_ofAddress( _location, "add and commit all for backup", git);


			}
			catch (Exception e)
			{
				log.WriteLine($"when processing {_location} as workroot inside sln by sync with remote: " + e.Message);
			}
		}
	}
}
