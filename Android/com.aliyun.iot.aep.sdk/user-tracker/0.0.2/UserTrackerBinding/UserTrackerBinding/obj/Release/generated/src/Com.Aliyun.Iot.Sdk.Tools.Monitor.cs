using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Sdk.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='Monitor']"
	[global::Android.Runtime.Register ("com/aliyun/iot/sdk/tools/Monitor", DoNotGenerateAcw=true)]
	public partial class Monitor : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/sdk/tools/Monitor", typeof (Monitor));
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

		protected Monitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='Monitor']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("d", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static unsafe void D (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='Monitor']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("e", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static unsafe void E (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='Monitor']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("i", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static unsafe void I (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='Monitor']/method[@name='registerHandler' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.sdk.tools.MonitorHandler']]"
		[Register ("registerHandler", "(Lcom/aliyun/iot/sdk/tools/MonitorHandler;)V", "")]
		public static unsafe void RegisterHandler (global::Com.Aliyun.Iot.Sdk.Tools.IMonitorHandler p0)
		{
			const string __id = "registerHandler.(Lcom/aliyun/iot/sdk/tools/MonitorHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='Monitor']/method[@name='unregisterHandler' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.sdk.tools.MonitorHandler']]"
		[Register ("unregisterHandler", "(Lcom/aliyun/iot/sdk/tools/MonitorHandler;)V", "")]
		public static unsafe void UnregisterHandler (global::Com.Aliyun.Iot.Sdk.Tools.IMonitorHandler p0)
		{
			const string __id = "unregisterHandler.(Lcom/aliyun/iot/sdk/tools/MonitorHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='Monitor']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("v", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static unsafe void V (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools']/class[@name='Monitor']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("w", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static unsafe void W (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
