using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.shield.op_.unary;
using nilnul.fs.address_.shield_;

namespace nilnul.fs.folder_.git_.work.be_
{
	static public class _TopX
	{
		//static public bool Be(Work obj, nilnul.win.prog_.Git git = null)
		//{
		//	return nilnul.fs.address_.shield.Eq.Singleton.Equals(obj.getRoot(), obj.en.address.en);
		//	//throw new NotImplementedException();
		//}
		/// <summary>
		/// assume it's work
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public bool __Be_ofAddress(string obj, nilnul.win.prog_.Git git = null)
		{
			return nilnul.fs.address_.shield.Eq.Singleton.Equals(

				nilnul.fs.folder_.git_.work._RtX.Shield_ofAddress(obj)
				,
				nilnul.fs.address_.shield.op_.unary_.Tgt.Singleton.Op_ofAddress(
					obj
				)
			);

		}

		static public bool Be(Work obj, nilnul.win.prog_.Git git = null)
		{
			return nilnul.fs.address_.shield.Eq.Singleton.Equals(
				obj.getRoot(git) //actual path
				,
				nilnul.fs.address_.shield.op_.unary_.Tgt.Singleton.op(
					obj.en.address.en
				)
			);
		}

		static public bool _Be(nilnul.fs.FolderI _work, nilnul.win.prog_.Git git = null)
		{
			return Be(new Work(_work));
		}

		static public bool _Be_ofWork(nilnul.fs.FolderI _work, nilnul.win.prog_.Git git = null)
		{
			return nilnul.fs.address_.shield.Eq.Singleton.Equals(
				work._RtX._Shield(_work, git)
				,
				nilnul.fs.address_.shield.op_.unary_.Tgt.Singleton.op(
					_work.address.en
				)
			);
		}

		static public bool _Be(
			nilnul.fs.address_.ShieldI obj
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.fs.address_.shield.Eq.Singleton.Equals(
				work._RtX.Shield(obj, git)
				,
				nilnul.fs.address_.shield.op_.unary_.Tgt.Singleton.op(
					obj
				)
			);
		}

		static public bool _Be(string _work, nilnul.win.prog_.Git git = null)
		{
			return _Be(
				nilnul.fs.Folder.FroAddress(_work)
			);
		}
	}
}