using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.bak._io
{
	/// <summary>
	/// reads or writes the file which stores the processed folder.
	/// The information stored therein is used to pause and resume an ongoing backup process.
	/// 
	/// if the log contains all entires and a second loop for the folders in the log begins, another object of this shall be created.
	/// assume: file has been created.
	/// </summary>
	public class Log
	{

		//public string fileAddress;

		//public List<string[]> jobsDone;

		public List<_log.Rec> recs;

		public nilnul.fs.location_.File file;


		//public StreamWriter lineAppender;

		

		public Log(nilnul.fs.location_.File fileAddress)
		{
			recs = new List<_log.Rec>();

			this.file = fileAddress;

			//this.lineAppender = File.AppendText(writer);


			FileStream fileStream=null;
			string jobs = null;
			try
			{
				fileStream = new FileStream(
				  fileAddress.ToString(), FileMode.Open,
				  FileAccess.ReadWrite, FileShare.Read
				 );

				using (var sr = new StreamReader(fileStream))
				{
					 jobs = sr.ReadToEnd();


					fileStream = null;

				}

			}
			catch (Exception)
			{
				if (fileStream!=null)
				{
					fileStream.Dispose();

				}
				throw;

			}


			var jobsArray = jobs.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var line in jobsArray)
			{
				try
				{
					var rec = _log.Rec.Parse(line);
					recs.Add(rec);
				}
				catch (Exception)
				{

					throw;
				}

			}

			///the first one is the address
			//var jobsStruct = jobsArray.Select(line => line.Split(new[] { '\t' }));


			//jobsDone = jobsStruct.ToList();


			//recs = new StreamReader(fileStream).ReadToEnd().Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(l=> _log.Rec.Parse(l)).ToList();
		}


		public void append(_log.Rec rec)
		{
			recs.Add(rec );

			System.IO.File.AppendAllText(this.file.ToString(), rec.ToString());
		}
		[Obsolete()]
		public void append(string folder, string branch, string action, string remote)
		{
			append(

				new _log.Rec(folder,branch, nilnul.Txt2Enum.ParseEnum<_log._rec.Action>(action),remote,DateTime.UtcNow,"")
			);
		}

		public void append(string folder, string branch, _log._rec.Action action, string remote)
		{
			append(

				new _log.Rec(folder,branch, (action),remote,DateTime.UtcNow,"")
			);
		}

	

		public bool isDone(string folder, string branch)
		{

			return recs.Any(
				x => nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.folder, folder)
				&& x.branch== branch

			);
		}

		public bool isDoneOnAllBranch(string folder)
		{

			return isDone(folder,"");
		}
	}
}
