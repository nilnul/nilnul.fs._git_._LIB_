using nilnul.os.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.tags_
{
	public class Current
		: nilnul.os.prog_.git.run_.end.result._msg_.AssumeDepoA
	{
		public override string argument => "tag --points-at"; // default is current

		public IEnumerable<string> _names_0depo(
			string _module, nilnul.os.prog_.Git git = null
		)
		{
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				_msg_0depo(_module,  git)
			);
		}


		static public Current Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Current>.Unison;
			}
		}


	}
}
