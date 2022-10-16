using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current.be_
{
	public class Pub :
		nilnul.win.prog_.git.Boxed
		//nilnul.obj.Box1<nilnul.win.prog_.Git>
		,
		nilnul.fs.git.module.BeI
	{
		public Pub()
		{
		}

		public Pub(Git val) : base(val)
		{
		}

		public bool be(ModuleI obj)
		{
			var currentBranch = module.repo.branch_.current._VwX.Txt(obj,this.boxed);
			if (string.IsNullOrWhiteSpace(currentBranch))
			{
				return false;
			}
			return nilnul.fs.git.repo._branch.name_.dnts.be_.local_._PubX.IsPub_assumeBranch(currentBranch);
		}

		static public Pub Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Pub>.Instance;
			}
		}

	}
}
