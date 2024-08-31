using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap.parents.indexed
{
	/// <summary>
	///  ^n means nth among the parents.
	/// eg:
	///		^ or ^1
	///		^0 means the commit itself and is used when <rev> is the object name of a tag object that refers to a commit object
	/// </summary>
	/// <remarks>
	/// note: in windows cmd shell, the "^" is an escape character.
	/// </remarks>
	internal class Notation
	{
	}
}
