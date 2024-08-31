using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_.work_;

namespace nilnul.fs.git._module.work
{
	public abstract class BeA
		:
		nilnul.fs.folder.BeA
		,
		nilnul.fs.folder_.git_.work_.top.BeI,
		nilnul.fs.folder.BeI

	{
		public abstract bool be(Top obj);

		public override bool be(FolderI obj)
		{
			return be(
				new Top(obj)
			);
		}

	}
}
