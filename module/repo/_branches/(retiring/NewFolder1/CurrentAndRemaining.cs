using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.gitTop.module.repo._branches
{
	[Obsolete()]
	public class CurrentAndRemaining
	{
		private nilnul.txt.Opt _current;

		public nilnul.txt.Opt current
		{
			get { return _current; }
			set { _current = value; }
		}

		private nilnul.txts_.List _others;

		public nilnul.txts_.List others
		{
			get { return _others; }
			set { _others = value; }
		}

		public CurrentAndRemaining(
			nilnul.txt.Opt current,
			nilnul.txts_.List others
		)
		{
			_current = current;
			_others = others;
		}


		public CurrentAndRemaining(
			nilnul.txt.Opt current,
			IEnumerable<string> others
		)
		{
			_current = current;
			_others = new txts_.List( others);
		}


		public override string ToString()
		{
			if ( nilnul.obj.opt.be_.None.Singleton.be( _current) )
			{
				return nilnul.txts.accumulate_.AsLines.Singleton.accumulate(_others);
			}
			else
			{
				return nilnul.txts.accumulate_.AsLines.Singleton.accumulate(new[] { "*" + (_current.val as nilnul.obj._opt_.val_.One<string>).val }.Concat(_others));
			}
		}

	}
}
