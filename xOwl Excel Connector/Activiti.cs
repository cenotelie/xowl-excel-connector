using System;
using System.Text;
using System.Reflection;
using System.Net;
using Newtonsoft.Json;
using xOwl_Annotations;

namespace xOwl_Excel_Connector
{
    public class ActivitiProcessManager
    {
        private readonly string xowlLogin = (string)Properties.Settings.Default["xowlLogin"];
        private readonly string xowlPassword = (string)Properties.Settings.Default["xowlPassword"];
        private readonly string activitiApi = (string)Properties.Settings.Default["activitiApi"];

        /// <summary>
        /// <exception cref="WebException">Connection Failed</exception>
        /// </summary>
        /// <param name="type"></param>
        public void CompleteTaskForData(Type type)
        {
            BusinessClass businessClass = type.GetCustomAttribute<BusinessClass>();
            string processId = businessClass.ProcessId;
            string taskId = businessClass.TaskId;
            if (processId == null || taskId == null)
            {
                return;
            }
            string parameters = $"taskDefinitionKey={taskId}&processDefinitionKey={processId}&assignee={xowlLogin}";
            Uri uri = new Uri(activitiApi + "/runtime/tasks?" + parameters);
            HttpWebRequest activitiReq = (HttpWebRequest)HttpWebRequest.Create(uri);
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(uri, "Basic", new NetworkCredential(xowlLogin, xowlPassword));
            activitiReq.Credentials = credentialCache;
            activitiReq.PreAuthenticate = true;
            String encoded = System.Convert.ToBase64String(Encoding.GetEncoding("iso-8859-1").GetBytes(xowlLogin + ":" + xowlPassword));
            activitiReq.Headers.Add("Authorization", "Basic " + encoded);
            activitiReq.ContentType = "application/json";
            activitiReq.ContentLength = 0;
            activitiReq.Accept = "application/json";
            activitiReq.Method = "GET";
            try
            {
                HttpWebResponse resp = (HttpWebResponse)activitiReq.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string response = sr.ReadToEnd().Trim();
                dynamic result = JsonConvert.DeserializeObject(response);
                if (result.data.Count > 0)
                {
                    string url = result.data[0].url;
                    activitiReq = (HttpWebRequest)HttpWebRequest.Create(url);
                    activitiReq.Credentials = credentialCache;
                    activitiReq.Headers.Add("Authorization", "Basic " + encoded);
                    activitiReq.ContentType = "application/json";
                    activitiReq.Method = "POST";
                    string body = "{ \"action\":\"complete\" }";
                    byte[] bytes = Encoding.UTF8.GetBytes(body);
                    activitiReq.ContentLength = bytes.Length;
                    System.IO.Stream os = activitiReq.GetRequestStream();
                    os.Write(bytes, 0, bytes.Length);
                    os.Close();
                    resp = (HttpWebResponse)activitiReq.GetResponse();
                }
            } catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Process Notification Failed");
            }
        }
    }
}
