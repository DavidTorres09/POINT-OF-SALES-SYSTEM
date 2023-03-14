using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_PointOfSale.Entities;
using Sol_PointOfSale.Business;

namespace Sol_PointOfSale.Presentation
{
    public partial class Frm_Point_Of_Sale : Form
    {
        public Frm_Point_Of_Sale()
        {
            InitializeComponent();
        }
        #region "My variables"
        int nCode = 0;
        int Statesave = 0;
        #endregion

        #region "My methods"
        private void Format_ps()
        {
            dgv_List.Columns[0].Width= 100;
            dgv_List.Columns[0].HeaderText = "CODIGO_PS";
            dgv_List.Columns[1].Width = 250;
            dgv_List.Columns[1].HeaderText = "POINT OF SALE";
        }

        private void List_ps(string cText)
        {
            try
            {
                dgv_List.DataSource = B_Point_Of_Sale.List_ps(cText);
                this.Format_ps();
                lbl_totalregisters.Text = "Total registers: " + Convert.ToString(dgv_List.Rows.Count);
;            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        public void Frm_Point_Of_Sale_Load(object sender, EventArgs e)
        {
            this.List_ps("%");
        }
    }
}
