using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;


namespace Html_servers_elements
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        HtmlTable table;
        HtmlTableRow htr;
        HtmlTableCell htc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Select1.Items.Add("1111111");
                Select1.Items.Add("2222222");
                Select1.Items.Add("3333333");
            }

            table = new HtmlTable();
            table.Border = 1;
            table.CellPadding = 3;
            table.CellSpacing = 3;
            table.Align = "center";
            table.BorderColor = "green";

            htr = new HtmlTableRow();
            htc = new HtmlTableCell(); htc.InnerHtml = "Html control"; htr.Cells.Add(htc);
            htc = new HtmlTableCell(); htc.InnerHtml = "OnServerClick"; htr.Cells.Add(htc);
            htc = new HtmlTableCell(); htc.InnerHtml = "OnServerChange"; htr.Cells.Add(htc);
            table.Rows.Add(htr);

            htr = new HtmlTableRow();
            htc = new HtmlTableCell(); htc.InnerHtml = "HtmlInputReset"; htr.Cells.Add(htc);
            htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
            htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
            table.Rows.Add(htr);

            Controls.Add(table);
        }

        protected void Reset_OnServerClick(object sender, EventArgs e)
        {
        }
        protected void Button_OnServerClick(object sender, EventArgs e)
        {
            htr = new HtmlTableRow();
            htc = new HtmlTableCell(); htc.InnerHtml = "HtmlInputButton"; htr.Cells.Add(htc);
            htc = new HtmlTableCell(); htc.InnerHtml = "YES"; htr.Cells.Add(htc);
            htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
            table.Rows.Add(htr);

            Controls.Add(table);
        }
        protected void Submit_OnServerClick(object sender, EventArgs e)
        {
            htr = new HtmlTableRow();
            htc = new HtmlTableCell(); htc.InnerHtml = "HtmlInputSubmit"; htr.Cells.Add(htc);
            htc = new HtmlTableCell(); htc.InnerHtml = "YES"; htr.Cells.Add(htc);
            htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
            table.Rows.Add(htr);

            Controls.Add(table);
        }
        protected void File_OnServerClick(object sender, EventArgs e)
        {
            htr = new HtmlTableRow();
            htc = new HtmlTableCell(); htc.InnerHtml = "HtmlInputFile"; htr.Cells.Add(htc);
            htc = new HtmlTableCell(); htc.InnerHtml = "YES"; htr.Cells.Add(htc);
            htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
            table.Rows.Add(htr);

            Controls.Add(table);
        }
        protected void Common_OnServerChange(object sender, EventArgs e)
        {
            if((new HtmlInputText()).GetType().Equals(sender.GetType()))
            {
                htr = new HtmlTableRow();
                htc = new HtmlTableCell(); htc.InnerHtml = "HtmlInputText"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "YES"; htr.Cells.Add(htc);
                table.Rows.Add(htr);

                Controls.Add(table);
            }
            else if ((new HtmlInputPassword()).GetType().Equals(sender.GetType()))
            {
                htr = new HtmlTableRow();
                htc = new HtmlTableCell(); htc.InnerHtml = "HtmlInputPassword"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "YES"; htr.Cells.Add(htc);
                table.Rows.Add(htr);

                Controls.Add(table);
            }
            else if ((new HtmlInputRadioButton()).GetType().Equals(sender.GetType()))
            {
                htr = new HtmlTableRow();
                htc = new HtmlTableCell(); htc.InnerHtml = "HtmlInputRadioButton"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "YES"; htr.Cells.Add(htc);
                table.Rows.Add(htr);

                Controls.Add(table);
            }
            else if ((new HtmlSelect()).GetType().Equals(sender.GetType()))
            {
                htr = new HtmlTableRow();
                htc = new HtmlTableCell(); htc.InnerHtml = "HtmlSelect"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "YES"; htr.Cells.Add(htc);
                table.Rows.Add(htr);

                Controls.Add(table);
            }
            else if ((new HtmlTextArea()).GetType().Equals(sender.GetType()))
            {
                htr = new HtmlTableRow();
                htc = new HtmlTableCell(); htc.InnerHtml = "HtmlTextArea"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "YES"; htr.Cells.Add(htc);
                table.Rows.Add(htr);

                Controls.Add(table);
            }
            else if ((new HtmlInputCheckBox()).GetType().Equals(sender.GetType()))
            {
                htr = new HtmlTableRow();
                htc = new HtmlTableCell(); htc.InnerHtml = "HtmlInputCheckBox"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "NO"; htr.Cells.Add(htc);
                htc = new HtmlTableCell(); htc.InnerHtml = "YES"; htr.Cells.Add(htc);
                table.Rows.Add(htr);

                Controls.Add(table);
            }
        }
    }
}