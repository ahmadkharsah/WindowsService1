using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer();
        string sourceFolderPath = string.Empty;
        DirectoryInfo sourceFolder;
        string destinationFolderPath = string.Empty;
        DirectoryInfo destinationFolder;
        EventLog eventsLog;
        MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortTypeClient serviceClient;

        public Service1()
        {
            InitializeComponent();
            this.AutoLog = true;

            eventsLog = new EventLog();
            if (!EventLog.SourceExists("Service1"))
            {
                EventLog.CreateEventSource("Service1", "Service1Log");
            }
            eventsLog.Source = "Service1";
            eventsLog.Log = "Service1Log";

            //Service Client 
            serviceClient = new MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortTypeClient();

        }

        protected override void OnStart(string[] args)
        {
            WriteToFile("Service is started at " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 10000; //number in milisecinds  
            timer.Enabled = true;

            //eventsLog.WriteEntry("Service1 Started at " + DateTime.Now.ToShortTimeString());

            sourceFolderPath = AppDomain.CurrentDomain.BaseDirectory + "\\" + ConfigurationManager.AppSettings["sourceFolder"];
            destinationFolderPath = AppDomain.CurrentDomain.BaseDirectory + "\\" + ConfigurationManager.AppSettings["destinationFolder"];

            if (!Directory.Exists(sourceFolderPath))
            {
                Directory.CreateDirectory(sourceFolderPath);
                //eventsLog.WriteEntry("Source Folder Created at: " + DateTime.Now.ToShortTimeString());
            }

            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
                //eventsLog.WriteEntry("Destination Folder Created at: " + DateTime.Now.ToShortTimeString());
            }

            sourceFolder = new DirectoryInfo(sourceFolderPath);
            destinationFolder = new DirectoryInfo(destinationFolderPath);

        }

        private void OnElapsedTime(object sender, ElapsedEventArgs e)
        {
            WriteToFile("Service is recall at " + DateTime.Now);
            CehckforFiles();
        }

        protected override void OnStop()
        {
            WriteToFile("Service is stopped at " + DateTime.Now);
        }

        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }

        public void CehckforFiles()
        {
            FileInfo[] files = sourceFolder.GetFiles();
            if (files.Length > 0)
            {
                foreach(FileInfo file in files)
                {
                    //File.Move(sourceFolderPath + "\\"+file.Name,destinationFolderPath + "\\"+ file.Name);
                    //File.Delete(sourceFolderPath + "\\" + file.Name);
                    if (file.Extension.Contains("xml")) {
                        StreamReader sr = new StreamReader((Stream)file.OpenRead());
                        string content = sr.ReadToEnd();
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(content);
                        var data = JSon.XmlToJSON(doc);
                        JObject json = JsonConvert.DeserializeObject<JObject>(data);
                       
                        var creationDateTime = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.creationDateTime").Value<string>();
                        var baseLanguage = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.baseLanguage").Value<string>();
                        var transLanguage = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.transLanguage").Value<string>();
                        var messageID = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.messageID").Value<string>();
                        var maximoVersion = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.maximoVersion").Value<string>();
                        var companyAddress1 = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:ADDRESS1.value").Value<string>();
                        var companyAddress1Changed = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:ADDRESS1.changed").Value<string>();
                        var companyAddress2 = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:ADDRESS2.value").ToObject<string>();
                        var companyAddress3 = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:ADDRESS3.value").Value<string>();
                        var companyAddress4 = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:ADDRESS4.value").Value<string>();
                        var company = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:COMPANY.value").Value<string>();
                        var companyCurrencyCode = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:CURRENCYCODE.value").Value<string>();
                        var companyPaymentTerms = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:PAYMENTTERMS.value").Value<string>();
                        var companyDisabled = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:DISABLED.value").Value<string>();
                        var companyHomePage = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:HOMEPAGE.value").Value<string>();
                        var companyName = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:NAME.value").Value<string>();
                        var companyNameLongDescription = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:NAME_LONGDESCRIPTION.value").Value<string>();
                        var companyOrgID = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:ORGID.value").Value<string>();
                        var companyType = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:TYPE.value").Value<string>();

                        var companyContactName = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES.max:COMPCONTACT.max:CONTACT.value").Value<string>();
                        var companyContactEmail = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES..max:COMPCONTACT.max:EMAIL.value").Value<string>();
                        var companyContactPhone = json.SelectToken("soapenv:Envelope.soapenv:Body.max:SyncCCINTMXVENDOR.max:CCINTMXVENDORSet.max:COMPANIES..max:COMPCONTACT.max:VOICEPHONE.value").Value<string>();

                        List<MaximoServiceReference.CCINTMXVENDOR_COMPANIESType> list = new List<MaximoServiceReference.CCINTMXVENDOR_COMPANIESType>();
                        var item = new MaximoServiceReference.CCINTMXVENDOR_COMPANIESType()
                        {
                            transLanguage = transLanguage,
                            action = MaximoServiceReference.ProcessingActionType.Add,
                            actionSpecified = true,
                            NAME = new MaximoServiceReference.MXLangStringType() { Value = companyName },
                            ADDRESS1 = new MaximoServiceReference.MXStringType() { Value = companyAddress1 },
                            ADDRESS2 = new MaximoServiceReference.MXStringType() { Value = companyAddress2 },
                            ADDRESS3 = new MaximoServiceReference.MXStringType() { Value = companyAddress3 },
                            ADDRESS4 = new MaximoServiceReference.MXStringType() { Value = companyAddress4 },
                            DISABLED = new MaximoServiceReference.MXBooleanType() { Value = companyDisabled == "0" ? false : true },
                            COMPANY = new MaximoServiceReference.MXStringType() { Value = company },
                            CURRENCYCODE = new MaximoServiceReference.MXStringType() { Value = companyCurrencyCode },
                            HOMEPAGE = new MaximoServiceReference.MXStringType() { Value = companyHomePage },
                            ORGID = new MaximoServiceReference.MXStringType() { Value = companyOrgID },
                            TYPE = new MaximoServiceReference.MXDomainType() { Value = companyType },
                            NAME_LONGDESCRIPTION = new MaximoServiceReference.MXLangStringType() { Value = companyNameLongDescription },
                            COMPCONTACT = new MaximoServiceReference.CCINTMXVENDOR_COMPCONTACTType[]
                            {
                                new MaximoServiceReference.CCINTMXVENDOR_COMPCONTACTType()
                                {
                                    CONTACT = new MaximoServiceReference.MXStringType(){Value =companyContactName },
                                    EMAIL = new MaximoServiceReference.MXStringType(){ Value = companyContactEmail },
                                    VOICEPHONE = new MaximoServiceReference.MXStringType(){Value = companyContactPhone }
                                }
                            }
                        };
                        list.Add(item) ;
                        DateTime _creationTime;
                        DateTime.TryParse((string)creationDateTime, out _creationTime);
                        try
                        {
                            if (serviceClient.State != System.ServiceModel.CommunicationState.Faulted)
                            {
                                serviceClient.SyncCCINTMXVENDOR(new MaximoServiceReference.SyncCCINTMXVENDORType()
                                {
                                    baseLanguage = baseLanguage,
                                    CCINTMXVENDORSet = list.ToArray(),
                                    creationDateTime = _creationTime,
                                    creationDateTimeSpecified = false,
                                    maximoVersion = maximoVersion,
                                    messageID = messageID,
                                    transLanguage = transLanguage
                                });
                            }
                            else
                            {
                                serviceClient = new MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortTypeClient();                                
                                serviceClient.Open();
                                serviceClient.SyncCCINTMXVENDOR(new MaximoServiceReference.SyncCCINTMXVENDORType() { 
                                    baseLanguage = baseLanguage,
                                    CCINTMXVENDORSet = list.ToArray(),
                                    creationDateTime = _creationTime,
                                    creationDateTimeSpecified = false,
                                    maximoVersion = maximoVersion,
                                    messageID = messageID,
                                    transLanguage = transLanguage
                                });
                            }
                            serviceClient.Close();
                        }
                        catch (Exception ex)
                        {
                            WriteToFile("Exception: " + ex.Message + DateTime.Now);
                        }

                    }
                }
            }
        }
    }

    public static class JSon
    {
        public static string XmlToJSON(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            return XmlToJSON(doc);
        }
        public static string XmlToJSON(XmlDocument xmlDoc)
        {
            StringBuilder sbJSON = new StringBuilder();
            sbJSON.Append("{ ");
            XmlToJSONnode(sbJSON, xmlDoc.DocumentElement, true);
            sbJSON.Append("}");
            return sbJSON.ToString();
        }

        //  XmlToJSONnode:  Output an XmlElement, possibly as part of a higher array
        private static void XmlToJSONnode(StringBuilder sbJSON, XmlElement node, bool showNodeName)
        {
            if (showNodeName)
                sbJSON.Append("\"" + SafeJSON(node.Name) + "\": ");
            sbJSON.Append("{");
            // Build a sorted list of key-value pairs
            //  where   key is case-sensitive nodeName
            //          value is an ArrayList of string or XmlElement
            //  so that we know whether the nodeName is an array or not.
            SortedList<string, object> childNodeNames = new SortedList<string, object>();

            //  Add in all node attributes
            if (node.Attributes != null)
                foreach (XmlAttribute attr in node.Attributes)
                    StoreChildNode(childNodeNames, attr.Name, attr.InnerText);

            //  Add in all nodes
            foreach (XmlNode cnode in node.ChildNodes)
            {
                if (cnode is XmlText)
                    StoreChildNode(childNodeNames, "value", cnode.InnerText);
                else if (cnode is XmlElement)
                    StoreChildNode(childNodeNames, cnode.Name, cnode);
            }

            // Now output all stored info
            foreach (string childname in childNodeNames.Keys)
            {
                List<object> alChild = (List<object>)childNodeNames[childname];
                if (alChild.Count == 1)
                    OutputNode(childname, alChild[0], sbJSON, true);
                else
                {
                    sbJSON.Append(" \"" + SafeJSON(childname) + "\": [ ");
                    foreach (object Child in alChild)
                        OutputNode(childname, Child, sbJSON, false);
                    sbJSON.Remove(sbJSON.Length - 2, 2);
                    sbJSON.Append(" ], ");
                }
            }
            sbJSON.Remove(sbJSON.Length - 2, 2);
            sbJSON.Append(" }");
        }

        //  StoreChildNode: Store data associated with each nodeName
        //                  so that we know whether the nodeName is an array or not.
        private static void StoreChildNode(SortedList<string, object> childNodeNames, string nodeName, object nodeValue)
        {
            // Pre-process contraction of XmlElement-s
            if (nodeValue is XmlElement)
            {
                // Convert  <aa></aa> into "aa":null
                //          <aa>xx</aa> into "aa":"xx"
                XmlNode cnode = (XmlNode)nodeValue;
                if (cnode.Attributes.Count == 0)
                {
                    XmlNodeList children = cnode.ChildNodes;
                    if (children.Count == 0)
                        nodeValue = null;
                    else if (children.Count == 1 && (children[0] is XmlText))
                        nodeValue = ((XmlText)(children[0])).InnerText;
                }
            }
            // Add nodeValue to ArrayList associated with each nodeName
            // If nodeName doesn't exist then add it
            List<object> ValuesAL;

            if (childNodeNames.ContainsKey(nodeName))
            {
                ValuesAL = (List<object>)childNodeNames[nodeName];
            }
            else
            {
                ValuesAL = new List<object>();
                childNodeNames[nodeName] = ValuesAL;
            }
            ValuesAL.Add(nodeValue);
        }

        private static void OutputNode(string childname, object alChild, StringBuilder sbJSON, bool showNodeName)
        {
            if (alChild == null)
            {
                if (showNodeName)
                    sbJSON.Append("\"" + SafeJSON(childname) + "\": ");
                sbJSON.Append("null");
            }
            else if (alChild is string)
            {
                if (showNodeName)
                    sbJSON.Append("\"" + SafeJSON(childname) + "\": ");
                string sChild = (string)alChild;
                sChild = sChild.Trim();
                sbJSON.Append("\"" + SafeJSON(sChild) + "\"");
            }
            else
                XmlToJSONnode(sbJSON, (XmlElement)alChild, showNodeName);
            sbJSON.Append(", ");
        }

        // Make a string safe for JSON
        private static string SafeJSON(string sIn)
        {
            StringBuilder sbOut = new StringBuilder(sIn.Length);
            foreach (char ch in sIn)
            {
                if (Char.IsControl(ch) || ch == '\'')
                {
                    int ich = (int)ch;
                    sbOut.Append(@"\u" + ich.ToString("x4"));
                    continue;
                }
                else if (ch == '\"' || ch == '\\' || ch == '/')
                {
                    sbOut.Append('\\');
                }
                sbOut.Append(ch);
            }
            return sbOut.ToString();
        }
    }
}
