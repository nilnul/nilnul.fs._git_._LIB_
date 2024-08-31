namespace nilnul.fs.git.svr_._github
{
	/// <summary>
	/// in Mb
	/// </summary>
	public class LimitInMbyteX
	{
		///GitHub doesn't have any set disk quotas. We try to provide abundant storage for all Git repositories, within reason. Keeping repositories small ensures that our servers are fast and downloads are quick for our users.
		///It seems it's 100GB?
		/// <summary>
		/// We recommend repositories remain small, ideally less than 1 GB, and less than 5 GB is strongly recommended.
		/// </summary>
		/// 5G. recommended 1G or less
		/// 
		static public int Repo {
			get {

				if (
					LimitInMbyte.Default.repo == default
				)
				{
					return (int)LimitInMbyte.Default.Properties[nameof(LimitInMbyte.repo)].DefaultValue;
				}

				return LimitInMbyte.Default.repo;
				
			}
		}

		/// <summary>
		/// 2G
		/// </summary>

		static public int Push {
			get {
				if (
					LimitInMbyte.Default.push == default
				)
				{
					return (int)LimitInMbyte.Default.Properties[nameof(LimitInMbyte.push)].DefaultValue;
				}

				return LimitInMbyte.Default.push;

			}
		}

		/// <summary>
		/// 100M. warn for 50M
		/// </summary>
		/// for Gfs, the limit is 2G
		static public int Blob {
			get {
				if (
					LimitInMbyte.Default.blob == default
				)
				{
					return (int)LimitInMbyte.Default.Properties[nameof(LimitInMbyte.blob)].DefaultValue;
				}

				return LimitInMbyte.Default.blob;

			}

		}


	}
}
