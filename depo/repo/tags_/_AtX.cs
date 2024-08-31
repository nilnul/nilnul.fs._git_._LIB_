using nilnul.os.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.tags_
{
	static public class _AtX
		
	{
		public const string ARGUMENT = "tag --points-at"; // default is current

		static public IEnumerable<string> _Names_0depo_1rep4snap(
			string _module, string repre4snap, nilnul.os.prog_.Git git = null
		)
		{
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				 nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
					 _module
					 ,
					 $"{ARGUMENT} {repre4snap}"
					 ,
					 git
				 )
			);
		}

		static public IEnumerable<string> _Names_0depo_1tag(
			string _module, string tag, nilnul.os.prog_.Git git = null
		)
		{
			return _Names_0depo_1rep4snap(_module, $"tags/{tag}",git);
		}





	}
}
