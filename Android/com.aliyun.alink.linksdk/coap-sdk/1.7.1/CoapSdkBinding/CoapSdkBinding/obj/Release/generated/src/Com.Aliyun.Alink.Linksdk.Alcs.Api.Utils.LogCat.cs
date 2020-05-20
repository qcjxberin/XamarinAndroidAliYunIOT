using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/utils/LogCat", DoNotGenerateAcw=true)]
	public partial class LogCat : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/utils/LogCat", typeof (LogCat));
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

		protected LogCat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/constructor[@name='LogCat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogCat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void D (string tag, string message)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void D (string tag, string message, global::Java.Lang.Throwable e)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void E (string tag, string message)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (string tag, string message, global::Java.Lang.Throwable e)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void I (string tag, string message)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void I (string tag, string message, global::Java.Lang.Throwable e)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void V (string tag, string message)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void V (string tag, string message, global::Java.Lang.Throwable e)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void W (string tag, string message)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='LogCat']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void W (string tag, string message, global::Java.Lang.Throwable e)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
