namespace nilnul.fs.git.svr_._azure
{
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
