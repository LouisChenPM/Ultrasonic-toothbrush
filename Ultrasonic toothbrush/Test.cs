using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrasonic_toothbrush
{
	class Test
	{
		static private Device preDevice=null;
		///Setting.FactoryMode;
		///Setting.PCBMode
		private static bool macResult = true;//mac地址范围测试
		private static bool nameResult = true;//名称是否相等测试
		private static bool rssiResult = true;//信号强度范围测试
		private static bool versionResult = true;//版本号范围测试
		private static bool factResetResult = true;//是否已经恢复工厂模式测试
		public static bool macRepeatSameProduct = true;//是否重复测试(人工选定)
		private static bool testResult = true;//总测试结果

		public static bool test(Device d)
		{
			init();//初始化
			Setting.Mode = Setting.TestMode.PRODUCT;

			//PRODUCT模式测试，检测前一mac地址是否重复
			if (Setting.Mode==Setting.TestMode.PRODUCT)
			{
				System.Threading.Thread t = System.Threading.Thread.CurrentThread;//线程同步
				//如果和前一个mac地址重复则显示窗口提示
				if (preDevice != null && preDevice.macStr == d.macStr)
				{
				UI.Repeat(d.macStr, t);
				t.Suspend();//挂起等待窗口点击确认
				macResult = macRepeatSameProduct;//mac
				}
			}
			if (macResult)//检测是否在某一范围
			{
				//if(d.macInt<miniMAC||mac >maxMAC)
			//macResult=false
				//检测mac地址是否在某一数值范围
			}
			//非脱机模式插入数据库返回mac地址是否重复
			if (macResult&&Setting.offLine==false)//检测MAC地址
			{
				//macResult=insertSql()插入数据库
			}
			if (d.rssi>0||d.rssi<Setting.Rssi)//检测信号强度
			{
				rssiResult = false;
			}
			if (d.name != Setting.DeviceName)//检测名称
			{
				nameResult = false;
			}
			if (d.version != Setting.Version)//检测版本号
			{
				versionResult = false;
			}
			//检测是否重置工厂模式
			factResetResult = d.FactoryReseted;

			ingore();//忽略那些非测试项
			preDevice = d;
			testResult = macResult && nameResult && rssiResult && versionResult && factResetResult;//计算最终结果
			//UI.Show()显示
			return testResult;
		}
		private static void init()
		{
			 macResult = true;//mac地址范围测试
			 nameResult = true;//名称是否相等测试
			 rssiResult = true;//信号强度范围测试
			 versionResult = true;//版本号范围测试
			 factResetResult = true;//是否已经恢复工厂模式测试
			 macRepeatSameProduct = true;//是否重复测试(人工选定)
			testResult = true;//总测试结果
	}
		//忽略非测试项
		private static void ingore()
		{
			if(Setting.macIngore)
			macResult = true;//mac地址范围测试
			if (Setting.nameIngore)
				nameResult = true;//名称是否相等测试
			if (Setting.rssiIngore)
				rssiResult = true;//信号强度范围测试
			if (Setting.versionIngore)
				versionResult = true;//版本号范围测试
			if (Setting.factResetIngore)
				factResetResult = true;//是否已经恢复工厂模式测试
		}

	}
}
