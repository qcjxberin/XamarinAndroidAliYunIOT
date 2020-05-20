using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/option/BlockOption", DoNotGenerateAcw=true)]
	public partial class BlockOption : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/option/BlockOption", typeof (BlockOption));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected BlockOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/constructor[@name='BlockOption' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe BlockOption (byte[] value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/constructor[@name='BlockOption' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.option.BlockOption']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;)V", "")]
		public unsafe BlockOption (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption origin)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/coap/option/BlockOption;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((origin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) origin).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/constructor[@name='BlockOption' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register (".ctor", "(IZI)V", "")]
		public unsafe BlockOption (int szx, bool m, int num)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IZI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (szx);
				__args [1] = new JniArgumentValue (m);
				__args [2] = new JniArgumentValue (num);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getNum;
#pragma warning disable 0169
		static Delegate GetGetNumHandler ()
		{
			if (cb_getNum == null)
				cb_getNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum);
			return cb_getNum;
		}

		static int n_GetNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num;
		}
#pragma warning restore 0169

		public virtual unsafe int Num {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/method[@name='getNum' and count(parameter)=0]"
			[Register ("getNum", "()I", "GetGetNumHandler")]
			get {
				const string __id = "getNum.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOffset);
			return cb_getOffset;
		}

		static int n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset;
		}
#pragma warning restore 0169

		public virtual unsafe int Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()I", "GetGetOffsetHandler")]
			get {
				const string __id = "getOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSzx;
#pragma warning disable 0169
		static Delegate GetGetSzxHandler ()
		{
			if (cb_getSzx == null)
				cb_getSzx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSzx);
			return cb_getSzx;
		}

		static int n_GetSzx (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Szx;
		}
#pragma warning restore 0169

		public virtual unsafe int Szx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/method[@name='getSzx' and count(parameter)=0]"
			[Register ("getSzx", "()I", "GetGetSzxHandler")]
			get {
				const string __id = "getSzx.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValue ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/method[@name='getValue' and count(parameter)=0]"
		[Register ("getValue", "()[B", "GetGetValueHandler")]
		public virtual unsafe byte[] GetValue ()
		{
			const string __id = "getValue.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_isM;
#pragma warning disable 0169
		static Delegate GetIsMHandler ()
		{
			if (cb_isM == null)
				cb_isM = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsM);
			return cb_isM;
		}

		static bool n_IsM (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.BlockOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsM ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/method[@name='isM' and count(parameter)=0]"
		[Register ("isM", "()Z", "GetIsMHandler")]
		public virtual unsafe bool IsM ()
		{
			const string __id = "isM.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/method[@name='size2Szx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("size2Szx", "(I)I", "")]
		public static unsafe int Size2Szx (int blockSize)
		{
			const string __id = "size2Szx.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (blockSize);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.option']/class[@name='BlockOption']/method[@name='szx2Size' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("szx2Size", "(I)I", "")]
		public static unsafe int Szx2Size (int szx)
		{
			const string __id = "szx2Size.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (szx);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
