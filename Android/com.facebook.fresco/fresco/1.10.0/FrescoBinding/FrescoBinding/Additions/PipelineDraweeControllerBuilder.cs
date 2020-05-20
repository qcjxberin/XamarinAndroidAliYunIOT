using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Facebook.Datasource;
using Com.Facebook.Drawee.Controller;
using Com.Facebook.Drawee.Interfaces;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline
{
    public partial class PipelineDraweeControllerBuilder : global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder
    {
        public override ISimpleDraweeControllerBuilder SetOldController(IDraweeController p0)
        {
            throw new NotImplementedException();
        }
        public override IDraweeController Build()
        {
            throw new NotImplementedException();
        }       
        public override ISimpleDraweeControllerBuilder SetCallerContext(Java.Lang.Object p0)
        {
            throw new NotImplementedException();
        }
        public override ISimpleDraweeControllerBuilder SetUri(Android.Net.Uri p0)
        {
            return RawSetUri(p0);
        }
        public override ISimpleDraweeControllerBuilder SetUri(string p0)
        {
            return RawSetUri(p0);
        }
        // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='obtainController' and count(parameter)=0]"
        [Register("obtainController", "()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeController;", "GetObtainControllerHandler")]
        public unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController RawObtainController()
        {
            const string __id = "obtainController.()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeController;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
        protected override AbstractDraweeController ObtainController()
        {
            return RawObtainController();
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='getDataSourceForRequest' and count(parameter)=5 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.imagepipeline.request.ImageRequest'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='com.facebook.drawee.controller.AbstractDraweeControllerBuilder.CacheLevel']]"
        [Register("getDataSourceForRequest", "(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;Lcom/facebook/imagepipeline/request/ImageRequest;Ljava/lang/Object;Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;)Lcom/facebook/datasource/DataSource;", "GetGetDataSourceForRequest_Lcom_facebook_drawee_interfaces_DraweeController_Ljava_lang_String_Lcom_facebook_imagepipeline_request_ImageRequest_Ljava_lang_Object_Lcom_facebook_drawee_controller_AbstractDraweeControllerBuilder_CacheLevel_Handler")]
        public unsafe global::Com.Facebook.Datasource.IDataSource RawGetDataSourceForRequest(global::Com.Facebook.Drawee.Interfaces.IDraweeController controller, string controllerId, global::Com.Facebook.Imagepipeline.Request.ImageRequest imageRequest, global::Java.Lang.Object callerContext, global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel cacheLevel)
        {
            const string __id = "getDataSourceForRequest.(Lcom/facebook/drawee/interfaces/DraweeController;Ljava/lang/String;Lcom/facebook/imagepipeline/request/ImageRequest;Ljava/lang/Object;Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;)Lcom/facebook/datasource/DataSource;";
            IntPtr native_controllerId = JNIEnv.NewString(controllerId);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[5];
                __args[0] = new JniArgumentValue((controller == null) ? IntPtr.Zero : ((global::Java.Lang.Object)controller).Handle);
                __args[1] = new JniArgumentValue(native_controllerId);
                __args[2] = new JniArgumentValue((imageRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object)imageRequest).Handle);
                __args[3] = new JniArgumentValue((callerContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object)callerContext).Handle);
                __args[4] = new JniArgumentValue((cacheLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object)cacheLevel).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Facebook.Datasource.IDataSource>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_controllerId);
            }
        }

        protected override IDataSource GetDataSourceForRequest(IDraweeController p0, string p1, Java.Lang.Object p2, Java.Lang.Object p3, CacheLevel p4)
        {
            return RawGetDataSourceForRequest(p0, p1, (global::Com.Facebook.Imagepipeline.Request.ImageRequest)p2, p3, p4);
        }
    }
}