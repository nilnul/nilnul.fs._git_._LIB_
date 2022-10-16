using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._branch._name.txt._be
{
	/*
		 */
	/// <summary>
	/// 
	/// </summary>
	public class Ch : nilnul.character_.cha.BeI
	{
		public IEnumerable<char> INVALIDS = ;
		public bool be(char obj)
		{
			return !INVALIDS.Contains(obj);
			/*They cannot have ASCII control characters (i.e. bytes whose values are lower than \040, or \177 DEL), space, tilde ~, caret ^, or colon : anywhere. */


		}
	}
}
