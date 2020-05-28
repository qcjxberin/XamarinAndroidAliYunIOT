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

namespace Com.Alibaba.Sdk.Android.Openaccount.Executor.Impl 
{
    public sealed partial class ExecutorServiceImpl 
    {
        public Java.Lang.Object InvokeAny(System.Collections.ICollection tasks) 
        {
            var para = tasks as ICollection<Java.Util.Concurrent.ICallable>;
            var result = InvokeAny(para);
            return result;
        }

        public Java.Lang.Object InvokeAny(System.Collections.ICollection tasks, long timeout, Java.Util.Concurrent.TimeUnit unit) 
        {
            var para = tasks as ICollection<Java.Util.Concurrent.ICallable>;
            var result = InvokeAny(para, timeout, unit);
            return result;
        }

        public System.Collections.IList InvokeAll(System.Collections.ICollection tasks) 
        {
            var para = tasks as ICollection<Java.Util.Concurrent.ICallable>;
            var result = InvokeAll(para) as System.Collections.IList;
            return result;
        }

        public System.Collections.IList InvokeAll(System.Collections.ICollection tasks, long timeout, Java.Util.Concurrent.TimeUnit unit) 
        {
            var para = tasks as ICollection<Java.Util.Concurrent.ICallable>;
            var result = InvokeAll(para,timeout,unit) as System.Collections.IList;
            return result;
        }
    }
}

namespace Com.Alibaba.Sdk.Android.Openaccount.Task
{
    public partial class InitWaitTask 
    {
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
}

namespace Com.Alibaba.Sdk.Android.Oauth 
{
    public partial class OauthQueryTask 
    {
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }

    public partial class BindByOauthTask 
    {
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
    public partial class LoginByOauthTask 
    {
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
}

namespace Com.Alibaba.Sdk.Android.Openaccount.Config 
{
    public partial class DynamicConfigInitHandler 
    {
        public global::Java.Lang.Object CreateRequestParameters() 
        {
            return RawCreateRequestParameters();
        }
    }
}

namespace Com.Alibaba.Sdk.Android.Oauth.Alipay
{
    public partial class GetAlipaySignTask
    {
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
}