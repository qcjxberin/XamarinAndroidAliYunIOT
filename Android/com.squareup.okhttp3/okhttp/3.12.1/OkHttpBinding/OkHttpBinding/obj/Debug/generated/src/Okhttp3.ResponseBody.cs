using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']"
	[global::Android.Runtime.Register ("okhttp3/ResponseBody", DoNotGenerateAcw=true)]
	public abstract partial class ResponseBody : global::Java.Lang.Object, global::Java.IO.ICloseable {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody.BomAwareReader']"
		[global::Android.Runtime.Register ("okhttp3/ResponseBody$BomAwareReader", DoNotGenerateAcw=true)]
		public sealed partial class BomAwareReader : global::Java.IO.Reader {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/ResponseBody$BomAwareReader", typeof (BomAwareReader));
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

			internal BomAwareReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody.BomAwareReader']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public override unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody.BomAwareReader']/method[@name='read' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("read", "([CII)I", "")]
			public override unsafe int Read (char[] cbuf, int off, int len)
			{
				const string __id = "read.([CII)I";
				IntPtr native_cbuf = JNIEnv.NewArray (cbuf);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_cbuf);
					__args [1] = new JniArgumentValue (off);
					__args [2] = new JniArgumentValue (len);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (cbuf != null) {
						JNIEnv.CopyArray (native_cbuf, cbuf);
						JNIEnv.DeleteLocalRef (native_cbuf);
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/ResponseBody", typeof (ResponseBody));
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

		protected ResponseBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/constructor[@name='ResponseBody' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResponseBody ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='byteStream' and count(parameter)=0]"
		[Register ("byteStream", "()Ljava/io/InputStream;", "")]
		public unsafe global::System.IO.Stream ByteStream ()
		{
			const string __id = "byteStream.()Ljava/io/InputStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='bytes' and count(parameter)=0]"
		[Register ("bytes", "()[B", "")]
		public unsafe byte[] Bytes ()
		{
			const string __id = "bytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='charStream' and count(parameter)=0]"
		[Register ("charStream", "()Ljava/io/Reader;", "")]
		public unsafe global::Java.IO.Reader CharStream ()
		{
			const string __id = "charStream.()Ljava/io/Reader;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.ResponseBody __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Okhttp3.ResponseBody __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='contentLength' and count(parameter)=0]"
		[Register ("contentLength", "()J", "GetContentLengthHandler")]
		public abstract long ContentLength ();

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
			global::Okhttp3.ResponseBody __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "GetContentTypeHandler")]
		public abstract global::Okhttp3.MediaType ContentType ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='byte[]']]"
		[Register ("create", "(Lokhttp3/MediaType;[B)Lokhttp3/ResponseBody;", "")]
		public static unsafe global::Okhttp3.ResponseBody Create (global::Okhttp3.MediaType contentType, byte[] content)
		{
			const string __id = "create.(Lokhttp3/MediaType;[B)Lokhttp3/ResponseBody;";
			IntPtr native_content = JNIEnv.NewArray (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contentType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentType).Handle);
				__args [1] = new JniArgumentValue (native_content);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (content != null) {
					JNIEnv.CopyArray (native_content, content);
					JNIEnv.DeleteLocalRef (native_content);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.MediaType'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Lokhttp3/MediaType;Ljava/lang/String;)Lokhttp3/ResponseBody;", "")]
		public static unsafe global::Okhttp3.ResponseBody Create (global::Okhttp3.MediaType contentType, string content)
		{
			const string __id = "create.(Lokhttp3/MediaType;Ljava/lang/String;)Lokhttp3/ResponseBody;";
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contentType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentType).Handle);
				__args [1] = new JniArgumentValue (native_content);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='string' and count(parameter)=0]"
		[Register ("string", "()Ljava/lang/String;", "")]
		public unsafe string String ()
		{
			const string __id = "string.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okhttp3/ResponseBody", DoNotGenerateAcw=true)]
	internal partial class ResponseBodyInvoker : ResponseBody {

		public ResponseBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/ResponseBody", typeof (ResponseBodyInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='contentLength' and count(parameter)=0]"
		[Register ("contentLength", "()J", "GetContentLengthHandler")]
		public override unsafe long ContentLength ()
		{
			const string __id = "contentLength.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ResponseBody']/method[@name='contentType' and count(parameter)=0]"
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
