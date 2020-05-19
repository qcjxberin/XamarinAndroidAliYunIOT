using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']"
	[global::Android.Runtime.Register ("okhttp3/MultipartBody", DoNotGenerateAcw=true)]
	public sealed partial class MultipartBody : global::Okhttp3.RequestBody {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/field[@name='ALTERNATIVE']"
		[Register ("ALTERNATIVE")]
		public static global::Okhttp3.MediaType Alternative {
			get {
				const string __id = "ALTERNATIVE.Lokhttp3/MediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/field[@name='DIGEST']"
		[Register ("DIGEST")]
		public static global::Okhttp3.MediaType Digest {
			get {
				const string __id = "DIGEST.Lokhttp3/MediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/field[@name='FORM']"
		[Register ("FORM")]
		public static global::Okhttp3.MediaType Form {
			get {
				const string __id = "FORM.Lokhttp3/MediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/field[@name='MIXED']"
		[Register ("MIXED")]
		public static global::Okhttp3.MediaType Mixed {
			get {
				const string __id = "MIXED.Lokhttp3/MediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/field[@name='PARALLEL']"
		[Register ("PARALLEL")]
		public static global::Okhttp3.MediaType Parallel {
			get {
				const string __id = "PARALLEL.Lokhttp3/MediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']"
		[global::Android.Runtime.Register ("okhttp3/MultipartBody$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/MultipartBody$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/constructor[@name='MultipartBody.Builder' and count(parameter)=0]"
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/constructor[@name='MultipartBody.Builder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Builder (string boundary)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_boundary = JNIEnv.NewString (boundary);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_boundary);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_boundary);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='addFormDataPart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addFormDataPart", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder AddFormDataPart (string name, string value)
			{
				const string __id = "addFormDataPart.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/MultipartBody$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='addFormDataPart' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='okhttp3.RequestBody']]"
			[Register ("addFormDataPart", "(Ljava/lang/String;Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder AddFormDataPart (string name, string filename, global::Okhttp3.RequestBody body)
			{
				const string __id = "addFormDataPart.(Ljava/lang/String;Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_filename = JNIEnv.NewString (filename);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_filename);
					__args [2] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_filename);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='addPart' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='okhttp3.RequestBody']]"
			[Register ("addPart", "(Lokhttp3/Headers;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder AddPart (global::Okhttp3.Headers headers, global::Okhttp3.RequestBody body)
			{
				const string __id = "addPart.(Lokhttp3/Headers;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
					__args [1] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='addPart' and count(parameter)=1 and parameter[1][@type='okhttp3.MultipartBody.Part']]"
			[Register ("addPart", "(Lokhttp3/MultipartBody$Part;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder AddPart (global::Okhttp3.MultipartBody.Part part)
			{
				const string __id = "addPart.(Lokhttp3/MultipartBody$Part;)Lokhttp3/MultipartBody$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((part == null) ? IntPtr.Zero : ((global::Java.Lang.Object) part).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='addPart' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("addPart", "(Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder AddPart (global::Okhttp3.RequestBody body)
			{
				const string __id = "addPart.(Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/MultipartBody;", "")]
			public unsafe global::Okhttp3.MultipartBody Build ()
			{
				const string __id = "build.()Lokhttp3/MultipartBody;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='okhttp3.MediaType']]"
			[Register ("setType", "(Lokhttp3/MediaType;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder SetType (global::Okhttp3.MediaType type)
			{
				const string __id = "setType.(Lokhttp3/MediaType;)Lokhttp3/MultipartBody$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']"
		[global::Android.Runtime.Register ("okhttp3/MultipartBody$Part", DoNotGenerateAcw=true)]
		public sealed partial class Part : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/MultipartBody$Part", typeof (Part));
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

			internal Part (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='okhttp3.RequestBody']]"
			[Register ("create", "(Lokhttp3/Headers;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;", "")]
			public static unsafe global::Okhttp3.MultipartBody.Part Create (global::Okhttp3.Headers headers, global::Okhttp3.RequestBody body)
			{
				const string __id = "create.(Lokhttp3/Headers;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
					__args [1] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Part> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']/method[@name='create' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("create", "(Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;", "")]
			public static unsafe global::Okhttp3.MultipartBody.Part Create (global::Okhttp3.RequestBody body)
			{
				const string __id = "create.(Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Part> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']/method[@name='createFormData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("createFormData", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/MultipartBody$Part;", "")]
			public static unsafe global::Okhttp3.MultipartBody.Part CreateFormData (string name, string value)
			{
				const string __id = "createFormData.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/MultipartBody$Part;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Part> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']/method[@name='createFormData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='okhttp3.RequestBody']]"
			[Register ("createFormData", "(Ljava/lang/String;Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;", "")]
			public static unsafe global::Okhttp3.MultipartBody.Part CreateFormData (string name, string filename, global::Okhttp3.RequestBody body)
			{
				const string __id = "createFormData.(Ljava/lang/String;Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_filename = JNIEnv.NewString (filename);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_filename);
					__args [2] = new JniArgumentValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Part> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_filename);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/MultipartBody", typeof (MultipartBody));
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

		internal MultipartBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='boundary' and count(parameter)=0]"
		[Register ("boundary", "()Ljava/lang/String;", "")]
		public unsafe string Boundary ()
		{
			const string __id = "boundary.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='contentType' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='part' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("part", "(I)Lokhttp3/MultipartBody$Part;", "")]
		public unsafe global::Okhttp3.MultipartBody.Part InvokePart (int index)
		{
			const string __id = "part.(I)Lokhttp3/MultipartBody$Part;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Part> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='parts' and count(parameter)=0]"
		[Register ("parts", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.MultipartBody.Part> Parts ()
		{
			const string __id = "parts.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Okhttp3.MultipartBody.Part>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='size' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lokhttp3/MediaType;", "")]
		public unsafe global::Okhttp3.MediaType Type ()
		{
			const string __id = "type.()Lokhttp3/MediaType;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
