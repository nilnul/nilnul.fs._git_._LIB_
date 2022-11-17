using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using nilnul.win.process;

namespace nilnul.fs.folder_.giT_
{
	/// <summary>
	/// </summary>
	/// 
	public class Nonrepo
		:
		nilnul.fs.folder.be_.git_.nonrepo.vow.En
	{
		public Nonrepo(FolderI val) : base(val)
		{
		}

		static public Nonrepo OfAddress(string s) {
			return new Nonrepo(
				nilnul.fs.Folder.FroAddress(s)
			);
		}
	}
}
