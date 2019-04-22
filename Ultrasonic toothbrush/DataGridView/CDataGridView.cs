using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace n_DataGridView
{
	public class CDataGridViewSetting
	{

	}

	public class CDataGridView: CDataGridViewSetting
	{
		public static void AddNull(System.Windows.Forms.DataGridView dgv, int row, int col)
		{
			Object[] o = new Object[col];
			for (int i = 0; i < row; i++) dgv.Rows.Add(o);
		}

		public static bool Update(System.Windows.Forms.DataGridView dgv,string rowName, string columnName, string value)
		{
			int i,r;//r:row index, i :cell index
			bool is_find = false;
			for (r = 0;r <dgv.RowCount;r++)
			{
				for (i = 0; i < dgv.ColumnCount; i++)
				{
					if (dgv.Rows[r].Cells[i].Value == null) continue;
					if (String.Compare(rowName,dgv.Rows[r].Cells[i].Value.ToString()) == 0)
					{
						is_find = true;
						break;
					}
				}
				if (is_find) break;
			}
			if (!is_find) return false;
			dgv.Rows[r].Cells[columnName].Value = value;
			return true;
		}


		public static object Get(System.Windows.Forms.DataGridView dgv, string rowName, string columnName)
		{
			int i,r;//r:row index, i :cell index
			bool is_find = false;
			try
			{
				for (r = 0;r < dgv.RowCount;r++)
				{
					for (i = 0; i < dgv.ColumnCount; i++)
					{
						if (dgv.Rows[r].Cells[i].Value == null) continue;
						if (String.Compare(rowName, dgv.Rows[r].Cells[i].Value.ToString()) == 0)
						{
							is_find = true;
							break;
						}
					}
					if (is_find) break;
				}
				if (!is_find) return null;
				return dgv.Rows[r].Cells[columnName].Value;
			}
			catch
			{
				return null;
			}
		}
		public static bool SetID(System.Windows.Forms.DataGridView dgv, int base_id, string id_s = "id")
		{
			int i, r;//r:row index, i :cell index
			for (i = 0; i < dgv.ColumnCount; i++)
			{
				if (dgv.Columns[i].Name == id_s.ToString()) break;
			}
			if (i >= dgv.ColumnCount) return false;//not find column

			try
			{
				for (r = 0; r < dgv.RowCount; r++)
				{
					dgv.Rows[r].Cells[i].Value = base_id+r;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static bool Set(System.Windows.Forms.DataGridView dgv, Object value, Object column=null)
		{
			int i, r;//r:row index, i :cell index
			if(column==null)
			{
				try
				{
					for (r = 0; r < dgv.RowCount; r++)
					{
						for (i = 0; i < dgv.ColumnCount; i++)
						{
							dgv.Rows[r].Cells[i].Value =value;
						}
					}
				}
				catch
				{
					return false;
				}
				return true;
			}

			//else column!=NULL find column
			for (i = 0; i < dgv.ColumnCount; i++)
			{
				if(dgv.Columns[i].Name==column.ToString()) break ;
			}
			if (i >= dgv.ColumnCount) return false;//not find column

			try
			{
				for (r = 0; r < dgv.RowCount; r++)
				{
					dgv.Rows[r].Cells[i].Value = value;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}


		public static bool InitCheckBoxCell(System.Windows.Forms.DataGridView dgv, bool value=true, Object column = null)
		{
			int i, r;//r:row index, i :cell index
			if (column == null)
			{
				try
				{
					for (r = 0; r < dgv.RowCount; r++)
					{
						for (i = 0; i < dgv.ColumnCount; i++)
						{
							dgv.Rows[r].Cells[i] = new DataGridViewCheckBoxCell();
							dgv.Rows[r].Cells[i].Value = value;
						}
					}
				}
				catch
				{
					return false;
				}
				return true;
			}

			//else column!=NULL find column
			for (i = 0; i < dgv.ColumnCount; i++)
			{
				if (dgv.Columns[i].Name == column.ToString()) break;
			}
			if (i >= dgv.ColumnCount) return false;//not find column

			try
			{
				for (r = 0; r < dgv.RowCount; r++)
				{
					dgv.Rows[r].Cells[i] = new DataGridViewCheckBoxCell();
					dgv.Rows[r].Cells[i].Value = value;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}



	}


}
