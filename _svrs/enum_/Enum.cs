using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._svrs
{
	public enum _EnumX1
	{
		[Description("Amazon AWS git code commit")]
		[Display(Name = "AmazonCodeCommit")]
		Amazon
			,
		//[StringValue]
		VisualStudio
			,
		Gitlab
			,
		Github
			,
		/// <summary>
		/// dev.azure.com
		/// provides some git server
		/// </summary>
		Azure
			,
		/// <summary>
		/// codeup.aliyun.com
		/// provides some git service
		/// </summary>
		Codeup
	}

}
