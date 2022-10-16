using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_.noDotLed_.nonlink_
{
	public class Large
		
	{
		private nilnul.num_.Positive1 _size;

		public nilnul.num_.Positive1 size
		{
			get { return _size; }
			set { _size = value; }
		}

		private nilnul.win.prog_.Git _git0nul;

		public nilnul.win.prog_.Git git0nul
		{
			get { return _git0nul; }
			set { _git0nul = value; }
		}

		 Large(nilnul.num_.Positive1 size,nilnul.win.prog_.Git git0nul)
		{
			_size = size;
			_git0nul = git0nul;
		}

		public Large(int size,nilnul.win.prog_.Git git0nul=null)
			:this(new num_.Positive1(size),git0nul)
		{
		}

		static public IEnumerable<string> _Addresses_addressAssumeModule_thresholdAssumePositive(
			string module
			,
			int size_assumePositive
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return _NonlinkX._Addresses_addressAssumeModule(module,git).Where(x=>
			new System.IO.FileInfo(x).Length> size_assumePositive
			);
		}


		public IEnumerable<string> _addresses_addressAssumeModule(
			string module
		)
		{
			return _NonlinkX._Addresses_addressAssumeModule(module,git0nul).Where(x=>
			new System.IO.FileInfo(x).Length> (int) _size.en
			);
		}

		/// <summary>
		/// 50M is the recommended by github
		/// </summary>
		/// <returns></returns>
		static public Large _Of49Mega() {
			return new Large(
				49* nilnul.num_.radix_.binary_.Mega.INT32
			);
		}
		static public Large Of49Mega = _Of49Mega();


		/// <summary>
		/// github would issue a warning
		/// </summary>
		/// <returns></returns>
		static public Large _Of99Mega() {
			return new Large(
				99* nilnul.num_.radix_.binary_.Mega.INT32
			);
		}
		static public Large Of99Mega = _Of99Mega();


	}
}
