using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.location_;
using nilnul.win.prog_;

namespace nilnul.fs.git.folder_.git_.notEmbedRepo
{
	/// <summary>
	/// </summary>
	static public class _InitX { 
		


	

		/// <summary>
		/// 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_modulable"></param>
		static public void _Init(
			string _modulable
			,
			Git git=null
		) {
			nilnul.win.prog_.git.run.result._Void_throwErrX.OfAddress(_modulable, "init",git);


		}

		public static void _Init( DirectoryInfo _modulable, nilnul.win.prog_.Git git=null)
		{
			_Init(_modulable.ToString(),git);
			//throw new NotImplementedException();
		}
	

	}
}
