using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage.commit
{
	static public class _VodX
	{


		/// <summary>
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>

		public static void _Vod_addressAssumeModule_assumeNub(
			string _location
			,
			nilnul.os.prog_.Git git = null
		)
		{

			const string commitMsg = "commit workspace index for possibly restoring work site later"; //don't change this as we need to keep the commit intact given same treeish;

			int exitCode = nilnul.fs.git.module.index.commit_.allowEmpty_._MinUiTitledX.ExitCode(
				_location
				,
				commitMsg
				,
				git
			);
			switch (exitCode)
			{
				case 128:
					new nilnul.obj.vow_.true_.xpn_.Unacceptable($"exception (exitCode:{exitCode}) When commiting worksite index/stage for {_location}: maybe there is index.lock? the exception is shown on the popped console, repeat the operation in git bash to repro").vow(
						//exitCode
						//==
						//0
						false
					);
					break;

				default:
					new nilnul.obj.vow_.true_.xpn_.Unacceptable($"exception (exitCode:{exitCode}) When commiting worksite index/stage for {_location}: the exception is shown on the popped console, repeat the operation in git bash to repro").vow(
						exitCode
						==
						0
					);

					break;
			}

		}

		public static void _Vod_assumeModule_assumeNub(
			fs.FolderI _module
,
			nilnul.os.prog_.Git git = null
		)
		{
			_Vod_addressAssumeModule_assumeNub(_module.ToString(), git);
		}
	}
}
