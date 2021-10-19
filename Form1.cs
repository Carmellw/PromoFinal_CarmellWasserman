using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PromoFinal_CarmellWasserman.BL;

namespace PromoFinal_CarmellWasserman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientArrToForm();
        }

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        private void textBox_Heb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.KeyChar = char.MinValue;
            }

            else
            {
                CapsLockCheck();
            }
            


        }


        private void save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading |
                MessageBoxOptions.RightAlign);
            }
            else
            {
                MessageBox.Show("All Fields OK");
                Client client = FormToClient();

                if (label_Id.Text == "0")
                {
                    client.Insert();
                    MessageBox.Show("Saved");
                }

                else
                {
                    client.Update();
                    MessageBox.Show("Updated");
                }
                ClientArrToForm();
                
            }
        }

        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            //בדיקת שם פרטי //

            if (textBox_FirstName.Text.Length < 2)
            {
                flag = false;
                textBox_FirstName.BackColor = Color.Red;
            }
            else
                textBox_FirstName.BackColor = Color.White;

            //בדיקת שם משפחה //

            if (textBox_LastName.Text.Length < 2)
            {
                flag = false;
                textBox_LastName.BackColor = Color.Red;
            }
            else
                textBox_LastName.BackColor = Color.White;

            //בדיקת מספר טלפון //

            if (textBox_PhoneNumber.Text.Length != 10)
            {
                flag = false;
                textBox_PhoneNumber.BackColor = Color.Red;
            }
            else
                textBox_PhoneNumber.BackColor = Color.White;
            

            //בדיקת מיקוד //

            if (textBox_ZipCode.Text.Length != 7)
            {
                flag = false;
                textBox_ZipCode.BackColor = Color.Red;
            }
            else
                textBox_ZipCode.BackColor = Color.White;

            return flag;
        }

        private Client FormToClient()
        {
            Client client = new Client();
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Id = int.Parse(label_Id.Text);
            //בדיקה האם יש ערך בשדה להמרה

            if (textBox_ZipCode.Text != "")
                client.ZipCode = int.Parse(textBox_ZipCode.Text);
            client.PhoneNumber = int.Parse(textBox_PhoneNumber.Text);
            return client;
        }

        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                pictureBox_CapsLock.Visible = true; 
            }

            else
            {
                pictureBox_CapsLock.Visible = false;

            }
            //כאן תהיה תיבת הודעה או סימון אחר//
        }

        private void ClientArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
        }

        private void ClientToForm(Client client)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס

            

            if (client != null)
            {
                label_Id.Text = client.Id.ToString();
                textBox_FirstName.Text = client.FirstName;
                textBox_LastName.Text = client.LastName;
                textBox_PhoneNumber.Text = client.PhoneNumber.ToString();
                textBox_ZipCode.Text = client.ZipCode.ToString();
            }

            else
            {
                label_Id.Text = "0";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_PhoneNumber.Text = "";
                textBox_ZipCode.Text = "";
            }
        }

        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            Client client = listBox_Clients.SelectedItem as Client;
            ClientToForm(client);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            label_Id.Text = "0";
            textBox_FirstName.Text = "";
            textBox_LastName.Text = "";
            textBox_PhoneNumber.Text = "";
            textBox_ZipCode.Text = "";
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Client client = FormToClient();
            if (client.Id == 0)
            {
                MessageBox.Show("You need to choose a client");
            }
            else

            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (client.Delete())
                    {
                        MessageBox.Show("Deleted");
                    }

                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }
                    ClientToForm(null);
                    ClientArrToForm();
                }
            }
        }
    }
}
