using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._depo_._work_.dir_
{

	/// <summary>
	/// if a folder is named using only digits like "2412", it's a partition folder. It's often named as datetime. <see cref="nilnul.time._lex_.phrase_.yr_"/> <see cref="nilnul.time.texfy_"/> <see cref="nilnul.time._phrase_."/> <see cref="nilnul.time.texfy_.alnum_"/>.
	///
	/// when the files in a depo are too much, partition folder is used to delegate some files into the child folder.
	/// Often media files such as image, sound, video are put into such folders.
	/// </summary>
	/// vs:
	///		<see cref="_InboxX"/>
	/// 
	public interface IPartition { }
}
