using DeskAssembleData;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskAssemble
{
    public partial class ProductCatalogueForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ProductCatalogueForm()
        {
            InitializeComponent();
        }

        private Image ConvertByteToImage(byte[] dataImage)
        {
            using (MemoryStream ms = new MemoryStream(dataImage))
            {
                return Image.FromStream(ms);
            }
        }

        private byte[] ConvertImageToByte( Image img)
        {
            Image temp = new Bitmap(img);
            using (MemoryStream ms = new MemoryStream())
            {
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        //열기버튼
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                textBox4.Text = openFileDialog1.SafeFileName;
            }
        }

        //등록버튼
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            using (DeskAssemblyEntities db = new DeskAssemblyEntities())
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                    return;

                Item item = new Item();
                item.Name = textBox1.Text;
                item.Price = int.Parse(textBox2.Text);

                if (comboBoxEdit1.Text == "부품")
                    item.IsProduct = false;
                else if (comboBoxEdit1.Text == "제품")
                    item.IsProduct = true;
                else
                    return;

                item.Image = ConvertImageToByte(pictureBox1.Image);
                db.Items.Add(item);
                db.SaveChanges();

                if (item.IsProduct == false)
                    MessageBox.Show("부품 등록 완료", "Message", MessageBoxButtons.OKCancel);
                else
                    MessageBox.Show("제품 등록 완료", "Message", MessageBoxButtons.OKCancel);
                itemBindingSource.Add(item);
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            pictureBox1.Image = null;
        }

        //수정버튼
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int ID = (int)dataGridView1.SelectedCells[0].Value;

            using (DeskAssemblyEntities db = new DeskAssemblyEntities())
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                    return;
                
                Item item = db.Items.Find(ID);
                if(item != null)
                {
                    item.Name = textBox1.Text;
                    item.Price = int.Parse(textBox2.Text);

                    if (comboBoxEdit1.Text == "부품")
                        item.IsProduct = false;
                    else if (comboBoxEdit1.Text == "제품")
                        item.IsProduct = true;
                    else
                        return;
                   
                    item.Image = ConvertImageToByte(pictureBox1.Image);
                    db.SaveChanges();
                    itemBindingSource.DataSource = db.Items.ToList();

                }
            }
        }

        //삭제버튼
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("삭제할 항목이 없습니다.", "에러", MessageBoxButtons.OK);
                return;
            }

            int ID = (int)dataGridView1.SelectedCells[0].Value;

            using (DeskAssemblyEntities db = new DeskAssemblyEntities())
            {
                try
                {
                    Item item = db.Items.Find(ID);
                    db.Items.Remove(item);
                    db.SaveChanges();
                    MessageBox.Show("삭제 완료", "삭제", MessageBoxButtons.OK);

                    itemBindingSource.RemoveCurrent();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("삭제할 항목이 없습니다.");
                }
            }
        }

        private void ProductCatalogueForm_Load(object sender, EventArgs e)
        {
            using (DeskAssemblyEntities db = new DeskAssemblyEntities())
            {
                itemBindingSource.DataSource = db.Items.ToList();
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        //새로고침버튼
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (DeskAssemblyEntities db = new DeskAssemblyEntities())
            {
                itemBindingSource.DataSource = db.Items.ToList();
            }
        }

        //그리드 클릭 시 우측상단에 제품 및 부품 정보 출력
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            InfoItemSetting();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoItemSetting();
        }

        private void InfoItemSetting()
        {
            int ID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            
            using(DeskAssemblyEntities db = new DeskAssemblyEntities())
            {
                Item item = db.Items.Find(ID);
                textBox1.Text = item.Name;
                textBox2.Text = item.Price.ToString();

                if (item.IsProduct == false)
                    comboBoxEdit1.Text = "부품";
                else
                    comboBoxEdit1.Text = "제품";

                pictureBox1.Image = ConvertByteToImage(item.Image);
            }
        }

        //초기화버튼
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
          
            pictureBox1.Image = null;
        }
    }
}