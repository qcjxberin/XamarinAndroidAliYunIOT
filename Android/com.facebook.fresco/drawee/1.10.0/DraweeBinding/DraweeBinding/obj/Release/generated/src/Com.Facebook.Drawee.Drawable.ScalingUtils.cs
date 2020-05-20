using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/ScalingUtils", DoNotGenerateAcw=true)]
	public partial class ScalingUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.AbstractScaleType']"
		[global::Android.Runtime.Register ("com/facebook/drawee/drawable/ScalingUtils$AbstractScaleType", DoNotGenerateAcw=true)]
		public abstract partial class AbstractScaleType : global::Java.Lang.Object, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType {


			public static class InterfaceConsts {

				// The following are fields from: com.facebook.drawee.drawable.ScalingUtils.ScaleType


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='CENTER']"
				[Register ("CENTER")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType Center {
					get {
						const string __id = "CENTER.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='CENTER_CROP']"
				[Register ("CENTER_CROP")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType CenterCrop {
					get {
						const string __id = "CENTER_CROP.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='CENTER_INSIDE']"
				[Register ("CENTER_INSIDE")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType CenterInside {
					get {
						const string __id = "CENTER_INSIDE.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_BOTTOM_START']"
				[Register ("FIT_BOTTOM_START")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitBottomStart {
					get {
						const string __id = "FIT_BOTTOM_START.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_CENTER']"
				[Register ("FIT_CENTER")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitCenter {
					get {
						const string __id = "FIT_CENTER.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_END']"
				[Register ("FIT_END")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitEnd {
					get {
						const string __id = "FIT_END.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_START']"
				[Register ("FIT_START")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitStart {
					get {
						const string __id = "FIT_START.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_XY']"
				[Register ("FIT_XY")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitXy {
					get {
						const string __id = "FIT_XY.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FOCUS_CROP']"
				[Register ("FOCUS_CROP")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FocusCrop {
					get {
						const string __id = "FOCUS_CROP.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ScalingUtils$AbstractScaleType", typeof (AbstractScaleType));
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

			protected AbstractScaleType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.AbstractScaleType']/constructor[@name='ScalingUtils.AbstractScaleType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AbstractScaleType ()
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

			static Delegate cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF;
#pragma warning disable 0169
			static Delegate GetGetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFHandler ()
			{
				if (cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF == null)
					cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, float, float, IntPtr>) n_GetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF);
				return cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF;
			}

			static IntPtr n_GetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF (IntPtr jnienv, IntPtr native__this, IntPtr native_outTransform, IntPtr native_parentRect, int childWidth, int childHeight, float focusX, float focusY)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.AbstractScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.AbstractScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Matrix outTransform = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_outTransform, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Rect parentRect = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_parentRect, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTransform (outTransform, parentRect, childWidth, childHeight, focusX, focusY));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.AbstractScaleType']/method[@name='getTransform' and count(parameter)=6 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='android.graphics.Rect'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
			[Register ("getTransform", "(Landroid/graphics/Matrix;Landroid/graphics/Rect;IIFF)Landroid/graphics/Matrix;", "GetGetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFHandler")]
			public virtual unsafe global::Android.Graphics.Matrix GetTransform (global::Android.Graphics.Matrix outTransform, global::Android.Graphics.Rect parentRect, int childWidth, int childHeight, float focusX, float focusY)
			{
				const string __id = "getTransform.(Landroid/graphics/Matrix;Landroid/graphics/Rect;IIFF)Landroid/graphics/Matrix;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue ((outTransform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outTransform).Handle);
					__args [1] = new JniArgumentValue ((parentRect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentRect).Handle);
					__args [2] = new JniArgumentValue (childWidth);
					__args [3] = new JniArgumentValue (childHeight);
					__args [4] = new JniArgumentValue (focusX);
					__args [5] = new JniArgumentValue (focusY);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_getTransformImpl_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFFF;
#pragma warning disable 0169
			static Delegate GetGetTransformImpl_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFFFHandler ()
			{
				if (cb_getTransformImpl_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFFF == null)
					cb_getTransformImpl_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, float, float, float, float>) n_GetTransformImpl_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFFF);
				return cb_getTransformImpl_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFFF;
			}

			static void n_GetTransformImpl_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFFF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, float p4, float p5, float p6, float p7)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.AbstractScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.AbstractScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Matrix p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.GetTransformImpl (p0, p1, p2, p3, p4, p5, p6, p7);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.AbstractScaleType']/method[@name='getTransformImpl' and count(parameter)=8 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='android.graphics.Rect'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float']]"
			[Register ("getTransformImpl", "(Landroid/graphics/Matrix;Landroid/graphics/Rect;IIFFFF)V", "GetGetTransformImpl_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFFFHandler")]
			public abstract void GetTransformImpl (global::Android.Graphics.Matrix p0, global::Android.Graphics.Rect p1, int p2, int p3, float p4, float p5, float p6, float p7);

		}

		[global::Android.Runtime.Register ("com/facebook/drawee/drawable/ScalingUtils$AbstractScaleType", DoNotGenerateAcw=true)]
		internal partial class AbstractScaleTypeInvoker : AbstractScaleType {

			public AbstractScaleTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ScalingUtils$AbstractScaleType", typeof (AbstractScaleTypeInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.AbstractScaleType']/method[@name='getTransformImpl' and count(parameter)=8 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='android.graphics.Rect'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float']]"
			[Register ("getTransformImpl", "(Landroid/graphics/Matrix;Landroid/graphics/Rect;IIFFFF)V", "GetGetTransformImpl_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFFFHandler")]
			public override unsafe void GetTransformImpl (global::Android.Graphics.Matrix p0, global::Android.Graphics.Rect p1, int p2, int p3, float p4, float p5, float p6, float p7)
			{
				const string __id = "getTransformImpl.(Landroid/graphics/Matrix;Landroid/graphics/Rect;IIFFFF)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue (p6);
					__args [7] = new JniArgumentValue (p7);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']"
		[global::Android.Runtime.Register ("com/facebook/drawee/drawable/ScalingUtils$InterpolatingScaleType", DoNotGenerateAcw=true)]
		public partial class InterpolatingScaleType : global::Java.Lang.Object, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IStatefulScaleType {


			public static class InterfaceConsts {

				// The following are fields from: com.facebook.drawee.drawable.ScalingUtils.ScaleType


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='CENTER']"
				[Register ("CENTER")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType Center {
					get {
						const string __id = "CENTER.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='CENTER_CROP']"
				[Register ("CENTER_CROP")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType CenterCrop {
					get {
						const string __id = "CENTER_CROP.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='CENTER_INSIDE']"
				[Register ("CENTER_INSIDE")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType CenterInside {
					get {
						const string __id = "CENTER_INSIDE.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_BOTTOM_START']"
				[Register ("FIT_BOTTOM_START")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitBottomStart {
					get {
						const string __id = "FIT_BOTTOM_START.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_CENTER']"
				[Register ("FIT_CENTER")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitCenter {
					get {
						const string __id = "FIT_CENTER.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_END']"
				[Register ("FIT_END")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitEnd {
					get {
						const string __id = "FIT_END.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_START']"
				[Register ("FIT_START")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitStart {
					get {
						const string __id = "FIT_START.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_XY']"
				[Register ("FIT_XY")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitXy {
					get {
						const string __id = "FIT_XY.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FOCUS_CROP']"
				[Register ("FOCUS_CROP")]
				public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FocusCrop {
					get {
						const string __id = "FOCUS_CROP.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ScalingUtils$InterpolatingScaleType", typeof (InterpolatingScaleType));
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

			protected InterpolatingScaleType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/constructor[@name='ScalingUtils.InterpolatingScaleType' and count(parameter)=2 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
			[Register (".ctor", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "")]
			public unsafe InterpolatingScaleType (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleTypeFrom, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleTypeTo)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((scaleTypeFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleTypeFrom).Handle);
					__args [1] = new JniArgumentValue ((scaleTypeTo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleTypeTo).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/constructor[@name='ScalingUtils.InterpolatingScaleType' and count(parameter)=4 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[3][@type='android.graphics.Rect'] and parameter[4][@type='android.graphics.Rect']]"
			[Register (".ctor", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Landroid/graphics/Rect;Landroid/graphics/Rect;)V", "")]
			public unsafe InterpolatingScaleType (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleTypeFrom, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleTypeTo, global::Android.Graphics.Rect boundsFrom, global::Android.Graphics.Rect boundsTo)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Landroid/graphics/Rect;Landroid/graphics/Rect;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((scaleTypeFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleTypeFrom).Handle);
					__args [1] = new JniArgumentValue ((scaleTypeTo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleTypeTo).Handle);
					__args [2] = new JniArgumentValue ((boundsFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boundsFrom).Handle);
					__args [3] = new JniArgumentValue ((boundsTo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boundsTo).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/constructor[@name='ScalingUtils.InterpolatingScaleType' and count(parameter)=6 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[3][@type='android.graphics.Rect'] and parameter[4][@type='android.graphics.Rect'] and parameter[5][@type='android.graphics.PointF'] and parameter[6][@type='android.graphics.PointF']]"
			[Register (".ctor", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/PointF;Landroid/graphics/PointF;)V", "")]
			public unsafe InterpolatingScaleType (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleTypeFrom, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleTypeTo, global::Android.Graphics.Rect boundsFrom, global::Android.Graphics.Rect boundsTo, global::Android.Graphics.PointF focusPointFrom, global::Android.Graphics.PointF focusPointTo)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/PointF;Landroid/graphics/PointF;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue ((scaleTypeFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleTypeFrom).Handle);
					__args [1] = new JniArgumentValue ((scaleTypeTo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleTypeTo).Handle);
					__args [2] = new JniArgumentValue ((boundsFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boundsFrom).Handle);
					__args [3] = new JniArgumentValue ((boundsTo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boundsTo).Handle);
					__args [4] = new JniArgumentValue ((focusPointFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) focusPointFrom).Handle);
					__args [5] = new JniArgumentValue ((focusPointTo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) focusPointTo).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getBoundsFrom;
#pragma warning disable 0169
			static Delegate GetGetBoundsFromHandler ()
			{
				if (cb_getBoundsFrom == null)
					cb_getBoundsFrom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBoundsFrom);
				return cb_getBoundsFrom;
			}

			static IntPtr n_GetBoundsFrom (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BoundsFrom);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.Rect BoundsFrom {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/method[@name='getBoundsFrom' and count(parameter)=0]"
				[Register ("getBoundsFrom", "()Landroid/graphics/Rect;", "GetGetBoundsFromHandler")]
				get {
					const string __id = "getBoundsFrom.()Landroid/graphics/Rect;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getBoundsTo;
#pragma warning disable 0169
			static Delegate GetGetBoundsToHandler ()
			{
				if (cb_getBoundsTo == null)
					cb_getBoundsTo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBoundsTo);
				return cb_getBoundsTo;
			}

			static IntPtr n_GetBoundsTo (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BoundsTo);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.Rect BoundsTo {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/method[@name='getBoundsTo' and count(parameter)=0]"
				[Register ("getBoundsTo", "()Landroid/graphics/Rect;", "GetGetBoundsToHandler")]
				get {
					const string __id = "getBoundsTo.()Landroid/graphics/Rect;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getFocusPointFrom;
#pragma warning disable 0169
			static Delegate GetGetFocusPointFromHandler ()
			{
				if (cb_getFocusPointFrom == null)
					cb_getFocusPointFrom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocusPointFrom);
				return cb_getFocusPointFrom;
			}

			static IntPtr n_GetFocusPointFrom (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FocusPointFrom);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.PointF FocusPointFrom {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/method[@name='getFocusPointFrom' and count(parameter)=0]"
				[Register ("getFocusPointFrom", "()Landroid/graphics/PointF;", "GetGetFocusPointFromHandler")]
				get {
					const string __id = "getFocusPointFrom.()Landroid/graphics/PointF;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getFocusPointTo;
#pragma warning disable 0169
			static Delegate GetGetFocusPointToHandler ()
			{
				if (cb_getFocusPointTo == null)
					cb_getFocusPointTo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocusPointTo);
				return cb_getFocusPointTo;
			}

			static IntPtr n_GetFocusPointTo (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FocusPointTo);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.PointF FocusPointTo {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/method[@name='getFocusPointTo' and count(parameter)=0]"
				[Register ("getFocusPointTo", "()Landroid/graphics/PointF;", "GetGetFocusPointToHandler")]
				get {
					const string __id = "getFocusPointTo.()Landroid/graphics/PointF;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getScaleTypeFrom;
#pragma warning disable 0169
			static Delegate GetGetScaleTypeFromHandler ()
			{
				if (cb_getScaleTypeFrom == null)
					cb_getScaleTypeFrom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleTypeFrom);
				return cb_getScaleTypeFrom;
			}

			static IntPtr n_GetScaleTypeFrom (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ScaleTypeFrom);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType ScaleTypeFrom {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/method[@name='getScaleTypeFrom' and count(parameter)=0]"
				[Register ("getScaleTypeFrom", "()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;", "GetGetScaleTypeFromHandler")]
				get {
					const string __id = "getScaleTypeFrom.()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getScaleTypeTo;
#pragma warning disable 0169
			static Delegate GetGetScaleTypeToHandler ()
			{
				if (cb_getScaleTypeTo == null)
					cb_getScaleTypeTo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleTypeTo);
				return cb_getScaleTypeTo;
			}

			static IntPtr n_GetScaleTypeTo (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ScaleTypeTo);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType ScaleTypeTo {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/method[@name='getScaleTypeTo' and count(parameter)=0]"
				[Register ("getScaleTypeTo", "()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;", "GetGetScaleTypeToHandler")]
				get {
					const string __id = "getScaleTypeTo.()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getState;
#pragma warning disable 0169
			static Delegate GetGetStateHandler ()
			{
				if (cb_getState == null)
					cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
				return cb_getState;
			}

			static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.State);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Object State {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/method[@name='getState' and count(parameter)=0]"
				[Register ("getState", "()Ljava/lang/Object;", "GetGetStateHandler")]
				get {
					const string __id = "getState.()Ljava/lang/Object;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetValue);
				return cb_getValue;
			}

			static float n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Value;
			}
#pragma warning restore 0169

			static Delegate cb_setValue_F;
#pragma warning disable 0169
			static Delegate GetSetValue_FHandler ()
			{
				if (cb_setValue_F == null)
					cb_setValue_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetValue_F);
				return cb_setValue_F;
			}

			static void n_SetValue_F (IntPtr jnienv, IntPtr native__this, float value)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Value = value;
			}
#pragma warning restore 0169

			public virtual unsafe float Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()F", "GetGetValueHandler")]
				get {
					const string __id = "getValue.()F";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='float']]"
				[Register ("setValue", "(F)V", "GetSetValue_FHandler")]
				set {
					const string __id = "setValue.(F)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

			static Delegate cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF;
#pragma warning disable 0169
			static Delegate GetGetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFHandler ()
			{
				if (cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF == null)
					cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, float, float, IntPtr>) n_GetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF);
				return cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF;
			}

			static IntPtr n_GetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF (IntPtr jnienv, IntPtr native__this, IntPtr native_transform, IntPtr native_parentBounds, int childWidth, int childHeight, float focusX, float focusY)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.InterpolatingScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Matrix transform = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_transform, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Rect parentBounds = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_parentBounds, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTransform (transform, parentBounds, childWidth, childHeight, focusX, focusY));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils.InterpolatingScaleType']/method[@name='getTransform' and count(parameter)=6 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='android.graphics.Rect'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
			[Register ("getTransform", "(Landroid/graphics/Matrix;Landroid/graphics/Rect;IIFF)Landroid/graphics/Matrix;", "GetGetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFHandler")]
			public virtual unsafe global::Android.Graphics.Matrix GetTransform (global::Android.Graphics.Matrix transform, global::Android.Graphics.Rect parentBounds, int childWidth, int childHeight, float focusX, float focusY)
			{
				const string __id = "getTransform.(Landroid/graphics/Matrix;Landroid/graphics/Rect;IIFF)Landroid/graphics/Matrix;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue ((transform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transform).Handle);
					__args [1] = new JniArgumentValue ((parentBounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentBounds).Handle);
					__args [2] = new JniArgumentValue (childWidth);
					__args [3] = new JniArgumentValue (childHeight);
					__args [4] = new JniArgumentValue (focusX);
					__args [5] = new JniArgumentValue (focusY);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		[Register ("com/facebook/drawee/drawable/ScalingUtils$ScaleType", DoNotGenerateAcw=true)]
		public abstract class ScaleType : Java.Lang.Object {

			internal ScaleType ()
			{
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='CENTER']"
			[Register ("CENTER")]
			public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType Center {
				get {
					const string __id = "CENTER.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='CENTER_CROP']"
			[Register ("CENTER_CROP")]
			public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType CenterCrop {
				get {
					const string __id = "CENTER_CROP.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='CENTER_INSIDE']"
			[Register ("CENTER_INSIDE")]
			public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType CenterInside {
				get {
					const string __id = "CENTER_INSIDE.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_BOTTOM_START']"
			[Register ("FIT_BOTTOM_START")]
			public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitBottomStart {
				get {
					const string __id = "FIT_BOTTOM_START.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_CENTER']"
			[Register ("FIT_CENTER")]
			public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitCenter {
				get {
					const string __id = "FIT_CENTER.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_END']"
			[Register ("FIT_END")]
			public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitEnd {
				get {
					const string __id = "FIT_END.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_START']"
			[Register ("FIT_START")]
			public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitStart {
				get {
					const string __id = "FIT_START.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FIT_XY']"
			[Register ("FIT_XY")]
			public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FitXy {
				get {
					const string __id = "FIT_XY.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/field[@name='FOCUS_CROP']"
			[Register ("FOCUS_CROP")]
			public static global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType FocusCrop {
				get {
					const string __id = "FOCUS_CROP.Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ScalingUtils$ScaleType", typeof (ScaleType));
		}

		[Register ("com/facebook/drawee/drawable/ScalingUtils$ScaleType", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'ScaleType' type. This type will be removed in a future release.", error: true)]
		public abstract class ScaleTypeConsts : ScaleType {

			private ScaleTypeConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']"
		[Register ("com/facebook/drawee/drawable/ScalingUtils$ScaleType", "", "Com.Facebook.Drawee.Drawable.ScalingUtils/IScaleTypeInvoker")]
		public partial interface IScaleType : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.ScaleType']/method[@name='getTransform' and count(parameter)=6 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='android.graphics.Rect'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
			[Register ("getTransform", "(Landroid/graphics/Matrix;Landroid/graphics/Rect;IIFF)Landroid/graphics/Matrix;", "GetGetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFHandler:Com.Facebook.Drawee.Drawable.ScalingUtils/IScaleTypeInvoker, DraweeBinding")]
			global::Android.Graphics.Matrix GetTransform (global::Android.Graphics.Matrix p0, global::Android.Graphics.Rect p1, int p2, int p3, float p4, float p5);

		}

		[global::Android.Runtime.Register ("com/facebook/drawee/drawable/ScalingUtils$ScaleType", DoNotGenerateAcw=true)]
		internal partial class IScaleTypeInvoker : global::Java.Lang.Object, IScaleType {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ScalingUtils$ScaleType", typeof (IScaleTypeInvoker));

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

			public static IScaleType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IScaleType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.drawable.ScalingUtils.ScaleType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IScaleTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF;
#pragma warning disable 0169
			static Delegate GetGetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFFHandler ()
			{
				if (cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF == null)
					cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, float, float, IntPtr>) n_GetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF);
				return cb_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF;
			}

			static IntPtr n_GetTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, float p4, float p5)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Matrix p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTransform (p0, p1, p2, p3, p4, p5));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF;
			public unsafe global::Android.Graphics.Matrix GetTransform (global::Android.Graphics.Matrix p0, global::Android.Graphics.Rect p1, int p2, int p3, float p4, float p5)
			{
				if (id_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF == IntPtr.Zero)
					id_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF = JNIEnv.GetMethodID (class_ref, "getTransform", "(Landroid/graphics/Matrix;Landroid/graphics/Rect;IIFF)Landroid/graphics/Matrix;");
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				global::Android.Graphics.Matrix __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransform_Landroid_graphics_Matrix_Landroid_graphics_Rect_IIFF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.StatefulScaleType']"
		[Register ("com/facebook/drawee/drawable/ScalingUtils$StatefulScaleType", "", "Com.Facebook.Drawee.Drawable.ScalingUtils/IStatefulScaleTypeInvoker")]
		public partial interface IStatefulScaleType : IJavaObject, IJavaPeerable {

			global::Java.Lang.Object State {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='ScalingUtils.StatefulScaleType']/method[@name='getState' and count(parameter)=0]"
				[Register ("getState", "()Ljava/lang/Object;", "GetGetStateHandler:Com.Facebook.Drawee.Drawable.ScalingUtils/IStatefulScaleTypeInvoker, DraweeBinding")] get;
			}

		}

		[global::Android.Runtime.Register ("com/facebook/drawee/drawable/ScalingUtils$StatefulScaleType", DoNotGenerateAcw=true)]
		internal partial class IStatefulScaleTypeInvoker : global::Java.Lang.Object, IStatefulScaleType {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ScalingUtils$StatefulScaleType", typeof (IStatefulScaleTypeInvoker));

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

			public static IStatefulScaleType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStatefulScaleType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.drawable.ScalingUtils.StatefulScaleType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStatefulScaleTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getState;
#pragma warning disable 0169
			static Delegate GetGetStateHandler ()
			{
				if (cb_getState == null)
					cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
				return cb_getState;
			}

			static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Drawable.ScalingUtils.IStatefulScaleType __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IStatefulScaleType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.State);
			}
#pragma warning restore 0169

			IntPtr id_getState;
			public unsafe global::Java.Lang.Object State {
				get {
					if (id_getState == IntPtr.Zero)
						id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Ljava/lang/Object;");
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef);
				}
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ScalingUtils", typeof (ScalingUtils));
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

		protected ScalingUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils']/constructor[@name='ScalingUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScalingUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScalingUtils']/method[@name='getActiveScaleTypeDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("getActiveScaleTypeDrawable", "(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/drawable/ScaleTypeDrawable;", "")]
		public static unsafe global::Com.Facebook.Drawee.Drawable.ScaleTypeDrawable GetActiveScaleTypeDrawable (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "getActiveScaleTypeDrawable.(Landroid/graphics/drawable/Drawable;)Lcom/facebook/drawee/drawable/ScaleTypeDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScaleTypeDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
