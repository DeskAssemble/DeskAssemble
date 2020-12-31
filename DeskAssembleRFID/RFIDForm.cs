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
        String tag11 = "f9 d8 0f c2";
        String tag12 = "f9 2d e1 b0";
        String tag13 = "d9 75 69 c2";
        String tag14 = "29 ca f6 b8";
        String tag15 = "39 a7 d9 a3";
        String tag16 = "b9 ca 18 ba";
        String tag17 = "69 7b 6d c2";
        String tag18 = "09 83 f9 b8";
        String tag19 = "2e 8e 61 19";
        String tag20 = "49 08 29 c3";
        String tag21 = "99 fc fc b9";
        String tag22 = "89 5f f0 c2";
        String tag23 = "e4 3d 50 2a";
        String tag24 = "04 d7 cb 2b";
        String tag25 = "13 e2 80 02";
    
        Item[] items = new Item[25];


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

        private Boolean movementCheckedState { get; set; }

        private void RFIDForm_Load(object sender, EventArgs e)
        {
            items[0] = new Item();
            items[0].name = "책상1";
            items[0].ItemId = 1;
            items[0].ContractId = 6;
            items[0].CardId = tag1;
            items[0].dt = DateTime.Now;

            items[1] = new Item();
            items[1].name = "책상1";
            items[1].ItemId = 1;
            items[1].ContractId = 8;
            items[1].CardId = tag5;
            items[1].dt = DateTime.Now;

            items[2] = new Item();
            items[2].name = "책상2";
            items[2].ItemId = 2;
            items[2].ContractId = 7;
            items[2].CardId = tag2;
            items[2].dt = DateTime.Now;

            items[3] = new Item();
            items[3].name = "책상2";
            items[3].ItemId = 2;
            items[3].ContractId = 9;
            items[3].CardId = tag6;
            items[3].dt = DateTime.Now;

            items[4] = new Item();
            items[4].name = "책상3";
            items[4].ItemId = 3;
            items[4].ContractId = 8;
            items[4].CardId = tag3;
            items[4].dt = DateTime.Now;

            items[5] = new Item();
            items[5].name = "책상3";
            items[5].ItemId = 3;
            items[5].ContractId = 10;
            items[5].CardId = tag7;
            items[5].dt = DateTime.Now;

            items[6] = new Item();
            items[6].name = "책상4";
            items[6].ItemId = 4;
            items[6].ContractId = 9;
            items[6].CardId = tag4;
            items[6].dt = DateTime.Now;

            items[7] = new Item();
            items[7].name = "책상4";
            items[7].ItemId = 4;
            items[7].ContractId = 6;
            items[7].CardId = tag8;
            items[7].dt = DateTime.Now;

            items[8] = new Item();
            items[8].name = "책상5";
            items[8].ItemId = 20;
            items[8].ContractId = 10;
            items[8].CardId = tag9;
            items[8].dt = DateTime.Now;

            items[9] = new Item();
            items[9].name = "책상5";
            items[9].ItemId = 20;
            items[9].ContractId = 7;
            items[9].CardId = tag10;
            items[9].dt = DateTime.Now;

            items[10] = new Item();
            items[10].name = "다리1";
            items[10].ItemId = 9;
            items[10].ContractId = 1;
            items[10].CardId = tag11;
            items[10].dt = DateTime.Now;

            items[11] = new Item();
            items[11].name = "다리2";
            items[11].ItemId = 10;
            items[11].ContractId = 2;
            items[11].CardId = tag12;
            items[11].dt = DateTime.Now;

            items[12] = new Item();
            items[12].name = "다리3";
            items[12].ItemId = 11;
            items[12].ContractId = 3;
            items[12].CardId = tag13;
            items[12].dt = DateTime.Now;

            items[13] = new Item();
            items[13].name = "다리4";
            items[13].ItemId = 12;
            items[13].ContractId = 4;
            items[13].CardId = tag14;
            items[13].dt = DateTime.Now;

            items[14] = new Item();
            items[14].name = "다리5";
            items[14].ItemId = 19;
            items[14].ContractId = 5;
            items[14].CardId = tag15;
            items[14].dt = DateTime.Now;

            items[15] = new Item();
            items[15].name = "판1";
            items[15].ItemId = 5;
            items[15].ContractId = 1;
            items[15].CardId = tag16;
            items[15].dt = DateTime.Now;

            items[16] = new Item();
            items[16].name = "판2";
            items[16].ItemId = 6;
            items[16].ContractId = 2;
            items[16].CardId = tag17;
            items[16].dt = DateTime.Now;

            items[17] = new Item();
            items[17].name = "판3";
            items[17].ItemId = 7;
            items[17].ContractId = 3;
            items[17].CardId = tag18;
            items[17].dt = DateTime.Now;

            items[18] = new Item();
            items[18].name = "판4";
            items[18].ItemId = 8;
            items[18].ContractId = 4;
            items[18].CardId = tag19;
            items[18].dt = DateTime.Now;

            items[19] = new Item();
            items[19].name = "판5";
            items[19].ItemId = 18;
            items[19].ContractId = 5;
            items[19].CardId = tag20;
            items[19].dt = DateTime.Now;

            items[20] = new Item();
            items[20].name = "볼트/너트1";
            items[20].ItemId = 13;
            items[20].ContractId = 1;
            items[20].CardId = tag21;
            items[20].dt = DateTime.Now;

            items[21] = new Item();
            items[21].name = "볼트/너트2";
            items[21].ItemId = 14;
            items[21].ContractId = 2;
            items[21].CardId = tag22;
            items[21].dt = DateTime.Now;

            items[22] = new Item();
            items[22].name = "볼트/너트3";
            items[22].ItemId = 15;
            items[22].ContractId = 3;
            items[22].CardId = tag23;
            items[22].dt = DateTime.Now;

            items[23] = new Item();
            items[23].name = "볼트/너트4";
            items[23].ItemId = 16;
            items[23].ContractId = 4;
            items[23].CardId = tag24;
            items[23].dt = DateTime.Now;

            items[24] = new Item();
            items[24].name = "볼트/너트5";
            items[24].ItemId = 17;
            items[24].ContractId = 5;
            items[24].CardId = tag25;
            items[24].dt = DateTime.Now;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.Properties.Items[radioGroup1.SelectedIndex].AccessibleName == "In")
                movementCheckedState = true; //입고

            else if (radioGroup1.Properties.Items[radioGroup1.SelectedIndex].AccessibleName == "Out")
                movementCheckedState = false; //출고
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection DeskConn = new SqlConnection();
                DeskConn.ConnectionString = "Server = cn76.ipdisk.co.kr,3423; database = DeskAssembly; uid = 8F; pwd = 1";
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