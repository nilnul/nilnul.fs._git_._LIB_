using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.next
{
	static public class _CreateX
	{
		static public void Void(
			nilnul.fs.git.ModuleI folder,
			nilnul.txt_._vered_.Name name,
			nilnul.web.UrlI3 url
			,
			nilnul.win.prog_.Git git = null
		)
		{

			var latest = _NextX.NameVer(folder, name, git);
			_cfg_.remote._CreateX.RetVoid(folder, name.ToString(), url, git);
		}

		static public void Void(
			nilnul.fs.git.ModuleI module,
			nilnul.txt_._vered_.Name name,
			string url
			,
			nilnul.win.prog_.Git git = null
		)
		{

			Void(module, name, nilnul.web.url._ParseX3.Parse(url), git);
		}

		static public void Void(
			nilnul.fs.git.ModuleI module,
			string name,
			string url
			,
			nilnul.win.prog_.Git git = null
		)
		{

			Void(module, new txt_._vered_.Name(name), (url), git);
		}



		static public void Void(
			nilnul.fs.git.Module folder,
			nilnul.txt_._vered_.Name name,
			nilnul.web.UrlI3 url
			,
			nilnul.win.prog_.Git git = null
		)
		{
			Void(folder as nilnul.fs.git.ModuleI, name, url, git);
		}

		static public void Void(
			nilnul.fs.folder_.git_.Top folder,
			txt_._vered_.Name name,
			nilnul.web.UrlI3 url
			,
			nilnul.win.prog_.Git git = null)
		{

			Void(new nilnul.fs.git.Module(folder), name, url, git);
		}

		static public void Void(
			nilnul.fs.folder_.git_.Top folder,
			string name,
			nilnul.web.UrlI3 url
			,
			nilnul.win.prog_.Git git = null)
		{

			Void(new nilnul.fs.git.Module(folder), new txt_._vered_.Name(name), url, git);
		}


		static public void Void(
			nilnul.fs.folder_.git_.Top folder,
			string name,
			string url
			,
			nilnul.win.prog_.Git git = null
		)
		{

			Void(
				folder
				,
				new txt_._vered_.Name(name)
				,
				nilnul.web.url._ParseX3.Parse(url)
				,
				git
			);
		}



	}
}
