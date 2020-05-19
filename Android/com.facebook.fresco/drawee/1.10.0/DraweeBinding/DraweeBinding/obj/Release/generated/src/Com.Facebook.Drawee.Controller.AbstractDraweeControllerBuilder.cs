using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']"
	[global::Android.Runtime.Register ("com/facebook/drawee/controller/AbstractDraweeControllerBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"BUILDER extends com.facebook.drawee.controller.AbstractDraweeControllerBuilder<BUILDER, REQUEST, IMAGE, INFO>", "REQUEST", "IMAGE", "INFO"})]
	public abstract partial class AbstractDraweeControllerBuilder : global::Java.Lang.Object, global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder.CacheLevel']"
		[global::Android.Runtime.Register ("com/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel", DoNotGenerateAcw=true)]
		public sealed partial class CacheLevel : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder.CacheLevel']/field[@name='BITMAP_MEMORY_CACHE']"
			[Register ("BITMAP_MEMORY_CACHE")]
			public static global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel BitmapMemoryCache {
				get {
					const string __id = "BITMAP_MEMORY_CACHE.Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder.CacheLevel']/field[@name='DISK_CACHE']"
			[Register ("DISK_CACHE")]
			public static global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel DiskCache {
				get {
					const string __id = "DISK_CACHE.Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder.CacheLevel']/field[@name='FULL_FETCH']"
			[Register ("FULL_FETCH")]
			public static global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel FullFetch {
				get {
					const string __id = "FULL_FETCH.Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel", typeof (CacheLevel));
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

			internal CacheLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder.CacheLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;", "")]
			public static unsafe global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder.CacheLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;", "")]
			public static unsafe global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel[] Values ()
			{
				const string __id = "values.()[Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/controller/AbstractDraweeControllerBuilder", typeof (AbstractDraweeControllerBuilder));
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

		protected AbstractDraweeControllerBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/constructor[@name='AbstractDraweeControllerBuilder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Set&lt;com.facebook.drawee.controller.ControllerListener&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/Set;)V", "")]
		protected unsafe AbstractDraweeControllerBuilder (global::Android.Content.Context context, global::System.Collections.Generic.ICollection<global::Com.Facebook.Drawee.Controller.IControllerListener> boundControllerListeners)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/util/Set;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_boundControllerListeners = global::Android.Runtime.JavaSet<global::Com.Facebook.Drawee.Controller.IControllerListener>.ToLocalJniHandle (boundControllerListeners);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_boundControllerListeners);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_boundControllerListeners);
			}
		}

		static Delegate cb_getAutoPlayAnimations;
#pragma warning disable 0169
		static Delegate GetGetAutoPlayAnimationsHandler ()
		{
			if (cb_getAutoPlayAnimations == null)
				cb_getAutoPlayAnimations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutoPlayAnimations);
			return cb_getAutoPlayAnimations;
		}

		static bool n_GetAutoPlayAnimations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoPlayAnimations;
		}
#pragma warning restore 0169

		public virtual unsafe bool AutoPlayAnimations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getAutoPlayAnimations' and count(parameter)=0]"
			[Register ("getAutoPlayAnimations", "()Z", "GetGetAutoPlayAnimationsHandler")]
			get {
				const string __id = "getAutoPlayAnimations.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCallerContext;
#pragma warning disable 0169
		static Delegate GetGetCallerContextHandler ()
		{
			if (cb_getCallerContext == null)
				cb_getCallerContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallerContext);
			return cb_getCallerContext;
		}

		static IntPtr n_GetCallerContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CallerContext);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object CallerContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getCallerContext' and count(parameter)=0]"
			[Register ("getCallerContext", "()Ljava/lang/Object;", "GetGetCallerContextHandler")]
			get {
				const string __id = "getCallerContext.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentDescription;
#pragma warning disable 0169
		static Delegate GetGetContentDescriptionHandler ()
		{
			if (cb_getContentDescription == null)
				cb_getContentDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentDescription);
			return cb_getContentDescription;
		}

		static IntPtr n_GetContentDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentDescription);
		}
#pragma warning restore 0169

		public virtual unsafe string ContentDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getContentDescription' and count(parameter)=0]"
			[Register ("getContentDescription", "()Ljava/lang/String;", "GetGetContentDescriptionHandler")]
			get {
				const string __id = "getContentDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getControllerListener;
#pragma warning disable 0169
		static Delegate GetGetControllerListenerHandler ()
		{
			if (cb_getControllerListener == null)
				cb_getControllerListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetControllerListener);
			return cb_getControllerListener;
		}

		static IntPtr n_GetControllerListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ControllerListener);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Controller.IControllerListener ControllerListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getControllerListener' and count(parameter)=0]"
			[Register ("getControllerListener", "()Lcom/facebook/drawee/controller/ControllerListener;", "GetGetControllerListenerHandler")]
			get {
				const string __id = "getControllerListener.()Lcom/facebook/drawee/controller/ControllerListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getControllerViewportVisibilityListener;
#pragma warning disable 0169
		static Delegate GetGetControllerViewportVisibilityListenerHandler ()
		{
			if (cb_getControllerViewportVisibilityListener == null)
				cb_getControllerViewportVisibilityListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetControllerViewportVisibilityListener);
			return cb_getControllerViewportVisibilityListener;
		}

		static IntPtr n_GetControllerViewportVisibilityListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ControllerViewportVisibilityListener);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener ControllerViewportVisibilityListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getControllerViewportVisibilityListener' and count(parameter)=0]"
			[Register ("getControllerViewportVisibilityListener", "()Lcom/facebook/drawee/controller/ControllerViewportVisibilityListener;", "GetGetControllerViewportVisibilityListenerHandler")]
			get {
				const string __id = "getControllerViewportVisibilityListener.()Lcom/facebook/drawee/controller/ControllerViewportVisibilityListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDataSourceSupplier;
#pragma warning disable 0169
		static Delegate GetGetDataSourceSupplierHandler ()
		{
			if (cb_getDataSourceSupplier == null)
				cb_getDataSourceSupplier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataSourceSupplier);
			return cb_getDataSourceSupplier;
		}

		static IntPtr n_GetDataSourceSupplier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSourceSupplier);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Common.Internal.ISupplier DataSourceSupplier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getDataSourceSupplier' and count(parameter)=0]"
			[Register ("getDataSourceSupplier", "()Lcom/facebook/common/internal/Supplier;", "GetGetDataSourceSupplierHandler")]
			get {
				const string __id = "getDataSourceSupplier.()Lcom/facebook/common/internal/Supplier;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageRequest;
#pragma warning disable 0169
		static Delegate GetGetImageRequestHandler ()
		{
			if (cb_getImageRequest == null)
				cb_getImageRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageRequest);
			return cb_getImageRequest;
		}

		static IntPtr n_GetImageRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageRequest);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object ImageRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getImageRequest' and count(parameter)=0]"
			[Register ("getImageRequest", "()Ljava/lang/Object;", "GetGetImageRequestHandler")]
			get {
				const string __id = "getImageRequest.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLowResImageRequest;
#pragma warning disable 0169
		static Delegate GetGetLowResImageRequestHandler ()
		{
			if (cb_getLowResImageRequest == null)
				cb_getLowResImageRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLowResImageRequest);
			return cb_getLowResImageRequest;
		}

		static IntPtr n_GetLowResImageRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LowResImageRequest);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object LowResImageRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getLowResImageRequest' and count(parameter)=0]"
			[Register ("getLowResImageRequest", "()Ljava/lang/Object;", "GetGetLowResImageRequestHandler")]
			get {
				const string __id = "getLowResImageRequest.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOldController;
#pragma warning disable 0169
		static Delegate GetGetOldControllerHandler ()
		{
			if (cb_getOldController == null)
				cb_getOldController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOldController);
			return cb_getOldController;
		}

		static IntPtr n_GetOldController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OldController);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Interfaces.IDraweeController OldController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getOldController' and count(parameter)=0]"
			[Register ("getOldController", "()Lcom/facebook/drawee/interfaces/DraweeController;", "GetGetOldControllerHandler")]
			get {
				const string __id = "getOldController.()Lcom/facebook/drawee/interfaces/DraweeController;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRetainImageOnFailure;
#pragma warning disable 0169
		static Delegate GetGetRetainImageOnFailureHandler ()
		{
			if (cb_getRetainImageOnFailure == null)
				cb_getRetainImageOnFailure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetRetainImageOnFailure);
			return cb_getRetainImageOnFailure;
		}

		static bool n_GetRetainImageOnFailure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetainImageOnFailure;
		}
#pragma warning restore 0169

		public virtual unsafe bool RetainImageOnFailure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getRetainImageOnFailure' and count(parameter)=0]"
			[Register ("getRetainImageOnFailure", "()Z", "GetGetRetainImageOnFailureHandler")]
			get {
				const string __id = "getRetainImageOnFailure.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTapToRetryEnabled;
#pragma warning disable 0169
		static Delegate GetGetTapToRetryEnabledHandler ()
		{
			if (cb_getTapToRetryEnabled == null)
				cb_getTapToRetryEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTapToRetryEnabled);
			return cb_getTapToRetryEnabled;
		}

		static bool n_GetTapToRetryEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TapToRetryEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool TapToRetryEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getTapToRetryEnabled' and count(parameter)=0]"
			[Register ("getTapToRetryEnabled", "()Z", "GetGetTapToRetryEnabledHandler")]
			get {
				const string __id = "getTapToRetryEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected unsafe global::Java.Lang.Object This {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getThis' and count(parameter)=0]"
			[Register ("getThis", "()Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "")]
			get {
				const string __id = "getThis.()Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_RawBuild;
#pragma warning disable 0169
		static Delegate GetRawBuildHandler ()
		{
			if (cb_RawBuild == null)
				cb_RawBuild = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RawBuild);
			return cb_RawBuild;
		}

		static IntPtr n_RawBuild (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawBuild ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='RawBuild' and count(parameter)=0]"
		[Register ("RawBuild", "()Lcom/facebook/drawee/controller/AbstractDraweeController;", "GetRawBuildHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Controller.AbstractDraweeController RawBuild ()
		{
			const string __id = "RawBuild.()Lcom/facebook/drawee/controller/AbstractDraweeController;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_buildController;
#pragma warning disable 0169
		static Delegate GetBuildControllerHandler ()
		{
			if (cb_buildController == null)
				cb_buildController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildController);
			return cb_buildController;
		}

		static IntPtr n_BuildController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildController ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='buildController' and count(parameter)=0]"
		[Register ("buildController", "()Lcom/facebook/drawee/controller/AbstractDraweeController;", "GetBuildControllerHandler")]
		protected virtual unsafe global::Com.Facebook.Drawee.Controller.AbstractDraweeController BuildController ()
		{
			const string __id = "buildController.()Lcom/facebook/drawee/controller/AbstractDraweeController;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='generateUniqueControllerId' and count(parameter)=0]"
		[Register ("generateUniqueControllerId", "()Ljava/lang/String;", "")]
		protected static unsafe string GenerateUniqueControllerId ()
		{
			const string __id = "generateUniqueControllerId.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDataSourceForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_;
#pragma warning disable 0169
		static Delegate GetGetDataSourceForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_Handler ()
		{
			if (cb_getDataSourceForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_ == null)
				cb_getDataSourceForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDataSourceForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_);
			return cb_getDataSourceForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_;
		}

		static IntPtr n_GetDataSourceForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController p0 = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel p4 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDataSourceForRequest (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getDataSourceForRequest' and count(parameter)=5 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='REQUEST'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='com.facebook.drawee.controller.AbstractDraweeControllerBuilder.CacheLevel']]"
		[Register ("getDataSourceForRequest", "(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;)Lcom/facebook/datasource/DataSource;", "GetGetDataSourceForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_Handler")]
		protected abstract global::Com.Facebook.Datasource.IDataSource GetDataSourceForRequest (global::Com.Facebook.Drawee.Interfaces.IDraweeController p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel p4);

		static Delegate cb_getDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controller, IntPtr native_controllerId, IntPtr native_imageRequest)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController controller = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_controller, JniHandleOwnership.DoNotTransfer);
			string controllerId = JNIEnv.GetString (native_controllerId, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object imageRequest = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_imageRequest, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDataSourceSupplierForRequest (controller, controllerId, imageRequest));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getDataSourceSupplierForRequest' and count(parameter)=3 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='REQUEST']]"
		[Register ("getDataSourceSupplierForRequest", "(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;Ljava/lang/Object;)Lcom/facebook/common/internal/Supplier;", "GetGetDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe global::Com.Facebook.Common.Internal.ISupplier GetDataSourceSupplierForRequest (global::Com.Facebook.Drawee.Interfaces.IDraweeController controller, string controllerId, global::Java.Lang.Object imageRequest)
		{
			const string __id = "getDataSourceSupplierForRequest.(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;Ljava/lang/Object;)Lcom/facebook/common/internal/Supplier;";
			IntPtr native_controllerId = JNIEnv.NewString (controllerId);
			IntPtr native_imageRequest = JNIEnv.ToLocalJniHandle (imageRequest);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((controller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controller).Handle);
				__args [1] = new JniArgumentValue (native_controllerId);
				__args [2] = new JniArgumentValue (native_imageRequest);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_controllerId);
				JNIEnv.DeleteLocalRef (native_imageRequest);
			}
		}

		static Delegate cb_getDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_;
#pragma warning disable 0169
		static Delegate GetGetDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_Handler ()
		{
			if (cb_getDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_ == null)
				cb_getDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_);
			return cb_getDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_;
		}

		static IntPtr n_GetDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controller, IntPtr native_controllerId, IntPtr native_imageRequest, IntPtr native_cacheLevel)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController controller = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_controller, JniHandleOwnership.DoNotTransfer);
			string controllerId = JNIEnv.GetString (native_controllerId, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object imageRequest = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_imageRequest, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel cacheLevel = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel> (native_cacheLevel, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDataSourceSupplierForRequest (controller, controllerId, imageRequest, cacheLevel));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getDataSourceSupplierForRequest' and count(parameter)=4 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='REQUEST'] and parameter[4][@type='com.facebook.drawee.controller.AbstractDraweeControllerBuilder.CacheLevel']]"
		[Register ("getDataSourceSupplierForRequest", "(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;Ljava/lang/Object;Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;)Lcom/facebook/common/internal/Supplier;", "GetGetDataSourceSupplierForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_Handler")]
		protected virtual unsafe global::Com.Facebook.Common.Internal.ISupplier GetDataSourceSupplierForRequest (global::Com.Facebook.Drawee.Interfaces.IDraweeController controller, string controllerId, global::Java.Lang.Object imageRequest, global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel cacheLevel)
		{
			const string __id = "getDataSourceSupplierForRequest.(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;Ljava/lang/Object;Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;)Lcom/facebook/common/internal/Supplier;";
			IntPtr native_controllerId = JNIEnv.NewString (controllerId);
			IntPtr native_imageRequest = JNIEnv.ToLocalJniHandle (imageRequest);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((controller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controller).Handle);
				__args [1] = new JniArgumentValue (native_controllerId);
				__args [2] = new JniArgumentValue (native_imageRequest);
				__args [3] = new JniArgumentValue ((cacheLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheLevel).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_controllerId);
				JNIEnv.DeleteLocalRef (native_imageRequest);
			}
		}

		static Delegate cb_getFirstAvailableDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_arrayLjava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetGetFirstAvailableDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_arrayLjava_lang_Object_ZHandler ()
		{
			if (cb_getFirstAvailableDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_arrayLjava_lang_Object_Z == null)
				cb_getFirstAvailableDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_arrayLjava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetFirstAvailableDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_arrayLjava_lang_Object_Z);
			return cb_getFirstAvailableDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_arrayLjava_lang_Object_Z;
		}

		static IntPtr n_GetFirstAvailableDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_arrayLjava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_controller, IntPtr native_controllerId, IntPtr native_imageRequests, bool tryBitmapCacheOnlyFirst)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController controller = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_controller, JniHandleOwnership.DoNotTransfer);
			string controllerId = JNIEnv.GetString (native_controllerId, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] imageRequests = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_imageRequests, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFirstAvailableDataSourceSupplier (controller, controllerId, imageRequests, tryBitmapCacheOnlyFirst));
			if (imageRequests != null)
				JNIEnv.CopyArray (imageRequests, native_imageRequests);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getFirstAvailableDataSourceSupplier' and count(parameter)=4 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='REQUEST[]'] and parameter[4][@type='boolean']]"
		[Register ("getFirstAvailableDataSourceSupplier", "(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;[Ljava/lang/Object;Z)Lcom/facebook/common/internal/Supplier;", "GetGetFirstAvailableDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_arrayLjava_lang_Object_ZHandler")]
		protected virtual unsafe global::Com.Facebook.Common.Internal.ISupplier GetFirstAvailableDataSourceSupplier (global::Com.Facebook.Drawee.Interfaces.IDraweeController controller, string controllerId, global::Java.Lang.Object[] imageRequests, bool tryBitmapCacheOnlyFirst)
		{
			const string __id = "getFirstAvailableDataSourceSupplier.(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;[Ljava/lang/Object;Z)Lcom/facebook/common/internal/Supplier;";
			IntPtr native_controllerId = JNIEnv.NewString (controllerId);
			IntPtr native_imageRequests = JNIEnv.NewArray (imageRequests);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((controller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controller).Handle);
				__args [1] = new JniArgumentValue (native_controllerId);
				__args [2] = new JniArgumentValue (native_imageRequests);
				__args [3] = new JniArgumentValue (tryBitmapCacheOnlyFirst);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_controllerId);
				if (imageRequests != null) {
					JNIEnv.CopyArray (native_imageRequests, imageRequests);
					JNIEnv.DeleteLocalRef (native_imageRequests);
				}
			}
		}

		static Delegate cb_getFirstAvailableImageRequests;
#pragma warning disable 0169
		static Delegate GetGetFirstAvailableImageRequestsHandler ()
		{
			if (cb_getFirstAvailableImageRequests == null)
				cb_getFirstAvailableImageRequests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstAvailableImageRequests);
			return cb_getFirstAvailableImageRequests;
		}

		static IntPtr n_GetFirstAvailableImageRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFirstAvailableImageRequests ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getFirstAvailableImageRequests' and count(parameter)=0]"
		[Register ("getFirstAvailableImageRequests", "()[Ljava/lang/Object;", "GetGetFirstAvailableImageRequestsHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetFirstAvailableImageRequests ()
		{
			const string __id = "getFirstAvailableImageRequests.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_maybeAttachListeners_Lcom_facebook_drawee_controller_AbstractDraweeController_;
#pragma warning disable 0169
		static Delegate GetMaybeAttachListeners_Lcom_facebook_drawee_controller_AbstractDraweeController_Handler ()
		{
			if (cb_maybeAttachListeners_Lcom_facebook_drawee_controller_AbstractDraweeController_ == null)
				cb_maybeAttachListeners_Lcom_facebook_drawee_controller_AbstractDraweeController_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MaybeAttachListeners_Lcom_facebook_drawee_controller_AbstractDraweeController_);
			return cb_maybeAttachListeners_Lcom_facebook_drawee_controller_AbstractDraweeController_;
		}

		static void n_MaybeAttachListeners_Lcom_facebook_drawee_controller_AbstractDraweeController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controller)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController controller = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (native_controller, JniHandleOwnership.DoNotTransfer);
			__this.MaybeAttachListeners (controller);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='maybeAttachListeners' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.controller.AbstractDraweeController']]"
		[Register ("maybeAttachListeners", "(Lcom/facebook/drawee/controller/AbstractDraweeController;)V", "GetMaybeAttachListeners_Lcom_facebook_drawee_controller_AbstractDraweeController_Handler")]
		protected virtual unsafe void MaybeAttachListeners (global::Com.Facebook.Drawee.Controller.AbstractDraweeController controller)
		{
			const string __id = "maybeAttachListeners.(Lcom/facebook/drawee/controller/AbstractDraweeController;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controller).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_maybeBuildAndSetGestureDetector_Lcom_facebook_drawee_controller_AbstractDraweeController_;
#pragma warning disable 0169
		static Delegate GetMaybeBuildAndSetGestureDetector_Lcom_facebook_drawee_controller_AbstractDraweeController_Handler ()
		{
			if (cb_maybeBuildAndSetGestureDetector_Lcom_facebook_drawee_controller_AbstractDraweeController_ == null)
				cb_maybeBuildAndSetGestureDetector_Lcom_facebook_drawee_controller_AbstractDraweeController_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MaybeBuildAndSetGestureDetector_Lcom_facebook_drawee_controller_AbstractDraweeController_);
			return cb_maybeBuildAndSetGestureDetector_Lcom_facebook_drawee_controller_AbstractDraweeController_;
		}

		static void n_MaybeBuildAndSetGestureDetector_Lcom_facebook_drawee_controller_AbstractDraweeController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controller)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController controller = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (native_controller, JniHandleOwnership.DoNotTransfer);
			__this.MaybeBuildAndSetGestureDetector (controller);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='maybeBuildAndSetGestureDetector' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.controller.AbstractDraweeController']]"
		[Register ("maybeBuildAndSetGestureDetector", "(Lcom/facebook/drawee/controller/AbstractDraweeController;)V", "GetMaybeBuildAndSetGestureDetector_Lcom_facebook_drawee_controller_AbstractDraweeController_Handler")]
		protected virtual unsafe void MaybeBuildAndSetGestureDetector (global::Com.Facebook.Drawee.Controller.AbstractDraweeController controller)
		{
			const string __id = "maybeBuildAndSetGestureDetector.(Lcom/facebook/drawee/controller/AbstractDraweeController;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controller).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_maybeBuildAndSetRetryManager_Lcom_facebook_drawee_controller_AbstractDraweeController_;
#pragma warning disable 0169
		static Delegate GetMaybeBuildAndSetRetryManager_Lcom_facebook_drawee_controller_AbstractDraweeController_Handler ()
		{
			if (cb_maybeBuildAndSetRetryManager_Lcom_facebook_drawee_controller_AbstractDraweeController_ == null)
				cb_maybeBuildAndSetRetryManager_Lcom_facebook_drawee_controller_AbstractDraweeController_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MaybeBuildAndSetRetryManager_Lcom_facebook_drawee_controller_AbstractDraweeController_);
			return cb_maybeBuildAndSetRetryManager_Lcom_facebook_drawee_controller_AbstractDraweeController_;
		}

		static void n_MaybeBuildAndSetRetryManager_Lcom_facebook_drawee_controller_AbstractDraweeController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controller)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController controller = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (native_controller, JniHandleOwnership.DoNotTransfer);
			__this.MaybeBuildAndSetRetryManager (controller);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='maybeBuildAndSetRetryManager' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.controller.AbstractDraweeController']]"
		[Register ("maybeBuildAndSetRetryManager", "(Lcom/facebook/drawee/controller/AbstractDraweeController;)V", "GetMaybeBuildAndSetRetryManager_Lcom_facebook_drawee_controller_AbstractDraweeController_Handler")]
		protected virtual unsafe void MaybeBuildAndSetRetryManager (global::Com.Facebook.Drawee.Controller.AbstractDraweeController controller)
		{
			const string __id = "maybeBuildAndSetRetryManager.(Lcom/facebook/drawee/controller/AbstractDraweeController;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controller).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_obtainController;
#pragma warning disable 0169
		static Delegate GetObtainControllerHandler ()
		{
			if (cb_obtainController == null)
				cb_obtainController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ObtainController);
			return cb_obtainController;
		}

		static IntPtr n_ObtainController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObtainController ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='obtainController' and count(parameter)=0]"
		[Register ("obtainController", "()Lcom/facebook/drawee/controller/AbstractDraweeController;", "GetObtainControllerHandler")]
		protected abstract global::Com.Facebook.Drawee.Controller.AbstractDraweeController ObtainController ();

		static Delegate cb_obtainDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtainDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Handler ()
		{
			if (cb_obtainDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_ == null)
				cb_obtainDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ObtainDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_);
			return cb_obtainDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_;
		}

		static IntPtr n_ObtainDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controller, IntPtr native_controllerId)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController controller = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_controller, JniHandleOwnership.DoNotTransfer);
			string controllerId = JNIEnv.GetString (native_controllerId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ObtainDataSourceSupplier (controller, controllerId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='obtainDataSourceSupplier' and count(parameter)=2 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController'] and parameter[2][@type='java.lang.String']]"
		[Register ("obtainDataSourceSupplier", "(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;)Lcom/facebook/common/internal/Supplier;", "GetObtainDataSourceSupplier_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Com.Facebook.Common.Internal.ISupplier ObtainDataSourceSupplier (global::Com.Facebook.Drawee.Interfaces.IDraweeController controller, string controllerId)
		{
			const string __id = "obtainDataSourceSupplier.(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;)Lcom/facebook/common/internal/Supplier;";
			IntPtr native_controllerId = JNIEnv.NewString (controllerId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((controller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controller).Handle);
				__args [1] = new JniArgumentValue (native_controllerId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_controllerId);
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static IntPtr n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reset ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetResetHandler")]
		public virtual unsafe global::Java.Lang.Object Reset ()
		{
			const string __id = "reset.()Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAutoPlayAnimations_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoPlayAnimations_ZHandler ()
		{
			if (cb_setAutoPlayAnimations_Z == null)
				cb_setAutoPlayAnimations_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetAutoPlayAnimations_Z);
			return cb_setAutoPlayAnimations_Z;
		}

		static IntPtr n_SetAutoPlayAnimations_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAutoPlayAnimations (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setAutoPlayAnimations' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutoPlayAnimations", "(Z)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetAutoPlayAnimations_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetAutoPlayAnimations (bool enabled)
		{
			const string __id = "setAutoPlayAnimations.(Z)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_RawSetCallerContext_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRawSetCallerContext_Ljava_lang_Object_Handler ()
		{
			if (cb_RawSetCallerContext_Ljava_lang_Object_ == null)
				cb_RawSetCallerContext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RawSetCallerContext_Ljava_lang_Object_);
			return cb_RawSetCallerContext_Ljava_lang_Object_;
		}

		static IntPtr n_RawSetCallerContext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callerContext)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object callerContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_callerContext, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RawSetCallerContext (callerContext));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='RawSetCallerContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("RawSetCallerContext", "(Ljava/lang/Object;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetRawSetCallerContext_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object RawSetCallerContext (global::Java.Lang.Object callerContext)
		{
			const string __id = "RawSetCallerContext.(Ljava/lang/Object;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callerContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callerContext).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setContentDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setContentDescription_Ljava_lang_String_ == null)
				cb_setContentDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentDescription_Ljava_lang_String_);
			return cb_setContentDescription_Ljava_lang_String_;
		}

		static IntPtr n_SetContentDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentDescription)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string contentDescription = JNIEnv.GetString (native_contentDescription, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentDescription (contentDescription));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setContentDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentDescription", "(Ljava/lang/String;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetContentDescription_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object SetContentDescription (string contentDescription)
		{
			const string __id = "setContentDescription.(Ljava/lang/String;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			IntPtr native_contentDescription = JNIEnv.NewString (contentDescription);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_contentDescription);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_contentDescription);
			}
		}

		static Delegate cb_setControllerListener_Lcom_facebook_drawee_controller_ControllerListener_;
#pragma warning disable 0169
		static Delegate GetSetControllerListener_Lcom_facebook_drawee_controller_ControllerListener_Handler ()
		{
			if (cb_setControllerListener_Lcom_facebook_drawee_controller_ControllerListener_ == null)
				cb_setControllerListener_Lcom_facebook_drawee_controller_ControllerListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetControllerListener_Lcom_facebook_drawee_controller_ControllerListener_);
			return cb_setControllerListener_Lcom_facebook_drawee_controller_ControllerListener_;
		}

		static IntPtr n_SetControllerListener_Lcom_facebook_drawee_controller_ControllerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controllerListener)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Controller.IControllerListener controllerListener = (global::Com.Facebook.Drawee.Controller.IControllerListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (native_controllerListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetControllerListener (controllerListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setControllerListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.controller.ControllerListener&lt;? super INFO&gt;']]"
		[Register ("setControllerListener", "(Lcom/facebook/drawee/controller/ControllerListener;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetControllerListener_Lcom_facebook_drawee_controller_ControllerListener_Handler")]
		public virtual unsafe global::Java.Lang.Object SetControllerListener (global::Com.Facebook.Drawee.Controller.IControllerListener controllerListener)
		{
			const string __id = "setControllerListener.(Lcom/facebook/drawee/controller/ControllerListener;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controllerListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controllerListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_;
#pragma warning disable 0169
		static Delegate GetSetControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_Handler ()
		{
			if (cb_setControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_ == null)
				cb_setControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_);
			return cb_setControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_;
		}

		static IntPtr n_SetControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controllerViewportVisibilityListener)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener controllerViewportVisibilityListener = (global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener> (native_controllerViewportVisibilityListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetControllerViewportVisibilityListener (controllerViewportVisibilityListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setControllerViewportVisibilityListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.controller.ControllerViewportVisibilityListener']]"
		[Register ("setControllerViewportVisibilityListener", "(Lcom/facebook/drawee/controller/ControllerViewportVisibilityListener;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_Handler")]
		public virtual unsafe global::Java.Lang.Object SetControllerViewportVisibilityListener (global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener controllerViewportVisibilityListener)
		{
			const string __id = "setControllerViewportVisibilityListener.(Lcom/facebook/drawee/controller/ControllerViewportVisibilityListener;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controllerViewportVisibilityListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controllerViewportVisibilityListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDataSourceSupplier_Lcom_facebook_common_internal_Supplier_;
#pragma warning disable 0169
		static Delegate GetSetDataSourceSupplier_Lcom_facebook_common_internal_Supplier_Handler ()
		{
			if (cb_setDataSourceSupplier_Lcom_facebook_common_internal_Supplier_ == null)
				cb_setDataSourceSupplier_Lcom_facebook_common_internal_Supplier_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDataSourceSupplier_Lcom_facebook_common_internal_Supplier_);
			return cb_setDataSourceSupplier_Lcom_facebook_common_internal_Supplier_;
		}

		static IntPtr n_SetDataSourceSupplier_Lcom_facebook_common_internal_Supplier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSourceSupplier)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Common.Internal.ISupplier dataSourceSupplier = (global::Com.Facebook.Common.Internal.ISupplier)global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (native_dataSourceSupplier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDataSourceSupplier (dataSourceSupplier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setDataSourceSupplier' and count(parameter)=1 and parameter[1][@type='com.facebook.common.internal.Supplier&lt;com.facebook.datasource.DataSource&lt;IMAGE&gt;&gt;']]"
		[Register ("setDataSourceSupplier", "(Lcom/facebook/common/internal/Supplier;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetDataSourceSupplier_Lcom_facebook_common_internal_Supplier_Handler")]
		public virtual unsafe global::Java.Lang.Object SetDataSourceSupplier (global::Com.Facebook.Common.Internal.ISupplier dataSourceSupplier)
		{
			const string __id = "setDataSourceSupplier.(Lcom/facebook/common/internal/Supplier;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSourceSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSourceSupplier).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFirstAvailableImageRequests_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetFirstAvailableImageRequests_arrayLjava_lang_Object_Handler ()
		{
			if (cb_setFirstAvailableImageRequests_arrayLjava_lang_Object_ == null)
				cb_setFirstAvailableImageRequests_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFirstAvailableImageRequests_arrayLjava_lang_Object_);
			return cb_setFirstAvailableImageRequests_arrayLjava_lang_Object_;
		}

		static IntPtr n_SetFirstAvailableImageRequests_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_firstAvailableImageRequests)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] firstAvailableImageRequests = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_firstAvailableImageRequests, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFirstAvailableImageRequests (firstAvailableImageRequests));
			if (firstAvailableImageRequests != null)
				JNIEnv.CopyArray (firstAvailableImageRequests, native_firstAvailableImageRequests);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setFirstAvailableImageRequests' and count(parameter)=1 and parameter[1][@type='REQUEST[]']]"
		[Register ("setFirstAvailableImageRequests", "([Ljava/lang/Object;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetFirstAvailableImageRequests_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object SetFirstAvailableImageRequests (global::Java.Lang.Object[] firstAvailableImageRequests)
		{
			const string __id = "setFirstAvailableImageRequests.([Ljava/lang/Object;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			IntPtr native_firstAvailableImageRequests = JNIEnv.NewArray (firstAvailableImageRequests);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_firstAvailableImageRequests);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (firstAvailableImageRequests != null) {
					JNIEnv.CopyArray (native_firstAvailableImageRequests, firstAvailableImageRequests);
					JNIEnv.DeleteLocalRef (native_firstAvailableImageRequests);
				}
			}
		}

		static Delegate cb_setFirstAvailableImageRequests_arrayLjava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetSetFirstAvailableImageRequests_arrayLjava_lang_Object_ZHandler ()
		{
			if (cb_setFirstAvailableImageRequests_arrayLjava_lang_Object_Z == null)
				cb_setFirstAvailableImageRequests_arrayLjava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_SetFirstAvailableImageRequests_arrayLjava_lang_Object_Z);
			return cb_setFirstAvailableImageRequests_arrayLjava_lang_Object_Z;
		}

		static IntPtr n_SetFirstAvailableImageRequests_arrayLjava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_firstAvailableImageRequests, bool tryCacheOnlyFirst)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] firstAvailableImageRequests = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_firstAvailableImageRequests, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFirstAvailableImageRequests (firstAvailableImageRequests, tryCacheOnlyFirst));
			if (firstAvailableImageRequests != null)
				JNIEnv.CopyArray (firstAvailableImageRequests, native_firstAvailableImageRequests);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setFirstAvailableImageRequests' and count(parameter)=2 and parameter[1][@type='REQUEST[]'] and parameter[2][@type='boolean']]"
		[Register ("setFirstAvailableImageRequests", "([Ljava/lang/Object;Z)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetFirstAvailableImageRequests_arrayLjava_lang_Object_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetFirstAvailableImageRequests (global::Java.Lang.Object[] firstAvailableImageRequests, bool tryCacheOnlyFirst)
		{
			const string __id = "setFirstAvailableImageRequests.([Ljava/lang/Object;Z)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			IntPtr native_firstAvailableImageRequests = JNIEnv.NewArray (firstAvailableImageRequests);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_firstAvailableImageRequests);
				__args [1] = new JniArgumentValue (tryCacheOnlyFirst);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (firstAvailableImageRequests != null) {
					JNIEnv.CopyArray (native_firstAvailableImageRequests, firstAvailableImageRequests);
					JNIEnv.DeleteLocalRef (native_firstAvailableImageRequests);
				}
			}
		}

		static Delegate cb_setImageRequest_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetImageRequest_Ljava_lang_Object_Handler ()
		{
			if (cb_setImageRequest_Ljava_lang_Object_ == null)
				cb_setImageRequest_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetImageRequest_Ljava_lang_Object_);
			return cb_setImageRequest_Ljava_lang_Object_;
		}

		static IntPtr n_SetImageRequest_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageRequest)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object imageRequest = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_imageRequest, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetImageRequest (imageRequest));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setImageRequest' and count(parameter)=1 and parameter[1][@type='REQUEST']]"
		[Register ("setImageRequest", "(Ljava/lang/Object;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetImageRequest_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object SetImageRequest (global::Java.Lang.Object imageRequest)
		{
			const string __id = "setImageRequest.(Ljava/lang/Object;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			IntPtr native_imageRequest = JNIEnv.ToLocalJniHandle (imageRequest);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imageRequest);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageRequest);
			}
		}

		static Delegate cb_setLowResImageRequest_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetLowResImageRequest_Ljava_lang_Object_Handler ()
		{
			if (cb_setLowResImageRequest_Ljava_lang_Object_ == null)
				cb_setLowResImageRequest_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLowResImageRequest_Ljava_lang_Object_);
			return cb_setLowResImageRequest_Ljava_lang_Object_;
		}

		static IntPtr n_SetLowResImageRequest_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lowResImageRequest)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object lowResImageRequest = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_lowResImageRequest, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLowResImageRequest (lowResImageRequest));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setLowResImageRequest' and count(parameter)=1 and parameter[1][@type='REQUEST']]"
		[Register ("setLowResImageRequest", "(Ljava/lang/Object;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetLowResImageRequest_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object SetLowResImageRequest (global::Java.Lang.Object lowResImageRequest)
		{
			const string __id = "setLowResImageRequest.(Ljava/lang/Object;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			IntPtr native_lowResImageRequest = JNIEnv.ToLocalJniHandle (lowResImageRequest);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_lowResImageRequest);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_lowResImageRequest);
			}
		}

		static Delegate cb_RawSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_;
#pragma warning disable 0169
		static Delegate GetRawSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_Handler ()
		{
			if (cb_RawSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_ == null)
				cb_RawSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RawSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_);
			return cb_RawSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_;
		}

		static IntPtr n_RawSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldController)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController oldController = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_oldController, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RawSetOldController (oldController));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='RawSetOldController' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
		[Register ("RawSetOldController", "(Lcom/facebook/drawee/interfaces/DraweeController;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetRawSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_Handler")]
		public virtual unsafe global::Java.Lang.Object RawSetOldController (global::Com.Facebook.Drawee.Interfaces.IDraweeController oldController)
		{
			const string __id = "RawSetOldController.(Lcom/facebook/drawee/interfaces/DraweeController;)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((oldController == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldController).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRetainImageOnFailure_Z;
#pragma warning disable 0169
		static Delegate GetSetRetainImageOnFailure_ZHandler ()
		{
			if (cb_setRetainImageOnFailure_Z == null)
				cb_setRetainImageOnFailure_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetRetainImageOnFailure_Z);
			return cb_setRetainImageOnFailure_Z;
		}

		static IntPtr n_SetRetainImageOnFailure_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRetainImageOnFailure (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setRetainImageOnFailure' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRetainImageOnFailure", "(Z)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetRetainImageOnFailure_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetRetainImageOnFailure (bool enabled)
		{
			const string __id = "setRetainImageOnFailure.(Z)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTapToRetryEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetTapToRetryEnabled_ZHandler ()
		{
			if (cb_setTapToRetryEnabled_Z == null)
				cb_setTapToRetryEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetTapToRetryEnabled_Z);
			return cb_setTapToRetryEnabled_Z;
		}

		static IntPtr n_SetTapToRetryEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTapToRetryEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='setTapToRetryEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTapToRetryEnabled", "(Z)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetSetTapToRetryEnabled_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetTapToRetryEnabled (bool enabled)
		{
			const string __id = "setTapToRetryEnabled.(Z)Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_validate;
#pragma warning disable 0169
		static Delegate GetValidateHandler ()
		{
			if (cb_validate == null)
				cb_validate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Validate);
			return cb_validate;
		}

		static void n_Validate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Validate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='validate' and count(parameter)=0]"
		[Register ("validate", "()V", "GetValidateHandler")]
		protected virtual unsafe void Validate ()
		{
			const string __id = "validate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/facebook/drawee/interfaces/DraweeController;", "GetBuildHandler")]
		public abstract global::Com.Facebook.Drawee.Interfaces.IDraweeController Build ();

		static Delegate cb_setCallerContext_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetCallerContext_Ljava_lang_Object_Handler ()
		{
			if (cb_setCallerContext_Ljava_lang_Object_ == null)
				cb_setCallerContext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCallerContext_Ljava_lang_Object_);
			return cb_setCallerContext_Ljava_lang_Object_;
		}

		static IntPtr n_SetCallerContext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCallerContext (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setCallerContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setCallerContext", "(Ljava/lang/Object;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetCallerContext_Ljava_lang_Object_Handler")]
		public abstract global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetCallerContext (global::Java.Lang.Object p0);

		static Delegate cb_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_;
#pragma warning disable 0169
		static Delegate GetSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_Handler ()
		{
			if (cb_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_ == null)
				cb_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOldController_Lcom_facebook_drawee_interfaces_DraweeController_);
			return cb_setOldController_Lcom_facebook_drawee_interfaces_DraweeController_;
		}

		static IntPtr n_SetOldController_Lcom_facebook_drawee_interfaces_DraweeController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController p0 = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOldController (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setOldController' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
		[Register ("setOldController", "(Lcom/facebook/drawee/interfaces/DraweeController;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_Handler")]
		public abstract global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetOldController (global::Com.Facebook.Drawee.Interfaces.IDraweeController p0);

		static Delegate cb_setUri_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetUri_Landroid_net_Uri_Handler ()
		{
			if (cb_setUri_Landroid_net_Uri_ == null)
				cb_setUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUri_Landroid_net_Uri_);
			return cb_setUri_Landroid_net_Uri_;
		}

		static IntPtr n_SetUri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setUri", "(Landroid/net/Uri;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetUri_Landroid_net_Uri_Handler")]
		public abstract global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri (global::Android.Net.Uri p0);

		static Delegate cb_setUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUri_Ljava_lang_String_Handler ()
		{
			if (cb_setUri_Ljava_lang_String_ == null)
				cb_setUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUri_Ljava_lang_String_);
			return cb_setUri_Ljava_lang_String_;
		}

		static IntPtr n_SetUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUri", "(Ljava/lang/String;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetUri_Ljava_lang_String_Handler")]
		public abstract global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri (string p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/controller/AbstractDraweeControllerBuilder", DoNotGenerateAcw=true)]
	internal partial class AbstractDraweeControllerBuilderInvoker : AbstractDraweeControllerBuilder {

		public AbstractDraweeControllerBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/controller/AbstractDraweeControllerBuilder", typeof (AbstractDraweeControllerBuilderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='getDataSourceForRequest' and count(parameter)=5 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='REQUEST'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='com.facebook.drawee.controller.AbstractDraweeControllerBuilder.CacheLevel']]"
		[Register ("getDataSourceForRequest", "(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;)Lcom/facebook/datasource/DataSource;", "GetGetDataSourceForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_Handler")]
		protected override unsafe global::Com.Facebook.Datasource.IDataSource GetDataSourceForRequest (global::Com.Facebook.Drawee.Interfaces.IDraweeController p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel p4)
		{
			const string __id = "getDataSourceForRequest.(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;)Lcom/facebook/datasource/DataSource;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Datasource.IDataSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeControllerBuilder']/method[@name='obtainController' and count(parameter)=0]"
		[Register ("obtainController", "()Lcom/facebook/drawee/controller/AbstractDraweeController;", "GetObtainControllerHandler")]
		protected override unsafe global::Com.Facebook.Drawee.Controller.AbstractDraweeController ObtainController ()
		{
			const string __id = "obtainController.()Lcom/facebook/drawee/controller/AbstractDraweeController;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/facebook/drawee/interfaces/DraweeController;", "GetBuildHandler")]
		public override unsafe global::Com.Facebook.Drawee.Interfaces.IDraweeController Build ()
		{
			const string __id = "build.()Lcom/facebook/drawee/interfaces/DraweeController;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setCallerContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setCallerContext", "(Ljava/lang/Object;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetCallerContext_Ljava_lang_Object_Handler")]
		public override unsafe global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetCallerContext (global::Java.Lang.Object p0)
		{
			const string __id = "setCallerContext.(Ljava/lang/Object;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setOldController' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
		[Register ("setOldController", "(Lcom/facebook/drawee/interfaces/DraweeController;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetOldController_Lcom_facebook_drawee_interfaces_DraweeController_Handler")]
		public override unsafe global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetOldController (global::Com.Facebook.Drawee.Interfaces.IDraweeController p0)
		{
			const string __id = "setOldController.(Lcom/facebook/drawee/interfaces/DraweeController;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setUri", "(Landroid/net/Uri;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetUri_Landroid_net_Uri_Handler")]
		public override unsafe global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri (global::Android.Net.Uri p0)
		{
			const string __id = "setUri.(Landroid/net/Uri;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='SimpleDraweeControllerBuilder']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUri", "(Ljava/lang/String;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;", "GetSetUri_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri (string p0)
		{
			const string __id = "setUri.(Ljava/lang/String;)Lcom/facebook/drawee/interfaces/SimpleDraweeControllerBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
