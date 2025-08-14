using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_
{
	/// <summary>
	/// work or repo
	/// </summary>
	public class InGitModule : nilnul.fs.folder.BeI
	{
		public bool be(Folder obj)
		{
			return categorize_.plainWorkRepo.io.be_.Module.Singleton.be(
				categorize_.plainWorkRepo.Io.Eval(obj)
			);
			//throw new NotImplementedException();
		}

		static public readonly InGitModule Singleton = nilnul.obj.SingletonByDefault<InGitModule>.Instance;

	}
}
