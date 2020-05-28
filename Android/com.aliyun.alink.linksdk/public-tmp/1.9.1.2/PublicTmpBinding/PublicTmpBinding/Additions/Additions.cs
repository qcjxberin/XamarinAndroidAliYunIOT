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
using GoogleGson;
using Java.Lang.Reflect;
using Com.Aliyun.Alink.Linksdk.Cmp.Core.Base;
using Com.Aliyun.Alink.Linksdk.Tools;

namespace Com.Aliyun.Alink.Linksdk.Tmp.Device.Panel.Listener 
{
    public partial class ConnectListenerWrapper 
    {
        public void OnIConnectSendListenerFailure(ARequest p0, AError p1) 
        {
            OnFailure(p0, p1);
        }
    }
    public partial class AlcsEventListenerWrapper
    {        
        public void OnDevListenerFail(global::Java.Lang.Object p0, global::Com.Aliyun.Alink.Linksdk.Tmp.Utils.ErrorInfo p1) 
        {
            OnFail(p0, p1);
        }

        public void OnDevListenerSuccess(global::Java.Lang.Object p0, global::Com.Aliyun.Alink.Linksdk.Tmp.Api.OutputParams p1)
        {
            OnSuccess(p0, p1);
        }

    }
}

namespace Com.Aliyun.Alink.Linksdk.Tmp.Device.Deviceshadow 
{
    public partial class TPropServiceHandler 
    {
        public void OnDevListenerFail(global::Java.Lang.Object p0, global::Com.Aliyun.Alink.Linksdk.Tmp.Utils.ErrorInfo p1) 
        {
            OnFail(p0, p1);
        }

        public void OnDevListenerSuccess(global::Java.Lang.Object p0, global::Com.Aliyun.Alink.Linksdk.Tmp.Api.OutputParams p1) 
        {
            OnSuccess(p0, p1);
        }
    }

    public partial class DeviceShadowRefreshListener 
    {
        public void OnProcessListenerFail(global::Com.Aliyun.Alink.Linksdk.Tmp.Utils.ErrorInfo p0)
        {
            OnFail(p0);
        }
    }
}

namespace Com.Aliyun.Alink.Linksdk.Tmp.Device.Payload.Discovery
{
    public partial class DiscoveryResponsePayload 
    {
        public partial class DiscoveryResponseDataDeserializer 
        {
            public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2) 
            {
                return RawDeserialize(p0, p1, p2);
            }
        }
    }
}

namespace Com.Aliyun.Alink.Linksdk.Tmp.Device.Payload 
{
    public partial class ValueWrapper 
    {
        public partial class ValueWrapperJsonSerializer
        {
            public JsonElement Serialize(Java.Lang.Object p0, IType p1, IJsonSerializationContext p2)
            {
                return Serialize(p0 as ValueWrapper, p1, p2);
            }
        }
        public partial class ValueWrapperJsonDeSerializer
        {
            public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2) 
            {
                return RawDeserialize(p0, p1, p2);
            }
        }
    }

    public partial class KeyValuePair 
    {
        public partial class KeyValuePairJsonSerializer 
        {
            public JsonElement Serialize(Java.Lang.Object p0, IType p1, IJsonSerializationContext p2) 
            {
                return Serialize(p0 as KeyValuePair, p1, p2);
            }
        }
        public partial class KeyValuePairJsonDeSerializer
        {
            public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
            {
                return RawDeserialize(p0, p1, p2);
            }
        }
    }

    public partial class ArgPair
    {
        public partial class ArgPairJsonDeSerializer 
        {
            public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
            {
                return RawDeserialize(p0, p1, p2);
            }
        }
        
    }

    public partial class CommonRequestPayload 
    {
        public partial class CommonRequestPayloadJsonDeSerializer 
        {
            public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2) 
            {
                return RawDeserialize(p0, p1, p2);
            }
        }
    }
}

namespace Com.Aliyun.Alink.Linksdk.Tmp.Config 
{
    public partial class ProvisionReceiver
    {
        public void OnDevListenerFail(global::Java.Lang.Object p0, global::Com.Aliyun.Alink.Linksdk.Tmp.Utils.ErrorInfo p1) 
        {
            OnFail(p0, p1);
        }

        public void OnDevListenerSuccess(global::Java.Lang.Object p0, global::Com.Aliyun.Alink.Linksdk.Tmp.Api.OutputParams p1) 
        {
            OnSuccess(p0, p1);
        }

    }
}

namespace Com.Aliyun.Alink.Linksdk.Tmp.Devicemodel.Loader 
{
    public partial class SingleExtendSerializer
    {
        public partial class DeserializeTask 
        {
            protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                var objectList = @params.ToList();
                var stringList = new List<string>();
                foreach (var item in objectList)
                {
                    stringList.Add((string)item);
                }
                return RawDoInBackground(stringList.ToArray());
            }
        }
    }
}

namespace Com.Aliyun.Alink.Linksdk.Tmp.Devicemodel
{
    public partial class Service 
    {
        public partial class ServiceJsonDeSerializer
        {
            public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2) 
            {
                return RawDeserialize(p0, p1, p2);
            }
        }
    }

    public partial class DataType
    {
        public partial class DataTypeJsonDeSerializer
        {
            public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2) 
            {
                return RawDeserialize(p0, p1, p2);
            }
        }
        public partial class DataTypeJsonSerializer
        {
            public JsonElement Serialize(Java.Lang.Object p0, IType p1, IJsonSerializationContext p2) 
            {
                return Serialize(p0 as DataType, p1, p2);
            }
        }
    }
}