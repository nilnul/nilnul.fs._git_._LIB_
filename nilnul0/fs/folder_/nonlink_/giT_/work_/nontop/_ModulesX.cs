﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.nonlink_.git_.work_.nontop
{
	static public class _ModulesX
	{
		static public IEnumerable<nilnul.fs.git.ModuleI> Seq_disregardRepo(
			nilnul.fs.FolderI nonlinkWork
		)
		{
			foreach (
				var item in nilnul.fs.folder.dirs_._NonlinkX.Folders(nonlinkWork)

			)
			{
				if (nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(item))
				{
					foreach (var item1 in work_.top._ModulesX.Seq_disregardRepo(item))
					{
						yield return item1;

					}
				}
				else
				{
					foreach (var item1 in Seq_disregardRepo(item))
					{
						yield return item1;

					}
				}
			}
		}
	}
}