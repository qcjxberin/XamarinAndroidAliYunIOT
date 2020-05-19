using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']"
	[global::Android.Runtime.Register ("okhttp3/MediaType", DoNotGenerateAcw=true)]
	public sealed partial class MediaType : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/MediaType", typeof (MediaType));
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

		internal MediaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='charset' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='charset' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("charset", "(Ljava/nio/charset/Charset;)Ljava/nio/charset/Charset;", "")]
		public unsafe global::Java.Nio.Charset.Charset Charset (global::Java.Nio.Charset.Charset defaultValue)
		{
			const string __id = "charset.(Ljava/nio/charset/Charset;)Ljava/nio/charset/Charset;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((defaultValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultValue).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lokhttp3/MediaType;", "")]
		public static unsafe global::Okhttp3.MediaType Get (string @string)
		{
			const string __id = "get.(Ljava/lang/String;)Lokhttp3/MediaType;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lokhttp3/MediaType;", "")]
		public static unsafe global::Okhttp3.MediaType Parse (string @string)
		{
			const string __id = "parse.(Ljava/lang/String;)Lokhttp3/MediaType;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='subtype' and count(parameter)=0]"
		[Register ("subtype", "()Ljava/lang/String;", "")]
		public unsafe string Subtype ()
		{
			const string __id = "subtype.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MediaType']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Ljava/lang/String;", "")]
		public unsafe string Type ()
		{
			const string __id = "type.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
