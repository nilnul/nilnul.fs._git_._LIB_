using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svrs_.vsBbGl.repos
{
	[Obsolete(nameof(client.prjs.Add))]
	public class Add
	{
		private nilnul.fs.git.svr_.VisualStudio _vs;

		public nilnul.fs.git.svr_.VisualStudio vs
		{
			get { return _vs; }
			set { _vs = value; }
		}


		private nilnul.fs.git.svr_.BitBucket _bitBucket;

		public nilnul.fs.git.svr_.BitBucket bitBucket
		{
			get { return _bitBucket; }
			set { _bitBucket = value; }
		}

		private nilnul.fs.git.svr_.Gitlab _gitLab;

		public nilnul.fs.git.svr_.Gitlab gitLab
		{
			get { return _gitLab; }
			set { _gitLab = value; }
		}



		public Add(nilnul.fs.git.svr_.VisualStudio vs
			,nilnul.fs.git.svr_.BitBucket bitBucket, 
			nilnul.fs.git.svr_.Gitlab gitlab
			
		)
		{
			_gitLab = gitlab;
			_vs = vs;
			_bitBucket = bitBucket;
		}
		public IEnumerable< string> exe(string prj) {
			yield return new nilnul.fs.git.svr_.vs.prjs.add.ByWebClient_basicUser(_vs).exe(
					prj
			);

			yield return new nilnul.fs.git.svr_.bitBucket.prjs.Add(_bitBucket).exe(prj);

			yield return new nilnul.fs.git.svr_.gitlab.prjs.Add(_gitLab).exe(prj);
		}
		public IEnumerable< string> exe_errAsMsg(string prj) {
			yield return new nilnul.fs.git.svr_.vs.prjs.add.ByWebClient_basicUser(_vs).exe_errAsMsg(
					prj
			);

			yield return new nilnul.fs.git.svr_.bitBucket.prjs.Add(_bitBucket).exe_errAsMsg(prj);

			yield return new nilnul.fs.git.svr_.gitlab.prjs.Add(_gitLab).exe_errAsMsg(prj);
		}


	}
}
