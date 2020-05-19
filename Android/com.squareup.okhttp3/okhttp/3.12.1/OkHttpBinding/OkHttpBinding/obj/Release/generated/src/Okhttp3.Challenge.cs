using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']"
	[global::Android.Runtime.Register ("okhttp3/Challenge", DoNotGenerateAcw=true)]
	public sealed partial class Challenge : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Challenge", typeof (Challenge));
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

		internal Challenge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/constructor[@name='Challenge' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Challenge (string scheme, string realm)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_scheme = JNIEnv.NewString (scheme);
			IntPtr native_realm = JNIEnv.NewString (realm);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_scheme);
				__args [1] = new JniArgumentValue (native_realm);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
				JNIEnv.DeleteLocalRef (native_realm);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/constructor[@name='Challenge' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe Challenge (string scheme, global::System.Collections.Generic.IDictionary<string, string> authParams)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_scheme = JNIEnv.NewString (scheme);
			IntPtr native_authParams = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (authParams);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_scheme);
				__args [1] = new JniArgumentValue (native_authParams);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
				JNIEnv.DeleteLocalRef (native_authParams);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/method[@name='authParams' and count(parameter)=0]"
		[Register ("authParams", "()Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, string> AuthParams ()
		{
			const string __id = "authParams.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/method[@name='charset' and count(parameter)=0]"
		[Register ("charset", "()Ljava/nio/charset/Charset;", "")]
		public unsafe global::Java.Nio.Charset.Charset Charset ()
		{
			const string __id = "charset.()Ljava/nio/charset/Charset;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/method[@name='realm' and count(parameter)=0]"
		[Register ("realm", "()Ljava/lang/String;", "")]
		public unsafe string Realm ()
		{
			const string __id = "realm.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/method[@name='scheme' and count(parameter)=0]"
		[Register ("scheme", "()Ljava/lang/String;", "")]
		public unsafe string Scheme ()
		{
			const string __id = "scheme.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Challenge']/method[@name='withCharset' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("withCharset", "(Ljava/nio/charset/Charset;)Lokhttp3/Challenge;", "")]
		public unsafe global::Okhttp3.Challenge WithCharset (global::Java.Nio.Charset.Charset charset)
		{
			const string __id = "withCharset.(Ljava/nio/charset/Charset;)Lokhttp3/Challenge;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((charset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charset).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Challenge> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
