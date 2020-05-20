using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/resources/ResourceAttributes", DoNotGenerateAcw=true)]
	public partial class ResourceAttributes : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/resources/ResourceAttributes", typeof (ResourceAttributes));
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

		protected ResourceAttributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/constructor[@name='ResourceAttributes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResourceAttributes ()
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

		static Delegate cb_getAttributeKeySet;
#pragma warning disable 0169
		static Delegate GetGetAttributeKeySetHandler ()
		{
			if (cb_getAttributeKeySet == null)
				cb_getAttributeKeySet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributeKeySet);
			return cb_getAttributeKeySet;
		}

		static IntPtr n_GetAttributeKeySet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AttributeKeySet);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<string> AttributeKeySet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='getAttributeKeySet' and count(parameter)=0]"
			[Register ("getAttributeKeySet", "()Ljava/util/Set;", "GetGetAttributeKeySetHandler")]
			get {
				const string __id = "getAttributeKeySet.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentTypes;
#pragma warning disable 0169
		static Delegate GetGetContentTypesHandler ()
		{
			if (cb_getContentTypes == null)
				cb_getContentTypes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentTypes);
			return cb_getContentTypes;
		}

		static IntPtr n_GetContentTypes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ContentTypes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ContentTypes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='getContentTypes' and count(parameter)=0]"
			[Register ("getContentTypes", "()Ljava/util/List;", "GetGetContentTypesHandler")]
			get {
				const string __id = "getContentTypes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasObservable;
#pragma warning disable 0169
		static Delegate GetHasObservableHandler ()
		{
			if (cb_hasObservable == null)
				cb_hasObservable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasObservable);
			return cb_hasObservable;
		}

		static bool n_HasObservable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasObservable;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasObservable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='hasObservable' and count(parameter)=0]"
			[Register ("hasObservable", "()Z", "GetHasObservableHandler")]
			get {
				const string __id = "hasObservable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getInterfaceDescriptions;
#pragma warning disable 0169
		static Delegate GetGetInterfaceDescriptionsHandler ()
		{
			if (cb_getInterfaceDescriptions == null)
				cb_getInterfaceDescriptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterfaceDescriptions);
			return cb_getInterfaceDescriptions;
		}

		static IntPtr n_GetInterfaceDescriptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.InterfaceDescriptions);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> InterfaceDescriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='getInterfaceDescriptions' and count(parameter)=0]"
			[Register ("getInterfaceDescriptions", "()Ljava/util/List;", "GetGetInterfaceDescriptionsHandler")]
			get {
				const string __id = "getInterfaceDescriptions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumSizeEstimate;
#pragma warning disable 0169
		static Delegate GetGetMaximumSizeEstimateHandler ()
		{
			if (cb_getMaximumSizeEstimate == null)
				cb_getMaximumSizeEstimate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaximumSizeEstimate);
			return cb_getMaximumSizeEstimate;
		}

		static IntPtr n_GetMaximumSizeEstimate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MaximumSizeEstimate);
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumSizeEstimate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMaximumSizeEstimate_Ljava_lang_String_Handler ()
		{
			if (cb_setMaximumSizeEstimate_Ljava_lang_String_ == null)
				cb_setMaximumSizeEstimate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaximumSizeEstimate_Ljava_lang_String_);
			return cb_setMaximumSizeEstimate_Ljava_lang_String_;
		}

		static void n_SetMaximumSizeEstimate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_size)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string size = JNIEnv.GetString (native_size, JniHandleOwnership.DoNotTransfer);
			__this.MaximumSizeEstimate = size;
		}
#pragma warning restore 0169

		public virtual unsafe string MaximumSizeEstimate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='getMaximumSizeEstimate' and count(parameter)=0]"
			[Register ("getMaximumSizeEstimate", "()Ljava/lang/String;", "GetGetMaximumSizeEstimateHandler")]
			get {
				const string __id = "getMaximumSizeEstimate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='setMaximumSizeEstimate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMaximumSizeEstimate", "(Ljava/lang/String;)V", "GetSetMaximumSizeEstimate_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMaximumSizeEstimate.(Ljava/lang/String;)V";
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

		static Delegate cb_getResourceTypes;
#pragma warning disable 0169
		static Delegate GetGetResourceTypesHandler ()
		{
			if (cb_getResourceTypes == null)
				cb_getResourceTypes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceTypes);
			return cb_getResourceTypes;
		}

		static IntPtr n_GetResourceTypes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ResourceTypes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ResourceTypes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='getResourceTypes' and count(parameter)=0]"
			[Register ("getResourceTypes", "()Ljava/util/List;", "GetGetResourceTypesHandler")]
			get {
				const string __id = "getResourceTypes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			__this.Title = title;
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTitle.(Ljava/lang/String;)V";
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

		static Delegate cb_addAttribute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAttribute_Ljava_lang_String_Handler ()
		{
			if (cb_addAttribute_Ljava_lang_String_ == null)
				cb_addAttribute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddAttribute_Ljava_lang_String_);
			return cb_addAttribute_Ljava_lang_String_;
		}

		static void n_AddAttribute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attr)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string attr = JNIEnv.GetString (native_attr, JniHandleOwnership.DoNotTransfer);
			__this.AddAttribute (attr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='addAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addAttribute", "(Ljava/lang/String;)V", "GetAddAttribute_Ljava_lang_String_Handler")]
		public virtual unsafe void AddAttribute (string attr)
		{
			const string __id = "addAttribute.(Ljava/lang/String;)V";
			IntPtr native_attr = JNIEnv.NewString (attr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attr);
			}
		}

		static Delegate cb_addAttribute_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAttribute_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addAttribute_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addAttribute_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAttribute_Ljava_lang_String_Ljava_lang_String_);
			return cb_addAttribute_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddAttribute_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attr, IntPtr native_value)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string attr = JNIEnv.GetString (native_attr, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AddAttribute (attr, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddAttribute_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddAttribute (string attr, string value)
		{
			const string __id = "addAttribute.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_attr = JNIEnv.NewString (attr);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_attr);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attr);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_addContentType_I;
#pragma warning disable 0169
		static Delegate GetAddContentType_IHandler ()
		{
			if (cb_addContentType_I == null)
				cb_addContentType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AddContentType_I);
			return cb_addContentType_I;
		}

		static void n_AddContentType_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddContentType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='addContentType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addContentType", "(I)V", "GetAddContentType_IHandler")]
		public virtual unsafe void AddContentType (int type)
		{
			const string __id = "addContentType.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addInterfaceDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddInterfaceDescription_Ljava_lang_String_Handler ()
		{
			if (cb_addInterfaceDescription_Ljava_lang_String_ == null)
				cb_addInterfaceDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddInterfaceDescription_Ljava_lang_String_);
			return cb_addInterfaceDescription_Ljava_lang_String_;
		}

		static void n_AddInterfaceDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string description = JNIEnv.GetString (native_description, JniHandleOwnership.DoNotTransfer);
			__this.AddInterfaceDescription (description);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='addInterfaceDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addInterfaceDescription", "(Ljava/lang/String;)V", "GetAddInterfaceDescription_Ljava_lang_String_Handler")]
		public virtual unsafe void AddInterfaceDescription (string description)
		{
			const string __id = "addInterfaceDescription.(Ljava/lang/String;)V";
			IntPtr native_description = JNIEnv.NewString (description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_description);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_description);
			}
		}

		static Delegate cb_addResourceType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddResourceType_Ljava_lang_String_Handler ()
		{
			if (cb_addResourceType_Ljava_lang_String_ == null)
				cb_addResourceType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddResourceType_Ljava_lang_String_);
			return cb_addResourceType_Ljava_lang_String_;
		}

		static void n_AddResourceType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
			__this.AddResourceType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='addResourceType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addResourceType", "(Ljava/lang/String;)V", "GetAddResourceType_Ljava_lang_String_Handler")]
		public virtual unsafe void AddResourceType (string type)
		{
			const string __id = "addResourceType.(Ljava/lang/String;)V";
			IntPtr native_type = JNIEnv.NewString (type);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
			}
		}

		static Delegate cb_clearAttribute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearAttribute_Ljava_lang_String_Handler ()
		{
			if (cb_clearAttribute_Ljava_lang_String_ == null)
				cb_clearAttribute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClearAttribute_Ljava_lang_String_);
			return cb_clearAttribute_Ljava_lang_String_;
		}

		static void n_ClearAttribute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attr)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string attr = JNIEnv.GetString (native_attr, JniHandleOwnership.DoNotTransfer);
			__this.ClearAttribute (attr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='clearAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearAttribute", "(Ljava/lang/String;)V", "GetClearAttribute_Ljava_lang_String_Handler")]
		public virtual unsafe void ClearAttribute (string attr)
		{
			const string __id = "clearAttribute.(Ljava/lang/String;)V";
			IntPtr native_attr = JNIEnv.NewString (attr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attr);
			}
		}

		static Delegate cb_clearContentType;
#pragma warning disable 0169
		static Delegate GetClearContentTypeHandler ()
		{
			if (cb_clearContentType == null)
				cb_clearContentType = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearContentType);
			return cb_clearContentType;
		}

		static void n_ClearContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearContentType ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='clearContentType' and count(parameter)=0]"
		[Register ("clearContentType", "()V", "GetClearContentTypeHandler")]
		public virtual unsafe void ClearContentType ()
		{
			const string __id = "clearContentType.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearResourceType;
#pragma warning disable 0169
		static Delegate GetClearResourceTypeHandler ()
		{
			if (cb_clearResourceType == null)
				cb_clearResourceType = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearResourceType);
			return cb_clearResourceType;
		}

		static void n_ClearResourceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearResourceType ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='clearResourceType' and count(parameter)=0]"
		[Register ("clearResourceType", "()V", "GetClearResourceTypeHandler")]
		public virtual unsafe void ClearResourceType ()
		{
			const string __id = "clearResourceType.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_containsAttribute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsAttribute_Ljava_lang_String_Handler ()
		{
			if (cb_containsAttribute_Ljava_lang_String_ == null)
				cb_containsAttribute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsAttribute_Ljava_lang_String_);
			return cb_containsAttribute_Ljava_lang_String_;
		}

		static bool n_ContainsAttribute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attr)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string attr = JNIEnv.GetString (native_attr, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsAttribute (attr);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='containsAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsAttribute", "(Ljava/lang/String;)Z", "GetContainsAttribute_Ljava_lang_String_Handler")]
		public virtual unsafe bool ContainsAttribute (string attr)
		{
			const string __id = "containsAttribute.(Ljava/lang/String;)Z";
			IntPtr native_attr = JNIEnv.NewString (attr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attr);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_attr);
			}
		}

		static Delegate cb_getAttributeValues_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAttributeValues_Ljava_lang_String_Handler ()
		{
			if (cb_getAttributeValues_Ljava_lang_String_ == null)
				cb_getAttributeValues_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAttributeValues_Ljava_lang_String_);
			return cb_getAttributeValues_Ljava_lang_String_;
		}

		static IntPtr n_GetAttributeValues_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attr)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string attr = JNIEnv.GetString (native_attr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GetAttributeValues (attr));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='getAttributeValues' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttributeValues", "(Ljava/lang/String;)Ljava/util/List;", "GetGetAttributeValues_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> GetAttributeValues (string attr)
		{
			const string __id = "getAttributeValues.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_attr = JNIEnv.NewString (attr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attr);
			}
		}

		static Delegate cb_setAttribute_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAttribute_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAttribute_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAttribute_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAttribute_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAttribute_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetAttribute_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attr, IntPtr native_value)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string attr = JNIEnv.GetString (native_attr, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetAttribute (attr, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='setAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetAttribute_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAttribute (string attr, string value)
		{
			const string __id = "setAttribute.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_attr = JNIEnv.NewString (attr);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_attr);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attr);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setMaximumSizeEstimate_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumSizeEstimate_IHandler ()
		{
			if (cb_setMaximumSizeEstimate_I == null)
				cb_setMaximumSizeEstimate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaximumSizeEstimate_I);
			return cb_setMaximumSizeEstimate_I;
		}

		static void n_SetMaximumSizeEstimate_I (IntPtr jnienv, IntPtr native__this, int size)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaximumSizeEstimate (size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='setMaximumSizeEstimate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaximumSizeEstimate", "(I)V", "GetSetMaximumSizeEstimate_IHandler")]
		public virtual unsafe void SetMaximumSizeEstimate (int size)
		{
			const string __id = "setMaximumSizeEstimate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setObservable;
#pragma warning disable 0169
		static Delegate GetSetObservableHandler ()
		{
			if (cb_setObservable == null)
				cb_setObservable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetObservable);
			return cb_setObservable;
		}

		static void n_SetObservable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetObservable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='ResourceAttributes']/method[@name='setObservable' and count(parameter)=0]"
		[Register ("setObservable", "()V", "GetSetObservableHandler")]
		public virtual unsafe void SetObservable ()
		{
			const string __id = "setObservable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
