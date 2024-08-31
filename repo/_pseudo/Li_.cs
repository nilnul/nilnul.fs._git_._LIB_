using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._pseudo
{
	internal enum Li_
	{
		[Description("AUTO_MERGE")]
		AutoMerge
			,
		[Description("CHERRY_PICK_HEAD")]
		CherryPickHead
			,
		[Description("ORIG_HEAD")]
		OrigHead

	}
}
