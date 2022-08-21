using AssettoServerBuilder.Types;

namespace AssettoServerBuilder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            AcceptButton = okEntryList;
            checkTypeEntryList.SelectedIndex = 0;
            sortTypeEntryList.SelectedIndex = 0;
            
            entryList.DataSource = Form1.Entries;
            for (int i = 0; i < entryList.Items.Count; i++)
            {
                var entry = (Entry)entryList.Items[i];
                if (entry.Ai == "fixed")
                {
                    entryList.SetItemChecked(i, true);
                }
            }
        }

        private void OnCheckAllClick(object sender, EventArgs e)
        {
            for (int i = 0; i < entryList.Items.Count; i++)
            {
                entryList.SetItemChecked(i, true);
            }
        }

        private void OnUncheckAllClick(object sender, EventArgs e)
        {
            for (int i = 0; i < entryList.Items.Count; i++)
            {
                entryList.SetItemChecked(i, false);
            }
        }

        private void OnApplyCheckClick(object sender, EventArgs e)
        {
            bool parsedEntryAmount = int.TryParse(entriesAmount.Text, out int entries);
            if (!parsedEntryAmount)
            {
                MessageBox.Show($@"Couldn't parse entry amount. Enter correct value and try again.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (entryList.Items.Count == 0)
            {
                return;
            }
            
            // 0 - first, 1 - last
            if (checkTypeEntryList.SelectedIndex == 0)
            {
                for (int i = 0; i < entryList.Items.Count && i < entries; i++)
                {
                    entryList.SetItemChecked(i, true);
                }
            } 
            else if (checkTypeEntryList.SelectedIndex == 1)
            {
                for (int i = entryList.Items.Count - 1; i >= 0 && i > entryList.Items.Count - entries - 1; i--)
                {
                    entryList.SetItemChecked(i, true);
                }
            }
        }

        private void OnOkClick(object sender, EventArgs e)
        {
            foreach (Entry entry in entryList.CheckedItems)
            {
                entry.Ai = "fixed";
            }

            if (sortTypeEntryList.Text == "entries with AI=none go first")
            {
                Form1.SortEntries = 1;
            } else if (sortTypeEntryList.Text == "entries with AI=fixed go first")
            {
                Form1.SortEntries = 2;
            }
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCloseClick(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
