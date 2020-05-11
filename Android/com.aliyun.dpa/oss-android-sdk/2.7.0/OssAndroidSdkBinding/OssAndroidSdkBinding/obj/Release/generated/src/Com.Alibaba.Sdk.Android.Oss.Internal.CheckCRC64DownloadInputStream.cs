using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='CheckCRC64DownloadInputStream']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/CheckCRC64DownloadInputStream", DoNotGenerateAcw=true)]
	public partial class CheckCRC64DownloadInputStream : global::Java.Util.Zip.CheckedInputStream {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/CheckCRC64DownloadInputStream", typeof (CheckCRC64DownloadInputStream));
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

		protected CheckCRC64DownloadInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='CheckCRC64DownloadInputStream']/constructor[@name='CheckCRC64DownloadInputStream' and count(parameter)=5 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.util.zip.Checksum'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/io/InputStream;Ljava/util/zip/Checksum;JJLjava/lang/String;)V", "")]
		public unsafe CheckCRC64DownloadInputStream (global::System.IO.Stream @is, global::Java.Util.Zip.IChecksum csum, long total, long serverCRC64, string requestId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;Ljava/util/zip/Checksum;JJLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			IntPtr native_requestId = JNIEnv.NewString (requestId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native__is);
				__args [1] = new JniArgumentValue ((csum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) csum).Handle);
				__args [2] = new JniArgumentValue (total);
				__args [3] = new JniArgumentValue (serverCRC64);
				__args [4] = new JniArgumentValue (native_requestId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
				JNIEnv.DeleteLocalRef (native_requestId);
			}
		}

		static Delegate cb_getClientCRC64;
#pragma warning disable 0169
		static Delegate GetGetClientCRC64Handler ()
		{
			if (cb_getClientCRC64 == null)
				cb_getClientCRC64 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetClientCRC64);
			return cb_getClientCRC64;
		}

		static long n_GetClientCRC64 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Internal.CheckCRC64DownloadInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.CheckCRC64DownloadInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClientCRC64;
		}
#pragma warning restore 0169

		public virtual unsafe long ClientCRC64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='CheckCRC64DownloadInputStream']/method[@name='getClientCRC64' and count(parameter)=0]"
			[Register ("getClientCRC64", "()J", "GetGetClientCRC64Handler")]
			get {
				const string __id = "getClientCRC64.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
