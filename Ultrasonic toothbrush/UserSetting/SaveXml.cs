using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ultrasonic_toothbrush.UserSetting
{
	class SaveXml
	{
		private static XmlDocument doc ;
		private static string xmlPath = "SSetting.xml";     //用于保存文件名和路径
		public static bool Save()
		{

			try
			{
				//Dec
				doc = new XmlDocument();
				XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
				doc.AppendChild(dec);

				//Root
				XmlElement root = doc.CreateElement("ROOT");
				doc.AppendChild(root);
				//MAC
				XmlElement mac = doc.CreateElement("MAC");
				XmlElement macMax = doc.CreateElement("MAX");
				XmlElement macMini = doc.CreateElement("MINI");

				macMax.InnerText = Setting.MacMax.ToString("X2");
				macMini.InnerText = Setting.MacMini.ToString("X2");

				mac.AppendChild(macMax);
				mac.AppendChild(macMini);

				//RSSSI
				XmlElement rssi = doc.CreateElement("RSSI");
				rssi.InnerText = Setting.Rssi.ToString();
				//Version
				XmlElement version = doc.CreateElement("VERSION");
				version.InnerText = Setting.Version;
				//DeviceName
				XmlElement deviceName = doc.CreateElement("DEVICENAME");
				deviceName.InnerText =Setting.DeviceName;
				//Channel
				XmlElement channel = doc.CreateElement("CHANNEL");
				channel.InnerText = Setting.Channel;
				//添加到root中
				XmlElement lineNumber = doc.CreateElement("LINENUMBER");
				lineNumber.InnerText = Setting.LineNumber;

				XmlElement server = doc.CreateElement("SERVER");
				server.InnerText = Setting.Server;

				XmlElement chip = doc.CreateElement("CHIP");
				chip.InnerText = Setting.Chip;

				root.AppendChild(mac);
				root.AppendChild(rssi);
				root.AppendChild(version);
				root.AppendChild(deviceName);
				root.AppendChild(channel);
				root.AppendChild(lineNumber);
				root.AppendChild(server);
				root.AppendChild(chip);
				doc.Save(xmlPath);
	
				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}

		public static bool Load()
		{
			try
			{
				doc.Load(xmlPath);
				XmlElement root = doc.DocumentElement;

				XmlNode macMax = root.SelectSingleNode("MAC/MAX");
				XmlNode macMini=root.SelectSingleNode("MAC/MINI");

				XmlNode rssi = root.SelectSingleNode("RSSI");
				XmlNode version = root.SelectSingleNode("VERSION");
				XmlNode deviceName = root.SelectSingleNode("DEVICENAME");
				XmlNode channel = root.SelectSingleNode("CHANNEL");
				XmlNode server = root.SelectSingleNode("SERVER");
				XmlNode lineNumber = root.SelectSingleNode("LINENUMBER");
				XmlNode chip = root.SelectSingleNode("CHIP");
				//赋值给setting
				Setting.MacMax = Convert.ToInt64(macMax.InnerText, 16);
				Setting.MacMini = Convert.ToInt64(macMini.InnerText, 16);
				Setting.Rssi= int.Parse(rssi.InnerText);
				Setting.Version = version.InnerText;
				Setting.DeviceName = deviceName.InnerText;
				Setting.Channel = channel.InnerText;
				Setting.Server = server.InnerText;
				Setting.LineNumber = lineNumber.InnerText;
				Setting.Chip = chip.InnerText;
				return true;
			}
			catch(Exception e)
			{
				return false;
			}
		}

		public static bool load(string path)//导入配置
		{
			xmlPath = xmlPath + path;
			return Load();
		}
	}
}
