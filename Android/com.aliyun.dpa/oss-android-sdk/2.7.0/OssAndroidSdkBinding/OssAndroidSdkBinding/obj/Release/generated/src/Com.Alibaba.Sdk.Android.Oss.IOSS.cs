using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']"
	[Register ("com/alibaba/sdk/android/oss/OSS", "", "Com.Alibaba.Sdk.Android.Oss.IOSSInvoker")]
	public partial interface IOSS : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='abortMultipartUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AbortMultipartUploadRequest']]"
		[Register ("abortMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadResult;", "GetAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadResult AbortMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='abortResumableUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest']]"
		[Register ("abortResumableUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)V", "GetAbortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		void AbortResumableUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='appendObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AppendObjectRequest']]"
		[Register ("appendObject", "(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;)Lcom/alibaba/sdk/android/oss/model/AppendObjectResult;", "GetAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult AppendObject (global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncAbortMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AbortMultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.AbortMultipartUploadRequest, com.alibaba.sdk.android.oss.model.AbortMultipartUploadResult&gt;']]"
		[Register ("asyncAbortMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncAbortMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncAppendObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.AppendObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.AppendObjectRequest, com.alibaba.sdk.android.oss.model.AppendObjectResult&gt;']]"
		[Register ("asyncAppendObject", "(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncAppendObject (global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncCompleteMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CompleteMultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.CompleteMultipartUploadRequest, com.alibaba.sdk.android.oss.model.CompleteMultipartUploadResult&gt;']]"
		[Register ("asyncCompleteMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncCompleteMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncCopyObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CopyObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.CopyObjectRequest, com.alibaba.sdk.android.oss.model.CopyObjectResult&gt;']]"
		[Register ("asyncCopyObject", "(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncCopyObject (global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncCreateBucket' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CreateBucketRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.CreateBucketRequest, com.alibaba.sdk.android.oss.model.CreateBucketResult&gt;']]"
		[Register ("asyncCreateBucket", "(Lcom/alibaba/sdk/android/oss/model/CreateBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncCreateBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncDeleteBucket' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.DeleteBucketRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.DeleteBucketRequest, com.alibaba.sdk.android.oss.model.DeleteBucketResult&gt;']]"
		[Register ("asyncDeleteBucket", "(Lcom/alibaba/sdk/android/oss/model/DeleteBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncDeleteBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncDeleteObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.DeleteObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.DeleteObjectRequest, com.alibaba.sdk.android.oss.model.DeleteObjectResult&gt;']]"
		[Register ("asyncDeleteObject", "(Lcom/alibaba/sdk/android/oss/model/DeleteObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncDeleteObject (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncGetBucketACL' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GetBucketACLRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.GetBucketACLRequest, com.alibaba.sdk.android.oss.model.GetBucketACLResult&gt;']]"
		[Register ("asyncGetBucketACL", "(Lcom/alibaba/sdk/android/oss/model/GetBucketACLRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncGetBucketACL (global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncGetObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GetObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.GetObjectRequest, com.alibaba.sdk.android.oss.model.GetObjectResult&gt;']]"
		[Register ("asyncGetObject", "(Lcom/alibaba/sdk/android/oss/model/GetObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncGetObject (global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncHeadObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.HeadObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.HeadObjectRequest, com.alibaba.sdk.android.oss.model.HeadObjectResult&gt;']]"
		[Register ("asyncHeadObject", "(Lcom/alibaba/sdk/android/oss/model/HeadObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncHeadObject (global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncInitMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.InitiateMultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.InitiateMultipartUploadRequest, com.alibaba.sdk.android.oss.model.InitiateMultipartUploadResult&gt;']]"
		[Register ("asyncInitMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncInitMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncListObjects' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListObjectsRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ListObjectsRequest, com.alibaba.sdk.android.oss.model.ListObjectsResult&gt;']]"
		[Register ("asyncListObjects", "(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncListObjects (global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncListParts' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListPartsRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ListPartsRequest, com.alibaba.sdk.android.oss.model.ListPartsResult&gt;']]"
		[Register ("asyncListParts", "(Lcom/alibaba/sdk/android/oss/model/ListPartsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncListParts (global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncMultipartUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.MultipartUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.MultipartUploadRequest, com.alibaba.sdk.android.oss.model.CompleteMultipartUploadResult&gt;']]"
		[Register ("asyncMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncPutObject' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.PutObjectRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.PutObjectRequest, com.alibaba.sdk.android.oss.model.PutObjectResult&gt;']]"
		[Register ("asyncPutObject", "(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncPutObject (global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncResumableUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ResumableUploadRequest, com.alibaba.sdk.android.oss.model.ResumableUploadResult&gt;']]"
		[Register ("asyncResumableUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncResumableUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncSequenceUpload' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.ResumableUploadRequest, com.alibaba.sdk.android.oss.model.ResumableUploadResult&gt;']]"
		[Register ("asyncSequenceUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncSequenceUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncTriggerCallback' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.TriggerCallbackRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.TriggerCallbackRequest, com.alibaba.sdk.android.oss.model.TriggerCallbackResult&gt;']]"
		[Register ("asyncTriggerCallback", "(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncTriggerCallback (global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='asyncUploadPart' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.UploadPartRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.callback.OSSCompletedCallback&lt;com.alibaba.sdk.android.oss.model.UploadPartRequest, com.alibaba.sdk.android.oss.model.UploadPartResult&gt;']]"
		[Register ("asyncUploadPart", "(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;", "GetAsyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncUploadPart (global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='completeMultipartUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CompleteMultipartUploadRequest']]"
		[Register ("completeMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;", "GetCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult CompleteMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='copyObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CopyObjectRequest']]"
		[Register ("copyObject", "(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;)Lcom/alibaba/sdk/android/oss/model/CopyObjectResult;", "GetCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult CopyObject (global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='createBucket' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CreateBucketRequest']]"
		[Register ("createBucket", "(Lcom/alibaba/sdk/android/oss/model/CreateBucketRequest;)Lcom/alibaba/sdk/android/oss/model/CreateBucketResult;", "GetCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketResult CreateBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='deleteBucket' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.DeleteBucketRequest']]"
		[Register ("deleteBucket", "(Lcom/alibaba/sdk/android/oss/model/DeleteBucketRequest;)Lcom/alibaba/sdk/android/oss/model/DeleteBucketResult;", "GetDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketResult DeleteBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='deleteObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.DeleteObjectRequest']]"
		[Register ("deleteObject", "(Lcom/alibaba/sdk/android/oss/model/DeleteObjectRequest;)Lcom/alibaba/sdk/android/oss/model/DeleteObjectResult;", "GetDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectResult DeleteObject (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='doesObjectExist' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("doesObjectExist", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetDoesObjectExist_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		bool DoesObjectExist (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='getBucketACL' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GetBucketACLRequest']]"
		[Register ("getBucketACL", "(Lcom/alibaba/sdk/android/oss/model/GetBucketACLRequest;)Lcom/alibaba/sdk/android/oss/model/GetBucketACLResult;", "GetGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult GetBucketACL (global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='getObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GetObjectRequest']]"
		[Register ("getObject", "(Lcom/alibaba/sdk/android/oss/model/GetObjectRequest;)Lcom/alibaba/sdk/android/oss/model/GetObjectResult;", "GetGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult GetObject (global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='headObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.HeadObjectRequest']]"
		[Register ("headObject", "(Lcom/alibaba/sdk/android/oss/model/HeadObjectRequest;)Lcom/alibaba/sdk/android/oss/model/HeadObjectResult;", "GetHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult HeadObject (global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='initMultipartUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.InitiateMultipartUploadRequest']]"
		[Register ("initMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadResult;", "GetInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadResult InitMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='listObjects' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListObjectsRequest']]"
		[Register ("listObjects", "(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;)Lcom/alibaba/sdk/android/oss/model/ListObjectsResult;", "GetListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult ListObjects (global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='listParts' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListPartsRequest']]"
		[Register ("listParts", "(Lcom/alibaba/sdk/android/oss/model/ListPartsRequest;)Lcom/alibaba/sdk/android/oss/model/ListPartsResult;", "GetListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult ListParts (global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='multipartUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.MultipartUploadRequest']]"
		[Register ("multipartUpload", "(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;", "GetMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult MultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='presignConstrainedObjectURL' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.GeneratePresignedUrlRequest']]"
		[Register ("presignConstrainedObjectURL", "(Lcom/alibaba/sdk/android/oss/model/GeneratePresignedUrlRequest;)Ljava/lang/String;", "GetPresignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		string PresignConstrainedObjectURL (global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='presignConstrainedObjectURL' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("presignConstrainedObjectURL", "(Ljava/lang/String;Ljava/lang/String;J)Ljava/lang/String;", "GetPresignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_JHandler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		string PresignConstrainedObjectURL (string p0, string p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='presignPublicObjectURL' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("presignPublicObjectURL", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetPresignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		string PresignPublicObjectURL (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='putObject' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.PutObjectRequest']]"
		[Register ("putObject", "(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;)Lcom/alibaba/sdk/android/oss/model/PutObjectResult;", "GetPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult PutObject (global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='resumableUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest']]"
		[Register ("resumableUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)Lcom/alibaba/sdk/android/oss/model/ResumableUploadResult;", "GetResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult ResumableUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='sequenceUpload' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ResumableUploadRequest']]"
		[Register ("sequenceUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)Lcom/alibaba/sdk/android/oss/model/ResumableUploadResult;", "GetSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult SequenceUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='triggerCallback' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.TriggerCallbackRequest']]"
		[Register ("triggerCallback", "(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;)Lcom/alibaba/sdk/android/oss/model/TriggerCallbackResult;", "GetTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult TriggerCallback (global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='updateCredentialProvider' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.common.auth.OSSCredentialProvider']]"
		[Register ("updateCredentialProvider", "(Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;)V", "GetUpdateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		void UpdateCredentialProvider (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss']/interface[@name='OSS']/method[@name='uploadPart' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.UploadPartRequest']]"
		[Register ("uploadPart", "(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;)Lcom/alibaba/sdk/android/oss/model/UploadPartResult;", "GetUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Handler:Com.Alibaba.Sdk.Android.Oss.IOSSInvoker, OssAndroidSdkBinding")]
		global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult UploadPart (global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest p0);

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/OSS", DoNotGenerateAcw=true)]
	internal partial class IOSSInvoker : global::Java.Lang.Object, IOSS {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/OSS", typeof (IOSSInvoker));

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

		public static IOSS GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSS> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.oss.OSS"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSSInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_;
#pragma warning disable 0169
		static Delegate GetAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Handler ()
		{
			if (cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_ == null)
				cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_);
			return cb_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_;
		}

		static IntPtr n_AbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AbortMultipartUpload (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadResult AbortMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest p0)
		{
			if (id_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_ == IntPtr.Zero)
				id_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_ = JNIEnv.GetMethodID (class_ref, "abortMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_abortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
#pragma warning disable 0169
		static Delegate GetAbortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler ()
		{
			if (cb_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ == null)
				cb_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AbortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_);
			return cb_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
		}

		static void n_AbortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AbortResumableUpload (p0);
		}
#pragma warning restore 0169

		IntPtr id_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
		public unsafe void AbortResumableUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0)
		{
			if (id_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ == IntPtr.Zero)
				id_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ = JNIEnv.GetMethodID (class_ref, "abortResumableUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_abortResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_, __args);
		}

		static Delegate cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_;
#pragma warning disable 0169
		static Delegate GetAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Handler ()
		{
			if (cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ == null)
				cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_);
			return cb_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_;
		}

		static IntPtr n_AppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult AppendObject (global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest p0)
		{
			if (id_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ == IntPtr.Zero)
				id_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_ = JNIEnv.GetMethodID (class_ref, "appendObject", "(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;)Lcom/alibaba/sdk/android/oss/model/AppendObjectResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncAbortMultipartUpload (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncAbortMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.AbortMultipartUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncAbortMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/AbortMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncAbortMultipartUpload_Lcom_alibaba_sdk_android_oss_model_AbortMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncAppendObject (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncAppendObject (global::Com.Alibaba.Sdk.Android.Oss.Model.AppendObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncAppendObject", "(Lcom/alibaba/sdk/android/oss/model/AppendObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncAppendObject_Lcom_alibaba_sdk_android_oss_model_AppendObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncCompleteMultipartUpload (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncCompleteMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncCompleteMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncCopyObject (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncCopyObject (global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncCopyObject", "(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncCreateBucket (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncCreateBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncCreateBucket", "(Lcom/alibaba/sdk/android/oss/model/CreateBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncDeleteBucket (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncDeleteBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncDeleteBucket", "(Lcom/alibaba/sdk/android/oss/model/DeleteBucketRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncDeleteObject (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncDeleteObject (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncDeleteObject", "(Lcom/alibaba/sdk/android/oss/model/DeleteObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncGetBucketACL (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncGetBucketACL (global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncGetBucketACL", "(Lcom/alibaba/sdk/android/oss/model/GetBucketACLRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncGetObject (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncGetObject (global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncGetObject", "(Lcom/alibaba/sdk/android/oss/model/GetObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncHeadObject (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncHeadObject (global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncHeadObject", "(Lcom/alibaba/sdk/android/oss/model/HeadObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncInitMultipartUpload (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncInitMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncInitMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncListObjects (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncListObjects (global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncListObjects", "(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncListParts (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncListParts (global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncListParts", "(Lcom/alibaba/sdk/android/oss/model/ListPartsRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncMultipartUpload (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncPutObject (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncPutObject (global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncPutObject", "(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncResumableUpload (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncResumableUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncResumableUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncSequenceUpload (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncSequenceUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncSequenceUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncTriggerCallback (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncTriggerCallback (global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncTriggerCallback", "(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_Handler ()
		{
			if (cb_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == null)
				cb_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_);
			return cb_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		}

		static IntPtr n_AsyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1 = (global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncUploadPart (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask AsyncUploadPart (global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest p0, global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback p1)
		{
			if (id_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ == IntPtr.Zero)
				id_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_ = JNIEnv.GetMethodID (class_ref, "asyncUploadPart", "(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;Lcom/alibaba/sdk/android/oss/callback/OSSCompletedCallback;)Lcom/alibaba/sdk/android/oss/internal/OSSAsyncTask;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Lcom_alibaba_sdk_android_oss_callback_OSSCompletedCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_;
#pragma warning disable 0169
		static Delegate GetCompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_Handler ()
		{
			if (cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ == null)
				cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_);
			return cb_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_;
		}

		static IntPtr n_CompleteMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CompleteMultipartUpload (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult CompleteMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadRequest p0)
		{
			if (id_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ == IntPtr.Zero)
				id_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_ = JNIEnv.GetMethodID (class_ref, "completeMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_completeMultipartUpload_Lcom_alibaba_sdk_android_oss_model_CompleteMultipartUploadRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_;
#pragma warning disable 0169
		static Delegate GetCopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_Handler ()
		{
			if (cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_ == null)
				cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_);
			return cb_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_;
		}

		static IntPtr n_CopyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CopyObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult CopyObject (global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest p0)
		{
			if (id_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_ == IntPtr.Zero)
				id_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_ = JNIEnv.GetMethodID (class_ref, "copyObject", "(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;)Lcom/alibaba/sdk/android/oss/model/CopyObjectResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copyObject_Lcom_alibaba_sdk_android_oss_model_CopyObjectRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_;
#pragma warning disable 0169
		static Delegate GetCreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_Handler ()
		{
			if (cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_ == null)
				cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_);
			return cb_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_;
		}

		static IntPtr n_CreateBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateBucket (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketResult CreateBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketRequest p0)
		{
			if (id_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_ == IntPtr.Zero)
				id_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_ = JNIEnv.GetMethodID (class_ref, "createBucket", "(Lcom/alibaba/sdk/android/oss/model/CreateBucketRequest;)Lcom/alibaba/sdk/android/oss/model/CreateBucketResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CreateBucketResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createBucket_Lcom_alibaba_sdk_android_oss_model_CreateBucketRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_;
#pragma warning disable 0169
		static Delegate GetDeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_Handler ()
		{
			if (cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_ == null)
				cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_);
			return cb_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_;
		}

		static IntPtr n_DeleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteBucket (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketResult DeleteBucket (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketRequest p0)
		{
			if (id_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_ == IntPtr.Zero)
				id_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_ = JNIEnv.GetMethodID (class_ref, "deleteBucket", "(Lcom/alibaba/sdk/android/oss/model/DeleteBucketRequest;)Lcom/alibaba/sdk/android/oss/model/DeleteBucketResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteBucketResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteBucket_Lcom_alibaba_sdk_android_oss_model_DeleteBucketRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_;
#pragma warning disable 0169
		static Delegate GetDeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_Handler ()
		{
			if (cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_ == null)
				cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_);
			return cb_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_;
		}

		static IntPtr n_DeleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectResult DeleteObject (global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectRequest p0)
		{
			if (id_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_ == IntPtr.Zero)
				id_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_ = JNIEnv.GetMethodID (class_ref, "deleteObject", "(Lcom/alibaba/sdk/android/oss/model/DeleteObjectRequest;)Lcom/alibaba/sdk/android/oss/model/DeleteObjectResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.DeleteObjectResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteObject_Lcom_alibaba_sdk_android_oss_model_DeleteObjectRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_doesObjectExist_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoesObjectExist_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_doesObjectExist_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_doesObjectExist_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_DoesObjectExist_Ljava_lang_String_Ljava_lang_String_);
			return cb_doesObjectExist_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_DoesObjectExist_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DoesObjectExist (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_doesObjectExist_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool DoesObjectExist (string p0, string p1)
		{
			if (id_doesObjectExist_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_doesObjectExist_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doesObjectExist", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_doesObjectExist_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_;
#pragma warning disable 0169
		static Delegate GetGetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_Handler ()
		{
			if (cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_ == null)
				cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_);
			return cb_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_;
		}

		static IntPtr n_GetBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBucketACL (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult GetBucketACL (global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLRequest p0)
		{
			if (id_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_ == IntPtr.Zero)
				id_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_ = JNIEnv.GetMethodID (class_ref, "getBucketACL", "(Lcom/alibaba/sdk/android/oss/model/GetBucketACLRequest;)Lcom/alibaba/sdk/android/oss/model/GetBucketACLResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetBucketACLResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBucketACL_Lcom_alibaba_sdk_android_oss_model_GetBucketACLRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_;
#pragma warning disable 0169
		static Delegate GetGetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_Handler ()
		{
			if (cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_ == null)
				cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_);
			return cb_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_;
		}

		static IntPtr n_GetObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult GetObject (global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectRequest p0)
		{
			if (id_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_ == IntPtr.Zero)
				id_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_ = JNIEnv.GetMethodID (class_ref, "getObject", "(Lcom/alibaba/sdk/android/oss/model/GetObjectRequest;)Lcom/alibaba/sdk/android/oss/model/GetObjectResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GetObjectResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObject_Lcom_alibaba_sdk_android_oss_model_GetObjectRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_;
#pragma warning disable 0169
		static Delegate GetHeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_Handler ()
		{
			if (cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_ == null)
				cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_);
			return cb_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_;
		}

		static IntPtr n_HeadObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HeadObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult HeadObject (global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectRequest p0)
		{
			if (id_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_ == IntPtr.Zero)
				id_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_ = JNIEnv.GetMethodID (class_ref, "headObject", "(Lcom/alibaba/sdk/android/oss/model/HeadObjectRequest;)Lcom/alibaba/sdk/android/oss/model/HeadObjectResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.HeadObjectResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headObject_Lcom_alibaba_sdk_android_oss_model_HeadObjectRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_;
#pragma warning disable 0169
		static Delegate GetInitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_Handler ()
		{
			if (cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_ == null)
				cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_);
			return cb_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_;
		}

		static IntPtr n_InitMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InitMultipartUpload (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadResult InitMultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadRequest p0)
		{
			if (id_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_ == IntPtr.Zero)
				id_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_ = JNIEnv.GetMethodID (class_ref, "initMultipartUpload", "(Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/InitiateMultipartUploadResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.InitiateMultipartUploadResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initMultipartUpload_Lcom_alibaba_sdk_android_oss_model_InitiateMultipartUploadRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_;
#pragma warning disable 0169
		static Delegate GetListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_Handler ()
		{
			if (cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_ == null)
				cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_);
			return cb_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_;
		}

		static IntPtr n_ListObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListObjects (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult ListObjects (global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest p0)
		{
			if (id_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_ == IntPtr.Zero)
				id_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_ = JNIEnv.GetMethodID (class_ref, "listObjects", "(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;)Lcom/alibaba/sdk/android/oss/model/ListObjectsResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_listObjects_Lcom_alibaba_sdk_android_oss_model_ListObjectsRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_;
#pragma warning disable 0169
		static Delegate GetListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_Handler ()
		{
			if (cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_ == null)
				cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_);
			return cb_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_;
		}

		static IntPtr n_ListParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListParts (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult ListParts (global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsRequest p0)
		{
			if (id_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_ == IntPtr.Zero)
				id_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_ = JNIEnv.GetMethodID (class_ref, "listParts", "(Lcom/alibaba/sdk/android/oss/model/ListPartsRequest;)Lcom/alibaba/sdk/android/oss/model/ListPartsResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ListPartsResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_listParts_Lcom_alibaba_sdk_android_oss_model_ListPartsRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_;
#pragma warning disable 0169
		static Delegate GetMultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_Handler ()
		{
			if (cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_ == null)
				cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_);
			return cb_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_;
		}

		static IntPtr n_MultipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MultipartUpload (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult MultipartUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.MultipartUploadRequest p0)
		{
			if (id_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_ == IntPtr.Zero)
				id_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_ = JNIEnv.GetMethodID (class_ref, "multipartUpload", "(Lcom/alibaba/sdk/android/oss/model/MultipartUploadRequest;)Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_multipartUpload_Lcom_alibaba_sdk_android_oss_model_MultipartUploadRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_;
#pragma warning disable 0169
		static Delegate GetPresignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_Handler ()
		{
			if (cb_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ == null)
				cb_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PresignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_);
			return cb_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_;
		}

		static IntPtr n_PresignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PresignConstrainedObjectURL (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_;
		public unsafe string PresignConstrainedObjectURL (global::Com.Alibaba.Sdk.Android.Oss.Model.GeneratePresignedUrlRequest p0)
		{
			if (id_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ == IntPtr.Zero)
				id_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_ = JNIEnv.GetMethodID (class_ref, "presignConstrainedObjectURL", "(Lcom/alibaba/sdk/android/oss/model/GeneratePresignedUrlRequest;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_presignConstrainedObjectURL_Lcom_alibaba_sdk_android_oss_model_GeneratePresignedUrlRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPresignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_PresignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J);
			return cb_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J;
		}

		static IntPtr n_PresignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PresignConstrainedObjectURL (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J;
		public unsafe string PresignConstrainedObjectURL (string p0, string p1, long p2)
		{
			if (id_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "presignConstrainedObjectURL", "(Ljava/lang/String;Ljava/lang/String;J)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_presignConstrainedObjectURL_Ljava_lang_String_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPresignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PresignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_);
			return cb_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PresignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PresignPublicObjectURL (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string PresignPublicObjectURL (string p0, string p1)
		{
			if (id_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "presignPublicObjectURL", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_presignPublicObjectURL_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_;
#pragma warning disable 0169
		static Delegate GetPutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_Handler ()
		{
			if (cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ == null)
				cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_);
			return cb_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_;
		}

		static IntPtr n_PutObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult PutObject (global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectRequest p0)
		{
			if (id_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ == IntPtr.Zero)
				id_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_ = JNIEnv.GetMethodID (class_ref, "putObject", "(Lcom/alibaba/sdk/android/oss/model/PutObjectRequest;)Lcom/alibaba/sdk/android/oss/model/PutObjectResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.PutObjectResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_putObject_Lcom_alibaba_sdk_android_oss_model_PutObjectRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
#pragma warning disable 0169
		static Delegate GetResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler ()
		{
			if (cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ == null)
				cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_);
			return cb_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
		}

		static IntPtr n_ResumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResumableUpload (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult ResumableUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0)
		{
			if (id_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ == IntPtr.Zero)
				id_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ = JNIEnv.GetMethodID (class_ref, "resumableUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)Lcom/alibaba/sdk/android/oss/model/ResumableUploadResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_resumableUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
#pragma warning disable 0169
		static Delegate GetSequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_Handler ()
		{
			if (cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ == null)
				cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_);
			return cb_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
		}

		static IntPtr n_SequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SequenceUpload (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult SequenceUpload (global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadRequest p0)
		{
			if (id_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ == IntPtr.Zero)
				id_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_ = JNIEnv.GetMethodID (class_ref, "sequenceUpload", "(Lcom/alibaba/sdk/android/oss/model/ResumableUploadRequest;)Lcom/alibaba/sdk/android/oss/model/ResumableUploadResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.ResumableUploadResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sequenceUpload_Lcom_alibaba_sdk_android_oss_model_ResumableUploadRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_;
#pragma warning disable 0169
		static Delegate GetTriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_Handler ()
		{
			if (cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ == null)
				cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_);
			return cb_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_;
		}

		static IntPtr n_TriggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TriggerCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult TriggerCallback (global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackRequest p0)
		{
			if (id_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ == IntPtr.Zero)
				id_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_ = JNIEnv.GetMethodID (class_ref, "triggerCallback", "(Lcom/alibaba/sdk/android/oss/model/TriggerCallbackRequest;)Lcom/alibaba/sdk/android/oss/model/TriggerCallbackResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.TriggerCallbackResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_triggerCallback_Lcom_alibaba_sdk_android_oss_model_TriggerCallbackRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_;
#pragma warning disable 0169
		static Delegate GetUpdateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_Handler ()
		{
			if (cb_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ == null)
				cb_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_);
			return cb_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_;
		}

		static void n_UpdateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider p0 = (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCredentialProvider (p0);
		}
#pragma warning restore 0169

		IntPtr id_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_;
		public unsafe void UpdateCredentialProvider (global::Com.Alibaba.Sdk.Android.Oss.Common.Auth.IOSSCredentialProvider p0)
		{
			if (id_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ == IntPtr.Zero)
				id_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_ = JNIEnv.GetMethodID (class_ref, "updateCredentialProvider", "(Lcom/alibaba/sdk/android/oss/common/auth/OSSCredentialProvider;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateCredentialProvider_Lcom_alibaba_sdk_android_oss_common_auth_OSSCredentialProvider_, __args);
		}

		static Delegate cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_;
#pragma warning disable 0169
		static Delegate GetUploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_Handler ()
		{
			if (cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ == null)
				cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_);
			return cb_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_;
		}

		static IntPtr n_UploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Oss.IOSS __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.IOSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UploadPart (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_;
		public unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult UploadPart (global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartRequest p0)
		{
			if (id_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ == IntPtr.Zero)
				id_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_ = JNIEnv.GetMethodID (class_ref, "uploadPart", "(Lcom/alibaba/sdk/android/oss/model/UploadPartRequest;)Lcom/alibaba/sdk/android/oss/model/UploadPartResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.UploadPartResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_uploadPart_Lcom_alibaba_sdk_android_oss_model_UploadPartRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
