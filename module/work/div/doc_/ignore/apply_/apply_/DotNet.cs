using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg.ignore.apply_
{
	[Obsolete(nameof(_ignore.apply_.DotNet))]
	public class DotNet
	{
		public const string srcContainer = @"E:\170203\data\nilnul.fs\git\_fs\ignoreCfg_\dotNet_";
		public static string Src = System.IO.Path.Combine(srcContainer, Ignore.IgnoreFileName);
		static public void Apply(string targetAddress) {

			System.IO.File.Copy(Src, 
				System.IO.Path.Combine(targetAddress, Ignore.IgnoreFileName)
			);

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="targetAddress"></param>
		/// <exception cref="">if file already exists</exception>
		static public void Apply(nilnul.fs.Folder targetAddress) {

			System.IO.File.Copy(Src, 

				nilnul.fs.folder.dir_.Doc.CreateAddress(
					targetAddress,
					Ignore.IgnoreFileName
				 ).ToString()
			);

		}

		static public void Overwrite(nilnul.fs.Folder targetAddress) {

			System.IO.File.Copy(Src, 

				nilnul.fs.folder.dir_.Doc.CreateAddress(
					targetAddress,
					Ignore.IgnoreFileName
				 ).ToString()
				 ,true
			);

		}



	}
}
