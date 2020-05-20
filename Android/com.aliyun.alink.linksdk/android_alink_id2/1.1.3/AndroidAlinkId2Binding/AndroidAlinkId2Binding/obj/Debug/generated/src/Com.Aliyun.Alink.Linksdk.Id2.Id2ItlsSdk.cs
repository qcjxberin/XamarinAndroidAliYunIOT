using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Id2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/id2/Id2ItlsSdk", DoNotGenerateAcw=true)]
	public partial class Id2ItlsSdk : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']/field[@name='DEBUGLEVEL_ERROR']"
		[Register ("DEBUGLEVEL_ERROR")]
		public const int DebuglevelError = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']/field[@name='DEBUGLEVEL_INFOR']"
		[Register ("DEBUGLEVEL_INFOR")]
		public const int DebuglevelInfor = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']/field[@name='DEBUGLEVEL_NODEBUG']"
		[Register ("DEBUGLEVEL_NODEBUG")]
		public const int DebuglevelNodebug = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']/field[@name='DEBUGLEVEL_STATECHANGE']"
		[Register ("DEBUGLEVEL_STATECHANGE")]
		public const int DebuglevelStatechange = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']/field[@name='DEBUGLEVEL_VERBOSE']"
		[Register ("DEBUGLEVEL_VERBOSE")]
		public const int DebuglevelVerbose = (int) 4;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']/field[@name='mContext']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']/field[@name='mSoPath']"
		[Register ("mSoPath")]
		public static string MSoPath {
			get {
				const string __id = "mSoPath.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSoPath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/id2/Id2ItlsSdk", typeof (Id2ItlsSdk));
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

		protected Id2ItlsSdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']/constructor[@name='Id2ItlsSdk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Id2ItlsSdk ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2ItlsSdk']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.id2.InitParams']]"
		[Register ("init", "(Lcom/aliyun/alink/linksdk/id2/InitParams;)V", "")]
		public static unsafe void Init (global::Com.Aliyun.Alink.Linksdk.Id2.InitParams p0)
		{
			const string __id = "init.(Lcom/aliyun/alink/linksdk/id2/InitParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
