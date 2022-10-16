using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap.document.toWork_.asNext_
{
	static public class _ByShowX
	{
		/*git show HEAD^:main.cpp > old_main.cpp
		 Instead of full path, from the docs: "A path starting with ./ or ../ is relative to the current working directory." Works on my 1.8.5 version. 

		If you're working in DOS, instead of git reset --soft HEAD^ you'll need to use git reset --soft HEAD~1. The ^ is a continuation character in DOS so it won't work properly. 
		 */


		public static void _Void(nilnul.fs.git.ModuleI module, string _snap, nilnul.fs._address.DocumentI document,  nilnul.win.prog_.Git git=null)
		{
			var shield = new nilnul.fs.address_.shield_.BaseDiv(module.top.en.address.en, document.div);
			var folder = new nilnul.fs.Folder(shield);

			var doc = nilnul.fs._address.doc_.MainExt.Ov(document.doc);

			var tgt = new nilnul.fs.folder.denote_.MainVered(folder).next(
				doc.main.ToString() + "(!Git)"
				,
				doc.ext
			);

			//	nilnul.fs._address.doc._MainX.Main1(
			//		document.doc
			//	)
			//	,
			//	nilnul.fs._address.doc._ExtX2.Exe(
			//		document.doc
			//	)
				
			//);
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(module,$@"show {_snap}:{nilnul.txt.op_.unary_._QuoteIfHasSpaceTabX.Op( document.ToString())} > {nilnul.txt.op_.unary_._QuoteIfHasSpaceTabX.Op(new nilnul.fs._address.Document(document.div,tgt).ToString() )}",git);

		}

		public static void Void(nilnul.fs.git.ModuleI module, string snap, string document,  nilnul.win.prog_.Git git=null)
		{
			_Void(module,snap, nilnul.fs._address.Document.Parse(document),git);

		}
	}
}
