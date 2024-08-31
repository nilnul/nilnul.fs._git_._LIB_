using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo
{
	public interface VowI:nilnul.obj.VowI_ofIn<DepoI>
	{
	}
	static public  class VowX
	{
		static public void Vow(this VowI vow, in string obj) {
			vow.vow(
				 nilnul.fs.git.Module.FroAddress(obj)
			); 
		}
		static public void Vow(this VowI vow, in DirectoryInfo obj) {
			vow.Vow(
				 obj.FullName
			); 
		}

	}

	public abstract class VowA : VowI, _vow_.OfAddressI
	{
		public void vow(in string obj) {
			VowX.Vow(this,in obj); 
		}
		public abstract void vow(in DepoI obj);
	}


}
