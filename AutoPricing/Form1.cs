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

            comboBox_SelectAutoType.Items.Add("Легковой");
            comboBox_SelectAutoType.Items.Add("Грузовой");
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
                MessageBox.Show("Некорректные данные");
                return;
            }

            Auto newAuto = null;
            if (comboBox_SelectAutoType.Text == "Легковой")
            {
                newAuto = new Car(mark, year, price);
            }
            else if (comboBox_SelectAutoType.Text == "Грузовой")
            {
                newAuto = new Truck(mark, year, price);
            }

            if (!ValidateAuto(newAuto))
            {
                MessageBox.Show("Некорректные данные");
                return;
            }

            if (!autos.Contains(newAuto))
            {
                autos.Add(newAuto);

                ListViewItem item = new ListViewItem(comboBox_SelectAutoType.Text);
                item.SubItems.Add(textBox_Mark.Text);
                item.SubItems.Add(textBox_ReleaseYear.Text);
                item.SubItems.Add(textBox_InitialPrice.Text);
                int actualPrice = newAuto.GetPrice();
                item.SubItems.Add(actualPrice.ToString());
                item.SubItems.Add("" + (listView1.Items.Count+1));
                listView1.Items.Add(item);
            }

            textBox_Mark.Clear();
            textBox_ReleaseYear.Clear();
            textBox_InitialPrice.Clear();
            textBox_Mark.Focus();

            refreshIds();
        }

        private void refreshIds()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[5].Text = "" + (i + 1);
            }
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
                    var selectedRowSubItems = listView1.SelectedItems[0].SubItems;
                    Auto auto = parseAutoFromSubItems(selectedRowSubItems);
                    if (auto != null)
                    {
                        autos.Remove(auto);
                    }

                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }

            }
            catch (ArgumentException)
            {
                // ingore
            }
            refreshIds();
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
            refreshIds();
        }

        private void button_removeById_Click(object sender, EventArgs e)
        {
            int rowNumber;
            try
            {
                rowNumber = int.Parse(textBox_rowNumber.Text, System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowTrailingWhite);
                ListViewItem.ListViewSubItemCollection items = listView1.Items[rowNumber - 1].SubItems;
                Auto auto = parseAutoFromSubItems(items);
                if (auto != null)
                {
                    autos.Remove(auto);
                }

                listView1.Items.RemoveAt(rowNumber - 1);
            }
            catch (Exception)
            {
                // ignore
            }
            refreshIds();
        }

        private Auto parseAutoFromSubItems(ListViewItem.ListViewSubItemCollection items)
        {
            Auto result = null;
            try
            {
                string type = items[0].Text;
                string mark = items[1].Text;
                int releaseYear = int.Parse(items[2].Text);
                int initialPrice = int.Parse(items[3].Text);
                if (type == "Легковой")
                {
                    result = new Car(mark, releaseYear, initialPrice);
                }
                else if (type == "Грузовой")
                {
                    result = new Truck(mark, releaseYear, initialPrice);
                }
            }
            catch (Exception)
            {
                // ignore
            }
            return result;
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            if(listView1.FocusedItem != null)
            {
                int index = listView1.FocusedItem.Index;
                var items = listView1.Items[index].SubItems;

                comboBox_SelectAutoType.Text = items[0].Text;
                textBox_Mark.Text = items[1].Text;
                textBox_ReleaseYear.Text = items[2].Text;
                textBox_InitialPrice.Text = items[3].Text;
            }
        }
    }
}
