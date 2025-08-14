using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._module.work._ignore.div.doc.patch_._nilnul
{
	[Obsolete(nameof(module.work.division.be_._ignored.rules_._Dotnet0nilnulX))]
	static public class _RulesX
	{

		static public IEnumerable<string> Enumerate() {
			return nilnul.fs.git.depo._werk_.destiny.be_._ignored._setting.rules_._nn._RscX.NilnulOnly().Select(
				x=> nilnul.txt.op_.unary_.TrimStart.Instanse_.TrimWhite.op(x)
			).Where(
				line=> !line.StartsWith("#")
			);
		}

		static public IEnumerable<string> MergeWithDotNetIgnore() {
			return nilnul.fs.git.Properties.RscX.DotNetIgnoreLines().Concat(Enumerate());
		}


		
//		#nilnul: ignore folders or files
//**/*(!Git

//#nilnul retiring a repo by renaming it to the ~{reason}{date}).git
//**/*).git/
//#in case mistypo
//**/*(.git

//#nilnul: makeing a repo from inside a repo; to avoid conflicts with parent repo, name a special folder in place; this folder is named: GIT
//**/*(nilnul.win.prog_.Git/

//#nilnul: ignore temp files
//**/~)*
//#obsoleting
//**/~$*
//		*/
	}
}
