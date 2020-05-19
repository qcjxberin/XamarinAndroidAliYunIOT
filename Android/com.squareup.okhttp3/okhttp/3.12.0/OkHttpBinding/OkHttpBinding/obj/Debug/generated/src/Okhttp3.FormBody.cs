using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']"
	[global::Android.Runtime.Register ("okhttp3/FormBody", DoNotGenerateAcw=true)]
	public sealed partial class FormBody : global::Okhttp3.RequestBody {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']"
		[global::Android.Runtime.Register ("okhttp3/FormBody$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/FormBody$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']/constructor[@name='FormBody.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']/constructor[@name='FormBody.Builder' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
			[Register (".ctor", "(Ljava/nio/charset/Charset;)V", "")]
			public unsafe Builder (global::Java.Nio.Charset.Charset charset)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/nio/charset/Charset;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((charset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charset).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("add", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/FormBody$Builder;", "")]
			public unsafe global::Okhttp3.FormBody.Builder Add (string name, string value)
			{
				const string __id = "add.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/FormBody$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.FormBody.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']/method[@name='addEncoded' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addEncoded", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/FormBody$Builder;", "")]
			public unsafe global::Okhttp3.FormBody.Builder AddEncoded (string name, string value)
			{
				const string __id = "addEncoded.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/FormBody$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.FormBody.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/FormBody;", "")]
			public unsafe global::Okhttp3.FormBody Build ()
			{
				const string __id = "build.()Lokhttp3/FormBody;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.FormBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/FormBody", typeof (FormBody));
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

		internal FormBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "")]
		public override unsafe global::Okhttp3.MediaType ContentType ()
		{
			const string __id = "contentType.()Lokhttp3/MediaType;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='encodedName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("encodedName", "(I)Ljava/lang/String;", "")]
		public unsafe string EncodedName (int index)
		{
			const string __id = "encodedName.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='encodedValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("encodedValue", "(I)Ljava/lang/String;", "")]
		public unsafe string EncodedValue (int index)
		{
			const string __id = "encodedValue.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='name' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("name", "(I)Ljava/lang/String;", "")]
		public unsafe string Name (int index)
		{
			const string __id = "name.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='value' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("value", "(I)Ljava/lang/String;", "")]
		public unsafe string Value (int index)
		{
			const string __id = "value.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='okio.BufferedSink']]"
		[Register ("writeTo", "(Lokio/BufferedSink;)V", "")]
		public override unsafe void WriteTo (global::Okio.IBufferedSink sink)
		{
			const string __id = "writeTo.(Lokio/BufferedSink;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
