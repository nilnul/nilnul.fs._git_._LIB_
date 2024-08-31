using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work
{
    /// <summary>
    ///  the documents of this work.
    ///     excluding:
    ///         files in .git
    ///         files in submodule
    /// </summary>
    /// 
    [Obsolete()]
	static public class _DocumentsX
    {

        [Obsolete(nameof(_work_.directory._DocumentsX))]
        private static IEnumerable<string> _OfNontopWork(string nontopWork)
        {
            foreach (
                var child in nilnul.fs.folder.dirs.as_._ChildsX.AddressTxtS(
                nontopWork)
                )
            {

                if (!nilnul.fs.folder_.git_.work.be_._TopX._Be(child))
                {
                    ///sub
                    foreach (var item in _OfNontopWork(child))
                    {
                        yield return item;
                    }
                }
            }
            foreach (var item in nilnul.fs.folder._DocsX.Infos_ofAddress(nontopWork))
            {
                yield return item.FullName;

            }
        }

        static public IEnumerable<string> OfAddress(
            string module
            ,
            nilnul.win.prog_.Git git = null
        )
        {
            foreach (var child in _work_._DirsX.Addresses_ofAddress(module))
            {

                foreach (var item in _work_.directory._DocumentsX._OfNontopWork(child))
                {
                    yield return item;
                }

            }

            //foreach (var child in nilnul.fs.folder.dirs.as_._ChildsX.AddressTxtS(module))
            //{
            //    if (nilnul.fs.git.module.dir.be_._WorkX._Be_ofAddress(child, git))
            //    {
            //        if (
            //            !nilnul.fs.git.module.dir_.work.be_._TopX._Be(child, git)
            //        )
            //        {
            //            foreach (var item in _work_.directory._DocumentsX._OfNontopWork(child))
            //            {
            //                yield return item;
            //            }
            //        }
            //    }
            //}
            foreach (var item in nilnul.fs.folder._DocsX.Infos_ofAddress(module))
            {
                yield return item.FullName;

            }
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

    }
}
