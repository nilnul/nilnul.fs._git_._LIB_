using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.dir
{
	/// <summary>
	/// a dir groomed (such as: release handles, possibly of sql server,  on the files; recoil back files that have been open for writing with possible buffer; ) before being feeded to nilnul.win.prog_.Git.  The dir might have not been setup as a repo.
	/// </summary>
	public class Primed
	{
		static public void Upload(string item, TextWriter Debug)
		{
			try
			{

				var workRepo = git.Dir.Enum_DirWorkRepo(item);
				if (workRepo == Dir.Dir_Workspace_Repo.Workspace)
				{
					git.Workspace.Upload(item, Debug);
				}
				else if (workRepo == Dir.Dir_Workspace_Repo.Repo)
				{
					return;
				}
				else
				{
					Workspace.Upload(item, Debug);
				}

			}

			catch (Exception e)
			{
				Debug.WriteLine(
					"Error in Add2Push of prepared dir: " +
					item.ToString()
					+ ":" + e.Message
				);



				//throw;
			}

		}
	}
}
