using nilnul.dev;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.folder._commit.andDirectory_
{
	public class Plain

	{

		public static void _Proc(nilnul.win.prog_.Git git,string _sln_none, StreamWriter log, CancellationToken  cancel)
		{

			try
			{
				foreach (var child in System.IO.Directory.GetDirectories(_sln_none))
				{
					if (cancel.IsCancellationRequested)
					{
						return;
					}
					var categorized = nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(_sln_none);

					switch (categorized)
					{
						case categorize_.git_._plainWorkRepo.Ret.Plain:

							_Proc(git, _sln_none, log, cancel);
							break;
						case categorize_.git_._plainWorkRepo.Ret.Work:
							//must be rootOfInnerModule

							andDirectory_.work_.RootOfInnerModule._Proc(git, _sln_none, log, cancel);
							break;
						case categorize_.git_._plainWorkRepo.Ret.Repo:
							throw new UnexpectedReachException("how come a repo occurs inside a plain folder?");
							break;
						default:
							throw new UnexpectedReachException("inside a plain folder, the dir must be plain or work(root)");

							break;
					}



				}
			}
			catch (Exception e)
			{
				log.WriteLine(
					$"when processing {_sln_none} as None:" + e.Message
					);

				//throw;
			}

		}

		
	}
}
