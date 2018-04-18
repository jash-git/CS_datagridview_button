using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 資料來源: https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview.cellclick.aspx
*/
namespace CS_datagridview_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //---
            //dataGridView初始化
            try
            {
                //--
                //dataGridView1.ReadOnly = true;//唯讀 不可更改
                dataGridView1.RowHeadersVisible = false;//DataGridView 最前面指示選取列所在位置的箭頭欄位
                dataGridView1.Rows[0].Selected = false;//取消DataGridView的默認選取(選中)Cell 使其不反藍
                dataGridView1.AllowUserToAddRows = false;//是否允許使用者新增資料
                dataGridView1.AllowUserToDeleteRows = false;//是否允許使用者刪除資料
                dataGridView1.AllowUserToOrderColumns = false;//是否允許使用者調整欄位位置
                //所有表格欄位寬度全部變成可調 dataGridView1.AllowUserToResizeColumns = false;//是否允許使用者改變欄寬
                dataGridView1.AllowUserToResizeRows = false;//是否允許使用者改變行高
                dataGridView1.Columns[0].ReadOnly = true;//單一欄位禁止編輯
                dataGridView1.Columns[1].ReadOnly = true;//單一欄位禁止編輯
                dataGridView1.AllowUserToAddRows = false;//刪除空白列
                dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;//整列選取
                //--

                do
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow r1 = this.dataGridView1.Rows[i];//取得DataGridView整列資料
                        this.dataGridView1.Rows.Remove(r1);//DataGridView刪除整列
                    }
                } while (dataGridView1.Rows.Count > 0);

            }
            catch
            {
            }
            //---dataGridView初始化

            //---
            //增加dataGridView測試資料
            dataGridView1.Rows.Add(false, "Data01", "set Value");
            dataGridView1.Rows.Add(false, "Data02", "set Value");
            dataGridView1.Rows.Add(false, "Data03", "set Value");
            dataGridView1.Rows.Add(false, "Data04", "set Value");
            //---增加dataGridView測試資料
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //---
            //dataGridView內嵌按鈕事件+dataGridView內欄位值修改
            if (e.ColumnIndex == 2)//dataGridView內嵌按鈕事件
            {
                MessageBox.Show("OK-"+e.RowIndex);
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex-1];
                cell.Value = "OK-" + e.RowIndex;//dataGridView內欄位值修改
            }
            //---dataGridView內嵌按鈕事件+dataGridView內欄位值修改
        }
    }
}
