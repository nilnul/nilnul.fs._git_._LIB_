using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.werk.documents
{
	/// <summary>
	/// if two nonlink documents, whether they are in the same folder or no, are the same
	/// , then after the first one, each docment would become a symlink pointing to the first one.
	/// The search is done by broadth search first.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// If this is depth search, hence the first one is by dictionary order.
	/// we can also use hardlink rather than symlink to save space; but hardlink would inadvertently change another file when one file is edited;
	internal class IDeDuplicate
	{
	}
}
