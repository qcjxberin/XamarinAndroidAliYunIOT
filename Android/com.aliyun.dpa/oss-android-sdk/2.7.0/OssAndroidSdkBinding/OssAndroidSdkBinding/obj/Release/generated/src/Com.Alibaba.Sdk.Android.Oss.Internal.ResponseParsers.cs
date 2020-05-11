using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers", DoNotGenerateAcw=true)]
	public sealed partial class ResponseParsers : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.AbortMultipartUploadResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$AbortMultipartUploadResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class AbortMultipartUploadResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$AbortMultipartUploadResponseParser", typeof (AbortMultipartUploadResponseParser));
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

			internal AbortMultipartUploadResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.AbortMultipartUploadResponseParser']/constructor[@name='ResponseParsers.AbortMultipartUploadResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AbortMultipartUploadResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.AbortMultipartUploadResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.AbortMultipartUploadResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadResult;)Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadResult;)Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.AppendObjectResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$AppendObjectResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class AppendObjectResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$AppendObjectResponseParser", typeof (AppendObjectResponseParser));
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

			internal AppendObjectResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.AppendObjectResponseParser']/constructor[@name='ResponseParsers.AppendObjectResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AppendObjectResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.AppendObjectResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.AppendObjectResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/AppendObjectResult;)Lcom/alibaba/sdk/android/oss/model/AppendObjectResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/AppendObjectResult;)Lcom/alibaba/sdk/android/oss/model/AppendObjectResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.CompleteMultipartUploadResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$CompleteMultipartUploadResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class CompleteMultipartUploadResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$CompleteMultipartUploadResponseParser", typeof (CompleteMultipartUploadResponseParser));
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

			internal CompleteMultipartUploadResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.CompleteMultipartUploadResponseParser']/constructor[@name='ResponseParsers.CompleteMultipartUploadResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CompleteMultipartUploadResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.CompleteMultipartUploadResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.CompleteMultipartUploadResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.CopyObjectResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$CopyObjectResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class CopyObjectResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$CopyObjectResponseParser", typeof (CopyObjectResponseParser));
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

			internal CopyObjectResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.CopyObjectResponseParser']/constructor[@name='ResponseParsers.CopyObjectResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CopyObjectResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.CopyObjectResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.CopyObjectResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/CopyObjectResult;)Lcom/alibaba/sdk/android/oss/model/CopyObjectResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/CopyObjectResult;)Lcom/alibaba/sdk/android/oss/model/CopyObjectResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.CreateBucketResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$CreateBucketResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class CreateBucketResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$CreateBucketResponseParser", typeof (CreateBucketResponseParser));
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

			internal CreateBucketResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.CreateBucketResponseParser']/constructor[@name='ResponseParsers.CreateBucketResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CreateBucketResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.CreateBucketResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.CreateBucketResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/CreateBucketResult;)Lcom/alibaba/sdk/android/oss/model/CreateBucketResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/CreateBucketResult;)Lcom/alibaba/sdk/android/oss/model/CreateBucketResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.DeleteBucketResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$DeleteBucketResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class DeleteBucketResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$DeleteBucketResponseParser", typeof (DeleteBucketResponseParser));
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

			internal DeleteBucketResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.DeleteBucketResponseParser']/constructor[@name='ResponseParsers.DeleteBucketResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DeleteBucketResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.DeleteBucketResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.DeleteBucketResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/DeleteBucketResult;)Lcom/alibaba/sdk/android/oss/model/DeleteBucketResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/DeleteBucketResult;)Lcom/alibaba/sdk/android/oss/model/DeleteBucketResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.DeleteObjectResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$DeleteObjectResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class DeleteObjectResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$DeleteObjectResponseParser", typeof (DeleteObjectResponseParser));
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

			internal DeleteObjectResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.DeleteObjectResponseParser']/constructor[@name='ResponseParsers.DeleteObjectResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DeleteObjectResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.DeleteObjectResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.DeleteObjectResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/DeleteObjectResult;)Lcom/alibaba/sdk/android/oss/model/DeleteObjectResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/DeleteObjectResult;)Lcom/alibaba/sdk/android/oss/model/DeleteObjectResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.GetBucketACLResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$GetBucketACLResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class GetBucketACLResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$GetBucketACLResponseParser", typeof (GetBucketACLResponseParser));
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

			internal GetBucketACLResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.GetBucketACLResponseParser']/constructor[@name='ResponseParsers.GetBucketACLResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe GetBucketACLResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.GetBucketACLResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.GetBucketACLResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/GetBucketACLResult;)Lcom/alibaba/sdk/android/oss/model/GetBucketACLResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/GetBucketACLResult;)Lcom/alibaba/sdk/android/oss/model/GetBucketACLResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.GetObjectResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$GetObjectResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class GetObjectResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$GetObjectResponseParser", typeof (GetObjectResponseParser));
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

			internal GetObjectResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.GetObjectResponseParser']/constructor[@name='ResponseParsers.GetObjectResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe GetObjectResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.GetObjectResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.GetObjectResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/GetObjectResult;)Lcom/alibaba/sdk/android/oss/model/GetObjectResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/GetObjectResult;)Lcom/alibaba/sdk/android/oss/model/GetObjectResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.HeadObjectResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$HeadObjectResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class HeadObjectResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$HeadObjectResponseParser", typeof (HeadObjectResponseParser));
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

			internal HeadObjectResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.HeadObjectResponseParser']/constructor[@name='ResponseParsers.HeadObjectResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe HeadObjectResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.HeadObjectResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.HeadObjectResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/HeadObjectResult;)Lcom/alibaba/sdk/android/oss/model/HeadObjectResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/HeadObjectResult;)Lcom/alibaba/sdk/android/oss/model/HeadObjectResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.InitMultipartResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$InitMultipartResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class InitMultipartResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$InitMultipartResponseParser", typeof (InitMultipartResponseParser));
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

			internal InitMultipartResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.InitMultipartResponseParser']/constructor[@name='ResponseParsers.InitMultipartResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe InitMultipartResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.InitMultipartResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.InitiateMultipartUploadResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadResult;)Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadResult;)Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.ListObjectsResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$ListObjectsResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class ListObjectsResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$ListObjectsResponseParser", typeof (ListObjectsResponseParser));
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

			internal ListObjectsResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.ListObjectsResponseParser']/constructor[@name='ResponseParsers.ListObjectsResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ListObjectsResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.ListObjectsResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.ListObjectsResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/ListObjectsResult;)Lcom/alibaba/sdk/android/oss/model/ListObjectsResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/ListObjectsResult;)Lcom/alibaba/sdk/android/oss/model/ListObjectsResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.ListPartsResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$ListPartsResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class ListPartsResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$ListPartsResponseParser", typeof (ListPartsResponseParser));
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

			internal ListPartsResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.ListPartsResponseParser']/constructor[@name='ResponseParsers.ListPartsResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ListPartsResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.ListPartsResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.ListPartsResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/ListPartsResult;)Lcom/alibaba/sdk/android/oss/model/ListPartsResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/ListPartsResult;)Lcom/alibaba/sdk/android/oss/model/ListPartsResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.PutObjectResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$PutObjectResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class PutObjectResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$PutObjectResponseParser", typeof (PutObjectResponseParser));
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

			internal PutObjectResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.PutObjectResponseParser']/constructor[@name='ResponseParsers.PutObjectResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe PutObjectResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.PutObjectResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.PutObjectResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/PutObjectResult;)Lcom/alibaba/sdk/android/oss/model/PutObjectResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/PutObjectResult;)Lcom/alibaba/sdk/android/oss/model/PutObjectResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.TriggerCallbackResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$TriggerCallbackResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class TriggerCallbackResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$TriggerCallbackResponseParser", typeof (TriggerCallbackResponseParser));
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

			internal TriggerCallbackResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.TriggerCallbackResponseParser']/constructor[@name='ResponseParsers.TriggerCallbackResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe TriggerCallbackResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.TriggerCallbackResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.TriggerCallbackResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/TriggerCallbackResult;)Lcom/alibaba/sdk/android/oss/model/TriggerCallbackResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/TriggerCallbackResult;)Lcom/alibaba/sdk/android/oss/model/TriggerCallbackResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.UploadPartResponseParser']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/ResponseParsers$UploadPartResponseParser", DoNotGenerateAcw=true)]
		public sealed partial class UploadPartResponseParser : global::Com.Alibaba.Sdk.Android.Oss.Internal.AbstractResponseParser {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers$UploadPartResponseParser", typeof (UploadPartResponseParser));
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

			internal UploadPartResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.UploadPartResponseParser']/constructor[@name='ResponseParsers.UploadPartResponseParser' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe UploadPartResponseParser ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers.UploadPartResponseParser']/method[@name='parseData' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.UploadPartResult']]"
			[Register ("parseData", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/UploadPartResult;)Lcom/alibaba/sdk/android/oss/model/UploadPartResult;", "")]
			public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult ParseData (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult result)
			{
				const string __id = "parseData.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Lcom/alibaba/sdk/android/oss/model/UploadPartResult;)Lcom/alibaba/sdk/android/oss/model/UploadPartResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
					__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/ResponseParsers", typeof (ResponseParsers));
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

		internal ResponseParsers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers']/constructor[@name='ResponseParsers' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResponseParsers ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers']/method[@name='parseObjectMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("parseObjectMetadata", "(Ljava/util/Map;)Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata ParseObjectMetadata (global::System.Collections.Generic.IDictionary<string, string> headers)
		{
			const string __id = "parseObjectMetadata.(Ljava/util/Map;)Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers']/method[@name='parseResponseErrorXML' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.ResponseMessage'] and parameter[2][@type='boolean']]"
		[Register ("parseResponseErrorXML", "(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Z)Lcom/alibaba/sdk/android/oss/ServiceException;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.ServiceException ParseResponseErrorXML (global::Com.Alibaba.Sdk.Android.Oss.Internal.ResponseMessage response, bool isHeadRequest)
		{
			const string __id = "parseResponseErrorXML.(Lcom/alibaba/sdk/android/oss/internal/ResponseMessage;Z)Lcom/alibaba/sdk/android/oss/ServiceException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				__args [1] = new JniArgumentValue (isHeadRequest);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ServiceException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='ResponseParsers']/method[@name='trimQuotes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trimQuotes", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string TrimQuotes (string s)
		{
			const string __id = "trimQuotes.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

	}
}
