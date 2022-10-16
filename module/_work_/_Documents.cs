using nilnul.fs.folder_.git_.work_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_
{
    /// <summary>
    ///  the documents of this work.
    ///     excluding:
    ///         files in .git
    ///         files in submodule
    /// </summary>
	static public class _DocumentsX
    {
        static public IEnumerable<string> OfAddress(
            string module
            ,
            nilnul.win.prog_.Git git = null
        )
        {
			return nilnul.fs.folder_.giT_.work_.top.divs_._WithinWorkX._Addresses_addressAssumeTop(module,git)
				.SelectMany(
				x=>System.IO.Directory.EnumerateFiles(x)
			);

            //foreach (var child in _work_._DirsX.Addresses_ofAddress(module))
            //{
            //    foreach (var item in _work_.directory._DocumentsX._OfNontopWork(child))
            //    {
            //        yield return item;
            //    }
            //}
           
            //foreach (var item in nilnul.fs.folder._DocsX.Infos_ofAddress(module))
            //{
            //    yield return item.FullName;
            //}
        }

        public static IEnumerable<FileInfo> FileInfoS_ofAddress(string module)
        {
            return OfAddress(module).Select(x => new FileInfo(x));
            //throw new NotImplementedException();
        }
        static public IEnumerable<string> Addresses(
            nilnul.fs.git._module_.TopI module
            ,
            nilnul.win.prog_.Git git = null
        )
        {
            return OfAddress(module.top.en.address.ToString(), git);
        }

		public static IEnumerable<string> Addresses(Top work ,
            nilnul.win.prog_.Git git = null)
		{
            return OfAddress(work.en.address.ToString(), git);

		}
	}
}
