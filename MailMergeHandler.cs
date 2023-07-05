using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Xml;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace MailMerge
{
    internal class MailMergeHandler
    {
        private static string SettingsFilePath { get; } = "word/settings.xml";
        private static string NamespaceUri { get; } = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";
        private static string NodeName { get; } = "connectString";
        private static string AttributeName { get; } = "w:val";

        public static void PerformMailMerge(
            string templatePath,
            string subject,
            string bcc,
            string cc,
            List<string> attachments,
            int lower,
            int upper,
            bool addSignature,
            bool sendEmails)
        {
            //var dataSourcePath = GetAttributeValue(templatePath);
            const string dataSourcePath = "e:\\test.xlsx";

            Word.Application wordApp = new()
            {
                Visible = true
            };
            // Open the mail merge template
            var doc = wordApp.Documents.Open(templatePath);
            doc.Activate();

            // Set the data source for the mail merge
            doc.MailMerge.OpenDataSource(Name: dataSourcePath);
            doc.MailMerge.MainDocumentType = WdMailMergeMainDocType.wdEMail;

            wordApp.Visible = false;

            Outlook.Application outlookApp = new();

            for (var i = lower; i <= Math.Min(doc.MailMerge.DataSource.RecordCount, upper); i++)
            {
                doc.MailMerge.DataSource.ActiveRecord = (WdMailMergeActiveRecord)i;
                doc.MailMerge.Destination = WdMailMergeDestination.wdSendToNewDocument;
                doc.MailMerge.DataSource.FirstRecord = (int)doc.MailMerge.DataSource.ActiveRecord;
                doc.MailMerge.DataSource.LastRecord = (int)doc.MailMerge.DataSource.ActiveRecord;
                doc.MailMerge.Execute();

                var wdDoc = wordApp.ActiveDocument;
                wdDoc.Content.Select();
                wdDoc.Content.Copy();

                MailItem mailItem = outlookApp.CreateItem(OlItemType.olMailItem);
                mailItem.Display();

                mailItem.To = doc.MailMerge.DataSource.DataFields["Email"].Value;
                mailItem.Subject = subject;
                mailItem.BCC = bcc;
                mailItem.CC = cc;

                attachments.ForEach(a => mailItem.Attachments.Add(a));

                var signature = mailItem.HTMLBody;

                var editor = mailItem.GetInspector;
                editor.WordEditor.Content.PasteSpecial();

                if (addSignature)
                {
                    //MailItem temp = outlookApp.CreateItem(OlItemType.olMailItem);
                    //temp.Display();
                    //var tempEditor = temp.GetInspector;
                    //tempEditor.WordEditor.Content.Copy();
                    //editor.WordEditor.Content.PasteSpecial();
                    //temp.Close(OlInspectorClose.olDiscard);
                    //Marshal.ReleaseComObject(temp);
                    mailItem.HTMLBody += signature;
                }

                if (sendEmails)
                    mailItem.Send();
                else
                    mailItem.Save();


                wdDoc.Close(false);
                Marshal.ReleaseComObject(wdDoc);
                Marshal.ReleaseComObject(mailItem);
            }

            doc.Close(false);
            wordApp.Quit();
            outlookApp.Quit();
            Marshal.ReleaseComObject(doc);
            Marshal.ReleaseComObject(wordApp);
            Marshal.ReleaseComObject(outlookApp);

        }

        static string GetAttributeValue(string filePath)
        {
            XmlDocument xmlDoc = new();

            using var xmlSteam = GetSettingsXmlStreamFromArchive(filePath);

            if (xmlSteam == null)
            {
                return "Error: settings.xml not found!";
            }
            xmlDoc.Load(xmlSteam);

            XmlNamespaceManager namespaceManager = new(xmlDoc.NameTable);
            namespaceManager.AddNamespace("w", NamespaceUri);

            XmlNode node = xmlDoc.SelectSingleNode("/w:settings/w:mailMerge/w:" + NodeName, namespaceManager);
            if (node != null)
            {
                XmlAttribute attribute = node.Attributes?[AttributeName];
                if (attribute != null)
                {
                    return attribute.Value;
                }
            }
            return null;
        }

        static Stream GetSettingsXmlStreamFromArchive(string archiveFilePath)
        {
            using var target = File.OpenRead(archiveFilePath);
            using var newArchive = new ZipArchive(target, ZipArchiveMode.Read);

            var entry = newArchive.GetEntry(SettingsFilePath);

            return entry?.Open();

        }
    }
}