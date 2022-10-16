using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.folders.divs_.nonlink_.git_.nonRepo.docs
{
	static public class _FindX
	{
		static public IEnumerable<address_.spear_.ParentDoc> Find(
			IEnumerable<string> folder
			, 
			Regex regex
			//,
			//StreamWriter streamWriter 
		) {
			return Docs._ParentDocS(folder).Where(
				x=> regex.IsMatch(x.doc.ToString())
			);
		}


		static public void Out(
			IEnumerable<string> folder
			, 
			Regex regex
			,
			StreamWriter streamWriter
		) {
			Find(folder, regex).ForEach(
				x=>
				streamWriter.WriteLine(
					x
				)
			);
		}

		static public void Out(
			IEnumerable<string> folder
			, 
			string regex
			,
			StreamWriter streamWriter
		) {
			Out(folder, new Regex(regex),streamWriter);
		}


		static public void Out(
			IEnumerable<string> folder
			, 
			string regex
			,
			string streamWriter
		) {
			Out(folder, new Regex(regex),
				new StreamWriter(streamWriter)
			);
		}


	}
}
