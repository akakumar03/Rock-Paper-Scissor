using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Rock_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Random rand = new Random(DateTime.Now.Millisecond); //Declaring a variable for random.
        double computer = rand.Next(1, 4); //Randomize the computer selection between 1 and 4.

        if (computer == 1)
        {
            Label1.Text = "Computer choses Rock";
        }
        else if (computer == 2)
        {
            Label1.Text = " Computer choses Paper";
        }
        else if (computer == 3)
        {

            Label1.Text = "Computer choses Scissor";
        }
        //We need to compare the random generation of the computer with the users input.
        // There can be 9 outcomes and we are using nested if statements to check it.

        //if (computer == 1 )     
        //{
        //    if (Rock.Checked == true)
        //    {
        //        Label2.Text = "Draw";
        //    };
        //}

        if (computer == 1 && Rock.Checked == true)
        {
            Label2.Text = "Draw";
        }
     else if (computer == 1 && Paper.Checked == true)
        {

            Label2.Text = "Lose";

        }
      else  if (computer == 1 && Scissor.Checked == true)
        {

            Label2.Text = "Win";

        }
        else if (computer == 2 && Rock.Checked == true)
        {
            Label2.Text = "Loose";

        }
        else if (computer == 2 && Paper.Checked == true)
        {
            Label2.Text = "Draw";

        }
        if (computer == 2 && Scissor.Checked == true)
        {
            Label2.Text = "Win";

        }
        else if (computer == 3 && Rock.Checked == true)
        {
            Label2.Text = "Win";

        }
        if (computer == 3)
        {
            if (Paper.Checked == true)
            {
                Label2.Text = "Loose";
            };
        }
        else if (computer == 3 && Scissor.Checked == true)
        {
              Label2.Text = "Draw";

        }
    }
}