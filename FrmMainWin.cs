using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;
using System.Deployment.Application;
using System.Collections;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GroupDataInGrid
{
    public partial class FrmMainWin : Form
    {
        string SqlQuery = "SELECT [Дата],[Организация],[Город],[Страна],[Менеджер],[Количество],[Сумма] FROM ShipmentZone";

        SqlConnection Connect = new SqlConnection(Properties.Settings.Default.SQLConnectionString);
        DataSet DtSet = new DataSet();

        public FrmMainWin()
        {
            InitializeComponent();
            GetDataFromServer(SqlQuery, DtSet);
        }

        void GetDataFromServer(string sql, DataSet dataSet)
        {
            //-----------------------get data from DB
            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter(sql, Connect);

                Connect.Open();
                DataAdapter.Fill(dataSet, "ShipmentZone");
                Connect.Close();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "ShipmentZone";
            }
            catch (Exception except) { MessageBox.Show(except.ToString()); }
        }

        void GetGroupedData(bool IsDate, bool IsOrg, bool IsCity, bool IsCountry, bool IsManager)
        {
            if (IsDate && IsOrg && IsCity && IsCountry && IsManager)
            {
                DtSet = new DataSet();
                GetDataFromServer(SqlQuery, DtSet);
                return;
            }

            DataSet dts = new DataSet();
            string Fields = "";
            if (IsDate) Fields += "[Дата],";
            if (IsOrg) Fields += "[Организация],";
            if (IsCity) Fields += "[Город],";
            if (IsCountry) Fields += "[Страна],";
            if (IsManager) Fields += "[Менеджер],";

            string sqlQuery = " SELECT SUM([Количество]) as [Количество], SUM([Сумма]) as [Cумма] FROM [dbo].[ShipmentZone] ";
                           
            if (!string.IsNullOrEmpty(Fields))
            {
                Fields = Fields.Substring(0, Fields.Length - 1);

                sqlQuery = $" SELECT {Fields} , SUM([Количество]) as [Количество], SUM([Сумма]) as [Cумма] FROM [dbo].[ShipmentZone] " +
                           $" GROUP BY {Fields} ";
            }

            GetDataFromServer(sqlQuery, dts);
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            GetGroupedData(chkDate.Checked, chkOrg.Checked, chkCity.Checked, chkCountry.Checked, chkManager.Checked);
        }

        private void chkOrg_CheckedChanged(object sender, EventArgs e)
        {
            GetGroupedData(chkDate.Checked, chkOrg.Checked, chkCity.Checked, chkCountry.Checked, chkManager.Checked);
        }

        private void chkCity_CheckedChanged(object sender, EventArgs e)
        {
            GetGroupedData(chkDate.Checked, chkOrg.Checked, chkCity.Checked, chkCountry.Checked, chkManager.Checked);
        }

        private void chkCountry_CheckedChanged(object sender, EventArgs e)
        {
            GetGroupedData(chkDate.Checked, chkOrg.Checked, chkCity.Checked, chkCountry.Checked, chkManager.Checked);
        }

        private void chkManager_CheckedChanged(object sender, EventArgs e)
        {
            GetGroupedData(chkDate.Checked, chkOrg.Checked, chkCity.Checked, chkCountry.Checked, chkManager.Checked);
        }
    }
}
