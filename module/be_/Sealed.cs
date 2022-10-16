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
	/// when we stop working on a repoWork, we can commit all the current work into repo and delete the workspace. In doing so, we can save space and make it clear that this work is sealed.
	/// If we later want to resume our work, we can checkout from repo of our workings.
	/// The appearance of sealed module is the module's work is empty and the index is also empty.
	/// </summary>
	public class Sealed : 
		nilnul.win.prog_.git.Boxed
		,
		git.module.BeI
		,
		nilnul.fs.folder.BeI
	{
		public Sealed(Git val) : base(val)
		{
		}
		public Sealed():base(Git.StaticInstance)
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

		static public Sealed Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sealed>.Instance;
			}
		}
	}
}