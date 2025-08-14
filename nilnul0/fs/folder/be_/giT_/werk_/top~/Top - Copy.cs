using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_.work_
{
	/// <summary>
	/// work or repo
	/// </summary>
	/// <remarks>
	/// due to unauthorization, there might be err even if the folder is a gitTop
	/// </remarks>
	public class Top : nilnul.fs.folder.BeI//,nilnul.fs.folder.BeI2
	{
		//[Obsolete()]
		//public bool be(FolderI obj)
		//{
		//	return be_.git_.Work.Singleton.be(obj) && folder_.git_.work.be_.Top.Singleton.be(
		//		new folder_.git_.Work(
		//			obj
		//		)
		//	);
		//	//throw new NotImplementedException();
		//}

		public bool be(FolderI obj)
		{
			return be_.git_.Work.Singleton.be(obj) 
				&& 
				folder_.git_.work.be_.Top.Singleton.be(
				new folder_.git_.Work(
					obj
				)
			);
		}

		public bool be(AddressI obj)
		{
					return be( new nilnul.fs.Folder(obj));
		}

		public bool be(string obj)
		{
			return be( nilnul.fs.Folder.FroAddress(obj));
		}




		static public Top Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Top>.Instance;
			}
		}

	}
}
