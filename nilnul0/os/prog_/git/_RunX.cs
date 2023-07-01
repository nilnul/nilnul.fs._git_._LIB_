using nilnul.fs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.git
{
	static public class _RunX
	{
	
		static public void _Vod_worksiteAssumeAddress_ofArgument(
			string _module
			,

			string arg
			,
			nilnul.win.prog_.Git git = null

		)
		{
			
			Process.Start(
				new ProcessStartInfo(
				   nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
				   ,
				   arg
				)
				{
					WorkingDirectory =		   _module
				}

		   );
		
		}

		static public void _Vod_worksiteAssumeAddress0nul_ofArgument(
			string _module
			,

			string arg
			,
			nilnul.win.prog_.Git git = null

		)
		{
			if (_module is null)
			{
				Process.Start(
					new ProcessStartInfo(
				   nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
				   ,
				   arg
				   )

				);
				return;
			}

			_Vod_worksiteAssumeAddress_ofArgument(_module,arg,git);
		}


		static public void _Vod_worksiteAssumeNulable_ofArgument(
			nilnul.fs.address_.ShieldI _module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			Process.Start(
				new ProcessStartInfo(
			   nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
			   ,
			   arg
			   )
				{
					WorkingDirectory =		   _module?.ToString()
				}

		   );
		
		}

		public static void _Vod_1ofArgument(FolderI folder, string v, Git git=null)
		{
			_Vod_worksiteAssumeAddress_ofArgument(folder.ToString(),v,git);
		}

		static public void _Vod_1ofArgument(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			 _Vod_worksiteAssumeNulable_ofArgument(
				module.top1.en.address.en
				,
				arg
				, git
			);
		}

		static public void _Vod_ofArgument(

			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			 _Vod_worksiteAssumeNulable_ofArgument(null, arg, git);

		}


		static public void _Vod_ofAddress_ofArgument(
			string module //git is supposed to run on a nonModule folder
			,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			 _Vod_worksiteAssumeNulable_ofArgument(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				arg
				, git
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="git">nullable</param>
		/// <param name="module"></param>
		/// <param name="args"></param>
		static public void _Vod_1dirOfAddress_ofArgs(
			nilnul.win.prog_.Git git,

			string module //git is supposed to run on a nonModule folder
			,
			IEnumerable<string> args
		)
		{
			 _Vod_worksiteAssumeNulable_ofArgument(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				new nilnul.win.prog._run.Args1(
					args
				).ToString()
				, git
			);
		}

		static public void _Vod_0nulable_1address_2args(
			nilnul.os.prog_.Git git0nul,

			string moduleAddress //git is supposed to run on a nonModule folder
			,
			IEnumerable<string> args
		)
		{
			 _Vod_worksiteAssumeNulable_ofArgument(
				 nilnul.fs.address_.shield_._AddressX1.Create(moduleAddress)
				,
				new nilnul.win.prog._run.Args1(
					args
				).ToString()
				, git0nul
			);
		}
		static public void _Vod_0nulable_1address_2args(
			nilnul.os.prog_.Git git0nul,

			string moduleAddress //git is supposed to run on a nonModule folder
			,
			params string[] args
		)
		{
			 _Vod_worksiteAssumeNulable_ofArgument(
				 nilnul.fs.address_.shield_._AddressX1.Create(moduleAddress)
				,
				new nilnul.win.prog._run.Args1(
					args
				).ToString()
				, git0nul
			);
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="git">nulable</param>
		/// <param name="module"></param>
		/// <param name="args"></param>
		static public void _Vod_1dirOfAddress_ofArgs(
			nilnul.win.prog_.Git git,

			string module //git is supposed to run on a nonModule folder
			,
			params string[] args
			)
		{
			 _Vod_1dirOfAddress_ofArgs(git, module, (IEnumerable<string>)args);
		}
		static public void _Vod_dirOfAddress_ofArgs(
			string module //git is supposed to run on a nonModule folder
			,
			params string[] args
		)
		{
			 _Vod_1dirOfAddress_ofArgs(null, module, args);
		}

		static public void _Vod_dirOfAddress_ofArgument(
			string module //git is supposed to run on a nonModule folder
			,
			string argument
		)
		{
			 _Vod_worksiteAssumeAddress_ofArgument(module, argument);

		}



	}
}
