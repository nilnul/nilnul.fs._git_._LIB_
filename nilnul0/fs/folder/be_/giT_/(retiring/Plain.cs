using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[Obsolete(nameof(None))]
	public class Plain
		: nilnul.fs.folder.BeI1
	{
		public bool be(FolderI folder)
		{
			return categorize_.git_.plainWorkRepo.io.be_.Plain.Singleton.be(
						categorize_.git_.plainWorkRepo.Io.Eval(folder)
			);
		}

		static public Plain Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Plain>.Instance;
			}
		}

	}
}
