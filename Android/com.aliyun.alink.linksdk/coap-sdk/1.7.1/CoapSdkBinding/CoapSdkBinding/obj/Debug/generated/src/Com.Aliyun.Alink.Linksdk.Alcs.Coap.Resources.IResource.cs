using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']"
	[Register ("com/aliyun/alink/linksdk/alcs/coap/resources/Resource", "", "Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker")]
	public partial interface IResource : IJavaObject, IJavaPeerable {

		global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes Attributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='getAttributes' and count(parameter)=0]"
			[Register ("getAttributes", "()Lcom/aliyun/alink/linksdk/alcs/coap/resources/ResourceAttributes;", "GetGetAttributesHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] get;
		}

		global::System.Collections.Generic.ICollection<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> Children {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='getChildren' and count(parameter)=0]"
			[Register ("getChildren", "()Ljava/util/Collection;", "GetGetChildrenHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] get;
		}

		global::Java.Util.Concurrent.IExecutorService Executor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='getExecutor' and count(parameter)=0]"
			[Register ("getExecutor", "()Ljava/util/concurrent/ExecutorService;", "GetGetExecutorHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] get;
		}

		bool IsCachable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='isCachable' and count(parameter)=0]"
			[Register ("isCachable", "()Z", "GetIsCachableHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] get;
		}

		bool IsObservable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='isObservable' and count(parameter)=0]"
			[Register ("isObservable", "()Z", "GetIsObservableHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] get;
		}

		bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] set;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource Parent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='getParent' and count(parameter)=0]"
			[Register ("getParent", "()Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;", "GetGetParentHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='setParent' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource']]"
			[Register ("setParent", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)V", "GetSetParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] set;
		}

		string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPath", "(Ljava/lang/String;)V", "GetSetPath_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] set;
		}

		string URI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='getURI' and count(parameter)=0]"
			[Register ("getURI", "()Ljava/lang/String;", "GetGetURIHandler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource']]"
		[Register ("add", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)V", "GetAdd_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")]
		void Add (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource']]"
		[Register ("delete", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)Z", "GetDelete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")]
		bool Delete (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/interface[@name='Resource']/method[@name='getChild' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getChild", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;", "GetGetChild_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResourceInvoker, CoapSdkBinding")]
		global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource GetChild (string p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/resources/Resource", DoNotGenerateAcw=true)]
	internal partial class IResourceInvoker : global::Java.Lang.Object, IResource {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/resources/Resource", typeof (IResourceInvoker));

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

		public static IResource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.coap.resources.Resource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAttributes;
#pragma warning disable 0169
		static Delegate GetGetAttributesHandler ()
		{
			if (cb_getAttributes == null)
				cb_getAttributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributes);
			return cb_getAttributes;
		}

		static IntPtr n_GetAttributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Attributes);
		}
#pragma warning restore 0169

		IntPtr id_getAttributes;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes Attributes {
			get {
				if (id_getAttributes == IntPtr.Zero)
					id_getAttributes = JNIEnv.GetMethodID (class_ref, "getAttributes", "()Lcom/aliyun/alink/linksdk/alcs/coap/resources/ResourceAttributes;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttributes), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getChildren;
#pragma warning disable 0169
		static Delegate GetGetChildrenHandler ()
		{
			if (cb_getChildren == null)
				cb_getChildren = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChildren);
			return cb_getChildren;
		}

		static IntPtr n_GetChildren (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource>.ToLocalJniHandle (__this.Children);
		}
#pragma warning restore 0169

		IntPtr id_getChildren;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> Children {
			get {
				if (id_getChildren == IntPtr.Zero)
					id_getChildren = JNIEnv.GetMethodID (class_ref, "getChildren", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChildren), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getExecutor;
#pragma warning disable 0169
		static Delegate GetGetExecutorHandler ()
		{
			if (cb_getExecutor == null)
				cb_getExecutor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExecutor);
			return cb_getExecutor;
		}

		static IntPtr n_GetExecutor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Executor);
		}
#pragma warning restore 0169

		IntPtr id_getExecutor;
		public unsafe global::Java.Util.Concurrent.IExecutorService Executor {
			get {
				if (id_getExecutor == IntPtr.Zero)
					id_getExecutor = JNIEnv.GetMethodID (class_ref, "getExecutor", "()Ljava/util/concurrent/ExecutorService;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExecutor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isCachable;
#pragma warning disable 0169
		static Delegate GetIsCachableHandler ()
		{
			if (cb_isCachable == null)
				cb_isCachable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCachable);
			return cb_isCachable;
		}

		static bool n_IsCachable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCachable;
		}
#pragma warning restore 0169

		IntPtr id_isCachable;
		public unsafe bool IsCachable {
			get {
				if (id_isCachable == IntPtr.Zero)
					id_isCachable = JNIEnv.GetMethodID (class_ref, "isCachable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCachable);
			}
		}

		static Delegate cb_isObservable;
#pragma warning disable 0169
		static Delegate GetIsObservableHandler ()
		{
			if (cb_isObservable == null)
				cb_isObservable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsObservable);
			return cb_isObservable;
		}

		static bool n_IsObservable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsObservable;
		}
#pragma warning restore 0169

		IntPtr id_isObservable;
		public unsafe bool IsObservable {
			get {
				if (id_isObservable == IntPtr.Zero)
					id_isObservable = JNIEnv.GetMethodID (class_ref, "isObservable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isObservable);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVisible;
		}
#pragma warning restore 0169

		IntPtr id_isVisible;
		public unsafe bool IsVisible {
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		IntPtr id_getName;
		IntPtr id_setName_Ljava_lang_String_;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getParent;
#pragma warning disable 0169
		static Delegate GetGetParentHandler ()
		{
			if (cb_getParent == null)
				cb_getParent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParent);
			return cb_getParent;
		}

		static IntPtr n_GetParent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parent);
		}
#pragma warning restore 0169

		static Delegate cb_setParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
#pragma warning disable 0169
		static Delegate GetSetParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler ()
		{
			if (cb_setParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ == null)
				cb_setParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_);
			return cb_setParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
		}

		static void n_SetParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parent = p0;
		}
#pragma warning restore 0169

		IntPtr id_getParent;
		IntPtr id_setParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource Parent {
			get {
				if (id_getParent == IntPtr.Zero)
					id_getParent = JNIEnv.GetMethodID (class_ref, "getParent", "()Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParent), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ == IntPtr.Zero)
					id_setParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ = JNIEnv.GetMethodID (class_ref, "setParent", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_, __args);
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		static Delegate cb_setPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPath_Ljava_lang_String_Handler ()
		{
			if (cb_setPath_Ljava_lang_String_ == null)
				cb_setPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPath_Ljava_lang_String_);
			return cb_setPath_Ljava_lang_String_;
		}

		static void n_SetPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Path = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPath;
		IntPtr id_setPath_Ljava_lang_String_;
		public unsafe string Path {
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPath_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getURI;
#pragma warning disable 0169
		static Delegate GetGetURIHandler ()
		{
			if (cb_getURI == null)
				cb_getURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetURI);
			return cb_getURI;
		}

		static IntPtr n_GetURI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.URI);
		}
#pragma warning restore 0169

		IntPtr id_getURI;
		public unsafe string URI {
			get {
				if (id_getURI == IntPtr.Zero)
					id_getURI = JNIEnv.GetMethodID (class_ref, "getURI", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getURI), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler ()
		{
			if (cb_add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ == null)
				cb_add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_);
			return cb_add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
		}

		static void n_Add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		IntPtr id_add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
		public unsafe void Add (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource p0)
		{
			if (id_add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ == IntPtr.Zero)
				id_add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_, __args);
		}

		static Delegate cb_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler ()
		{
			if (cb_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ == null)
				cb_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_);
			return cb_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
		}

		static bool n_Delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Delete (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
		public unsafe bool Delete (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource p0)
		{
			if (id_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ == IntPtr.Zero)
				id_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_, __args);
			return __ret;
		}

		static Delegate cb_getChild_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetChild_Ljava_lang_String_Handler ()
		{
			if (cb_getChild_Ljava_lang_String_ == null)
				cb_getChild_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChild_Ljava_lang_String_);
			return cb_getChild_Ljava_lang_String_;
		}

		static IntPtr n_GetChild_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChild (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getChild_Ljava_lang_String_;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource GetChild (string p0)
		{
			if (id_getChild_Ljava_lang_String_ == IntPtr.Zero)
				id_getChild_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getChild", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource __ret = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChild_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
