using Adressbok.Classes;
using System.Windows.Forms;
using System;
namespace Adressbok
{
//    Adressbok
//Programmet är utvecklat för att spara personer med information om dem till en lista på datorn i form av en textfil.

//Man kan alltid uppdatera information om personer samt radera eller lägga till nya personer i adressboken.

//Det går att söka på namn och postort genom adressboken.

//version 2.1

//Skapad av: Dimitri Ismagilov

    public partial class Form1 : Form
    {
        private Filehandler contact = new Filehandler();
        private List<Person> searchList = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            contact.LoadPeople();
            UpdateListView();
        }
        //Metoden för knappen spara, som sparar person till listan samt kontrollerar alla fält i formuläret ifyllda.
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxAddress.Text == "" || textBoxPostalCode.Text == "" || textBoxCity.Text == "" || textBoxEmail.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Alla fällt måste vara ifyllda");
            }
            var person = new Person();
            {
                person.Name = textBoxName.Text;
                person.Address = textBoxAddress.Text;
                person.PostalCode = textBoxPostalCode.Text;
                person.City = textBoxCity.Text;
                person.Email = textBoxEmail.Text;
                person.Phone = textBoxPhone.Text;
            };
            contact.AddPerson(person);
            UpdateListView();
        }
        //Metoden för knappen uppdatera, som uppdaterar kontakter i adressboken samt uppdatera listan med kontakter.
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count > 0)
            {
                int index = listViewResult.SelectedItems[0].Index;
                var newPerson = new Person
                {
                    Name = textBoxName.Text,
                    Address = textBoxAddress.Text,
                    PostalCode = textBoxPostalCode.Text,
                    City = textBoxCity.Text,
                    Email = textBoxEmail.Text,
                    Phone = textBoxPhone.Text
                };
                contact.UpdatePerson(index, newPerson);
                UpdateListView();
            }
        }
        //Metoden för knappen radera, som raderar kontakter från listan.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count > 0)
            {
                int index = listViewResult.SelectedItems[0].Index;

                if (searchList.Count > 0 && index < searchList.Count)
                {
                    var personToDelete = searchList[index];
                    contact.DeletePerson(contact.People.IndexOf(personToDelete));
                    searchList.RemoveAt(index);
                }

                else
                {
                    contact.DeletePerson(index);
                }
                UpdateListView();
            }
        }
        //Metoden för sök knappen sök, som loppar genom listan och söker efter poster och visar resultat i listview.
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValueName = textBoxSearchName.Text;
            string searchValueCity = textBoxSearchCity.Text;

            listViewResult.Items.Clear();
            searchList.Clear();
            foreach (var person in contact.People)
            {
                    if (person.Name.ToLower().Contains(searchValueName.ToLower()) && person.City.ToLower().Contains(searchValueCity.ToLower()))
                    {
                        var item = new ListViewItem(person.Name);
                        {                          
                            item.SubItems.Add(person.Name);
                            item.SubItems.Add(person.Address);
                            item.SubItems.Add(person.PostalCode);
                            item.SubItems.Add(person.City);
                            item.SubItems.Add(person.Email);
                            item.SubItems.Add(person.Phone);
                        }
                        listViewResult.Items.Add(item);
                        searchList.Add(person);
                    }

                textBoxName.Clear(); textBoxAddress.Clear(); textBoxPostalCode.Clear();
                textBoxCity.Clear(); textBoxEmail.Clear(); textBoxPhone.Clear();
            }
        }
        //Metoden för att uppdatera resultatboxen.
        private void UpdateListView()
        {
            listViewResult.Items.Clear();
            foreach (var person in contact.People)
            {
                var item = new ListViewItem(person.Name);
                {
                    item.SubItems.Add(person.Name);
                    item.SubItems.Add(person.Address);
                    item.SubItems.Add(person.PostalCode);
                    item.SubItems.Add(person.City);
                    item.SubItems.Add(person.Email);
                    item.SubItems.Add(person.Phone);
                }
                listViewResult.Items.Add(item);
                textBoxName.Clear(); textBoxAddress.Clear(); textBoxPostalCode.Clear();
                textBoxCity.Clear(); textBoxEmail.Clear(); textBoxPhone.Clear();
            }
        }
        //Metoden för att överföra information från resultat boxén till formuläret.
        private void listViewResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewResult.SelectedItems[0];
                textBoxName.Text = item.SubItems[1].Text;
                textBoxAddress.Text = item.SubItems[2].Text;
                textBoxPostalCode.Text = item.SubItems[3].Text;
                textBoxCity.Text = item.SubItems[4].Text;
                textBoxEmail.Text = item.SubItems[5].Text;
                textBoxPhone.Text = item.SubItems[6].Text;
            }
        }
    }
}

