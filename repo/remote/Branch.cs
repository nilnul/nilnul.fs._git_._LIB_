using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.remote
{
	public class Branch
	{
		private nilnul.fs.git.module.repo._cfg_._remote.Name _remote;

		public nilnul.fs.git.module.repo._cfg_._remote.Name remote
		{
			get { return _remote; }
			set { _remote = value; }
		}

		private nilnul.fs.git.repo._branch.Name _branch;

		public nilnul.fs.git.repo._branch.Name branch
		{
			get { return _branch; }
			set { _branch = value; }
		}
		public Branch(nilnul.fs.git.module.repo._cfg_._remote.Name remote
			,

nilnul.fs.git.repo._branch.Name branch
			)
		{
			this._remote = remote;
			this._branch = branch;
		}

		public Branch(nilnul.fs.git.module.repo._cfg_._remote.Name v1, string v2)
		:this(
			v1
			,
			new _branch.Name(
				v2
			)
		)
		{
		}
		public Branch(string v1, string v2):this(
			new module.repo._cfg_._remote.Name(v1),v2
		)
		{
		}

		public override string ToString()
		{
			return $"{remote}/{branch}";
		}

		static public Branch Parse(string s) {
			var splitted=s.Split(
				'/'
			);

			if (splitted.Length!=2)
			{
				throw new nilnul.obj_.xpn_.parse_.scan_.PhraseException($"{s} must be two part separated by /");
			}

			return new Branch(
				splitted[0]
				,
				splitted[1]

			);
		}

	}
}
