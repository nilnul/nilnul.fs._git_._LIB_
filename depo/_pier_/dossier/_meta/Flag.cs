using nilnul.txt.stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier_.dossier._meta
{
	///<summary>
	/// A 16-bit ‘flags’ field split into (high to low bits)
	///		eg:
	/// hex: 0009
	/// bin: 00000000 00001001
	///		1-bit assume-valid flag(false);
	///		1-bit extended flag(must be zero in version 2);
	///		2-bit stage(during merge);
	///		12-bit name length if the length is less than 0xFFF, otherwise 0xFFF is stored in this field.
	///</summary>
	/* 
	  (Version 3 or later) A 16-bit field, only applicable if the
  "extended flag" above is 1, split into (high to low bits).

    1-bit reserved for future

    1-bit skip-worktree flag (used by sparse checkout)

    1-bit intent-to-add flag (used by "git add -N")

    13-bit unused, must be zero
	*/

	internal enum Flag
	{
		
	}


}
