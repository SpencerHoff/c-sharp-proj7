using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7
{
    public partial class Project7Form : Form
    {
        string firstname;
        string lastname;

        string upperstate;
        string firstinitial;
        string lastinitial;
        string newstate;

        public Project7Form()
        {
            InitializeComponent();
        }
        /* this changes all of the characters for the state input to uppercase, then determines if the first character of the first 
        and last name is uppercase. If so, it places the values into a single string in the customers box*/
        private void save_button_Click(object sender, EventArgs e)
        {
            
            if (state_box.Text != "")
            {
                upperstate = "";
                foreach (char state in state_box.Text)
                {
                    
                    upperstate = upperstate + char.ToUpper(state);
                    
                }
                MessageBox.Show(upperstate);
                if (char.IsUpper(firstname_box.Text[0]))
                {
                    if (char.IsUpper(lastname_box.Text[0]))
                    {
                        customer_listbox.Items.Add(lastname_box.Text + ", " + firstname_box.Text + ", " + upperstate);
                    }
                    else
                    {
                        MessageBox.Show("Please capitalize the last name.");
                        lastname_box.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please capitalize the first name.");
                    firstname_box.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a value for the state.");
                state_box.Focus();

            }
            
            firstname_box.Text = "";
            lastname_box.Text = "";
            state_box.Text = "";
            firstinitial_box.Text = "";
            lastinitial_box.Text = "";
            firstname_box.Focus();

        }
        //this refrences the selection from the customers list and displays the initials of their name
        private void search_button_Click(object sender, EventArgs e)
        {
            if (customer_listbox.SelectedIndex > -1)
            {
                string str = customer_listbox.SelectedItem.ToString();
                str = str.Trim();
                string[] tokens = str.Split(',');


                firstinitial = tokens[1].Trim();
                firstname_box.Text = firstinitial;
                string firstinitial2 = firstinitial.Remove(1);
                firstinitial_box.Text = firstinitial2;

             
                lastinitial = tokens[0];
                lastname_box.Text = lastinitial;
                string lastinitial2 = lastinitial.Remove(1);
                lastinitial_box.Text = lastinitial2;


                newstate = tokens[2].Trim();
                state_box.Text = newstate;
            }
            else 
            {
                MessageBox.Show("Please select a name to search.");
            }
        }
        // this closes the form
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
