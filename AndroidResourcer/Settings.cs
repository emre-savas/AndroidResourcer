using System;
using System.Data;
using System.Windows.Forms;

namespace DotNetResourcer
{
    public static class Settings
    {
        public static string LegalLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_1234567890";
        public static string Numbers = "1234567890";

        public static string SettingsFileName = "!Settings.dat";
        public static string LettersFileName = "!Letters.dat";

        public static string SettingsFilePath = Application.StartupPath + "\\" + SettingsFileName;
        public static string LettersFilePath = Application.StartupPath + "\\" + LettersFileName;

        public static DataTable GetContentAsDataTable(DataGridView pGrid, bool IgnoreHideColumns = false)
        {
            try
            {
                if (pGrid.ColumnCount == 0)
                    return null;

                DataTable dtSource = new DataTable("Letters");
                foreach (DataGridViewColumn col in pGrid.Columns)
                {
                    if (IgnoreHideColumns & !col.Visible)
                        continue;

                    if (col.Name == string.Empty)
                        continue;

                    dtSource.Columns.Add(col.Name);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }

                if (dtSource.Columns.Count == 0)
                    return null;

                bool containsValue = false;

                foreach (DataGridViewRow row in pGrid.Rows)
                {
                    containsValue = false;

                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        if (row.Cells[col.ColumnName].Value != null
                            && row.Cells[col.ColumnName].Value != DBNull.Value
                            && !containsValue)
                        {
                            containsValue = true;
                        }

                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }

                    if (containsValue)
                    {
                        dtSource.Rows.Add(drNewRow);
                    }
                }

                return dtSource;
            }
            catch { return null; }
        }
    }
}