using nilnul.fs.address_;
using nilnul.fs.address_.spear;
using nilnul.fs.file;
using nilnul.obj.str;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.documents_.included_.nonlink_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _LargeX
	{
		static public  long  _GetThreshold(
		) {

			var blobUpperInOctets = fs.git.depo._werk_.document_._large.Settings1.Default.limit8octets;// ((long) ( svrs_._aagg.LimitInMbyteX.Blob * .9 ) )* 1048576;

			var min = 50 * 1048576;
			if (blobUpperInOctets<min)
			{
				blobUpperInOctets = min;
				nilnul.app.trace._OfXmlX.TraceError(
					new System.Xml.Linq.XElement(
						"Err"
						,
new ArgumentOutOfRangeException(
					$"{blobUpperInOctets} is less than {min} due to say misconfiguration;"
				)
					)
				);
				throw new ArgumentOutOfRangeException(
					$"{blobUpperInOctets} is less than 1moctets due to say misconfiguration;"
				);
			}

			return blobUpperInOctets;
	

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		static public IEnumerable<(string dossier, nilnul.fs.address_.Spear spear, long size)> _Document9spear9sizeEs_0includedNonlinkEs(
			//out long threshold
			//,
			IEnumerable<(string document, address_.Spear spear, long size)> nonlinkFileEsIncluded
			, nilnul.win.prog_.Git git=null
		) {

			return nonlinkFileEsIncluded.Where(
				d =>
				d.size> _GetThreshold()
			); ;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <exception cref="documents_.upsert_.xpn_.BeyondQuotaException"
		static public IEnumerable<(FileInfo t, long Length)> _Info9sizeEs_0depo(
			string module, out long threshold, nilnul.win.prog_.Git git=null
		) {

			var t = threshold= _GetThreshold();
			return _LinklessX._Info9sizeEs_0depo(module, git).Where(
				d =>
				d.Length > t  /// here out par is disallowed
			); ;
		}

		static public IEnumerable<(string document, nilnul.fs.address_.Spear spear, long size)> _Document9spear9sizeEs_0depo(
			string module, out long threshold, nilnul.win.prog_.Git git=null
		) {
			var t = threshold= _GetThreshold();

			return _LinklessX._Document9spear9sizeEs_0depo(module, git).Where(
				d =>d.size> t
			); 


		}


	
		public static IEnumerable<(string document, FileInfo info, long size)> _Document9info9sizeEs_0includedNonlinks( IEnumerable<(string document, FileInfo info, long size)> _includedNonlinks, out long threshold, Git git)
		{
			var t = threshold= _GetThreshold();
			return _includedNonlinks.Where(
				d =>d.size
				>		/// the first part of the split is the threshold
				t
			); 

		}
	}
}
