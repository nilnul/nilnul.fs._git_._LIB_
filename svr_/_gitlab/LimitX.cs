namespace nilnul.fs.git.svr_._gitlab
{
	///https://docs.gitlab.com/ee/user/gitlab_com/index.html#account-and-limit-settings
	///Repository size including LFS	10 GB, which is increased from 5G, according to (https://about.gitlab.com/blog/2015/04/08/gitlab-dot-com-storage-limit-raised-to-10gb-per-repo/)
	///
	/// git push and GitLab project imports are limited to 5 GB per request through Cloudflare.
	/// <summary>
	/// in Mb
	/// </summary>
	public class LimitInMbyteX
	{
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
		/// docs.gitlab.com/ee/administration/instance_limits.html#max-push-size
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

		static public int Blob {
			get {
				

				return Push;

			}

		}


	}
}
