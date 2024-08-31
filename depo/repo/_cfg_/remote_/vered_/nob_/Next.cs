using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_
{
	static public class _NextX
	{
		static public nilnul.txt_.Vered1 NameVer(
			nilnul.fs.git.ModuleI folder,
			nilnul.txt_._vered.Name name,
			nilnul.win.prog_.Git git = null) {

			var latest = newest._NulableX.Txt(folder, name, git);
			if (latest==null)
			{
				return new txt_.Vered1(name);
			}
			return nilnul.txt_.Vered1.Parse( nilnul.txt_.vered.op_.unary_._NextX.Next(latest) );

		}

		static public nilnul.txt_.Vered NameVer(
			nilnul.fs.git.ModuleI folder,
			nilnul.txt_._vered_.Name name,
			nilnul.win.prog_.Git git = null) {

			var latest = newest._NulableX.Txt(folder, name, git);
			if (latest==null)
			{
				return new txt_.Vered(name);
			}
			return nilnul.txt_.vered.op_.unary_._NextX.Next(latest);

		}

		


		static public nilnul.txt_.Vered1 NameVer(
			nilnul.fs.git.Module folder,
			nilnul.txt_._vered.Name name,
			nilnul.win.prog_.Git git = null)
		{

			return NameVer( folder as ModuleI,name,git);

		}

		static public nilnul.txt_.Vered NameVer(
			nilnul.fs.git.Module folder,
			nilnul.txt_._vered_.Name name,
			nilnul.win.prog_.Git git = null)
		{

			return NameVer( folder as ModuleI,name,git);

		}

		static public nilnul.txt_.Vered1 NameVer(
			nilnul.fs.folder_.git_.Top folder,
			nilnul.txt_._vered.Name name,
			nilnul.win.prog_.Git git = null)
		{

			return NameVer( new nilnul.fs.git.Module(folder),name,git);

		}
		static public nilnul.txt_.Vered NameVer(
			nilnul.fs.folder_.git_.Top folder,
			nilnul.txt_._vered_.Name name,
			nilnul.win.prog_.Git git = null)
		{

			return NameVer( new nilnul.fs.git.Module(folder),name,git);

		}

		static public nilnul.txt_.Vered _NameVer_moduleAddress(
			string folder,
			string name,
			nilnul.win.prog_.Git git = null)
		{

			return NameVer( 
				nilnul.fs.git.Module.FroAddress(folder)
				,
				new txt_._vered_.Name(name)
				,

				git
			);

		}



	}
}
