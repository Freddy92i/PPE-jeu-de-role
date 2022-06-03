using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace formjdrppe
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }
        public static List<AllLogs> List = new List<AllLogs>();
       

        private async void log_Load(object sender, EventArgs e)
        {
            if (List.Count == 0)
            {
                string response = await api.getAllAsync("/logs");
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                List = JSserializer.Deserialize<List<AllLogs>>(response);

            }

            
            dataGridView1.DataSource = List;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
        }
    }
}
