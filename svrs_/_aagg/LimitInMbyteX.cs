using System;
using System.Linq;

namespace nilnul.fs.git.svrs_._aagg
{
	/// <summary>
	/// in Mb
	/// </summary>
	public class LimitInMbyteX
	{
		static public int Repo {
			get {

				return new[] {
					svr_._amazon.LimitInMbyteX.Repo
					,
					svr_._azure.LimitInMbyteX.Repo
					,
					svr_._github.LimitInMbyteX.Repo	//5G
					,
					svr_._gitlab.LimitInMbyteX.Repo
				}.Min();
				
			}
		}

		/// <summary>
		/// docs.gitlab.com/ee/administration/instance_limits.html#max-push-size
		/// </summary>
		static public int Push {
			get {

				return new[] {
					svr_._amazon.LimitInMbyteX.Push
					,
					svr_._azure.LimitInMbyteX.Push
					,
					svr_._github.LimitInMbyteX.Push	//2G
					,
					svr_._gitlab.LimitInMbyteX.Push
				}.Min();


			}
		}

		static public int Blob {
			get {
				

				return new[] {
					svr_._amazon.LimitInMbyteX.Blob
					,
					svr_._azure.LimitInMbyteX.Blob
					,
					svr_._github.LimitInMbyteX.Blob	//100MetaBytes
					,
					svr_._gitlab.LimitInMbyteX.Blob
				}.Min();


			}

		}




	}
}
