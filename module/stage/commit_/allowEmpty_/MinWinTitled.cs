using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.commit_.allowEmpty_
{
	static public class _MinUiTitledX
	{
		static public int _ExitCode( 
			string _module
			,
			string _msg_normalized
			,
			nilnul.win.prog_.Git git=null)
		{
			return nilnul.os.prog_.git.run_.exit._CodX._Cod_ofDir9argument9cmd(
				_module
				, 
				$"commit --allow-empty  -m\"{_msg_normalized}\""
				,
				git
			);
		}


		static public int ExitCode(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.index._commit.Msg msg
			, nilnul.win.prog_.Git git=null
		)
		{
			return _ExitCode(
				module.ToString()
				,
				msg
				,git
				);
		}

		static public int ExitCode( 
			string module
			,
			string msg_notNormalized
			,
			nilnul.win.prog_.Git git=null)
		{
			return ExitCode(
				 nilnul.fs.git.Module.FroAddress(module)
				 ,
				 new _commit.Msg(msg_notNormalized)
				 ,git
			);
		}


	}
}
