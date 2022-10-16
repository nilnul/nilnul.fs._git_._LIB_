namespace nilnul.fs.git.svr_._amazon
{
	/// <summary>
	/// in Mb
	/// </summary>
	public class LimitInMbyteX
	{
		static public int Blob {
			get {
				if (
				LimitInMbyte.Default.blob == default
					) return (int) LimitInMbyte.Default.Properties[nameof(LimitInMbyte.blob)].DefaultValue;

				return LimitInMbyte.Default.blob;
			}

		}
		static public int Repo {
			get {

				
				return int.MaxValue;
			}
		}

		static public int Push {
			get {
				return Repo;
			}
		}


	}
}
