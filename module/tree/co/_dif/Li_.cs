using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.tree.co._dif
{
	internal enum Li_
	{
		/// <summary>
		/// A
		/// </summary>
		Added
			,
		/// <summary>
		///  (C)
		/// </summary>
		Copied,
		/// <summary>
		///  (D)
		/// </summary>
		Deleted,

		/// <summary>
		/// (M)
		/// </summary>
		Modified ,

		/// <summary>
		/// (R)
		/// </summary>
		Renamed ,

		///have their type (i.e. regular file, symlink, submodule, ...) changed (T)
		TypeChaned,
		/// <summary>
		///  (U)
		/// </summary>
		Unmerged,
		/// <summary>
		///  (X)
		/// </summary>
		 Unknown,
		 /// <summary>
		 /// or have had their pairing Broken (B).
		 /// </summary>
		Broken
	}
}
