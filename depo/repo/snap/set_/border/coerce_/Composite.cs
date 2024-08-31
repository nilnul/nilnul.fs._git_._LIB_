using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.set_.border.coerce_
{
	/// eg:
	///		A..B C..D
	///			,means:
	///				( (..B) | (..D) ) -  ( (..A) |(..C) )
	/// <summary>
	/// </summary>
	/// eg:
	///		^D B C
	///			( (..B) |(..C) ) - (..D)
	///
	/// 
	///
	[Obsolete("Manual is confusing, and not translates well into set theory such as set operator precedence and associativity;")]
	internal class Composite
	{
	}
}
