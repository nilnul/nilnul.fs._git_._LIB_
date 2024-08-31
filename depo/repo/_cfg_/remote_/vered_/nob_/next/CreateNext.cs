using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remotes_.ids_.named
{
	static public class _CreateNextX
	{
		static public void CreateNext(
			nilnul.fs.folder_.git_.Top folder,
			nilnul.txt_._vered_.Name name,
			nilnul.web.UrlI2 url
			,
			nilnul.win.prog_.Git git = null) {

			var latest = _NextX.NameVer(folder, name, git);

			_cfg_._remote._CreateX.RetVoid(folder, name.ToString(), url, git);
		}


		static public void CreateNext(
			nilnul.fs.folder_.git_.Top folder,
			string name,
			nilnul.web.UrlI2 url
			,
			nilnul.win.prog_.Git git = null) {

			CreateNext(folder, new txt_._vered_.Name(name),url,git);
		}

		static public void CreateNext(
			nilnul.fs.folder_.git_.Top folder,
			string name,
			string url
			,
			nilnul.win.prog_.Git git = null) {

			CreateNext(folder, new txt_._vered_.Name(name),nilnul.web.url._ParseX2.Parse(url) ,git);
		}

		static public void CreateNext(
			nilnul.fs.git.Module module,
			string name,
			string url
			,
			nilnul.win.prog_.Git git = null) {

			CreateNext(module.top, new txt_._vered_.Name(name),nilnul.web.url._ParseX2.Parse(url) ,git);
		}



	}
}
