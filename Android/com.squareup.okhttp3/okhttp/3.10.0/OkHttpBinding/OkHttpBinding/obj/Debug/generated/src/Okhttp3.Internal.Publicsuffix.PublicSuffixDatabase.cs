using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Publicsuffix {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.publicsuffix']/class[@name='PublicSuffixDatabase']"
	[global::Android.Runtime.Register ("okhttp3/internal/publicsuffix/PublicSuffixDatabase", DoNotGenerateAcw=true)]
	public sealed partial class PublicSuffixDatabase : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.publicsuffix']/class[@name='PublicSuffixDatabase']/field[@name='PUBLIC_SUFFIX_RESOURCE']"
		[Register ("PUBLIC_SUFFIX_RESOURCE")]
		public const string PublicSuffixResource = (string) "publicsuffixes.gz";
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/publicsuffix/PublicSuffixDatabase", typeof (PublicSuffixDatabase));
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

		internal PublicSuffixDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.publicsuffix']/class[@name='PublicSuffixDatabase']/constructor[@name='PublicSuffixDatabase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PublicSuffixDatabase ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.publicsuffix']/class[@name='PublicSuffixDatabase']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lokhttp3/internal/publicsuffix/PublicSuffixDatabase;", "")]
		public static unsafe global::Okhttp3.Internal.Publicsuffix.PublicSuffixDatabase Get ()
		{
			const string __id = "get.()Lokhttp3/internal/publicsuffix/PublicSuffixDatabase;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Publicsuffix.PublicSuffixDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.publicsuffix']/class[@name='PublicSuffixDatabase']/method[@name='getEffectiveTldPlusOne' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEffectiveTldPlusOne", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetEffectiveTldPlusOne (string domain)
		{
			const string __id = "getEffectiveTldPlusOne.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_domain = JNIEnv.NewString (domain);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_domain);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_domain);
			}
		}

	}
}
