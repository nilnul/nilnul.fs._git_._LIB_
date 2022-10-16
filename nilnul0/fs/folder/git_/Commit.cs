using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.folder
{
	/// <summary>
	/// all the modules and sub-modules
	/// </summary>
	/// 
	[Obsolete()]
	static public class _CommitX
	{

		public static void CommitAllInsideModules(nilnul.win.prog_.Git git, string folder, StreamWriter log )
		{
			CancellationTokenSource source = new CancellationTokenSource();
			CancellationToken token = source.Token;


			try
			{


				switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(folder))
				{
					case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

						_commit.andDirectory_.top_.None._Proc(git, folder, log, token);

						break;
					case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
						_commit.andDirectory_.top_.Repo._Proc();

						break;
					case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:

						_commit.andDirectory_.top_.Work._Proc(git,folder,log,token);
						break;
					default:
						throw new UnexpectedReachException("unknown git.folder.Category");


				}



			}
			catch (Exception e)
			{
				log.WriteLine($"when processing {folder} as top:" + e.Message);
				//throw;
			}


		}



	}
}
