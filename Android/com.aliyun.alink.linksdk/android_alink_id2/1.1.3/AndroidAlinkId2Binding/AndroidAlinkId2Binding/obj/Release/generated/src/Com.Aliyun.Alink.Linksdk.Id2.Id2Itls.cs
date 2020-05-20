using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Id2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/id2/Id2Itls", DoNotGenerateAcw=true)]
	public partial class Id2Itls : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/id2/Id2Itls", typeof (Id2Itls));
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

		protected Id2Itls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/constructor[@name='Id2Itls' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Id2Itls ()
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

		static Delegate cb_getAlertType;
#pragma warning disable 0169
		static Delegate GetGetAlertTypeHandler ()
		{
			if (cb_getAlertType == null)
				cb_getAlertType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAlertType);
			return cb_getAlertType;
		}

		static int n_GetAlertType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlertType;
		}
#pragma warning restore 0169

		public virtual unsafe int AlertType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/method[@name='getAlertType' and count(parameter)=0]"
			[Register ("getAlertType", "()I", "GetGetAlertTypeHandler")]
			get {
				const string __id = "getAlertType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getID2Id;
#pragma warning disable 0169
		static Delegate GetGetID2IdHandler ()
		{
			if (cb_getID2Id == null)
				cb_getID2Id = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetID2Id);
			return cb_getID2Id;
		}

		static IntPtr n_GetID2Id (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ID2Id);
		}
#pragma warning restore 0169

		public virtual unsafe string ID2Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/method[@name='getID2Id' and count(parameter)=0]"
			[Register ("getID2Id", "()Ljava/lang/String;", "GetGetID2IdHandler")]
			get {
				const string __id = "getID2Id.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_destroyItls_J;
#pragma warning disable 0169
		static Delegate GetDestroyItls_JHandler ()
		{
			if (cb_destroyItls_J == null)
				cb_destroyItls_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_DestroyItls_J);
			return cb_destroyItls_J;
		}

		static void n_DestroyItls_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DestroyItls (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/method[@name='destroyItls' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("destroyItls", "(J)V", "GetDestroyItls_JHandler")]
		public virtual unsafe void DestroyItls (long p0)
		{
			const string __id = "destroyItls.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_establishItls_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEstablishItls_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_establishItls_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_establishItls_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, long>) n_EstablishItls_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_);
			return cb_establishItls_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		}

		static long n_EstablishItls_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.EstablishItls (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/method[@name='establishItls' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("establishItls", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)J", "GetEstablishItls_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe long EstablishItls (string p0, int p1, string p2, string p3)
		{
			const string __id = "establishItls.(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)J";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getTimestampAuthCode_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTimestampAuthCode_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getTimestampAuthCode_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getTimestampAuthCode_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTimestampAuthCode_Ljava_lang_String_Ljava_lang_String_);
			return cb_getTimestampAuthCode_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetTimestampAuthCode_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTimestampAuthCode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/method[@name='getTimestampAuthCode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getTimestampAuthCode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetTimestampAuthCode_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTimestampAuthCode (string p0, string p1)
		{
			const string __id = "getTimestampAuthCode.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/method[@name='initItlsSo' and count(parameter)=0]"
		[Register ("initItlsSo", "()V", "")]
		protected static unsafe void InitItlsSo ()
		{
			const string __id = "initItlsSo.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_itlsRead_JarrayBII;
#pragma warning disable 0169
		static Delegate GetItlsRead_JarrayBIIHandler ()
		{
			if (cb_itlsRead_JarrayBII == null)
				cb_itlsRead_JarrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, int, int>) n_ItlsRead_JarrayBII);
			return cb_itlsRead_JarrayBII;
		}

		static int n_ItlsRead_JarrayBII (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ItlsRead (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/method[@name='itlsRead' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("itlsRead", "(J[BII)I", "GetItlsRead_JarrayBIIHandler")]
		public virtual unsafe int ItlsRead (long p0, byte[] p1, int p2, int p3)
		{
			const string __id = "itlsRead.(J[BII)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_itlsWrite_JarrayBII;
#pragma warning disable 0169
		static Delegate GetItlsWrite_JarrayBIIHandler ()
		{
			if (cb_itlsWrite_JarrayBII == null)
				cb_itlsWrite_JarrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, int, int>) n_ItlsWrite_JarrayBII);
			return cb_itlsWrite_JarrayBII;
		}

		static int n_ItlsWrite_JarrayBII (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ItlsWrite (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/method[@name='itlsWrite' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("itlsWrite", "(J[BII)I", "GetItlsWrite_JarrayBIIHandler")]
		public virtual unsafe int ItlsWrite (long p0, byte[] p1, int p2, int p3)
		{
			const string __id = "itlsWrite.(J[BII)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_setItlsDebugLevel_I;
#pragma warning disable 0169
		static Delegate GetSetItlsDebugLevel_IHandler ()
		{
			if (cb_setItlsDebugLevel_I == null)
				cb_setItlsDebugLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItlsDebugLevel_I);
			return cb_setItlsDebugLevel_I;
		}

		static void n_SetItlsDebugLevel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetItlsDebugLevel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/method[@name='setItlsDebugLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setItlsDebugLevel", "(I)V", "GetSetItlsDebugLevel_IHandler")]
		public virtual unsafe void SetItlsDebugLevel (int p0)
		{
			const string __id = "setItlsDebugLevel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setJniDebugLevel_I;
#pragma warning disable 0169
		static Delegate GetSetJniDebugLevel_IHandler ()
		{
			if (cb_setJniDebugLevel_I == null)
				cb_setJniDebugLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetJniDebugLevel_I);
			return cb_setJniDebugLevel_I;
		}

		static void n_SetJniDebugLevel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Id2.Id2Itls> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetJniDebugLevel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.id2']/class[@name='Id2Itls']/method[@name='setJniDebugLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setJniDebugLevel", "(I)V", "GetSetJniDebugLevel_IHandler")]
		public virtual unsafe void SetJniDebugLevel (int p0)
		{
			const string __id = "setJniDebugLevel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
