using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource", DoNotGenerateAcw=true)]
	public partial class AlcsCoAPResource : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource", typeof (AlcsCoAPResource));
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

		protected AlcsCoAPResource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/constructor[@name='AlcsCoAPResource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AlcsCoAPResource (string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/constructor[@name='AlcsCoAPResource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
		public unsafe AlcsCoAPResource (string name, bool visible)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (visible);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Attributes);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes Attributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getAttributes' and count(parameter)=0]"
			[Register ("getAttributes", "()Lcom/aliyun/alink/linksdk/alcs/coap/resources/ResourceAttributes;", "GetGetAttributesHandler")]
			get {
				const string __id = "getAttributes.()Lcom/aliyun/alink/linksdk/alcs/coap/resources/ResourceAttributes;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource>.ToLocalJniHandle (__this.Children);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> Children {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getChildren' and count(parameter)=0]"
			[Register ("getChildren", "()Ljava/util/Collection;", "GetGetChildrenHandler")]
			get {
				const string __id = "getChildren.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Executor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Concurrent.IExecutorService Executor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getExecutor' and count(parameter)=0]"
			[Register ("getExecutor", "()Ljava/util/concurrent/ExecutorService;", "GetGetExecutorHandler")]
			get {
				const string __id = "getExecutor.()Ljava/util/concurrent/ExecutorService;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExpTime;
#pragma warning disable 0169
		static Delegate GetGetExpTimeHandler ()
		{
			if (cb_getExpTime == null)
				cb_getExpTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetExpTime);
			return cb_getExpTime;
		}

		static int n_GetExpTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpTime;
		}
#pragma warning restore 0169

		static Delegate cb_setExpTime_I;
#pragma warning disable 0169
		static Delegate GetSetExpTime_IHandler ()
		{
			if (cb_setExpTime_I == null)
				cb_setExpTime_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetExpTime_I);
			return cb_setExpTime_I;
		}

		static void n_SetExpTime_I (IntPtr jnienv, IntPtr native__this, int expTime)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpTime = expTime;
		}
#pragma warning restore 0169

		public virtual unsafe int ExpTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getExpTime' and count(parameter)=0]"
			[Register ("getExpTime", "()I", "GetGetExpTimeHandler")]
			get {
				const string __id = "getExpTime.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setExpTime' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExpTime", "(I)V", "GetSetExpTime_IHandler")]
			set {
				const string __id = "setExpTime.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHandler;
#pragma warning disable 0169
		static Delegate GetGetHandlerHandler ()
		{
			if (cb_getHandler == null)
				cb_getHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHandler);
			return cb_getHandler;
		}

		static IntPtr n_GetHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Handler);
		}
#pragma warning restore 0169

		static Delegate cb_setHandler_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPResHandler_;
#pragma warning disable 0169
		static Delegate GetSetHandler_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPResHandler_Handler ()
		{
			if (cb_setHandler_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPResHandler_ == null)
				cb_setHandler_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPResHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHandler_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPResHandler_);
			return cb_setHandler_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPResHandler_;
		}

		static void n_SetHandler_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPResHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPResHandler handler = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPResHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPResHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			__this.Handler = handler;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPResHandler Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPResHandler;", "GetGetHandlerHandler")]
			get {
				const string __id = "getHandler.()Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPResHandler;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPResHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setHandler' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPResHandler']]"
			[Register ("setHandler", "(Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPResHandler;)V", "GetSetHandler_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPResHandler_Handler")]
			set {
				const string __id = "setHandler.(Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPResHandler;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCachable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCachable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='isCachable' and count(parameter)=0]"
			[Register ("isCachable", "()Z", "GetIsCachableHandler")]
			get {
				const string __id = "isCachable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsObservable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsObservable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='isObservable' and count(parameter)=0]"
			[Register ("isObservable", "()Z", "GetIsObservableHandler")]
			get {
				const string __id = "isObservable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVisible;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxAge;
#pragma warning disable 0169
		static Delegate GetGetMaxAgeHandler ()
		{
			if (cb_getMaxAge == null)
				cb_getMaxAge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxAge);
			return cb_getMaxAge;
		}

		static int n_GetMaxAge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxAge;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxAge_I;
#pragma warning disable 0169
		static Delegate GetSetMaxAge_IHandler ()
		{
			if (cb_setMaxAge_I == null)
				cb_setMaxAge_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxAge_I);
			return cb_setMaxAge_I;
		}

		static void n_SetMaxAge_I (IntPtr jnienv, IntPtr native__this, int maxAge)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxAge = maxAge;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxAge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getMaxAge' and count(parameter)=0]"
			[Register ("getMaxAge", "()I", "GetGetMaxAgeHandler")]
			get {
				const string __id = "getMaxAge.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setMaxAge' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxAge", "(I)V", "GetSetMaxAge_IHandler")]
			set {
				const string __id = "setMaxAge.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Name = name;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNeedAuth;
#pragma warning disable 0169
		static Delegate GetGetNeedAuthHandler ()
		{
			if (cb_getNeedAuth == null)
				cb_getNeedAuth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNeedAuth);
			return cb_getNeedAuth;
		}

		static int n_GetNeedAuth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedAuth;
		}
#pragma warning restore 0169

		static Delegate cb_setNeedAuth_I;
#pragma warning disable 0169
		static Delegate GetSetNeedAuth_IHandler ()
		{
			if (cb_setNeedAuth_I == null)
				cb_setNeedAuth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNeedAuth_I);
			return cb_setNeedAuth_I;
		}

		static void n_SetNeedAuth_I (IntPtr jnienv, IntPtr native__this, int needAuth)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NeedAuth = needAuth;
		}
#pragma warning restore 0169

		public virtual unsafe int NeedAuth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getNeedAuth' and count(parameter)=0]"
			[Register ("getNeedAuth", "()I", "GetGetNeedAuthHandler")]
			get {
				const string __id = "getNeedAuth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setNeedAuth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNeedAuth", "(I)V", "GetSetNeedAuth_IHandler")]
			set {
				const string __id = "setNeedAuth.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource parent = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (native_parent, JniHandleOwnership.DoNotTransfer);
			__this.Parent = parent;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource Parent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getParent' and count(parameter)=0]"
			[Register ("getParent", "()Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;", "GetGetParentHandler")]
			get {
				const string __id = "getParent.()Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setParent' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource']]"
			[Register ("setParent", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)V", "GetSetParent_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler")]
			set {
				const string __id = "setParent.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.Path = path;
		}
#pragma warning restore 0169

		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				const string __id = "getPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPath", "(Ljava/lang/String;)V", "GetSetPath_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPermission;
#pragma warning disable 0169
		static Delegate GetGetPermissionHandler ()
		{
			if (cb_getPermission == null)
				cb_getPermission = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPermission);
			return cb_getPermission;
		}

		static int n_GetPermission (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Permission;
		}
#pragma warning restore 0169

		static Delegate cb_setPermission_I;
#pragma warning disable 0169
		static Delegate GetSetPermission_IHandler ()
		{
			if (cb_setPermission_I == null)
				cb_setPermission_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPermission_I);
			return cb_setPermission_I;
		}

		static void n_SetPermission_I (IntPtr jnienv, IntPtr native__this, int permission)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Permission = permission;
		}
#pragma warning restore 0169

		public virtual unsafe int Permission {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getPermission' and count(parameter)=0]"
			[Register ("getPermission", "()I", "GetGetPermissionHandler")]
			get {
				const string __id = "getPermission.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setPermission' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPermission", "(I)V", "GetSetPermission_IHandler")]
			set {
				const string __id = "setPermission.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.URI);
		}
#pragma warning restore 0169

		public virtual unsafe string URI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getURI' and count(parameter)=0]"
			[Register ("getURI", "()Ljava/lang/String;", "GetGetURIHandler")]
			get {
				const string __id = "getURI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static void n_Add_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource child = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (native_child, JniHandleOwnership.DoNotTransfer);
			__this.Add (child);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource']]"
		[Register ("add", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)V", "GetAdd_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler")]
		public virtual unsafe void Add (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource child)
		{
			const string __id = "add.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_add_arrayLcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
#pragma warning disable 0169
		static Delegate GetAdd_arrayLcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler ()
		{
			if (cb_add_arrayLcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ == null)
				cb_add_arrayLcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_arrayLcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_);
			return cb_add_arrayLcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
		}

		static IntPtr n_Add_arrayLcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_children)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource[] children = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource[]) JNIEnv.GetArray (native_children, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (children));
			if (children != null)
				JNIEnv.CopyArray (children, native_children);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource...']]"
		[Register ("add", "([Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;", "GetAdd_arrayLcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource Add (params global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource[] children)
		{
			const string __id = "add.([Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;";
			IntPtr native_children = JNIEnv.NewArray (children);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_children);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (children != null) {
					JNIEnv.CopyArray (native_children, children);
					JNIEnv.DeleteLocalRef (native_children);
				}
			}
		}

		static Delegate cb_addChild_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
#pragma warning disable 0169
		static Delegate GetAddChild_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler ()
		{
			if (cb_addChild_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ == null)
				cb_addChild_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddChild_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_);
			return cb_addChild_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
		}

		static IntPtr n_AddChild_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource child = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (native_child, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddChild (child));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='addChild' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.AlcsCoAPResource']]"
		[Register ("addChild", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)Lcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;", "GetAddChild_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource AddChild (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource child)
		{
			const string __id = "addChild.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)Lcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler ()
		{
			if (cb_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ == null)
				cb_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_);
			return cb_delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_;
		}

		static bool n_Delete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource child = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (native_child, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Delete (child);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource']]"
		[Register ("delete", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)Z", "GetDelete_Lcom_aliyun_alink_linksdk_alcs_coap_resources_Resource_Handler")]
		public virtual unsafe bool Delete (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource child)
		{
			const string __id = "delete.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_delete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_ == null)
				cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Delete_Ljava_lang_String_);
			return cb_delete_Ljava_lang_String_;
		}

		static IntPtr n_Delete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Delete (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;", "GetDelete_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource Delete (string name)
		{
			const string __id = "delete.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_execute_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_Runnable_Handler ()
		{
			if (cb_execute_Ljava_lang_Runnable_ == null)
				cb_execute_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Execute_Ljava_lang_Runnable_);
			return cb_execute_Ljava_lang_Runnable_;
		}

		static void n_Execute_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable task = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_task, JniHandleOwnership.DoNotTransfer);
			__this.Execute (task);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("execute", "(Ljava/lang/Runnable;)V", "GetExecute_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void Execute (global::Java.Lang.IRunnable task)
		{
			const string __id = "execute.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object) task).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_executeAndWait_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetExecuteAndWait_Ljava_lang_Runnable_Handler ()
		{
			if (cb_executeAndWait_Ljava_lang_Runnable_ == null)
				cb_executeAndWait_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ExecuteAndWait_Ljava_lang_Runnable_);
			return cb_executeAndWait_Ljava_lang_Runnable_;
		}

		static void n_ExecuteAndWait_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable task = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_task, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteAndWait (task);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='executeAndWait' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("executeAndWait", "(Ljava/lang/Runnable;)V", "GetExecuteAndWait_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void ExecuteAndWait (global::Java.Lang.IRunnable task)
		{
			const string __id = "executeAndWait.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object) task).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getChild_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetChild_Ljava_lang_String_Handler ()
		{
			if (cb_getChild_Ljava_lang_String_ == null)
				cb_getChild_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChild_Ljava_lang_String_);
			return cb_getChild_Ljava_lang_String_;
		}

		static IntPtr n_GetChild_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChild (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getChild' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getChild", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;", "GetGetChild_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource GetChild (string name)
		{
			const string __id = "getChild.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getcType;
#pragma warning disable 0169
		static Delegate GetGetcTypeHandler ()
		{
			if (cb_getcType == null)
				cb_getcType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetcType);
			return cb_getcType;
		}

		static int n_GetcType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetcType ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='getcType' and count(parameter)=0]"
		[Register ("getcType", "()I", "GetGetcTypeHandler")]
		public virtual unsafe int GetcType ()
		{
			const string __id = "getcType.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setObservable_Z;
#pragma warning disable 0169
		static Delegate GetSetObservable_ZHandler ()
		{
			if (cb_setObservable_Z == null)
				cb_setObservable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetObservable_Z);
			return cb_setObservable_Z;
		}

		static void n_SetObservable_Z (IntPtr jnienv, IntPtr native__this, bool observable)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetObservable (observable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setObservable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setObservable", "(Z)V", "GetSetObservable_ZHandler")]
		public virtual unsafe void SetObservable (bool observable)
		{
			const string __id = "setObservable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (observable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setObserveType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_;
#pragma warning disable 0169
		static Delegate GetSetObserveType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_Handler ()
		{
			if (cb_setObserveType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_ == null)
				cb_setObserveType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObserveType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_);
			return cb_setObserveType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_;
		}

		static void n_SetObserveType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type type = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.SetObserveType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setObserveType' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.Type']]"
		[Register ("setObserveType", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;)V", "GetSetObserveType_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPConstant_Type_Handler")]
		public virtual unsafe void SetObserveType (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type type)
		{
			const string __id = "setObserveType.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool visible)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVisible (visible);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
		public virtual unsafe void SetVisible (bool visible)
		{
			const string __id = "setVisible.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (visible);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setcType_I;
#pragma warning disable 0169
		static Delegate GetSetcType_IHandler ()
		{
			if (cb_setcType_I == null)
				cb_setcType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetcType_I);
			return cb_setcType_I;
		}

		static void n_SetcType_I (IntPtr jnienv, IntPtr native__this, int cType)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetcType (cType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='AlcsCoAPResource']/method[@name='setcType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setcType", "(I)V", "GetSetcType_IHandler")]
		public virtual unsafe void SetcType (int cType)
		{
			const string __id = "setcType.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cType);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
