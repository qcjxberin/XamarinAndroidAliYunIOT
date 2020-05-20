using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.React.Modules.Network
{

	
	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.react.modules.network']/interface[@name='CookieJarContainer']"
	[Register("com/facebook/react/modules/network/CookieJarContainer", "", "Com.Facebook.React.Modules.Network.ICookieJarContainerInvoker")]
	public partial interface ICookieJarContainer : global::Okhttp3.ICookieJar
	{

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.react.modules.network']/interface[@name='CookieJarContainer']/method[@name='removeCookieJar' and count(parameter)=0]"
		[Register("removeCookieJar", "()V", "GetRemoveCookieJarHandler:Com.Facebook.React.Modules.Network.ICookieJarContainerInvoker, ReactNativeBinding")]
		void RemoveCookieJar();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.react.modules.network']/interface[@name='CookieJarContainer']/method[@name='setCookieJar' and count(parameter)=1 and parameter[1][@type='okhttp3.CookieJar']]"
		[Register("setCookieJar", "(Lokhttp3/CookieJar;)V", "GetSetCookieJar_Lokhttp3_CookieJar_Handler:Com.Facebook.React.Modules.Network.ICookieJarContainerInvoker, ReactNativeBinding")]
		void SetCookieJar(global::Okhttp3.ICookieJar p0);

	}

	[global::Android.Runtime.Register("com/facebook/react/modules/network/CookieJarContainer", DoNotGenerateAcw = true)]
	internal partial class ICookieJarContainerInvoker : global::Java.Lang.Object, ICookieJarContainer
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("com/facebook/react/modules/network/CookieJarContainer", typeof(ICookieJarContainerInvoker));

		static IntPtr java_class_ref
		{
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers
		{
			get { return _members; }
		}

		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ICookieJarContainer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICookieJarContainer>(handle, transfer);
		}

		static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
				throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance(handle), "com.facebook.react.modules.network.CookieJarContainer"));
			return handle;
		}

		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef(this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		public ICookieJarContainerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef(local_ref);
			JNIEnv.DeleteLocalRef(local_ref);
		}

		static Delegate cb_removeCookieJar;
#pragma warning disable 0169
		static Delegate GetRemoveCookieJarHandler()
		{
			if (cb_removeCookieJar == null)
				cb_removeCookieJar = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_RemoveCookieJar);
			return cb_removeCookieJar;
		}

		static void n_RemoveCookieJar(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.React.Modules.Network.ICookieJarContainer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.React.Modules.Network.ICookieJarContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCookieJar();
		}
#pragma warning restore 0169

		IntPtr id_removeCookieJar;
		public unsafe void RemoveCookieJar()
		{
			if (id_removeCookieJar == IntPtr.Zero)
				id_removeCookieJar = JNIEnv.GetMethodID(class_ref, "removeCookieJar", "()V");
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_removeCookieJar);
		}

		static Delegate cb_setCookieJar_Lokhttp3_CookieJar_;
#pragma warning disable 0169
		static Delegate GetSetCookieJar_Lokhttp3_CookieJar_Handler()
		{
			if (cb_setCookieJar_Lokhttp3_CookieJar_ == null)
				cb_setCookieJar_Lokhttp3_CookieJar_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetCookieJar_Lokhttp3_CookieJar_);
			return cb_setCookieJar_Lokhttp3_CookieJar_;
		}

		static void n_SetCookieJar_Lokhttp3_CookieJar_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.React.Modules.Network.ICookieJarContainer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.React.Modules.Network.ICookieJarContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICookieJar p0 = (global::Okhttp3.ICookieJar)global::Java.Lang.Object.GetObject<global::Okhttp3.ICookieJar>(native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCookieJar(p0);
		}
#pragma warning restore 0169

		IntPtr id_setCookieJar_Lokhttp3_CookieJar_;
		public unsafe void SetCookieJar(global::Okhttp3.ICookieJar p0)
		{
			if (id_setCookieJar_Lokhttp3_CookieJar_ == IntPtr.Zero)
				id_setCookieJar_Lokhttp3_CookieJar_ = JNIEnv.GetMethodID(class_ref, "setCookieJar", "(Lokhttp3/CookieJar;)V");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setCookieJar_Lokhttp3_CookieJar_, __args);
		}

		static Delegate cb_loadForRequest_Lokhttp3_HttpUrl_;
#pragma warning disable 0169
		static Delegate GetLoadForRequest_Lokhttp3_HttpUrl_Handler()
		{
			if (cb_loadForRequest_Lokhttp3_HttpUrl_ == null)
				cb_loadForRequest_Lokhttp3_HttpUrl_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_LoadForRequest_Lokhttp3_HttpUrl_);
			return cb_loadForRequest_Lokhttp3_HttpUrl_;
		}

		static IntPtr n_LoadForRequest_Lokhttp3_HttpUrl_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.React.Modules.Network.ICookieJarContainer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.React.Modules.Network.ICookieJarContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.HttpUrl p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle((System.Collections.IList)__this.LoadForRequest(p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadForRequest_Lokhttp3_HttpUrl_;
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.Cookie> LoadForRequest(global::Okhttp3.HttpUrl p0)
		{
			if (id_loadForRequest_Lokhttp3_HttpUrl_ == IntPtr.Zero)
				id_loadForRequest_Lokhttp3_HttpUrl_ = JNIEnv.GetMethodID(class_ref, "loadForRequest", "(Lokhttp3/HttpUrl;)Ljava/util/List;");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
			global::System.Collections.Generic.IList<global::Okhttp3.Cookie> __ret = global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_loadForRequest_Lokhttp3_HttpUrl_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSaveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_Handler()
		{
			if (cb_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_ == null)
				cb_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_SaveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_);
			return cb_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_;
		}

		static void n_SaveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.ICookieJar __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICookieJar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.HttpUrl p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl>(native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveFromResponse(p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_;
		public unsafe void SaveFromResponse(global::Okhttp3.HttpUrl p0, global::System.Collections.Generic.IList<global::Okhttp3.Cookie> p1)
		{
			if (id_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_ == IntPtr.Zero)
				id_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_ = JNIEnv.GetMethodID(class_ref, "saveFromResponse", "(Lokhttp3/HttpUrl;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.ToLocalJniHandle(p1);
			JValue* __args = stackalloc JValue[2];
			__args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
			__args[1] = new JValue(native_p1);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_saveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef(native_p1);
		}


		//		static Delegate cb_saveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_;
		//#pragma warning disable 0169
		//		static Delegate GetSaveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_Handler()
		//		{
		//			if (cb_saveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_ == null)
		//				cb_saveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_SaveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_);
		//			return cb_saveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_;
		//		}

		//		static void n_SaveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		//		{
		//			global::Com.Facebook.React.Modules.Network.ICookieJarContainer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.React.Modules.Network.ICookieJarContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
		//			global::Okhttp3.HttpUrl p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl>(native_p0, JniHandleOwnership.DoNotTransfer);

		//			//global::Android.Runtime.JavaList<Okhttp3.Cookie>
		//			global::Android.Runtime.JavaList<Okhttp3.Cookie> p1 = (global::Android.Runtime.JavaList<Okhttp3.Cookie>)global::Java.Lang.Object.GetObject<global::Android.Runtime.JavaList<Okhttp3.Cookie>>(native_p1, JniHandleOwnership.DoNotTransfer);
		//			//global::System.Collections.Generic.IList`1 p1 = (global::System.Collections.Generic.IList`1)global::Java.Lang.Object.GetObject < global::System.Collections.Generic.IList`1 > (native_p1, JniHandleOwnership.DoNotTransfer);
		//			__this.SaveFromResponse(p0, p1);
		//		}
		//#pragma warning restore 0169

		//		IntPtr id_saveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_;
		//		public unsafe void SaveFromResponse(global::Okhttp3.HttpUrl p0, global::System.Collections.Generic.IList<Okhttp3.Cookie> p1)
		//		{
		//			if (id_saveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_ == IntPtr.Zero)
		//				id_saveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_ = JNIEnv.GetMethodID(class_ref, "saveFromResponse", "(Lokhttp3/HttpUrl;LSystem/Collections/Generic/IList`1;)V");
		//			JValue* __args = stackalloc JValue[2];
		//			__args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
		//			__args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
		//			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_saveFromResponse_Lokhttp3_HttpUrl_LSystem_Collections_Generic_IList_1_, __args);
		//		}

	}	
}
