using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._svrs
{
	public enum _EnumX
	{
		[Description("Amazon AWS git code commit")]
		[Display(Name = "AmazonCodeCommit")]
		Amazon
			,
		//[StringValue]
		VisualStudio
			,
		[Description("dev.azure.com")]
		[Display(Name = "Azure_DevOpS")]

		Azure
			,
		Gitlab
			,
		Github

		//	,
		//Azure
	}

	public class EnumX
	{
		public static  string Amazon {
			get {
				return nameof(_EnumX.Amazon);
			}
		}

		public static string[] Names() {
			return Enum.GetNames(typeof(_EnumX) );
		}

	}
}
