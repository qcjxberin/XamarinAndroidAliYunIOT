using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Generic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyInflater']"
	[global::Android.Runtime.Register ("com/facebook/drawee/generic/GenericDraweeHierarchyInflater", DoNotGenerateAcw=true)]
	public partial class GenericDraweeHierarchyInflater : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/generic/GenericDraweeHierarchyInflater", typeof (GenericDraweeHierarchyInflater));
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

		protected GenericDraweeHierarchyInflater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyInflater']/constructor[@name='GenericDraweeHierarchyInflater' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GenericDraweeHierarchyInflater ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyInflater']/method[@name='inflateBuilder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register ("inflateBuilder", "(Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "")]
		public static unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder InflateBuilder (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
		{
			const string __id = "inflateBuilder.(Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyInflater']/method[@name='inflateHierarchy' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register ("inflateHierarchy", "(Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/facebook/drawee/generic/GenericDraweeHierarchy;", "")]
		public static unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy InflateHierarchy (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
		{
			const string __id = "inflateHierarchy.(Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/facebook/drawee/generic/GenericDraweeHierarchy;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='GenericDraweeHierarchyInflater']/method[@name='updateBuilder' and count(parameter)=3 and parameter[1][@type='com.facebook.drawee.generic.GenericDraweeHierarchyBuilder'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.util.AttributeSet']]"
		[Register ("updateBuilder", "(Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;", "")]
		public static unsafe global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder UpdateBuilder (global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder builder, global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
		{
			const string __id = "updateBuilder.(Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/facebook/drawee/generic/GenericDraweeHierarchyBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [2] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.GenericDraweeHierarchyBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
