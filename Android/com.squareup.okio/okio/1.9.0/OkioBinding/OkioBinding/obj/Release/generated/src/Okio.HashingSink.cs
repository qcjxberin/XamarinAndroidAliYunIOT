using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='HashingSink']"
	[global::Android.Runtime.Register ("okio/HashingSink", DoNotGenerateAcw=true)]
	public sealed partial class HashingSink : global::Okio.ForwardingSink {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/HashingSink", typeof (HashingSink));
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

		internal HashingSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='HashingSink']/method[@name='hash' and count(parameter)=0]"
		[Register ("hash", "()Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString Hash ()
		{
			const string __id = "hash.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='HashingSink']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register ("md5", "(Lokio/Sink;)Lokio/HashingSink;", "")]
		public static unsafe global::Okio.HashingSink Md5 (global::Okio.ISink sink)
		{
			const string __id = "md5.(Lokio/Sink;)Lokio/HashingSink;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.HashingSink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='HashingSink']/method[@name='sha1' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register ("sha1", "(Lokio/Sink;)Lokio/HashingSink;", "")]
		public static unsafe global::Okio.HashingSink Sha1 (global::Okio.ISink sink)
		{
			const string __id = "sha1.(Lokio/Sink;)Lokio/HashingSink;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.HashingSink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='HashingSink']/method[@name='sha256' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register ("sha256", "(Lokio/Sink;)Lokio/HashingSink;", "")]
		public static unsafe global::Okio.HashingSink Sha256 (global::Okio.ISink sink)
		{
			const string __id = "sha256.(Lokio/Sink;)Lokio/HashingSink;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.HashingSink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
