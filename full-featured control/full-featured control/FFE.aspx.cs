using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace full_featured_control
{
    public partial class FFE : System.Web.UI.Page
    {
        private static int flag = 0;
        private static string date;
        enum StepIndex { PERSDATA = 0, SELECT, SERVICE, PAYTYPE, DATE, CONFIRM };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TextBox1.Text = "";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = (MultiView1.ActiveViewIndex + 1) % 3;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = TextBox1.Text;
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            flag = (flag + 1) % 3;
            if (flag == 0)
            {
                AdRotator1.KeywordFilter = "b2";
            }
            else if (flag == 1)
            {
                AdRotator1.KeywordFilter = "b1";
            }
            else if (flag == 2)
            {
                AdRotator1.KeywordFilter = "";
            }
            Response.Write("Click" + " " + flag);
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            FinishText.Text = "Thank you for order!";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            RadioButtonList1.ClearSelection();
            ListBox1.ClearSelection();
            CheckBoxList1.ClearSelection();
            Calendar1.SelectedDate = DateTime.Now;
        }

        protected void Wizard1_ActiveStepChanged(object sender, EventArgs e)
        {
            string buf = "";
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    buf = li.Value;
                }
            }

            if (Wizard1.ActiveStepIndex.Equals((int)StepIndex.CONFIRM))
            {
                FinishText.Text = TextBox4.Text + " " + TextBox5.Text + " " + TextBox6.Text
                    + "<br>" + RadioButtonList1.SelectedValue
                    + "<br>" + buf
                    + "<br>" + ListBox1.SelectedValue
                    + "<br>" + date;
            }
        }

        protected void Wizard1_CancelButtonClick(object sender, EventArgs e)
        {
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            RadioButtonList1.ClearSelection();
            ListBox1.ClearSelection();
            CheckBoxList1.ClearSelection();
            Calendar1.SelectedDate = DateTime.Now;
            Wizard1.ActiveStepIndex = 0;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            date = String.Empty;
            if (Calendar1.SelectedDates.Count == 1)
            {
                date = Calendar1.SelectedDates[0].ToLongDateString();
            }
            else
            {
                date = Calendar1.SelectedDates[0].ToLongDateString();
                date += " - ";
                date += Calendar1.SelectedDates[Calendar1.SelectedDates.Count - 1].ToLongDateString();
            }
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode tn = TreeView1.SelectedNode;
            string txt=tn.Value;
            if (tn.ShowCheckBox != null && (bool)tn.ShowCheckBox) txt += (tn.Checked ? "ch" : "nch");
            Label1.Text = txt;
        }

        protected void TreeView1_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
            //TreeNode tn = TreeView1.SelectedNode;
            //Label1.Text = tn.Value + (tn.Checked ? "ch" : "nch");
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            Menu mnu = (Menu)sender;
            Response.Write(mnu.SelectedItem.Text + " - " + mnu.SelectedItem.Value);
        }


        protected void Button6_Click1(object sender, EventArgs e)
        {
            flag = (flag + 1) % 3;
            if (flag == 0)
            {
                AdRotator1.KeywordFilter = "b2";
            }
            else if (flag == 1)
            {
                AdRotator1.KeywordFilter = "b1";
            }
            else if (flag == 2)
            {
                AdRotator1.KeywordFilter = "";
            }
            Response.Write(AdRotator1.KeywordFilter);
            Response.Write("Click");
        }
    }
}