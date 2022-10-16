using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using nilnul.win.process;
using nilnul.fs.folder_.git_;
using nilnul.fs.address_;
using nilnul.fs.git._module_;
using nilnul.fs.folder_.git_.work_;

namespace nilnul.fs.git
{
	/// <summary>
	/// This is inside module, but may be not root. You have to use its member to get its root.
	/// module is a collection of
	/// anything such as folder (sub or root), inside workspace root
	/// or  inside ".git" root;
	/// 
	/// given a specified module instance,
	///		the inners of submodule are excluded for they are in another module.
	/// </summary>
	//[DebuggerDisplay("{top1}",Name ="Module")]
	///if you have overridden ToString(), you do not need to use DebuggerDisplayAttribute. If you use both, the DebuggerDisplayAttribute attribute takes precedence over the ToString() override.
	public class Module
		: nilnul.obj.Box<nilnul.fs.folder_.git_.work_.Top>
		,_module_.TopI
				, ModuleI


	{
		[Obsolete()]
		public nilnul.fs.folder_.git_.Top top {
			get {
				return new fs.folder_.git_.Top(this.boxed.en);
			}
		}
		public nilnul.fs.folder_.git_.work_.Top top1 {
			get {
				return (this.boxed);
			}
		}

		fs.folder_.git_.work_.Top TopI1.top1 =>top1;

		public Module(fs.folder_.git_.work_.Top val) : base(val)
		{
		}

		public Module(fs.folder_.git_.Top val) : this(new fs.folder_.git_.work_.Top(val.en) )
		{
		}

		public Module(FolderI folder):this(new fs.folder_.git_.work_.Top(folder))
		{
		}

		public Module(ShieldI module):this(new nilnul.fs.Folder(module))
		{
		}

		public override string ToString()
		{
			return boxed.ToString();
		}

		static public implicit operator Module(nilnul.fs.folder_.git_.Top top) {
			return new Module(top);
		}

		static public implicit operator nilnul.fs.folder_.git_.Top(Module top) {
			return new nilnul.fs.folder_.git_.Top(  top.top.en );
		}

		static public Module FroAddress(string address) {
			return new Module(
				new nilnul.fs.folder_.git_.work_.Top(address)
			);
		}

		static public Module FroFolder(nilnul.fs.FolderI address) {
			return new Module(
				new nilnul.fs.folder_.git_.work_.Top(address)
			);
		}

		static public Module OvTop(nilnul.fs.address_.ShieldI address) {
			return new Module(
				new nilnul.fs.folder_.git_.work_.Top(address)
			);
		}

		static public Module OvInnerDiv(nilnul.fs.FolderI folder) {
			return  Module.FroAddress(
				nilnul.fs.folder_.git_.work._RtX.Address(
					(folder)
				)
			);
		}
		static public Module OvInnerDivAddress(string folder) {
			return  Module.FroAddress(
				nilnul.fs.folder_.git_.work._RtX.Address_ofAddress(
					(folder)
				)
			);
		}


	}
}
