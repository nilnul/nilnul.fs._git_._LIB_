using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.bak._io._log
{
	/// <summary>
	/// each Rec is intended for one line in the log file.
	/// </summary>
	public struct Rec
	{
		public const char SEPARATOR = '\t';
		static public string Separator = SEPARATOR.ToString();

		public string  folder;
		public string branch;//if this is empty, it's all branches
		public _rec.Action action;
		public string remote;	//empty if not applicable


		public DateTime time;	//utc

		public string note;


		public Rec(string folder, string branch, _rec.Action action,string remote, DateTime time, string note)
		{
			this.folder = folder;
			this.branch = branch;
			this.action = action;
			this.remote = remote;
			this.time = time;
			this.note = note;
		}

		public override string ToString()
		{
			return string.Join(Separator, folder,branch,action,remote,time,note);
		}

		static public Rec Parse(string line) {

			var array = line.Split(SEPARATOR);
			return new Rec(
				array[0]
				,
				array[1]
				,
				nilnul.Txt2Enum.ParseEnum<_rec.Action>( array[2])
				,
				array[3]
				,
				DateTime.Parse(
				array[4])
				,array[5]	
			);
		}



		static public string toTxt(string[] items) {
			return string.Join(Separator, items);
		}


	}
}
