using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.cfg.section_.core
{
	public class Longpaths
	{
		static public string _GetVal_0depo(
			string module
			,
			nilnul.os.prog_.Git git = null

		)
		{

			var result = nilnul.os.prog_.git.run_.exit_.onDue._ResultX._Result_assumeAddress(module, $"config {KEY}", git, 30*1000, 30*1000);
			

			return result.msg0Nul4errTrimmed??"";

			
		}

		public const string KEY = "core.longpaths";
		/// <summary>
		/// null for error; nonul value trimmed
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// <exception cref="">
		///	if no value is set, exit code 1 is returned. to have exit code as 0, we can use the "--default value" option.
		/// </exception>

		static public string GetVal(
			nilnul.fs.git.ModuleI module
			,
			nilnul.os.prog_.Git git = null

		)
		{

			var result = nilnul.os.prog_.git.run_.exit_.onDue._ResultX.Result(module, $"config {KEY}", git, 30*1000, 30*1000);
			

			return result.msg0Nul4errTrimmed??"";

			
		}

		static public void _ForceTrue_0depo(
			string module
			,
			nilnul.win.prog_.Git git = null

		)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX._Vod_0address_1argument_2xpn(
				module
				,
				"config core.longpaths true"
				,
				$"git config core.longpaths true @{module} throws exception, possibly due to config.lock; do it in console to reproduce"
				,
				git
			);
		}

		static public void SetTrue(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.prog_.Git git = null

		)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				module
				,
				"config core.longpaths true"
				,
				$"git config core.longpaths true @{module} throws exception, possibly due to config.lock; do it in console to reproduce"
				,
				git
			);
		}

		static public void EnsureTrue(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.prog_.Git git = null

		)
		{
			if (GetVal(module,git) !="true" )
			{
				SetTrue(module,git);
			};
		}
		static public void _EnsureTrue_0depo(
			string module
			,
			nilnul.win.prog_.Git git = null

		)
		{
			if (_GetVal_0depo(module,git) !="true" )
			{
				_ForceTrue_0depo(module,git);
			};
		}


		static public void SetTrue_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git = null

		)
		{
			SetTrue(
				nilnul.fs.git.Module.FroAddress(module)
				,
				git
			);
		}

		static public void EnsureTrue_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git = null

		)
		{
			EnsureTrue(
				nilnul.fs.git.Module.FroAddress(module)
				,
				git
			);
		}


	}
}
