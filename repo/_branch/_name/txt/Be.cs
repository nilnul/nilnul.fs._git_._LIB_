using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._branch._name.txt
{
	/*extern alias txt;*/
	/*https://mirrors.edge.kernel.org/pub/software/scm/git/docs/git-check-ref-format.html
	  
	Git imposes the following rules on how references are named:
They can include slash / for hierarchical (directory) grouping, but no slash-separated component can begin with a dot . or end with the sequence .lock. 
They must contain at least one /. This enforces the presence of a category like heads/, tags/ etc. but the actual names are not restricted. If the --allow-onelevel option is used, this rule is waived. 
They cannot have two consecutive dots .. anywhere. 
They cannot have ASCII control characters (i.e. bytes whose values are lower than \040, or \177 DEL), space, tilde ~, caret ^, or colon : anywhere. 
They cannot have question-mark ?, asterisk *, or open bracket [ anywhere. See the --refspec-pattern option below for an exception to this rule. 
They cannot begin or end with a slash / or contain multiple consecutive slashes (see the --normalize option below for an exception to this rule) 
They cannot end with a dot .. 
They cannot contain a sequence @{. 
They cannot be the single character @. 
They cannot contain a \.  
		 */
	/// <summary>
	/// 
	/// </summary>
	public class Be
		: 
		/*txt::*/
		nilnul.txt.BeI
	{
		/// <summary>
		/// except char.be, program.be
		/// </summary>
		public Predicate<string>[] _cannots = new Predicate<string>[] {
			x=>x.Split('/').Any( y=> y.StartsWith(".") || y.EndsWith(".lock"))
			,
			x=> x.EndsWith(".")
			,
			x=>x.Contains("@{")
			,
			x=> x.EndsWith("/")
			,
			x=>x.StartsWith("/")
			,
			x=>x.Contains("//")
			,
			x=>x.Contains("..")

		};

		public bool be(string obj)
		{
			return new nilnul.txt.be_.NotContain(_be.ch.set_.Invalid.Set).be(obj)
				&&

			_cannots.All(cannot=> !cannot(obj) )
			&&
			!_be.whole.set_.Invalids.Str.Contains(obj)

			;


			//return Regex.IsMatch(obj, @"\A[a-zA-Z0-9_-]+\z");	//\w is digits and letters
			//throw new NotImplementedException();
		}

		static public Be Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be>.Instance;
			}
		}


		

	}
}
