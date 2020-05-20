using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalSdk']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/api/AlcsPalSdk", DoNotGenerateAcw=true)]
	public partial class AlcsPalSdk : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalSdk']/field[@name='mContext']"
		[Register ("mContext")]
		public static global::Android.Content.Context MContext {
			get {
				const string __id = "mContext.Landroid/content/Context;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalSdk']/field[@name='mHandler']"
		[Register ("mHandler")]
		public static global::Android.OS.Handler MHandler {
			get {
				const string __id = "mHandler.Landroid/os/Handler;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHandler.Landroid/os/Handler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/api/AlcsPalSdk", typeof (AlcsPalSdk));
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

		protected AlcsPalSdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalSdk']/constructor[@name='AlcsPalSdk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlcsPalSdk ()
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

		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalSdk']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Android.OS.Handler Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalSdk']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Landroid/os/Handler;", "")]
			get {
				const string __id = "getHandler.()Landroid/os/Handler;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='AlcsPalSdk']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.api.PluginMgrConfig'] and parameter[3][@type='java.util.List&lt;com.aliyun.alink.linksdk.alcs.lpbs.plugin.IPlugin&gt;']]"
		[Register ("init", "(Landroid/content/Context;Lcom/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgrConfig;Ljava/util/List;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgrConfig p1, global::System.Collections.Generic.IList<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin> p2)
		{
			const string __id = "init.(Landroid/content/Context;Lcom/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgrConfig;Ljava/util/List;)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
