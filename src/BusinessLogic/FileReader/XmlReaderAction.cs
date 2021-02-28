using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BusinessLogic
{
    public class XmlReaderAction : IFileReaderAction
    {
        public string Read(string path)
        {
            var stringResult = new StringBuilder();
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }

            var fileExists = File.Exists(path);
            if (fileExists)
            {
                var fileExtension = Path.GetExtension(path);
                if (fileExtension != ".xml")
                {
                    throw new InvalidOperationException("The file type must be of type XML");
                }

                var reader = new XmlTextReader(path);
                reader.WhitespaceHandling = WhitespaceHandling.None;
                
                // Parse the file and display each of the nodes.
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            stringResult.Append($"<{0}>{reader.Name}");
                            break;
                        case XmlNodeType.Text:
                            stringResult.Append(reader.Value);
                            break;
                        case XmlNodeType.CDATA:
                            stringResult.Append($"<![CDATA[{0}]]>{reader.Value}");
                            break;
                        case XmlNodeType.ProcessingInstruction:
                            stringResult.Append($"<?{0} {1}?> {reader.Name}, {reader.Value}");
                            break;
                        case XmlNodeType.Comment:
                            stringResult.Append($"<!--{0}--> {reader.Value}");
                            break;
                        case XmlNodeType.XmlDeclaration:
                            stringResult.Append($"<?xml version='1.0'?>");
                            break;
                        case XmlNodeType.Document:
                            break;
                        case XmlNodeType.DocumentType:
                            stringResult.Append($"<!DOCTYPE {0} [{1}] {reader.Name}, {reader.Value}");
                            break;
                        case XmlNodeType.EntityReference:
                            stringResult.Append(reader.Name);
                            break;
                        case XmlNodeType.EndElement:
                            stringResult.Append($"</{0}> {reader.Name}");
                            break;
                    }
                }
            }
            return stringResult.ToString();
        }
    }
}
