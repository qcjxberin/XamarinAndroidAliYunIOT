using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']"
	[global::Android.Runtime.Register ("okhttp3/RequestBody", DoNotGenerateAcw=true)]
	public abstract partial class RequestBody : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/RequestBody", typeof (RequestBody));
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

		protected RequestBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/constructor[@name='RequestBody' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestBody ()
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

		static Delegate cb_contentLength;
#pragma warning disable 0169
		static Delegate GetContentLengthHandler ()
		{
			if (cb_contentLength == null)
				cb_contentLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ContentLength);
			return cb_contentLength;
		}

		static long n_ContentLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.RequestBody __this = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='contentLength' and count(parameter)=0]"
		[Register ("contentLength", "()J", "GetContentLengthHandler")]
		public virtual unsafe long ContentLength ()
		{
			const string __id = "contentLength.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_contentType;
#pragma warning disable 0169
		static Delegate GetContentTypeHandler ()
		{
			if (cb_contentType == null)
				cb_contentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ContentType);
			return cb_contentType;
		}

		static IntPtr n_ContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.RequestBody __this = global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "GetContentTypeHandler")]
		public abstract global::Okhttp3.MediaType ContentType ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='byte[]']]"
		[Register ("create", "(Lokhttp3/MediaType;[B)Lokhttp3/RequestBody;", "")]
		public static unsafe global::Okhttp3.RequestBody Create (global::Okhttp3.MediaType contentType, byte[] content)
		{
			const string __id = "create.(Lokhttp3/MediaType;[B)Lokhttp3/RequestBody;";
			IntPtr native_content = JNIEnv.NewArray (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contentType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentType).Handle);
				__args [1] = new JniArgumentValue (native_content);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (content != null) {
					JNIEnv.CopyArray (native_content, content);
					JNIEnv.DeleteLocalRef (native_content);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='create' and count(parameter)=4 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("create", "(Lokhttp3/MediaType;[BII)Lokhttp3/RequestBody;", "")]
		public static unsafe global::Okhttp3.RequestBody Create (global::Okhttp3.MediaType contentType, byte[] content, int offset, int byteCount)
		{
			const string __id = "create.(Lokhttp3/MediaType;[BII)Lokhttp3/RequestBody;";
			IntPtr native_content = JNIEnv.NewArray (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((contentType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentType).Handle);
				__args [1] = new JniArgumentValue (native_content);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (byteCount);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (content != null) {
					JNIEnv.CopyArray (native_content, content);
					JNIEnv.DeleteLocalRef (native_content);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='java.io.File']]"
		[Register ("create", "(Lokhttp3/MediaType;Ljava/io/File;)Lokhttp3/RequestBody;", "")]
		public static unsafe global::Okhttp3.RequestBody Create (global::Okhttp3.MediaType contentType, global::Java.IO.File file)
		{
			const string __id = "create.(Lokhttp3/MediaType;Ljava/io/File;)Lokhttp3/RequestBody;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contentType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentType).Handle);
				__args [1] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Lokhttp3/MediaType;Ljava/lang/String;)Lokhttp3/RequestBody;", "")]
		public static unsafe global::Okhttp3.RequestBody Create (global::Okhttp3.MediaType contentType, string content)
		{
			const string __id = "create.(Lokhttp3/MediaType;Ljava/lang/String;)Lokhttp3/RequestBody;";
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contentType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentType).Handle);
				__args [1] = new JniArgumentValue (native_content);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

	}

	[global::Android.Runtime.Register ("okhttp3/RequestBody", DoNotGenerateAcw=true)]
	internal partial class RequestBodyInvoker : RequestBody {

		public RequestBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/RequestBody", typeof (RequestBodyInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='RequestBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "GetContentTypeHandler")]
		public override unsafe global::Okhttp3.MediaType ContentType ()
		{
			const string __id = "contentType.()Lokhttp3/MediaType;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
