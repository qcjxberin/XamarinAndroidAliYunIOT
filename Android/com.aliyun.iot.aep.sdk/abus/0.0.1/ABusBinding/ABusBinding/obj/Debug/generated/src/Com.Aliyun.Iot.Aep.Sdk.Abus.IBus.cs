using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Abus {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IBus']"
	[Register ("com/aliyun/iot/aep/sdk/abus/IBus", "", "Com.Aliyun.Iot.Aep.Sdk.Abus.IBusInvoker")]
	public partial interface IBus : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IBus']/method[@name='attachListener' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class&lt;? extends java.lang.Object&gt;']]"
		[Register ("attachListener", "(ILjava/lang/Object;Ljava/lang/String;Ljava/lang/Class;)V", "GetAttachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_Handler:Com.Aliyun.Iot.Aep.Sdk.Abus.IBusInvoker, ABus")]
		void AttachListener (int p0, global::Java.Lang.Object p1, string p2, global::Java.Lang.Class p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IBus']/method[@name='blockChannel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("blockChannel", "(IZ)V", "GetBlockChannel_IZHandler:Com.Aliyun.Iot.Aep.Sdk.Abus.IBusInvoker, ABus")]
		void BlockChannel (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IBus']/method[@name='cancelChannel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cancelChannel", "(I)V", "GetCancelChannel_IHandler:Com.Aliyun.Iot.Aep.Sdk.Abus.IBusInvoker, ABus")]
		void CancelChannel (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IBus']/method[@name='detachListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("detachListener", "(ILjava/lang/Object;)V", "GetDetachListener_ILjava_lang_Object_Handler:Com.Aliyun.Iot.Aep.Sdk.Abus.IBusInvoker, ABus")]
		void DetachListener (int p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IBus']/method[@name='detachListener' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Class&lt;? extends java.lang.Object&gt;']]"
		[Register ("detachListener", "(ILjava/lang/Object;Ljava/lang/Class;)V", "GetDetachListener_ILjava_lang_Object_Ljava_lang_Class_Handler:Com.Aliyun.Iot.Aep.Sdk.Abus.IBusInvoker, ABus")]
		void DetachListener (int p0, global::Java.Lang.Object p1, global::Java.Lang.Class p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IBus']/method[@name='postEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("postEvent", "(ILjava/lang/Object;)V", "GetPostEvent_ILjava_lang_Object_Handler:Com.Aliyun.Iot.Aep.Sdk.Abus.IBusInvoker, ABus")]
		void PostEvent (int p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/abus/IBus", DoNotGenerateAcw=true)]
	internal partial class IBusInvoker : global::Java.Lang.Object, IBus {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/abus/IBus", typeof (IBusInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IBus GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBus> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.abus.IBus"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBusInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetAttachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_AttachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_);
			return cb_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_;
		}

		static void n_AttachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.AttachListener (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_;
		public unsafe void AttachListener (int p0, global::Java.Lang.Object p1, string p2, global::Java.Lang.Class p3)
		{
			if (id_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "attachListener", "(ILjava/lang/Object;Ljava/lang/String;Ljava/lang/Class;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachListener_ILjava_lang_Object_Ljava_lang_String_Ljava_lang_Class_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_blockChannel_IZ;
#pragma warning disable 0169
		static Delegate GetBlockChannel_IZHandler ()
		{
			if (cb_blockChannel_IZ == null)
				cb_blockChannel_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_BlockChannel_IZ);
			return cb_blockChannel_IZ;
		}

		static void n_BlockChannel_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockChannel (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_blockChannel_IZ;
		public unsafe void BlockChannel (int p0, bool p1)
		{
			if (id_blockChannel_IZ == IntPtr.Zero)
				id_blockChannel_IZ = JNIEnv.GetMethodID (class_ref, "blockChannel", "(IZ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockChannel_IZ, __args);
		}

		static Delegate cb_cancelChannel_I;
#pragma warning disable 0169
		static Delegate GetCancelChannel_IHandler ()
		{
			if (cb_cancelChannel_I == null)
				cb_cancelChannel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_CancelChannel_I);
			return cb_cancelChannel_I;
		}

		static void n_CancelChannel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelChannel (p0);
		}
#pragma warning restore 0169

		IntPtr id_cancelChannel_I;
		public unsafe void CancelChannel (int p0)
		{
			if (id_cancelChannel_I == IntPtr.Zero)
				id_cancelChannel_I = JNIEnv.GetMethodID (class_ref, "cancelChannel", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelChannel_I, __args);
		}

		static Delegate cb_detachListener_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDetachListener_ILjava_lang_Object_Handler ()
		{
			if (cb_detachListener_ILjava_lang_Object_ == null)
				cb_detachListener_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_DetachListener_ILjava_lang_Object_);
			return cb_detachListener_ILjava_lang_Object_;
		}

		static void n_DetachListener_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DetachListener (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_detachListener_ILjava_lang_Object_;
		public unsafe void DetachListener (int p0, global::Java.Lang.Object p1)
		{
			if (id_detachListener_ILjava_lang_Object_ == IntPtr.Zero)
				id_detachListener_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "detachListener", "(ILjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detachListener_ILjava_lang_Object_, __args);
		}

		static Delegate cb_detachListener_ILjava_lang_Object_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetDetachListener_ILjava_lang_Object_Ljava_lang_Class_Handler ()
		{
			if (cb_detachListener_ILjava_lang_Object_Ljava_lang_Class_ == null)
				cb_detachListener_ILjava_lang_Object_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_DetachListener_ILjava_lang_Object_Ljava_lang_Class_);
			return cb_detachListener_ILjava_lang_Object_Ljava_lang_Class_;
		}

		static void n_DetachListener_ILjava_lang_Object_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DetachListener (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_detachListener_ILjava_lang_Object_Ljava_lang_Class_;
		public unsafe void DetachListener (int p0, global::Java.Lang.Object p1, global::Java.Lang.Class p2)
		{
			if (id_detachListener_ILjava_lang_Object_Ljava_lang_Class_ == IntPtr.Zero)
				id_detachListener_ILjava_lang_Object_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "detachListener", "(ILjava/lang/Object;Ljava/lang/Class;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detachListener_ILjava_lang_Object_Ljava_lang_Class_, __args);
		}

		static Delegate cb_postEvent_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPostEvent_ILjava_lang_Object_Handler ()
		{
			if (cb_postEvent_ILjava_lang_Object_ == null)
				cb_postEvent_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_PostEvent_ILjava_lang_Object_);
			return cb_postEvent_ILjava_lang_Object_;
		}

		static void n_PostEvent_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostEvent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_postEvent_ILjava_lang_Object_;
		public unsafe void PostEvent (int p0, global::Java.Lang.Object p1)
		{
			if (id_postEvent_ILjava_lang_Object_ == IntPtr.Zero)
				id_postEvent_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "postEvent", "(ILjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postEvent_ILjava_lang_Object_, __args);
		}

	}

}
