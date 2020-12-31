using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskAssembleRFID
{
    public partial class RFIDForm : XtraForm
    {
        public RFIDForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = "COM5";
                serialPort1.Open();
            }

            base.OnLoad(e);
        }

        private int movementCheckedState { get; set; }

        String tag1 = "e4 a5 90 2a";
        String tag2 = "c3 56 a5 40";
        String tag3 = "22 51 cf 34";
        String tag4 = "e9 4a 81 9d";
        String tag5 = "c0 03 3a 32";
        String tag6 = "b0 94 a0 32";
        String tag7 = "83 3d 47 02";
        String tag8 = "e5 e1 5e 23";
        String tag9 = "d5 99 55 23";
        String tag10 = "f9 f2 b5 b2";

        Item[] items = new Item[10];

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //if (textEdit7.Text != "" && !serialPort1.IsOpen)
            //{
            //    serialPort1.PortName = textEdit7.Text;
            //    serialPort1.Open();
            //}
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string input = serialPort1.ReadLine();

                for (int i = 0; i < items.Length; i++)
                {
                    if (input.IndexOf(items[i].CardId) != -1)
                    {
                        textEdit1.Invoke(new MethodInvoker(delegate ()
                        {
                            textEdit1.Text = items[i].ItemId.ToString();
                        }));
                        textEdit2.Invoke(new MethodInvoker(delegate ()
                        {
                            textEdit2.Text = items[i].ContractId.ToString();
                        }));
                        textEdit3.Invoke(new MethodInvoker(delegate ()
                        {
                            items[i].dt = DateTime.Now;
                            textEdit3.Text = items[i].dt.ToString();
                        }));
                        textEdit6.Invoke(new MethodInvoker(delegate ()
                        {
                            textEdit6.Text = items[i].name;
                        }));

                        break;
                    }
                }
            }
        }

        class Item
        {
            public string name;
            public int ItemId;
            public int ContractId;
            public string CardId;
            public DateTime dt;
        }


        private void RFIDForm_Load(object sender, EventArgs e)
        {
            items[0] = new Item();
            items[0].name = "책상1";
            items[0].ItemId = 1;
            items[0].ContractId = 1;
            items[0].CardId = tag1;
            items[0].dt = DateTime.Now;

            items[1] = new Item();
            items[1].name = "책상1";
            items[1].ItemId = 1;
            items[1].ContractId = 3;
            items[1].CardId = tag5;
            items[1].dt = DateTime.Now;

            items[2] = new Item();
            items[2].name = "책상2";
            items[2].ItemId = 2;
            items[2].ContractId = 2;
            items[2].CardId = tag2;
            items[2].dt = DateTime.Now;

            items[3] = new Item();
            items[3].name = "책상2";
            items[3].ItemId = 2;
            items[3].ContractId = 4;
            items[3].CardId = tag6;
            items[3].dt = DateTime.Now;

            items[4] = new Item();
            items[4].name = "책상3";
            items[4].ItemId = 3;
            items[4].ContractId = 3;
            items[4].CardId = tag3;
            items[4].dt = DateTime.Now;

            items[5] = new Item();
            items[5].name = "책상3";
            items[5].ItemId = 3;
            items[5].ContractId = 5;
            items[5].CardId = tag7;
            items[5].dt = DateTime.Now;

            items[6] = new Item();
            items[6].name = "책상4";
            items[6].ItemId = 4;
            items[6].ContractId = 4;
            items[6].CardId = tag4;
            items[6].dt = DateTime.Now;

            items[7] = new Item();
            items[7].name = "책상4";
            items[7].ItemId = 4;
            items[7].ContractId = 1;
            items[7].CardId = tag8;
            items[7].dt = DateTime.Now;

            items[8] = new Item();
            items[8].name = "책상5";
            items[8].ItemId = 17;
            items[8].ContractId = 5;
            items[8].CardId = tag9;
            items[8].dt = DateTime.Now;

            items[9] = new Item();
            items[9].name = "책상5";
            items[9].ItemId = 17;
            items[9].ContractId = 2;
            items[9].CardId = tag10;
            items[9].dt = DateTime.Now;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.Properties.Items[radioGroup1.SelectedIndex].AccessibleName == "In")
                movementCheckedState = 1; //입고

            else if (radioGroup1.Properties.Items[radioGroup1.SelectedIndex].AccessibleName == "Out")
                movementCheckedState = 0; //출고
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection DeskConn = new SqlConnection();
                DeskConn.ConnectionString = "Server = 10.10.31.22; database = DeskAssembly; uid = sa; pwd = 3512";
                DeskConn.Open();

                SqlCommand Command = new SqlCommand();
                Command.Connection = DeskConn;
                Command.CommandType = CommandType.StoredProcedure;

                Command.CommandText = "DBInData";
                {
                    Command.Parameters.AddWithValue("@ItemId", textEdit1.Text);
                    Command.Parameters.AddWithValue("@ContractId", textEdit2.Text);
                    Command.Parameters.AddWithValue("@Datetime", textEdit3.Text);
                    Command.Parameters.AddWithValue("@WareHouseId", textEdit4.Text);
                    Command.Parameters.AddWithValue("@Quantity", textEdit5.Text);
                    Command.Parameters.AddWithValue("@IsIn", movementCheckedState);
                }

                if (radioGroup1.Properties.Items[radioGroup1.SelectedIndex].AccessibleName == "In")
                    XtraMessageBox.Show("입고되었습니다.", "Information");

                else if (radioGroup1.Properties.Items[radioGroup1.SelectedIndex].AccessibleName == "Out")
                    XtraMessageBox.Show("출고되었습니다.", "Information");

                Command.ExecuteNonQuery();

                DeskConn.Close();
            }
            catch(SqlException ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}