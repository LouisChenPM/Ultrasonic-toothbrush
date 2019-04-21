using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using n_mysql;

namespace n_feike_db
{

	public class CfeikeDB : Cmysql
	{
		public string export_file;
		public string time_format;

		public CfeikeDB()
		{
			this.database = "bluetooth";
			this.build_conn();
			this.secure_file_priv = "C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/";
			this.export_file = "";
			this.time_format = "yyyy_MM_dd_HH_mm_ss_ffff";
		}

		public override int deal_rdr()
		{
			this.rdr_count = 0;
			while (this.rdr.Read())
			{
				this.rdr_count++;
				try
				{
					if (this.debug) Console.WriteLine(this.rdr[0] + " -- " + this.rdr[1] + "--" + this.rdr[2]);
				}
				catch (Exception e) { if (this.debug) Console.WriteLine(e.ToString()); break; }

			}
			this.close();
			return this.rdr_count;
		}

		public int is_count_limit(string limit)
		{
			return this.is_exist("`bluetooth`.`product`", "idproduct", limit);
		}

		public int is_exist_mac(UInt64 mac)//-1 do nothing ,0 :not exist ;>0 mac count 
		{
			this.sql = "SELECT mac from `bluetooth`.`mac` where mac = '" + mac + "';";
			if (this.command(this.conn_str, sql, ExeType.Select, false))
			{
				return this.deal_rdr();
			}
			else return -1; //do nothing
		}

		public int is_empty(string db_tab)//db_tab="bluetooth.mac"
		{
			this.sql = "SELECT * FROM " + db_tab + ";";
			if (this.debug) Console.WriteLine(this.sql);
			if (this.transaction(this.conn_str, sql, ExeType.Select, true)) return this.rdr_count;
			return -1;
		}

		public bool get_last_record(string db_tab, string id)//db_tab="bluetooth.mac" ,id "idmac"
		{
			this.sql = "SELECT " + id + " FROM " + db_tab + " ORDER BY " + id + " DESC LIMIT 0,1;";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Select, false);//not deal
		}

		public bool get_first_record(string db_tab, string id)//db_tab="bluetooth.mac" ,id "idmac"
		{
			this.sql = "SELECT " + id + " FROM " + db_tab + " ORDER BY " + id + " ASC LIMIT 0,1;";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Select, false);//not deal
		}

		public bool alter_auto_inc(string db_tab, int inc_value)
		{
			this.sql = "ALTER TABLE " + db_tab + " AUTO_INCREMENT = " + inc_value + " ;";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, this.sql, ExeType.Script, true);
		}

		public bool delete_worker(string idworker)
		{
			this.sql = " DELETE FROM `bluetooth`.`worker` WHERE `idworker`='" + idworker + "';";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Insert, true);
		}

		public bool insert_worker(string name, string status, int idstatus)
		{
			this.sql = " INSERT INTO `bluetooth`.`worker` (`name`, `status`, `idstatus`) VALUES('" + name + "', '" + status + "', '" + idstatus + "');";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Insert, true);
		}


		public bool insert_order(string idstatus, string devicetype, string order_number, string product_name, string amount, string deliverytime, string starttime, string who, string unitprice, string total, string status)
		{
			this.sql = " INSERT INTO `bluetooth`.`order` ( `idstatus`, `devicetype`, `number`, `name`, `quantity`, `deliverytime`, `starttime`, `who`, `unitprice`, `total`, `status`) VALUES('" + idstatus + "', '" + devicetype + "', '" + order_number + "', '" + product_name + "', '" + amount + "', '" + deliverytime + "', '" + starttime + "', '" + who + "', '" + unitprice + "', '" + total + "',  '" + status + "');";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Insert, true);
		}

		public bool insert_order(int idstatus, int devicetype, string order_number, string product_name, int amount, string deliverytime, string starttime, string who, double unitprice, double total, string status)
		{
			return this.insert_order(idstatus.ToString(), devicetype.ToString(), order_number, product_name, amount.ToString(), deliverytime, starttime, who, unitprice.ToString(), total.ToString(), status);
		}

		public bool delete_line(string number)
		{
			this.sql = " DELETE FROM `bluetooth`.`line` WHERE `number`='" + number + "';";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Insert, true);
		}

		public bool insert_line(string number, string name, string who, string what, string when, string start, string end, string where, string capacity, string status, string contact, string level)
		{
			string guid = Guid.NewGuid().ToString();

			this.sql = "INSERT INTO `bluetooth`.`line` (`guid`, `number`, `name`, `who`, `what`, `time`, `start`, `end`, `where`, `capacity`, `status`, `contact`, `level`) VALUES('" + guid + "', '" + number + "', '" + name + "', '" + who + "', '" + what + "', '" + when + "', '" + start + "', '" + end + "', '" + where + "', '" + capacity + "', '" + status + "', '" + contact + "', '" + level + "');";

			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Insert, true);
		}

		public bool insert_test(string where, string who, string what, string how)
		{
			string guid = Guid.NewGuid().ToString();
			this.sql = "INSERT INTO `bluetooth`.`test` (`guid`,`where`, `who`, `what`, `how`) VALUES('" + guid + "','" + where + "','" + who + "','" + what + "','" + how + "');";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Insert, true);
		}

		public bool insert_fail(string order, string type, UInt64 mac, string s_mac, string chip, string r_mac, string weight, string resistance, string voltage, string rssi, string version, string name, string line, string who_worker, string result)
		{
			this.sql = "INSERT INTO `bluetooth`.`fail` (`order_from`, `type`, `mac`, `s_mac`, `chip`,`r_mac`,`weight`, `resistance`, `voltage`, `rssi`, `version`, `name`, `line`, `who`,  `result`)VALUES ( '" + order + "', '" + type + "', '" + mac + "', '" + s_mac + "', '" + chip + "', '" + r_mac + "', '" + weight + "', '" + resistance + "', '" + voltage + "', '" + rssi + "', '" + version + "', '" + name + "', '" + line + "', '" + who_worker + "', '" + result + "');";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Insert, true);
		}

		public bool insert_product(string order, string type, UInt64 mac, string s_mac, string chip, string r_mac, string weight, string resistance, string voltage, string rssi, string version, string name, string line, string who_worker, string result)
		{
			this.sql = "INSERT INTO `bluetooth`.`product` (`order_from`, `type`, `mac`, `s_mac`, `chip`, `r_mac`, `weight`, `resistance`, `voltage`, `rssi`, `version`, `name`, `line`, `who`,  `result`)VALUES ( '" + order + "', '" + type + "', '" + mac + "', '" + s_mac + "', '" + chip + "', '" + r_mac + "', '" + weight + "', '" + resistance + "', '" + voltage + "', '" + rssi + "', '" + version + "', '" + name + "', '" + line + "', '" + who_worker + "', '" + result + "');";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Insert, true);
		}

		//INSERT INTO  `bluetooth`.`mac` (`mac`) VALUES (5),(6),(7),(8);
		public bool insert_mac(DataTable d, UInt64 min, UInt64 max, int fromBase = 16) //mac (min,max)
		{
			try
			{
				if (this.debug) Console.WriteLine("insert_mac()");
				if (d == null) return false;
				if (this.debug) Console.WriteLine("Columns" + d.Columns.Count);
				if (this.debug) Console.WriteLine("Rows:" + d.Rows.Count);

				UInt64 mac;
				int count = 0, insert_count = 0;
				string sql = "INSERT INTO  `bluetooth`.`mac` (`mac`) VALUES ";
				string s;
				foreach (DataRow dr in d.Rows)
				{
					count++;
					if (dr[0].ToString().Length < 1) continue; //check length
					s = dr[0].ToString();
					s = s.Replace(":", "");
					mac = Convert.ToUInt64(s, fromBase);
					if (mac >= min && mac <= max && this.is_exist(" `bluetooth`.`mac` ", "mac", mac.ToString()) > 0) continue;
					insert_count++;
					sql += "(" + mac + ")";
					if (count < d.Rows.Count) sql += ",";
				}
				sql += ";";
				if (this.debug) Console.WriteLine("insert_count=" + insert_count + "," + sql);
				if (insert_count < 1) return true;
				return this.transaction(this.conn_str, sql, ExeType.Insert);
			}
			catch (Exception e)
			{
				if (this.debug) Console.WriteLine(e.ToString());
				return false;
			}
		}

		public int insert_mac(DataTable d)
		{
			if (this.debug) Console.WriteLine("insert_mac()");
			if (d == null) return -1;
			if (this.debug) Console.WriteLine("Columns" + d.Columns.Count);
			if (this.debug) Console.WriteLine("Rows:" + d.Rows.Count);

			int false_count = 0;
			foreach (DataRow dr in d.Rows)
			{
				if (dr[0].ToString().Length < 1) continue; //check length
				if (this.insert_mac(UInt64.Parse(dr[0].ToString()))) continue;
				false_count++;//add false
				if (this.debug) Console.WriteLine("error insert_mac:" + dr[0]);//show fail
			}

			return false_count;
		}

		public bool insert_mac(UInt64 mac)
		{
			this.sql = "INSERT INTO `bluetooth`.`mac` (`mac`) VALUES( '" + mac + "');";
			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Insert, true);
		}

		public bool export_mac(string outfile, bool add_secure_file_priv = true)
		{
			if (add_secure_file_priv) this.export_file = this.secure_file_priv + outfile;
			else this.export_file = outfile;

			this.sql = "SELECT* FROM bluetooth.mac into outfile '" + this.export_file + "';";
			return this.transaction(this.conn_str, sql, ExeType.Select, true);
		}

		public bool export_mac()
		{
			string outfile = "MAC_" + DateTime.Now.ToString(this.time_format) + ".csv";
			return this.export_mac(outfile, true);
		}

		public bool load_mac(string infile)
		{
			string file = infile.Replace("\\", "/");
			this.sql = "LOAD DATA INFILE '" + file + "' INTO TABLE bluetooth.mac;";
			return this.transaction(this.conn_str, sql, ExeType.Script, true);
		}

		public bool insert_customer(string who, string type, string country, string planet, string area, string where, string latitudeLongitude, string contact, string mail, string url, string start, string end, string what, string introduction, int level, string group, int credit, string remark, string status, string pionerr, string file, string logo, string image, string audio, string vedio)
		{
			this.sql = "INSERT INTO `bluetooth`.`customer` ( `who`, `type`, `country`, `planet`, `area`, `where`, `l_l`, `contact`, `mail`, `url`, `start`, `end`, `what`, `introduction`, `level`, `group`, `credit`, `remark`, `status`, `pioneer`, `file`, `logo`, `image`, `audio`, `vedio`) VALUES( '" + who + "', '" + type + "', '" + country + "', '" + planet + "', '" + area + "', '" + where + "', '" + latitudeLongitude + "', '" + contact + "', '" + mail + "', '" + url + "', '" + start + "', '" + end + "', '" + what + "', '" + introduction + "', '" + level + "', '" + group + "', '" + credit + " ', '" + remark + "', '" + status + "', '" + pionerr + "', '" + file + "', '" + logo + "', '" + image + "', '" + audio + "', '" + vedio + "');";

			if (this.debug) Console.WriteLine(this.sql);
			return this.transaction(this.conn_str, sql, ExeType.Insert, true);
		}

		public bool set_test_item(string item, int idtestitem)
		{
			this.sql = "UPDATE `bluetooth`.`testitem` SET `item`= '" + item + "' WHERE `idtestitem`= '" + idtestitem + "';";
			return this.transaction(this.conn_str, this.sql, ExeType.Script, true);
		}


	}//  class CfeikeDB
}
