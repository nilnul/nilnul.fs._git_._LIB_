using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_
{
	/// <summary>
	/// excluding ".gitignore" files
	/// </summary>
	static public class _NoIgnoreSettingX
	{
		static public IEnumerable<string> OfAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
            return _work_._DocumentsX.OfAddress(module).Where(
               a=>
			    ! nilnul.fs._address.doc.Eq.Singleton.Equals(
					 nilnul.fs.address_.spear._DocX.__Txt(a) 
					,
					_module._work_.div.doc_._IgnoreX.NAME
				 )
             );
			
		}
		public static IEnumerable<FileInfo> FileInfoS_ofAddress(string module
			,
			nilnul.win.prog_.Git git = null
			
			)
		{
			return OfAddress(module).Select(x => new FileInfo(x));
			//throw new NotImplementedException();
		}

		static public IEnumerable<string> Addresses(
			nilnul.fs.folder_.git_.work_.Top module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return OfAddress(module.en.address.ToString(),git);
		}

		static public IEnumerable<string> Addresses(
			nilnul.fs.git._module_.TopI1 module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return OfAddress(module.top1.en.address.ToString(),git);
		}

	}
}
