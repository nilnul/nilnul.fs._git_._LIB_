using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.branch._name.txt_._segmented._seg._nom
{
	public class Be
		:nilnul.txt.BeI
		,
		nilnul.character_.cha.CollectionI
	{
		public bool be(char c) {
			return !(
				char.IsControl(c) || char.IsSurrogate(c) || char.IsPunctuation(c) || char.IsSeparator(c) || char.IsWhiteSpace(c) || char.IsSymbol(c)
				
				)
				||
				c == "_";


		}

		public bool be(string c) {
			return c.All(x => be(c)) &&
				nilnul.txt_._vered._name.txt.Be.Singleton.be(c)
				;

		}

	}
}
