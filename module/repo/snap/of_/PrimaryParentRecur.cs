using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap.of_
{
	/// <summary>
	///  ~n, means nth 1st parent recursively;
	///  eg:
	///		~ means ~1
	///		~2
	///			the main parent of the main parent of current;
	/// </summary>
	internal class PrimaryParentRecur
		: nilnul.obj.Box_ofIn<uint>
	{

		public PrimaryParentRecur(in uint val) : base(val)
		{
		}

		public PrimaryParentRecur(uint x) : base(x)
		{
		}

		public override string ToString()
		{
			return $"~{ this.boxed}";
		}
	}
}
