using AutoPricing.Models;
using System.ComponentModel.Design;

namespace AutoPricing
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;

        private List<Auto> autos = new List<Auto>();

        public Form1()
        {
            InitializeComponent();

            comboBox_SelectAutoType.Items.Add("��������");
            comboBox_SelectAutoType.Items.Add("��������");
            comboBox_SelectAutoType.SelectedIndex = 0;

            // Create an instance of a ListView column sorter and assign it
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
        }

        private void comboBox_SelectAutoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox_SelectAutoType.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var trim = System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowTrailingWhite;

            string mark = textBox_Mark.Text;
            int year;
            int price;
            try
            {
                year = int.Parse(textBox_ReleaseYear.Text, trim);
                price = int.Parse(textBox_InitialPrice.Text, trim);
            }
            catch (FormatException)
            {
                MessageBox.Show("������������ ������");
                return;
            }

            Auto newAuto = null;
            if (comboBox_SelectAutoType.Text == "��������")
            {
                newAuto = new Car(mark, year, price);
            }
            else if (comboBox_SelectAutoType.Text == "��������")
            {
                newAuto = new Truck(mark, year, price);
            }

            if (!ValidateAuto(newAuto))
            {
                MessageBox.Show("������������ ������");
                return;
            }

            if (!autos.Contains(newAuto))
            {
                autos.Add(newAuto);

                ListViewItem item = new ListViewItem("id");
                item.SubItems.Add(comboBox_SelectAutoType.Text);
                item.SubItems.Add(textBox_Mark.Text);
                item.SubItems.Add(textBox_ReleaseYear.Text);
                item.SubItems.Add(textBox_InitialPrice.Text);
                int actualPrice = newAuto.GetPrice();
                item.SubItems.Add(actualPrice.ToString());
                listView1.Items.Add(item);
            }

            textBox_Mark.Clear();
            textBox_ReleaseYear.Clear();
            textBox_InitialPrice.Clear();
            textBox_Mark.Focus();
        }

        private bool ValidateAuto(Auto newAuto)
        {
            if (newAuto == null)
            {
                return false;
            }
            if (string.IsNullOrEmpty(newAuto.Mark) || newAuto.InitialPrice < 0 || newAuto.ReleaseYear < 1900 || newAuto.ReleaseYear > DateTime.Now.Year)
            {
                return false;
            }
            return true;
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0)
                {
                    var selectedItem = listView1.SelectedItems[0];
                    if (selectedItem != null)
                    {
                        string type = selectedItem.SubItems[1].Text;
                        string mark = selectedItem.SubItems[2].Text;
                        int releaseYear = int.Parse(selectedItem.SubItems[3].Text);
                        int price = int.Parse(selectedItem.SubItems[4].Text);

                        Auto auto = null;
                        if(type == "��������")
                        {
                            auto = new Car(mark, price, releaseYear);
                        }
                        else if (type == "��������")
                        {
                            auto = new Truck(mark, price, releaseYear);
                        }

                        autos.Remove(auto);
                    }
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }

            }
            catch(ArgumentException)
            {
                // ingore
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }

        private void button_removeByRowNumber_Click(object sender, EventArgs e)
        {
            int rowNumber;
            try
            {
                rowNumber = int.Parse(textBox_rowNumber.Text, System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowTrailingWhite);


                listView1.Items.RemoveAt(rowNumber - 1);
            } 
            catch (Exception)
            {
                // ignore
            }
        }
    }
}