using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='ByteString']"
	[global::Android.Runtime.Register ("okio/ByteString", DoNotGenerateAcw=true)]
	public partial class ByteString : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IComparable {



		// Metadata.xml XPath field reference: path="/api/package[@name='okio']/class[@name='ByteString']/field[@name='EMPTY']"
		[Register ("EMPTY")]
		public static global::Okio.ByteString Empty {
			get {
				const string __id = "EMPTY.Lokio/ByteString;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/ByteString", typeof (ByteString));
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

		protected ByteString (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_asByteBuffer;
#pragma warning disable 0169
		static Delegate GetAsByteBufferHandler ()
		{
			if (cb_asByteBuffer == null)
				cb_asByteBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsByteBuffer);
			return cb_asByteBuffer;
		}

		static IntPtr n_AsByteBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsByteBuffer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='asByteBuffer' and count(parameter)=0]"
		[Register ("asByteBuffer", "()Ljava/nio/ByteBuffer;", "GetAsByteBufferHandler")]
		public virtual unsafe global::Java.Nio.ByteBuffer AsByteBuffer ()
		{
			const string __id = "asByteBuffer.()Ljava/nio/ByteBuffer;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_base64;
#pragma warning disable 0169
		static Delegate GetBase64Handler ()
		{
			if (cb_base64 == null)
				cb_base64 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Base64);
			return cb_base64;
		}

		static IntPtr n_Base64 (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Base64 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='base64' and count(parameter)=0]"
		[Register ("base64", "()Ljava/lang/String;", "GetBase64Handler")]
		public virtual unsafe string Base64 ()
		{
			const string __id = "base64.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_base64Url;
#pragma warning disable 0169
		static Delegate GetBase64UrlHandler ()
		{
			if (cb_base64Url == null)
				cb_base64Url = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Base64Url);
			return cb_base64Url;
		}

		static IntPtr n_Base64Url (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Base64Url ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='base64Url' and count(parameter)=0]"
		[Register ("base64Url", "()Ljava/lang/String;", "GetBase64UrlHandler")]
		public virtual unsafe string Base64Url ()
		{
			const string __id = "base64Url.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compareTo_Lokio_ByteString_;
#pragma warning disable 0169
		static Delegate GetRawCompareTo_Lokio_ByteString_Handler ()
		{
			if (cb_compareTo_Lokio_ByteString_ == null)
				cb_compareTo_Lokio_ByteString_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_RawCompareTo_Lokio_ByteString_);
			return cb_compareTo_Lokio_ByteString_;
		}

		static int n_RawCompareTo_Lokio_ByteString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_byteString)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString byteString = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_byteString, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RawCompareTo (byteString);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("compareTo", "(Lokio/ByteString;)I", "GetRawCompareTo_Lokio_ByteString_Handler")]
		public virtual unsafe int RawCompareTo (global::Okio.ByteString byteString)
		{
			const string __id = "compareTo.(Lokio/ByteString;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((byteString == null) ? IntPtr.Zero : ((global::Java.Lang.Object) byteString).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='decodeBase64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeBase64", "(Ljava/lang/String;)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString DecodeBase64 (string base64)
		{
			const string __id = "decodeBase64.(Ljava/lang/String;)Lokio/ByteString;";
			IntPtr native_base64 = JNIEnv.NewString (base64);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_base64);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_base64);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='decodeHex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeHex", "(Ljava/lang/String;)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString DecodeHex (string hex)
		{
			const string __id = "decodeHex.(Ljava/lang/String;)Lokio/ByteString;";
			IntPtr native_hex = JNIEnv.NewString (hex);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hex);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hex);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='encodeUtf8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeUtf8", "(Ljava/lang/String;)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString EncodeUtf8 (string s)
		{
			const string __id = "encodeUtf8.(Ljava/lang/String;)Lokio/ByteString;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='endsWith' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("endsWith", "([B)Z", "")]
		public unsafe bool EndsWith (byte[] prefix)
		{
			const string __id = "endsWith.([B)Z";
			IntPtr native_prefix = JNIEnv.NewArray (prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (prefix != null) {
					JNIEnv.CopyArray (native_prefix, prefix);
					JNIEnv.DeleteLocalRef (native_prefix);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='endsWith' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("endsWith", "(Lokio/ByteString;)Z", "")]
		public unsafe bool EndsWith (global::Okio.ByteString prefix)
		{
			const string __id = "endsWith.(Lokio/ByteString;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((prefix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prefix).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getByte_I;
#pragma warning disable 0169
		static Delegate GetGetByte_IHandler ()
		{
			if (cb_getByte_I == null)
				cb_getByte_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte>) n_GetByte_I);
			return cb_getByte_I;
		}

		static sbyte n_GetByte_I (IntPtr jnienv, IntPtr native__this, int pos)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetByte (pos);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getByte", "(I)B", "GetGetByte_IHandler")]
		public virtual unsafe sbyte GetByte (int pos)
		{
			const string __id = "getByte.(I)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pos);
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_hex;
#pragma warning disable 0169
		static Delegate GetHexHandler ()
		{
			if (cb_hex == null)
				cb_hex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Hex);
			return cb_hex;
		}

		static IntPtr n_Hex (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Hex ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='hex' and count(parameter)=0]"
		[Register ("hex", "()Ljava/lang/String;", "GetHexHandler")]
		public virtual unsafe string Hex ()
		{
			const string __id = "hex.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("indexOf", "([B)I", "")]
		public unsafe int IndexOf (byte[] other)
		{
			const string __id = "indexOf.([B)I";
			IntPtr native_other = JNIEnv.NewArray (other);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_other);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (other != null) {
					JNIEnv.CopyArray (native_other, other);
					JNIEnv.DeleteLocalRef (native_other);
				}
			}
		}

		static Delegate cb_indexOf_arrayBI;
#pragma warning disable 0169
		static Delegate GetIndexOf_arrayBIHandler ()
		{
			if (cb_indexOf_arrayBI == null)
				cb_indexOf_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_IndexOf_arrayBI);
			return cb_indexOf_arrayBI;
		}

		static int n_IndexOf_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_other, int fromIndex)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] other = (byte[]) JNIEnv.GetArray (native_other, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.IndexOf (other, fromIndex);
			if (other != null)
				JNIEnv.CopyArray (other, native_other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("indexOf", "([BI)I", "GetIndexOf_arrayBIHandler")]
		public virtual unsafe int IndexOf (byte[] other, int fromIndex)
		{
			const string __id = "indexOf.([BI)I";
			IntPtr native_other = JNIEnv.NewArray (other);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_other);
				__args [1] = new JniArgumentValue (fromIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (other != null) {
					JNIEnv.CopyArray (native_other, other);
					JNIEnv.DeleteLocalRef (native_other);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("indexOf", "(Lokio/ByteString;)I", "")]
		public unsafe int IndexOf (global::Okio.ByteString other)
		{
			const string __id = "indexOf.(Lokio/ByteString;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='okio.ByteString'] and parameter[2][@type='int']]"
		[Register ("indexOf", "(Lokio/ByteString;I)I", "")]
		public unsafe int IndexOf (global::Okio.ByteString other, int fromIndex)
		{
			const string __id = "indexOf.(Lokio/ByteString;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				__args [1] = new JniArgumentValue (fromIndex);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='lastIndexOf' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("lastIndexOf", "([B)I", "")]
		public unsafe int LastIndexOf (byte[] other)
		{
			const string __id = "lastIndexOf.([B)I";
			IntPtr native_other = JNIEnv.NewArray (other);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_other);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (other != null) {
					JNIEnv.CopyArray (native_other, other);
					JNIEnv.DeleteLocalRef (native_other);
				}
			}
		}

		static Delegate cb_lastIndexOf_arrayBI;
#pragma warning disable 0169
		static Delegate GetLastIndexOf_arrayBIHandler ()
		{
			if (cb_lastIndexOf_arrayBI == null)
				cb_lastIndexOf_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_LastIndexOf_arrayBI);
			return cb_lastIndexOf_arrayBI;
		}

		static int n_LastIndexOf_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_other, int fromIndex)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] other = (byte[]) JNIEnv.GetArray (native_other, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.LastIndexOf (other, fromIndex);
			if (other != null)
				JNIEnv.CopyArray (other, native_other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("lastIndexOf", "([BI)I", "GetLastIndexOf_arrayBIHandler")]
		public virtual unsafe int LastIndexOf (byte[] other, int fromIndex)
		{
			const string __id = "lastIndexOf.([BI)I";
			IntPtr native_other = JNIEnv.NewArray (other);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_other);
				__args [1] = new JniArgumentValue (fromIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (other != null) {
					JNIEnv.CopyArray (native_other, other);
					JNIEnv.DeleteLocalRef (native_other);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='lastIndexOf' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("lastIndexOf", "(Lokio/ByteString;)I", "")]
		public unsafe int LastIndexOf (global::Okio.ByteString other)
		{
			const string __id = "lastIndexOf.(Lokio/ByteString;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='okio.ByteString'] and parameter[2][@type='int']]"
		[Register ("lastIndexOf", "(Lokio/ByteString;I)I", "")]
		public unsafe int LastIndexOf (global::Okio.ByteString other, int fromIndex)
		{
			const string __id = "lastIndexOf.(Lokio/ByteString;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				__args [1] = new JniArgumentValue (fromIndex);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_md5;
#pragma warning disable 0169
		static Delegate GetMd5Handler ()
		{
			if (cb_md5 == null)
				cb_md5 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Md5);
			return cb_md5;
		}

		static IntPtr n_Md5 (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Md5 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='md5' and count(parameter)=0]"
		[Register ("md5", "()Lokio/ByteString;", "GetMd5Handler")]
		public virtual unsafe global::Okio.ByteString Md5 ()
		{
			const string __id = "md5.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='of' and count(parameter)=1 and parameter[1][@type='byte...']]"
		[Register ("of", "([B)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString Of (params byte[] data)
		{
			const string __id = "of.([B)Lokio/ByteString;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='of' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("of", "([BII)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString Of (byte[] data, int offset, int byteCount)
		{
			const string __id = "of.([BII)Lokio/ByteString;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (byteCount);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_rangeEquals_IarrayBII;
#pragma warning disable 0169
		static Delegate GetRangeEquals_IarrayBIIHandler ()
		{
			if (cb_rangeEquals_IarrayBII == null)
				cb_rangeEquals_IarrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int, int, bool>) n_RangeEquals_IarrayBII);
			return cb_rangeEquals_IarrayBII;
		}

		static bool n_RangeEquals_IarrayBII (IntPtr jnienv, IntPtr native__this, int offset, IntPtr native_other, int otherOffset, int byteCount)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] other = (byte[]) JNIEnv.GetArray (native_other, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.RangeEquals (offset, other, otherOffset, byteCount);
			if (other != null)
				JNIEnv.CopyArray (other, native_other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='rangeEquals' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("rangeEquals", "(I[BII)Z", "GetRangeEquals_IarrayBIIHandler")]
		public virtual unsafe bool RangeEquals (int offset, byte[] other, int otherOffset, int byteCount)
		{
			const string __id = "rangeEquals.(I[BII)Z";
			IntPtr native_other = JNIEnv.NewArray (other);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue (native_other);
				__args [2] = new JniArgumentValue (otherOffset);
				__args [3] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (other != null) {
					JNIEnv.CopyArray (native_other, other);
					JNIEnv.DeleteLocalRef (native_other);
				}
			}
		}

		static Delegate cb_rangeEquals_ILokio_ByteString_II;
#pragma warning disable 0169
		static Delegate GetRangeEquals_ILokio_ByteString_IIHandler ()
		{
			if (cb_rangeEquals_ILokio_ByteString_II == null)
				cb_rangeEquals_ILokio_ByteString_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int, int, bool>) n_RangeEquals_ILokio_ByteString_II);
			return cb_rangeEquals_ILokio_ByteString_II;
		}

		static bool n_RangeEquals_ILokio_ByteString_II (IntPtr jnienv, IntPtr native__this, int offset, IntPtr native_other, int otherOffset, int byteCount)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString other = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RangeEquals (offset, other, otherOffset, byteCount);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='rangeEquals' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='okio.ByteString'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("rangeEquals", "(ILokio/ByteString;II)Z", "GetRangeEquals_ILokio_ByteString_IIHandler")]
		public virtual unsafe bool RangeEquals (int offset, global::Okio.ByteString other, int otherOffset, int byteCount)
		{
			const string __id = "rangeEquals.(ILokio/ByteString;II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				__args [2] = new JniArgumentValue (otherOffset);
				__args [3] = new JniArgumentValue (byteCount);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='read' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("read", "(Ljava/io/InputStream;I)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString Read (global::System.IO.Stream @in, int byteCount)
		{
			const string __id = "read.(Ljava/io/InputStream;I)Lokio/ByteString;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__in);
				__args [1] = new JniArgumentValue (byteCount);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		static Delegate cb_sha1;
#pragma warning disable 0169
		static Delegate GetSha1Handler ()
		{
			if (cb_sha1 == null)
				cb_sha1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Sha1);
			return cb_sha1;
		}

		static IntPtr n_Sha1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sha1 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='sha1' and count(parameter)=0]"
		[Register ("sha1", "()Lokio/ByteString;", "GetSha1Handler")]
		public virtual unsafe global::Okio.ByteString Sha1 ()
		{
			const string __id = "sha1.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sha256;
#pragma warning disable 0169
		static Delegate GetSha256Handler ()
		{
			if (cb_sha256 == null)
				cb_sha256 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Sha256);
			return cb_sha256;
		}

		static IntPtr n_Sha256 (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sha256 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='sha256' and count(parameter)=0]"
		[Register ("sha256", "()Lokio/ByteString;", "GetSha256Handler")]
		public virtual unsafe global::Okio.ByteString Sha256 ()
		{
			const string __id = "sha256.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='startsWith' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("startsWith", "([B)Z", "")]
		public unsafe bool StartsWith (byte[] prefix)
		{
			const string __id = "startsWith.([B)Z";
			IntPtr native_prefix = JNIEnv.NewArray (prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (prefix != null) {
					JNIEnv.CopyArray (native_prefix, prefix);
					JNIEnv.DeleteLocalRef (native_prefix);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='startsWith' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("startsWith", "(Lokio/ByteString;)Z", "")]
		public unsafe bool StartsWith (global::Okio.ByteString prefix)
		{
			const string __id = "startsWith.(Lokio/ByteString;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((prefix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prefix).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_substring_I;
#pragma warning disable 0169
		static Delegate GetSubstring_IHandler ()
		{
			if (cb_substring_I == null)
				cb_substring_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Substring_I);
			return cb_substring_I;
		}

		static IntPtr n_Substring_I (IntPtr jnienv, IntPtr native__this, int beginIndex)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Substring (beginIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='substring' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("substring", "(I)Lokio/ByteString;", "GetSubstring_IHandler")]
		public virtual unsafe global::Okio.ByteString Substring (int beginIndex)
		{
			const string __id = "substring.(I)Lokio/ByteString;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (beginIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_substring_II;
#pragma warning disable 0169
		static Delegate GetSubstring_IIHandler ()
		{
			if (cb_substring_II == null)
				cb_substring_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Substring_II);
			return cb_substring_II;
		}

		static IntPtr n_Substring_II (IntPtr jnienv, IntPtr native__this, int beginIndex, int endIndex)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Substring (beginIndex, endIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='substring' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("substring", "(II)Lokio/ByteString;", "GetSubstring_IIHandler")]
		public virtual unsafe global::Okio.ByteString Substring (int beginIndex, int endIndex)
		{
			const string __id = "substring.(II)Lokio/ByteString;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (beginIndex);
				__args [1] = new JniArgumentValue (endIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toAsciiLowercase;
#pragma warning disable 0169
		static Delegate GetToAsciiLowercaseHandler ()
		{
			if (cb_toAsciiLowercase == null)
				cb_toAsciiLowercase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToAsciiLowercase);
			return cb_toAsciiLowercase;
		}

		static IntPtr n_ToAsciiLowercase (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToAsciiLowercase ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='toAsciiLowercase' and count(parameter)=0]"
		[Register ("toAsciiLowercase", "()Lokio/ByteString;", "GetToAsciiLowercaseHandler")]
		public virtual unsafe global::Okio.ByteString ToAsciiLowercase ()
		{
			const string __id = "toAsciiLowercase.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toAsciiUppercase;
#pragma warning disable 0169
		static Delegate GetToAsciiUppercaseHandler ()
		{
			if (cb_toAsciiUppercase == null)
				cb_toAsciiUppercase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToAsciiUppercase);
			return cb_toAsciiUppercase;
		}

		static IntPtr n_ToAsciiUppercase (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToAsciiUppercase ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='toAsciiUppercase' and count(parameter)=0]"
		[Register ("toAsciiUppercase", "()Lokio/ByteString;", "GetToAsciiUppercaseHandler")]
		public virtual unsafe global::Okio.ByteString ToAsciiUppercase ()
		{
			const string __id = "toAsciiUppercase.()Lokio/ByteString;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual unsafe byte[] ToByteArray ()
		{
			const string __id = "toByteArray.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_utf8;
#pragma warning disable 0169
		static Delegate GetUtf8Handler ()
		{
			if (cb_utf8 == null)
				cb_utf8 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Utf8);
			return cb_utf8;
		}

		static IntPtr n_Utf8 (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Utf8 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='utf8' and count(parameter)=0]"
		[Register ("utf8", "()Ljava/lang/String;", "GetUtf8Handler")]
		public virtual unsafe string Utf8 ()
		{
			const string __id = "utf8.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_io_OutputStream_Handler ()
		{
			if (cb_write_Ljava_io_OutputStream_ == null)
				cb_write_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_io_OutputStream_);
			return cb_write_Ljava_io_OutputStream_;
		}

		static void n_Write_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Write (@out);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("write", "(Ljava/io/OutputStream;)V", "GetWrite_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void Write (global::System.IO.Stream @out)
		{
			const string __id = "write.(Ljava/io/OutputStream;)V";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__out);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

	}
}
