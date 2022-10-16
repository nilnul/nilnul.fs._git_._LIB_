using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_.work_;

namespace nilnul.fs.git.module.work.be_
{

	/// <summary>
	/// no docs. There might be empty folders.
	/// </summary>
	public class Empty :

		nilnul.fs.folder_.git_.work_.top.BeI,
		nilnul.fs.folder.BeI
		
	{
		public bool be(Top obj)
		{
			return _EmptyX.Be(obj);
		}
		public bool be(FolderI obj)
		{
			return be(
				new Top(obj)
			);
		}


		static public Empty Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Empty>.Instance;
			}
		}

	}
}
