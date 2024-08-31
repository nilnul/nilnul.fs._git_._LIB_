using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap.of_
{
	
	
	/// <summary>
	///  ~n, means nth 1st parent recursively;
	///  in otherwords ^^...^ at n times.
	///  eg:
	///		~ means ~1
	///		~2
	///			the main parent of the main parent of current;
	///		HEAD~1
	///		HEAD~
	///			,the first parent of head
	///		HEAD~2
	///			,the first parent of the first parent of HEAD. This would be the same as HEAD^^
	///			
	/// </summary>
	internal class Tilde4PrimaryParentRecur
		: nilnul.obj.Box_ofIn<uint>
	{

		public Tilde4PrimaryParentRecur(in uint val) : base(val)
		{
		}

		public Tilde4PrimaryParentRecur(uint x) : base(x)
		{
		}

		public override string ToString()
		{
			return $"~{ this.boxed}";
		}
	}
}
