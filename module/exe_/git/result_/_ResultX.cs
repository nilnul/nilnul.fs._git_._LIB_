using System;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.exe_.git.result_
{
	[Obsolete("copied from web. need review",true)]
	 static class _WhenUnlockedX
	{
		public static  nilnul.win.prog._run.Result Result(
			nilnul.fs.address_.ShieldI shield,
			string arg,
			nilnul.win.prog_.Git git = null
		)
		{

			//At least you can change your loop from a busy-wait to a slow poll. For example:
			while (nilnul.fs.git.module.be_._LockedX._Be_ofTop(shield, git))
			{
				System.Console.WriteLine($"locked at {shield} at {DateTime.UtcNow}");
				 Task.Delay(2*1000).Wait();
			}
			return nilnul.win.prog_.git.run._ResultX.Result(
				shield //.ToString()
				
				
				,
				arg
				,git
			);
			//return Result( new nilnul.fs.git.Module(module),arg,git);
		}
	}
}
