using nilnul.os.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.werk.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="module.be_.Wrought"/>
	 public class Wrought
		:
		nilnul.win.prog_.git.Boxed,

		nilnul.fs.git.depo.BeI
		,
		nilnul.fs.git.depo._be_._AssumeDepoI
	{
		public Wrought(win.prog_.Git val) : base(val)
		{
		}

		public Wrought()
		{
		}

		public bool _be_0depo(in string _depo)
		{
			
			return nilnul.fs.git.module._work_.documents_._NoDotLedX._Addresses_ofAddress(_depo,this.boxed).Any();
		}

	

		
		public bool be(in DepoI val)
		{
			return _be_0depo(val.top1.ToString());
		}


		static public Wrought Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Wrought>.Instance;
			}
		}


	}
}
