using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogerImpl']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/LogerImpl", DoNotGenerateAcw=true)]
	public partial class LogerImpl : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogger {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/LogerImpl", typeof (LogerImpl));
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

		protected LogerImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogerImpl']/constructor[@name='LogerImpl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe LogerImpl (string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_d_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_d_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_d_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_Ljava_lang_String_);
			return cb_d_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_D_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_msg)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.D (tag, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogerImpl']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "GetD_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void D (string tag, string msg)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_Ljava_lang_String_);
			return cb_e_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_msg)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.E (tag, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogerImpl']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "GetE_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void E (string tag, string msg)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_);
			return cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native__where, IntPtr native_ex)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			string @where = JNIEnv.GetString (native__where, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.E (tag, @where, ex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogerImpl']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "GetE_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Handler")]
		public virtual unsafe void E (string tag, string @where, global::Java.Lang.Exception ex)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native__where = JNIEnv.NewString (@where);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native__where);
				__args [2] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native__where);
			}
		}

		static Delegate cb_i_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_i_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_i_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_I_Ljava_lang_String_Ljava_lang_String_);
			return cb_i_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_I_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_msg)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.I (tag, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogerImpl']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "GetI_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void I (string tag, string msg)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_w_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_w_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_w_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_W_Ljava_lang_String_Ljava_lang_String_);
			return cb_w_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_W_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_msg)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.W (tag, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogerImpl']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "GetW_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void W (string tag, string msg)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
