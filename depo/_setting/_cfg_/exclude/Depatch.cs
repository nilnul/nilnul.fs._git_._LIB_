using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using System.Linq.Expressions;

namespace nilnul.fs.git.module._ignore_.exclude
{
	/// <summary>
	/// patch the ignore file to reflect dotnet ignores
	/// </summary>
	static public class _DepatchX
	{
		static public void _OfSpear(nilnul.fs.FileI spear1, IEnumerable<string> lines2exclude)
		{
			if (!lines2exclude.Any())
			{
				return;
			}

			var spear = spear1.ToString();
			System.IO.File.WriteAllLines(
				spear
				,
				System.IO.File.ReadLines(spear).Where(
					oldLine =>  !lines2exclude.Any(
						line2exclude=> nilnul.txt.eq_.Trim.Singleton.Equals(line2exclude, oldLine)
					)
				).ToList()
				
			);
			
		}


		static public void _OfSpear(string spear, IEnumerable<string> lines)
		{
			_OfSpear(new nilnul.fs.File(spear),lines);
		}


		public static void _OfSpear(SpearI spearI1, IEnumerable<string> lines)
		{
			 _OfSpear(new nilnul.fs.File(spearI1),lines);
		}

		
		static public void _OfModule(nilnul.fs.git.ModuleI spear, IEnumerable<string> lines)
		{

			_OfSpear(
				_ignore_.exclude._AddressX.Spear(spear)
				,
				
				lines
			);

		}
		static public void _OfModule(string spear, IEnumerable<string> lines)
		{
			_OfModule( nilnul.fs.git.Module.FroAddress(spear),lines);
		}

	}
}