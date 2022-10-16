using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_
{
	/// <summary>
	/// workable
	/// </summary>
	/// <remarks>
	/// aliase:
	///		nonrepo
	/// </remarks>
	public class Plain0work:nilnul.fs.folder.BeI
	{
		

		public bool be(FolderI obj)
		{
			return
				folder.categorize_.giT_._plainWorkRepo.ret.be_.Nonrepo.Singleton.be(

					folder.categorize_.git_.PlainWorkRepo.Category(obj)
				);

			//return be_.git_.None.Singleton.be(obj)
			//	||
			//	be_.git_.Work.Singleton.be(obj);
				
				
			//throw new NotImplementedException();
		}

		public bool be_ofShield(string spear)
		{
			return be(
				new nilnul.fs.Folder(
					 nilnul.fs.address_.Shield.Parse(
					spear
					)

				)
			);
		}

		public bool be_ofAddress(string spear)
		{
			return be(
				new nilnul.fs.Folder(
					 nilnul.fs.address_.shield_._AddressX1.Create(
					spear
					)

				)
			);
		}



		static public Plain0work Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Plain0work>.Instance;
			}
		}




	}
}
