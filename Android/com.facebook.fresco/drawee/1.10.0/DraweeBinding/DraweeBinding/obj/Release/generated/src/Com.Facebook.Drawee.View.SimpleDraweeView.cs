using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']"
	[global::Android.Runtime.Register ("com/facebook/drawee/view/SimpleDraweeView", DoNotGenerateAcw=true)]
	public partial class SimpleDraweeView : global::Com.Facebook.Drawee.View.GenericDraweeView {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/view/SimpleDraweeView", typeof (SimpleDraweeView));
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

		protected SimpleDraweeView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/constructor[@name='SimpleDraweeView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SimpleDraweeView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/constructor[@name='SimpleDraweeView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SimpleDraweeView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/constructor[@name='SimpleDraweeView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SimpleDraweeView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/constructor[@name='SimpleDraweeView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe SimpleDraweeView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr, int defStyleRes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				__args [3] = new JniArgumentValue (defStyleRes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/constructor[@name='SimpleDraweeView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.drawee.generic.GenericDraweeHierarchy']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/drawee/generic/GenericDraweeHierarchy;)V", "")]
		public unsafe SimpleDraweeView (global::Android.Content.Context context, global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy hierarchy)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/facebook/drawee/generic/GenericDraweeHierarchy;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((hierarchy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hierarchy).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getControllerBuilder;
#pragma warning disable 0169
		static Delegate GetGetControllerBuilderHandler ()
		{
			if (cb_getControllerBuilder == null)
				cb_getControllerBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetControllerBuilder);
			return cb_getControllerBuilder;
		}

		static IntPtr n_GetControllerBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.SimpleDraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.SimpleDraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ControllerBuilder);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder ControllerBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/method[@name='getControllerBuilder' and count(parameter)=0]"
			[Register ("getControllerBuilder", "()Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;", "GetGetControllerBuilderHandler")]
			get {
				const string __id = "getControllerBuilder.()Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='com.facebook.common.internal.Supplier&lt;? extends com.facebook.drawee.controller.AbstractDraweeControllerBuilder&gt;']]"
		[Register ("initialize", "(Lcom/facebook/common/internal/Supplier;)V", "")]
		public static unsafe void Initialize (global::Com.Facebook.Common.Internal.ISupplier draweeControllerBuilderSupplier)
		{
			const string __id = "initialize.(Lcom/facebook/common/internal/Supplier;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((draweeControllerBuilderSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) draweeControllerBuilderSupplier).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_setActualImageResource_I;
#pragma warning disable 0169
		static Delegate GetSetActualImageResource_IHandler ()
		{
			if (cb_setActualImageResource_I == null)
				cb_setActualImageResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetActualImageResource_I);
			return cb_setActualImageResource_I;
		}

		static void n_SetActualImageResource_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Facebook.Drawee.View.SimpleDraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.SimpleDraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetActualImageResource (resourceId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/method[@name='setActualImageResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setActualImageResource", "(I)V", "GetSetActualImageResource_IHandler")]
		public virtual unsafe void SetActualImageResource (int resourceId)
		{
			const string __id = "setActualImageResource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setActualImageResource_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetActualImageResource_ILjava_lang_Object_Handler ()
		{
			if (cb_setActualImageResource_ILjava_lang_Object_ == null)
				cb_setActualImageResource_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetActualImageResource_ILjava_lang_Object_);
			return cb_setActualImageResource_ILjava_lang_Object_;
		}

		static void n_SetActualImageResource_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int resourceId, IntPtr native_callerContext)
		{
			global::Com.Facebook.Drawee.View.SimpleDraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.SimpleDraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object callerContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_callerContext, JniHandleOwnership.DoNotTransfer);
			__this.SetActualImageResource (resourceId, callerContext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/method[@name='setActualImageResource' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setActualImageResource", "(ILjava/lang/Object;)V", "GetSetActualImageResource_ILjava_lang_Object_Handler")]
		public virtual unsafe void SetActualImageResource (int resourceId, global::Java.Lang.Object callerContext)
		{
			const string __id = "setActualImageResource.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resourceId);
				__args [1] = new JniArgumentValue ((callerContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callerContext).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_;
#pragma warning disable 0169
		static Delegate GetSetImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_Handler ()
		{
			if (cb_setImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_ == null)
				cb_setImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_);
			return cb_setImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_;
		}

		static void n_SetImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Facebook.Drawee.View.SimpleDraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.SimpleDraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Request.ImageRequest request = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Request.ImageRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.SetImageRequest (request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/method[@name='setImageRequest' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.request.ImageRequest']]"
		[Register ("setImageRequest", "(Lcom/facebook/imagepipeline/request/ImageRequest;)V", "GetSetImageRequest_Lcom_facebook_imagepipeline_request_ImageRequest_Handler")]
		public virtual unsafe void SetImageRequest (global::Com.Facebook.Imagepipeline.Request.ImageRequest request)
		{
			const string __id = "setImageRequest.(Lcom/facebook/imagepipeline/request/ImageRequest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImageURI_Landroid_net_Uri_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetImageURI_Landroid_net_Uri_Ljava_lang_Object_Handler ()
		{
			if (cb_setImageURI_Landroid_net_Uri_Ljava_lang_Object_ == null)
				cb_setImageURI_Landroid_net_Uri_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetImageURI_Landroid_net_Uri_Ljava_lang_Object_);
			return cb_setImageURI_Landroid_net_Uri_Ljava_lang_Object_;
		}

		static void n_SetImageURI_Landroid_net_Uri_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_callerContext)
		{
			global::Com.Facebook.Drawee.View.SimpleDraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.SimpleDraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object callerContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_callerContext, JniHandleOwnership.DoNotTransfer);
			__this.SetImageURI (uri, callerContext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/method[@name='setImageURI' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setImageURI", "(Landroid/net/Uri;Ljava/lang/Object;)V", "GetSetImageURI_Landroid_net_Uri_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetImageURI (global::Android.Net.Uri uri, global::Java.Lang.Object callerContext)
		{
			const string __id = "setImageURI.(Landroid/net/Uri;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue ((callerContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callerContext).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImageURI_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageURI_Ljava_lang_String_Handler ()
		{
			if (cb_setImageURI_Ljava_lang_String_ == null)
				cb_setImageURI_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageURI_Ljava_lang_String_);
			return cb_setImageURI_Ljava_lang_String_;
		}

		static void n_SetImageURI_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uriString)
		{
			global::Com.Facebook.Drawee.View.SimpleDraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.SimpleDraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uriString = JNIEnv.GetString (native_uriString, JniHandleOwnership.DoNotTransfer);
			__this.SetImageURI (uriString);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/method[@name='setImageURI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setImageURI", "(Ljava/lang/String;)V", "GetSetImageURI_Ljava_lang_String_Handler")]
		public virtual unsafe void SetImageURI (string uriString)
		{
			const string __id = "setImageURI.(Ljava/lang/String;)V";
			IntPtr native_uriString = JNIEnv.NewString (uriString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uriString);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_uriString);
			}
		}

		static Delegate cb_setImageURI_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetImageURI_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setImageURI_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setImageURI_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetImageURI_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setImageURI_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetImageURI_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uriString, IntPtr native_callerContext)
		{
			global::Com.Facebook.Drawee.View.SimpleDraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.SimpleDraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uriString = JNIEnv.GetString (native_uriString, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object callerContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_callerContext, JniHandleOwnership.DoNotTransfer);
			__this.SetImageURI (uriString, callerContext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/method[@name='setImageURI' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setImageURI", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetImageURI_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetImageURI (string uriString, global::Java.Lang.Object callerContext)
		{
			const string __id = "setImageURI.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_uriString = JNIEnv.NewString (uriString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_uriString);
				__args [1] = new JniArgumentValue ((callerContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callerContext).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_uriString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='SimpleDraweeView']/method[@name='shutDown' and count(parameter)=0]"
		[Register ("shutDown", "()V", "")]
		public static unsafe void ShutDown ()
		{
			const string __id = "shutDown.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
