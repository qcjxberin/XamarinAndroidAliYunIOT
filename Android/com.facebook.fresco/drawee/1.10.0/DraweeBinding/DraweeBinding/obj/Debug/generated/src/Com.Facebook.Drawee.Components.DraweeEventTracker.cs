using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker']"
	[global::Android.Runtime.Register ("com/facebook/drawee/components/DraweeEventTracker", DoNotGenerateAcw=true)]
	public partial class DraweeEventTracker : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']"
		[global::Android.Runtime.Register ("com/facebook/drawee/components/DraweeEventTracker$Event", DoNotGenerateAcw=true)]
		public sealed partial class Event : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_ACTIVITY_START']"
			[Register ("ON_ACTIVITY_START")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnActivityStart {
				get {
					const string __id = "ON_ACTIVITY_START.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_ACTIVITY_STOP']"
			[Register ("ON_ACTIVITY_STOP")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnActivityStop {
				get {
					const string __id = "ON_ACTIVITY_STOP.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_ATTACH_CONTROLLER']"
			[Register ("ON_ATTACH_CONTROLLER")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnAttachController {
				get {
					const string __id = "ON_ATTACH_CONTROLLER.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_CLEAR_CONTROLLER']"
			[Register ("ON_CLEAR_CONTROLLER")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnClearController {
				get {
					const string __id = "ON_CLEAR_CONTROLLER.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_CLEAR_HIERARCHY']"
			[Register ("ON_CLEAR_HIERARCHY")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnClearHierarchy {
				get {
					const string __id = "ON_CLEAR_HIERARCHY.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_CLEAR_OLD_CONTROLLER']"
			[Register ("ON_CLEAR_OLD_CONTROLLER")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnClearOldController {
				get {
					const string __id = "ON_CLEAR_OLD_CONTROLLER.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_DATASOURCE_FAILURE']"
			[Register ("ON_DATASOURCE_FAILURE")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnDatasourceFailure {
				get {
					const string __id = "ON_DATASOURCE_FAILURE.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_DATASOURCE_FAILURE_INT']"
			[Register ("ON_DATASOURCE_FAILURE_INT")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnDatasourceFailureInt {
				get {
					const string __id = "ON_DATASOURCE_FAILURE_INT.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_DATASOURCE_RESULT']"
			[Register ("ON_DATASOURCE_RESULT")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnDatasourceResult {
				get {
					const string __id = "ON_DATASOURCE_RESULT.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_DATASOURCE_RESULT_INT']"
			[Register ("ON_DATASOURCE_RESULT_INT")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnDatasourceResultInt {
				get {
					const string __id = "ON_DATASOURCE_RESULT_INT.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_DATASOURCE_SUBMIT']"
			[Register ("ON_DATASOURCE_SUBMIT")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnDatasourceSubmit {
				get {
					const string __id = "ON_DATASOURCE_SUBMIT.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_DETACH_CONTROLLER']"
			[Register ("ON_DETACH_CONTROLLER")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnDetachController {
				get {
					const string __id = "ON_DETACH_CONTROLLER.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_DRAWABLE_HIDE']"
			[Register ("ON_DRAWABLE_HIDE")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnDrawableHide {
				get {
					const string __id = "ON_DRAWABLE_HIDE.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_DRAWABLE_SHOW']"
			[Register ("ON_DRAWABLE_SHOW")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnDrawableShow {
				get {
					const string __id = "ON_DRAWABLE_SHOW.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_HOLDER_ATTACH']"
			[Register ("ON_HOLDER_ATTACH")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnHolderAttach {
				get {
					const string __id = "ON_HOLDER_ATTACH.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_HOLDER_DETACH']"
			[Register ("ON_HOLDER_DETACH")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnHolderDetach {
				get {
					const string __id = "ON_HOLDER_DETACH.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_INIT_CONTROLLER']"
			[Register ("ON_INIT_CONTROLLER")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnInitController {
				get {
					const string __id = "ON_INIT_CONTROLLER.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_RELEASE_CONTROLLER']"
			[Register ("ON_RELEASE_CONTROLLER")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnReleaseController {
				get {
					const string __id = "ON_RELEASE_CONTROLLER.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_RUN_CLEAR_CONTROLLER']"
			[Register ("ON_RUN_CLEAR_CONTROLLER")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnRunClearController {
				get {
					const string __id = "ON_RUN_CLEAR_CONTROLLER.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_SAME_CONTROLLER_SKIPPED']"
			[Register ("ON_SAME_CONTROLLER_SKIPPED")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnSameControllerSkipped {
				get {
					const string __id = "ON_SAME_CONTROLLER_SKIPPED.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_SCHEDULE_CLEAR_CONTROLLER']"
			[Register ("ON_SCHEDULE_CLEAR_CONTROLLER")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnScheduleClearController {
				get {
					const string __id = "ON_SCHEDULE_CLEAR_CONTROLLER.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_SET_CONTROLLER']"
			[Register ("ON_SET_CONTROLLER")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnSetController {
				get {
					const string __id = "ON_SET_CONTROLLER.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_SET_HIERARCHY']"
			[Register ("ON_SET_HIERARCHY")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnSetHierarchy {
				get {
					const string __id = "ON_SET_HIERARCHY.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/field[@name='ON_SUBMIT_CACHE_HIT']"
			[Register ("ON_SUBMIT_CACHE_HIT")]
			public static global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event OnSubmitCacheHit {
				get {
					const string __id = "ON_SUBMIT_CACHE_HIT.Lcom/facebook/drawee/components/DraweeEventTracker$Event;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/components/DraweeEventTracker$Event", typeof (Event));
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

			internal Event (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/drawee/components/DraweeEventTracker$Event;", "")]
			public static unsafe global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/facebook/drawee/components/DraweeEventTracker$Event;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker.Event']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/drawee/components/DraweeEventTracker$Event;", "")]
			public static unsafe global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event[] Values ()
			{
				const string __id = "values.()[Lcom/facebook/drawee/components/DraweeEventTracker$Event;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/components/DraweeEventTracker", typeof (DraweeEventTracker));
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

		protected DraweeEventTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "")]
		public static unsafe void Disable ()
		{
			const string __id = "disable.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/facebook/drawee/components/DraweeEventTracker;", "")]
		public static unsafe global::Com.Facebook.Drawee.Components.DraweeEventTracker NewInstance ()
		{
			const string __id = "newInstance.()Lcom/facebook/drawee/components/DraweeEventTracker;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_recordEvent_Lcom_facebook_drawee_components_DraweeEventTracker_Event_;
#pragma warning disable 0169
		static Delegate GetRecordEvent_Lcom_facebook_drawee_components_DraweeEventTracker_Event_Handler ()
		{
			if (cb_recordEvent_Lcom_facebook_drawee_components_DraweeEventTracker_Event_ == null)
				cb_recordEvent_Lcom_facebook_drawee_components_DraweeEventTracker_Event_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RecordEvent_Lcom_facebook_drawee_components_DraweeEventTracker_Event_);
			return cb_recordEvent_Lcom_facebook_drawee_components_DraweeEventTracker_Event_;
		}

		static void n_RecordEvent_Lcom_facebook_drawee_components_DraweeEventTracker_Event_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Facebook.Drawee.Components.DraweeEventTracker __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event e = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.RecordEvent (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DraweeEventTracker']/method[@name='recordEvent' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.components.DraweeEventTracker.Event']]"
		[Register ("recordEvent", "(Lcom/facebook/drawee/components/DraweeEventTracker$Event;)V", "GetRecordEvent_Lcom_facebook_drawee_components_DraweeEventTracker_Event_Handler")]
		public virtual unsafe void RecordEvent (global::Com.Facebook.Drawee.Components.DraweeEventTracker.Event e)
		{
			const string __id = "recordEvent.(Lcom/facebook/drawee/components/DraweeEventTracker$Event;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
