using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumTable
{
    public partial class frmTaskEkle : Form
    {
        public frmTaskEkle()
        {
            InitializeComponent();
            foreach (PictureBoxInfo User in SQLHelper.Select())
            {
                cbStorys.Items.Add(User.Story_Name);
            }
        }

        private void SearchStoryID(string Story_Name)
        {
            foreach (PictureBoxInfo Items in SQLHelper.Select())
            {
                if (Items.Story_Name == cbStorys.Text)
                {
                    ThisStory_ID = Items.Story_ID;
                }
            }
        }
        int IsFirst;
        Point FirstTaskStoryLocation;
        int ThisStory_ID;
        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            SearchStoryID(cbStorys.Text);
            frmMain frm = frmMain.GetInstance;
            Button PB = new Button();
            Task TaskPass = new Task();
            List<PictureBoxInfo> Data = SQLHelper.Select();
            SQLHelper.UpdateTaskCount(ThisStory_ID);
            foreach (PictureBoxInfo Instance in Data)
            {
                if (ThisStory_ID == Instance.Story_ID)
                {
                    IsFirst = Instance.Story_Task_Count;
                    FirstTaskStoryLocation = Instance.PB_Location;
                    PB.BackColor = Color.FromArgb(Convert.ToInt32(Instance.PB_BackColor));
                }
            }
            foreach (Panel Panel in frm.Controls.OfType<Panel>())
            {
                if (Panel.Name == "panel5")
                {
                    foreach (Panel Panels in Panel.Controls.OfType<Panel>())
                    {
                        if (Panels.Name == "pnlNotStarted")
                        {
                            Panels.Refresh();
                            PB.Location = SQLHelper.GetLastRowTask(ThisStory_ID);
                            if (IsFirst == 0)
                            {
                                PB.Location = FirstTaskStoryLocation;
                            }
                        }
                    }
                }
            }
            TaskPass.Task_BackColor = PB.BackColor.GetHashCode().ToString();
            TaskPass.TaskLocationX = PB.Location.X;
            TaskPass.TaskLocationY = PB.Location.Y;
            TaskPass.Task_Author = txtAuthor.Text;
            TaskPass.Task_DeadLine = dtpDeadLine.Value.ToString();
            TaskPass.Task_Description = rtbDescription.Text;
            TaskPass.Task_Status = 0;//Not Started 0...
            TaskPass.Story_ID = ThisStory_ID;
            TaskPass.Task_Header = txtTask_Header.Text;
            SQLHelper.InsertTask(TaskPass);
            Application.Restart();
           
            this.Close();
        }
    }
}
