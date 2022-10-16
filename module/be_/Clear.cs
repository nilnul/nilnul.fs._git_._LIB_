using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.be_
{
	/// <summary>
	/// nothing in work. But it's unknown that the index is empty or not
	/// </summary>
	public class Clear : 
		nilnul.win.prog_.git.Boxed
		,
		git.module.BeI
		,
		nilnul.fs.folder.BeI
	{
		public Clear(Git val) : base(val)
		{
		}
		public Clear():base(Git.StaticInstance)
		{

		}
		public bool be(ModuleI obj)
		{
			return module.work.be_.Empty.Singleton.be((obj).top1);
		}

		public bool be(FolderI obj)
		{
			return be( new nilnul.fs.git.Module(obj));
		}

		static public Clear Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Clear>.Instance;
			}
		}
	}
}