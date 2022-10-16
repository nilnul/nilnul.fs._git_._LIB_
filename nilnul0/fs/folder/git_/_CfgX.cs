using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.git_
{
	static public class _CfgX
	{
		static public void _Set(nilnul.fs.FolderI folder, nilnul.fs._address.DocI doc, string _key_valid, string _val_valid, nilnul.win.prog_.Git git=null) {

			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				folder
				,
				$"config -f {nilnul.fs._address.doc.phrase_.QuoteIfHasWhite.Singleton.phrase(doc)} {_key_valid} { _val_valid}"
				, git
			);
		}
		static public void _Set(nilnul.fs.FolderI folder, nilnul.fs._address.Doc doc, string _key_valid, string _val_valid, nilnul.win.prog_.Git git = null)
		{

			_Set(folder, (nilnul.fs._address.DocI)doc, _key_valid, _val_valid, git);
		}

		static public void _Set(nilnul.fs.FolderI folder, string doc, string _key_valid, string _val_valid, nilnul.win.prog_.Git git=null) {

			_Set((folder), new nilnul.fs._address.Doc(doc), _key_valid, _val_valid, git);

		}
		static public void _Set(nilnul.fs.address_.ShieldI folder, nilnul.fs._address.DocI doc, string _key_valid, string _val_valid, nilnul.win.prog_.Git git=null) {

			_Set( new nilnul.fs.Folder(folder), doc,_key_valid,_val_valid,git);
		}

		static public void _Set(string folder, nilnul.fs._address.DocI doc, string _key_valid, string _val_valid, nilnul.win.prog_.Git git=null) {

			_Set(  nilnul.fs.address_.Shield.FroAddress(folder), doc,_key_valid,_val_valid,git);
		}
		static public void _Set(string folder, nilnul.fs._address.Doc doc, string _key_valid, string _val_valid, nilnul.win.prog_.Git git=null) {

			_Set( folder, (nilnul.fs._address.DocI)doc,_key_valid,_val_valid,git);
		}

		static public void _Set(string folder, string doc, string _key_valid, string _val_valid, nilnul.win.prog_.Git git=null) {

			_Set(  (folder), new nilnul.fs._address.Doc( doc),_key_valid,_val_valid,git);
		}


	}
}
