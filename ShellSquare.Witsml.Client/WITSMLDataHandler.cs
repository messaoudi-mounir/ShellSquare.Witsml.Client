﻿using System;
using System.Web.Services;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace ShellSquare.Witsml.Client
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "Primary", Namespace = "http://www.witsml.org/message/120")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LastValueResultType[]))]
    public class WITSMLDataHandler : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        private System.Threading.SendOrPostCallback WMLS_GetCapOperationCompleted;

        private System.Threading.SendOrPostCallback WMLS_GetVersionOperationCompleted;

        private System.Threading.SendOrPostCallback WMLS_GetBaseMsgOperationCompleted;

        private System.Threading.SendOrPostCallback WMLS_AddToStoreOperationCompleted;

        private System.Threading.SendOrPostCallback WMLS_GetFromStoreOperationCompleted;

        private System.Threading.SendOrPostCallback WMLS_DeleteFromStoreOperationCompleted;

        private System.Threading.SendOrPostCallback WMLS_UpdateInStoreOperationCompleted;

        /// <summary>
        /// For setting Basic authentication in header
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        protected override System.Net.WebRequest GetWebRequest(Uri uri)
        {
            HttpWebRequest request;
            request = (HttpWebRequest)base.GetWebRequest(uri);

            if (PreAuthenticate)
            {
                NetworkCredential networkCredentials =
                Credentials.GetCredential(uri, "Basic");

                if (networkCredentials != null)
                {
                    byte[] credentialBuffer = new UTF8Encoding().GetBytes(
                    networkCredentials.UserName + ":" +
                    networkCredentials.Password);
                    request.Headers["Authorization"] =
                    "Basic " + Convert.ToBase64String(credentialBuffer);
                }
                else
                {
                    throw new ApplicationException("No network credentials");
                }
            }
            return request;
        }

        public WITSMLDataHandler(string url, string username, string password)
        {
            this.Url = url;
            // Create a new instance of NetworkCredential using the client credentials.
            this.PreAuthenticate = true;
            NetworkCredential netCredential = new NetworkCredential(username, password);
            Uri uri = new Uri(url);
            ICredentials credentials = netCredential.GetCredential(uri, "Basic");
            this.Credentials = credentials;
        }
        /// <remarks/>
        public event WMLS_GetCapCompletedEventHandler WMLS_GetCapCompleted;

        /// <remarks/>
        public event WMLS_GetVersionCompletedEventHandler WMLS_GetVersionCompleted;

        /// <remarks/>
        public event WMLS_GetBaseMsgCompletedEventHandler WMLS_GetBaseMsgCompleted;

        /// <remarks/>
        public event WMLS_AddToStoreCompletedEventHandler WMLS_AddToStoreCompleted;

        /// <remarks/>
        public event WMLS_GetFromStoreCompletedEventHandler WMLS_GetFromStoreCompleted;

        /// <remarks/>
        public event WMLS_DeleteFromStoreCompletedEventHandler WMLS_DeleteFromStoreCompleted;

        /// <remarks/>
        public event WMLS_UpdateInStoreCompletedEventHandler WMLS_UpdateInStoreCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_GetCap", RequestNamespace = "http://www.witsml.org/message/120", ResponseNamespace = "http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public short WMLS_GetCap(string OptionsIn, out string CapabilitiesOut, out string SuppMsgOut)
        {
            object[] results = this.Invoke("WMLS_GetCap", new object[] {
                        OptionsIn});
            CapabilitiesOut = ((string)(results[1]));
            SuppMsgOut = ((string)(results[2]));
            return ((short)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginWMLS_GetCap(string OptionsIn, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("WMLS_GetCap", new object[] {
                        OptionsIn}, callback, asyncState);
        }

        /// <remarks/>
        public short EndWMLS_GetCap(System.IAsyncResult asyncResult, out string CapabilitiesOut, out string SuppMsgOut)
        {
            object[] results = this.EndInvoke(asyncResult);
            CapabilitiesOut = ((string)(results[1]));
            SuppMsgOut = ((string)(results[2]));
            return ((short)(results[0]));
        }

        /// <remarks/>
        public void WMLS_GetCapAsync(string OptionsIn)
        {
            this.WMLS_GetCapAsync(OptionsIn, null);
        }

        /// <remarks/>
        public void WMLS_GetCapAsync(string OptionsIn, object userState)
        {
            if ((this.WMLS_GetCapOperationCompleted == null))
            {
                this.WMLS_GetCapOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_GetCapOperationCompleted);
            }
            this.InvokeAsync("WMLS_GetCap", new object[] {
                        OptionsIn}, this.WMLS_GetCapOperationCompleted, userState);
        }

        private void OnWMLS_GetCapOperationCompleted(object arg)
        {
            if ((this.WMLS_GetCapCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_GetCapCompleted(this, new WMLS_GetCapCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_GetVersion", RequestNamespace = "http://www.witsml.org/message/120", ResponseNamespace = "http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public string WMLS_GetVersion()
        {
            object[] results = this.Invoke("WMLS_GetVersion", new object[0]);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginWMLS_GetVersion(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("WMLS_GetVersion", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string EndWMLS_GetVersion(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void WMLS_GetVersionAsync()
        {
            this.WMLS_GetVersionAsync(null);
        }

        /// <remarks/>
        public void WMLS_GetVersionAsync(object userState)
        {
            if ((this.WMLS_GetVersionOperationCompleted == null))
            {
                this.WMLS_GetVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_GetVersionOperationCompleted);
            }
            this.InvokeAsync("WMLS_GetVersion", new object[0], this.WMLS_GetVersionOperationCompleted, userState);
        }

        private void OnWMLS_GetVersionOperationCompleted(object arg)
        {
            if ((this.WMLS_GetVersionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_GetVersionCompleted(this, new WMLS_GetVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_GetBaseMsg", RequestNamespace = "http://www.witsml.org/message/120", ResponseNamespace = "http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public string WMLS_GetBaseMsg(short ReturnValueIn)
        {
            object[] results = this.Invoke("WMLS_GetBaseMsg", new object[] {
                        ReturnValueIn});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginWMLS_GetBaseMsg(short ReturnValueIn, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("WMLS_GetBaseMsg", new object[] {
                        ReturnValueIn}, callback, asyncState);
        }

        /// <remarks/>
        public string EndWMLS_GetBaseMsg(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void WMLS_GetBaseMsgAsync(short ReturnValueIn)
        {
            this.WMLS_GetBaseMsgAsync(ReturnValueIn, null);
        }

        /// <remarks/>
        public void WMLS_GetBaseMsgAsync(short ReturnValueIn, object userState)
        {
            if ((this.WMLS_GetBaseMsgOperationCompleted == null))
            {
                this.WMLS_GetBaseMsgOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_GetBaseMsgOperationCompleted);
            }
            this.InvokeAsync("WMLS_GetBaseMsg", new object[] {
                        ReturnValueIn}, this.WMLS_GetBaseMsgOperationCompleted, userState);
        }

        private void OnWMLS_GetBaseMsgOperationCompleted(object arg)
        {
            if ((this.WMLS_GetBaseMsgCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_GetBaseMsgCompleted(this, new WMLS_GetBaseMsgCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_AddToStore", RequestNamespace = "http://www.witsml.org/message/120", ResponseNamespace = "http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public short WMLS_AddToStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut)
        {
            object[] results = this.Invoke("WMLS_AddToStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn});
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginWMLS_AddToStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("WMLS_AddToStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn}, callback, asyncState);
        }

        /// <remarks/>
        public short EndWMLS_AddToStore(System.IAsyncResult asyncResult, out string SuppMsgOut)
        {
            object[] results = this.EndInvoke(asyncResult);
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }

        /// <remarks/>
        public void WMLS_AddToStoreAsync(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn)
        {
            this.WMLS_AddToStoreAsync(WMLtypeIn, XMLin, OptionsIn, CapabilitiesIn, null);
        }

        /// <remarks/>
        public void WMLS_AddToStoreAsync(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, object userState)
        {
            if ((this.WMLS_AddToStoreOperationCompleted == null))
            {
                this.WMLS_AddToStoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_AddToStoreOperationCompleted);
            }
            this.InvokeAsync("WMLS_AddToStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn}, this.WMLS_AddToStoreOperationCompleted, userState);
        }

        private void OnWMLS_AddToStoreOperationCompleted(object arg)
        {
            if ((this.WMLS_AddToStoreCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_AddToStoreCompleted(this, new WMLS_AddToStoreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_GetFromStore", RequestNamespace = "http://www.witsml.org/message/120", ResponseNamespace = "http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public short WMLS_GetFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, out string XMLout, out string SuppMsgOut)
        {
            object[] results = this.Invoke("WMLS_GetFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn});
            XMLout = ((string)(results[1]));
            SuppMsgOut = ((string)(results[2]));
            return ((short)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginWMLS_GetFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("WMLS_GetFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn}, callback, asyncState);
        }

        /// <remarks/>
        public short EndWMLS_GetFromStore(System.IAsyncResult asyncResult, out string XMLout, out string SuppMsgOut)
        {
            object[] results = this.EndInvoke(asyncResult);
            XMLout = ((string)(results[1]));
            SuppMsgOut = ((string)(results[2]));
            return ((short)(results[0]));
        }

        /// <remarks/>
        public void WMLS_GetFromStoreAsync(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn)
        {
            this.WMLS_GetFromStoreAsync(WMLtypeIn, QueryIn, OptionsIn, CapabilitiesIn, null);
        }

        /// <remarks/>
        public void WMLS_GetFromStoreAsync(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, object userState)
        {
            if ((this.WMLS_GetFromStoreOperationCompleted == null))
            {
                this.WMLS_GetFromStoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_GetFromStoreOperationCompleted);
            }
            this.InvokeAsync("WMLS_GetFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn}, this.WMLS_GetFromStoreOperationCompleted, userState);
        }

        private void OnWMLS_GetFromStoreOperationCompleted(object arg)
        {
            if ((this.WMLS_GetFromStoreCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_GetFromStoreCompleted(this, new WMLS_GetFromStoreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_DeleteFromStore", RequestNamespace = "http://www.witsml.org/message/120", ResponseNamespace = "http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public short WMLS_DeleteFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut)
        {
            object[] results = this.Invoke("WMLS_DeleteFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn});
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginWMLS_DeleteFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("WMLS_DeleteFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn}, callback, asyncState);
        }

        /// <remarks/>
        public short EndWMLS_DeleteFromStore(System.IAsyncResult asyncResult, out string SuppMsgOut)
        {
            object[] results = this.EndInvoke(asyncResult);
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }

        /// <remarks/>
        public void WMLS_DeleteFromStoreAsync(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn)
        {
            this.WMLS_DeleteFromStoreAsync(WMLtypeIn, QueryIn, OptionsIn, CapabilitiesIn, null);
        }

        /// <remarks/>
        public void WMLS_DeleteFromStoreAsync(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, object userState)
        {
            if ((this.WMLS_DeleteFromStoreOperationCompleted == null))
            {
                this.WMLS_DeleteFromStoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_DeleteFromStoreOperationCompleted);
            }
            this.InvokeAsync("WMLS_DeleteFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn}, this.WMLS_DeleteFromStoreOperationCompleted, userState);
        }

        private void OnWMLS_DeleteFromStoreOperationCompleted(object arg)
        {
            if ((this.WMLS_DeleteFromStoreCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_DeleteFromStoreCompleted(this, new WMLS_DeleteFromStoreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_UpdateInStore", RequestNamespace = "http://www.witsml.org/message/120", ResponseNamespace = "http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public short WMLS_UpdateInStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut)
        {
            object[] results = this.Invoke("WMLS_UpdateInStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn});
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginWMLS_UpdateInStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("WMLS_UpdateInStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn}, callback, asyncState);
        }

        /// <remarks/>
        public short EndWMLS_UpdateInStore(System.IAsyncResult asyncResult, out string SuppMsgOut)
        {
            object[] results = this.EndInvoke(asyncResult);
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }

        /// <remarks/>
        public void WMLS_UpdateInStoreAsync(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn)
        {
            this.WMLS_UpdateInStoreAsync(WMLtypeIn, XMLin, OptionsIn, CapabilitiesIn, null);
        }

        /// <remarks/>
        public void WMLS_UpdateInStoreAsync(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, object userState)
        {
            if ((this.WMLS_UpdateInStoreOperationCompleted == null))
            {
                this.WMLS_UpdateInStoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_UpdateInStoreOperationCompleted);
            }
            this.InvokeAsync("WMLS_UpdateInStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn}, this.WMLS_UpdateInStoreOperationCompleted, userState);
        }

        private void OnWMLS_UpdateInStoreOperationCompleted(object arg)
        {
            if ((this.WMLS_UpdateInStoreCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_UpdateInStoreCompleted(this, new WMLS_UpdateInStoreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }
}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/System")]
    public partial class Version
    {

        private int _BuildField;

        private int _MajorField;

        private int _MinorField;

        private int _RevisionField;

        /// <remarks/>
        public int _Build
        {
            get
            {
                return this._BuildField;
            }
            set
            {
                this._BuildField = value;
            }
        }

        /// <remarks/>
        public int _Major
        {
            get
            {
                return this._MajorField;
            }
            set
            {
                this._MajorField = value;
            }
        }

        /// <remarks/>
        public int _Minor
        {
            get
            {
                return this._MinorField;
            }
            set
            {
                this._MinorField = value;
            }
        }

        /// <remarks/>
        public int _Revision
        {
            get
            {
                return this._RevisionField;
            }
            set
            {
                this._RevisionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.witsml.org/message/120")]
    public partial class PermissionInfo
    {

        private WITSMLObjectInfo objectInfoField;

        private AccessType[] accessTypeListField;

        /// <remarks/>
        public WITSMLObjectInfo ObjectInfo
        {
            get
            {
                return this.objectInfoField;
            }
            set
            {
                this.objectInfoField = value;
            }
        }

        /// <remarks/>
        public AccessType[] AccessTypeList
        {
            get
            {
                return this.accessTypeListField;
            }
            set
            {
                this.accessTypeListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.witsml.org/message/120")]
    public partial class WITSMLObjectInfo
    {

        private string uidWellField;

        private string uidWellboreField;

        private string uidField;

        private string objectTypeField;

        /// <remarks/>
        public string UidWell
        {
            get
            {
                return this.uidWellField;
            }
            set
            {
                this.uidWellField = value;
            }
        }

        /// <remarks/>
        public string UidWellbore
        {
            get
            {
                return this.uidWellboreField;
            }
            set
            {
                this.uidWellboreField = value;
            }
        }

        /// <remarks/>
        public string Uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }

        /// <remarks/>
        public string ObjectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.witsml.org/message/120")]
    public enum AccessType
    {

        /// <remarks/>
        GET,

        /// <remarks/>
        ADD,

        /// <remarks/>
        UPDATE,

        /// <remarks/>
        DELETE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.witsml.org/message/120")]
    public partial class UserAccessInfo
    {

        private long idField;

        private bool hasCurveFilterField;

        private bool hasGetAccessToLogField;

        private bool hasGetAccessToRealtimeField;

        /// <remarks/>
        public long Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public bool HasCurveFilter
        {
            get
            {
                return this.hasCurveFilterField;
            }
            set
            {
                this.hasCurveFilterField = value;
            }
        }

        /// <remarks/>
        public bool HasGetAccessToLog
        {
            get
            {
                return this.hasGetAccessToLogField;
            }
            set
            {
                this.hasGetAccessToLogField = value;
            }
        }

        /// <remarks/>
        public bool HasGetAccessToRealtime
        {
            get
            {
                return this.hasGetAccessToRealtimeField;
            }
            set
            {
                this.hasGetAccessToRealtimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.witsml.org/message/120")]
    public partial class WellboreInfo
    {

        private long idField;

        private string uidWellField;

        private string uidWellboreField;

        /// <remarks/>
        public long Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string UidWell
        {
            get
            {
                return this.uidWellField;
            }
            set
            {
                this.uidWellField = value;
            }
        }

        /// <remarks/>
        public string UidWellbore
        {
            get
            {
                return this.uidWellboreField;
            }
            set
            {
                this.uidWellboreField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Sense.Intellifield.Witsml.Common")]
    public partial class LastValueType
    {

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private System.DateTime timeReceivedField;

        private bool timeReceivedFieldSpecified;

        private double mdField;

        private bool mdFieldSpecified;

        private string unitField;

        private object valueField;

        private ArrayOfKeyValueOfstringstringKeyValueOfstringstring[] valuesField;

        /// <remarks/>
        public System.DateTime TimeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeStampSpecified
        {
            get
            {
                return this.timeStampFieldSpecified;
            }
            set
            {
                this.timeStampFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime TimeReceived
        {
            get
            {
                return this.timeReceivedField;
            }
            set
            {
                this.timeReceivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeReceivedSpecified
        {
            get
            {
                return this.timeReceivedFieldSpecified;
            }
            set
            {
                this.timeReceivedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double Md
        {
            get
            {
                return this.mdField;
            }
            set
            {
                this.mdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MdSpecified
        {
            get
            {
                return this.mdFieldSpecified;
            }
            set
            {
                this.mdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfstringstring", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public ArrayOfKeyValueOfstringstringKeyValueOfstringstring[] Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    public partial class ArrayOfKeyValueOfstringstringKeyValueOfstringstring
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Sense.Intellifield.Witsml.Common")]
    public partial class LastValueResultType
    {

        private long idField;

        private bool idFieldSpecified;

        private LastValueType lastValueField;

        /// <remarks/>
        public long ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IDSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public LastValueType LastValue
        {
            get
            {
                return this.lastValueField;
            }
            set
            {
                this.lastValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Sense.Intellifield.Witsml.Common")]
    public partial class SensorUidType
    {

        private long idField;

        private bool idFieldSpecified;

        private string sourceObjectTypeField;

        private string uidWellField;

        private string uidWellboreField;

        private string uidLogField;

        private string idSubField;

        private string dataGroupField;

        private string groupDefinitionIDField;

        private string mnemonicField;

        private bool acceptAbsentCurveField;

        private bool acceptAbsentCurveFieldSpecified;

        /// <remarks/>
        public long ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IDSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SourceObjectType
        {
            get
            {
                return this.sourceObjectTypeField;
            }
            set
            {
                this.sourceObjectTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string UidWell
        {
            get
            {
                return this.uidWellField;
            }
            set
            {
                this.uidWellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string UidWellbore
        {
            get
            {
                return this.uidWellboreField;
            }
            set
            {
                this.uidWellboreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string UidLog
        {
            get
            {
                return this.uidLogField;
            }
            set
            {
                this.uidLogField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdSub
        {
            get
            {
                return this.idSubField;
            }
            set
            {
                this.idSubField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string DataGroup
        {
            get
            {
                return this.dataGroupField;
            }
            set
            {
                this.dataGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string GroupDefinitionID
        {
            get
            {
                return this.groupDefinitionIDField;
            }
            set
            {
                this.groupDefinitionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Mnemonic
        {
            get
            {
                return this.mnemonicField;
            }
            set
            {
                this.mnemonicField = value;
            }
        }

        /// <remarks/>
        public bool AcceptAbsentCurve
        {
            get
            {
                return this.acceptAbsentCurveField;
            }
            set
            {
                this.acceptAbsentCurveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcceptAbsentCurveSpecified
        {
            get
            {
                return this.acceptAbsentCurveFieldSpecified;
            }
            set
            {
                this.acceptAbsentCurveFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.witsml.org/message/120")]
    public partial class LogQuery
    {

        private string[] m_mnemonicListField;

        private string[] m_aggregateListField;

        private string uidLogField;

        private string uidWellField;

        private string uidWellboreField;

        private decimal stepIncrementField;

        private int maxRowsField;

        private System.DateTime startTimeField;

        private System.DateTime endTimeField;

        private string[] mnemonicListField;

        private string[] aggregateListField;

        private bool timeBasedLogField;

        private System.Nullable<bool> increasingField;

        private string indexCurveField;

        /// <remarks/>
        public string[] m_mnemonicList
        {
            get
            {
                return this.m_mnemonicListField;
            }
            set
            {
                this.m_mnemonicListField = value;
            }
        }

        /// <remarks/>
        public string[] m_aggregateList
        {
            get
            {
                return this.m_aggregateListField;
            }
            set
            {
                this.m_aggregateListField = value;
            }
        }

        /// <remarks/>
        public string UidLog
        {
            get
            {
                return this.uidLogField;
            }
            set
            {
                this.uidLogField = value;
            }
        }

        /// <remarks/>
        public string UidWell
        {
            get
            {
                return this.uidWellField;
            }
            set
            {
                this.uidWellField = value;
            }
        }

        /// <remarks/>
        public string UidWellbore
        {
            get
            {
                return this.uidWellboreField;
            }
            set
            {
                this.uidWellboreField = value;
            }
        }

        /// <remarks/>
        public decimal StepIncrement
        {
            get
            {
                return this.stepIncrementField;
            }
            set
            {
                this.stepIncrementField = value;
            }
        }

        /// <remarks/>
        public int MaxRows
        {
            get
            {
                return this.maxRowsField;
            }
            set
            {
                this.maxRowsField = value;
            }
        }

        /// <remarks/>
        public System.DateTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <remarks/>
        public string[] MnemonicList
        {
            get
            {
                return this.mnemonicListField;
            }
            set
            {
                this.mnemonicListField = value;
            }
        }

        /// <remarks/>
        public string[] AggregateList
        {
            get
            {
                return this.aggregateListField;
            }
            set
            {
                this.aggregateListField = value;
            }
        }

        /// <remarks/>
        public bool TimeBasedLog
        {
            get
            {
                return this.timeBasedLogField;
            }
            set
            {
                this.timeBasedLogField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> Increasing
        {
            get
            {
                return this.increasingField;
            }
            set
            {
                this.increasingField = value;
            }
        }

        /// <remarks/>
        public string IndexCurve
        {
            get
            {
                return this.indexCurveField;
            }
            set
            {
                this.indexCurveField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void WMLS_GetCapCompletedEventHandler(object sender, WMLS_GetCapCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_GetCapCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal WMLS_GetCapCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public short Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }

        /// <remarks/>
        public string CapabilitiesOut
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }

        /// <remarks/>
        public string SuppMsgOut
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void WMLS_GetVersionCompletedEventHandler(object sender, WMLS_GetVersionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_GetVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal WMLS_GetVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void WMLS_GetBaseMsgCompletedEventHandler(object sender, WMLS_GetBaseMsgCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_GetBaseMsgCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal WMLS_GetBaseMsgCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void WMLS_AddToStoreCompletedEventHandler(object sender, WMLS_AddToStoreCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_AddToStoreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal WMLS_AddToStoreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public short Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }

        /// <remarks/>
        public string SuppMsgOut
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void WMLS_GetFromStoreCompletedEventHandler(object sender, WMLS_GetFromStoreCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_GetFromStoreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal WMLS_GetFromStoreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public short Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }

        /// <remarks/>
        public string XMLout
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }

        /// <remarks/>
        public string SuppMsgOut
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void WMLS_DeleteFromStoreCompletedEventHandler(object sender, WMLS_DeleteFromStoreCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_DeleteFromStoreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal WMLS_DeleteFromStoreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public short Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }

        /// <remarks/>
        public string SuppMsgOut
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void WMLS_UpdateInStoreCompletedEventHandler(object sender, WMLS_UpdateInStoreCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_UpdateInStoreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal WMLS_UpdateInStoreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public short Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }

        /// <remarks/>
        public string SuppMsgOut
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void GetVersionCompletedEventHandler(object sender, GetVersionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Version Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Version)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void GetNameCompletedEventHandler(object sender, GetNameCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void WCF_GetFromStoreBinaryCompletedEventHandler(object sender, WCF_GetFromStoreBinaryCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WCF_GetFromStoreBinaryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal WCF_GetFromStoreBinaryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public short Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }

        /// <remarks/>
        public byte[] LogDataList
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[1]));
            }
        }

        /// <remarks/>
        public string SuppMsgOut
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void WMLS_GetFromStoreBinaryDataCompletedEventHandler(object sender, WMLS_GetFromStoreBinaryDataCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_GetFromStoreBinaryDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal WMLS_GetFromStoreBinaryDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public short WMLS_GetFromStoreBinaryDataResult
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool WMLS_GetFromStoreBinaryDataResultSpecified
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }

        /// <remarks/>
        public byte[] binaryLogData
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[2]));
            }
        }

        /// <remarks/>
        public string SuppMsgOut
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void GetPermissionInfoCompletedEventHandler(object sender, GetPermissionInfoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPermissionInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetPermissionInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public short Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }

        /// <remarks/>
        public PermissionInfo[] permissionInfo
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((PermissionInfo[])(this.results[1]));
            }
        }
    }
