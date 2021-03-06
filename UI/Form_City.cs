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
    public partial class Form_City : Form
    {
        public Form_City(City city = null)
        {
            InitializeComponent();
            if (city != null && city.Id <= 0)
            {
                city = null;
            }

            //טעינת אוסף הישובים לרשימה בטופס

            CityArrToForm(city);
            CityToForm(city);
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
                City city = FormToCity();

                if (label_Id.Text == "0")
                {
                    city.Insert();
                    MessageBox.Show("Saved");
                }

                else
                {
                    city.Update();
                    MessageBox.Show("Updated");
                }
                CityArrToForm(city);

            }
        }

        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            //בדיקת שם פרטי //

            if (textBox_Name.Text.Length < 2)
            {
                flag = false;
                label_Name.ForeColor = Color.Red;
            }
            else
                label_Name.ForeColor = Color.White;

            if (!flag)
            {
                pictureBox1.Image = PromoFinal_CarmellWasserman.Properties.Resources.chunk_the_groundhog_chunk;
            }
            else
            {
                pictureBox1.Image = PromoFinal_CarmellWasserman.Properties.Resources.chunk_the_groundhog_chunk3;
            }



            return flag;
        }

        private City FormToCity()
        {
            City city = new City();
            city.Name = textBox_Name.Text;
            city.Id = int.Parse(label_Id.Text);
            //בדיקה האם יש ערך בשדה להמרה

            
            return city;
        }

        

        private void CityArrToForm( City curCity= null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CityArr cityArr = new CityArr();
            cityArr.Fill();
            listBox_Cities.DataSource = cityArr;
            listBox_Cities.ValueMember = "Id";
            listBox_Cities.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCity != null)
            {
                listBox_Cities.SelectedValue = curCity.Id;
            }
        }

        private void CityToForm(City city = null)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס



            if (city != null)
            {
                label_Id.Text = city.Id.ToString();
                textBox_Name.Text = city.Name;
                
            }

            else
            {
                label_Id.Text = "0";
                textBox_Name.Text = "";
                
            }
        }

        private void listBox_Cities_DoubleClick(object sender, EventArgs e)
        {
            City city = listBox_Cities.SelectedItem as City;
            CityToForm(city);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            label_Id.Text = "0";
            textBox_Name.Text = "";
            
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            City city = FormToCity();
            if (city.Id == 0)
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
                    city = FormToCity();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(city))
                        MessageBox.Show("You can’t delete a city that is related to a client");
                    else
                    {
                        if (city.Delete())
                        {
                            MessageBox.Show("Deleted");
                        }

                        else
                        {
                            MessageBox.Show("Not Deleted");
                        }
                        CityToForm(null);
                        CityArrToForm();
                    }
                }
            }
        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_FilterId.Text != "")
                id = int.Parse(textBox_FilterId.Text);

            //מייצרים אוסף של כלל הלקוחות

            CityArr cityArr = new CityArr();
            cityArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            cityArr = cityArr.Filter(id, textBox_FilterName.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Cities.DataSource = cityArr;

        }

        public City SelectedCity
        {
            get => listBox_Cities.SelectedItem as City;
        }

    }
}
