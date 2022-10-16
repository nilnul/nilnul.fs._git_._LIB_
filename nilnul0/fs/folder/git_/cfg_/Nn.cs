using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.git_.cfg_
{
		public static class _NnX
		{

			/// <summary>
			/// in this very folder, ensure a file named, ".nilnul" or any configed, to store the settings.
			/// </summary>
			/// <param name="folder"></param>
			/// <param name="key"></param>
			/// <param name="val"></param>
			/// <param name="git"></param>

			static public void _Set(nilnul.fs.FolderI folder, string key, string val, nilnul.win.prog_.Git git = null)
			{
				//if (
				//	nilnul.fs.address.be_.Folder.Singleton.be(
				//		new nilnul.fs.address_.BaseDst(folder.address.en, ".git")
				//	)

				//)
				{

					nilnul.fs.folder.git_._CfgX._Set(
						folder.ToString()
						, nilnul.fs.folder.dnt_.cfg.Settings1.Default.txt
						, key
						, val
						, git
					);

				}
			}

		

		}
	}
