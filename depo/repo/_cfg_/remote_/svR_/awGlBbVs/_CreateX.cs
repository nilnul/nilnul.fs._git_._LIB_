using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.awGlBbVs
{

		static public class _CreateX
		{




			static public void Exe(nilnul.fs.git.ModuleI _gitTop, nilnul.web.UrlI3 url
				,
				nilnul.win.prog_.Git git = null
			)
			{


				nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
					_gitTop
					, 
					new _remote.Name(_AwGlBbVsX.GetNewestKey())

					,

					url
					, git
				);

			}

		static public void Exe(nilnul.fs.git.Module _gitTop, nilnul.web.UrlI3 url
			,
			nilnul.win.prog_.Git git = null
		)
		=> Exe(_gitTop as nilnul.fs.git.ModuleI, url, git);

		static public void Exe(nilnul.fs.folder_.git_.Top _gitTop, nilnul.web.UrlI3 url
			,
			nilnul.win.prog_.Git git = null
		)
		=> Exe(new nilnul.fs.git.Module(_gitTop), url, git);


			static public void Exe(nilnul.fs.folder_.git_.Top _gitTop, string url
				,
				nilnul.win.prog_.Git git = null
			)
			{


				Exe(_gitTop, nilnul.web.url._ParseX3.Parse(url), git);

			}

		static public void Exe(ModuleI gitTop, string firstUrl)
		{
			Exe(gitTop, nilnul.web.url._ParseX3.Parse(firstUrl));
		}
	}
	}
