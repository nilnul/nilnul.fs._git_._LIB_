using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore.apply_
{
	/* extern alias obj;*/
	[Obsolete()]
	public class DotNet
	{
		static public void Overwrite(string targetAddress) {
			System.IO.File.WriteAllText(targetAddress, git.Properties.Resources.dotNetIgnore);
		}
		static public void Overwrite(nilnul.fs.Folder targetAddress) {

			Overwrite(
				nilnul.fs.folder.dir_.Doc.CreateAddress(
					targetAddress,
					_Apply.IgnoreFileName
				 ).ToString()
			);
		}

		static public void Create(string targetAddress) {
			nilnul.obj.vow_.False.Vow(System.IO.File.Exists(targetAddress));
			Overwrite(targetAddress);
		}


		static public bool Ensure(string targetAddress) {
			return Ensure(new nilnul.fs.folder_.git_.Top(targetAddress));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="targetAddress"></param>
		/// <returns>true if created</returns>
		static public bool Ensure(nilnul.fs.folder_.git_.Top targetAddress) {
			if (!System.IO.File.Exists(targetAddress.ToString()))
			{
				Overwrite(targetAddress);
				return true;
			}
			return false;
		}
		static public bool Ensure(nilnul.fs.Folder targetAddress) {
			return Ensure(new nilnul.fs.folder_.git_.Top(targetAddress));
		}

		static public void Create(nilnul.fs.Folder targetAddress) {
			Create(
				nilnul.fs.folder.dir_.Doc.CreateAddress(
					targetAddress,
					_Apply.IgnoreFileName
				 ).ToString()
			);
		}
	}
}