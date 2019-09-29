using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;

namespace GoogleSheetStorageExample
{
    public partial class PostcodeNotesApplication : Form
    {
        bool SaveChangesBool = false;
        string LastSearchedPostcode = "";
        string LastSeachedPostcodeInformation = "";

        public PostcodeNotesApplication()
        {
            InitializeComponent();
        }

        private void FindPostcode_Click(object sender, EventArgs e)
        {
            if (PostcodeInformationRichBox.Enabled)
            {
                if (LastSeachedPostcodeInformation != PostcodeInformationRichBox.Text.ToString())
                {
                    DialogResult Result = MessageBox.Show("The Postcode Information has not been save! Would you like to save it?", "Save changes", MessageBoxButtons.YesNo);

                    if (Result == DialogResult.Yes)
                    {
                        SaveUserChanges();
                    }
                }
            }

            string PostcodeToFindString = PostcodeToFind.Text;

            if (PostcodeToFindString.Length != 7)
            {
                MessageBox.Show("Postcode length is incorrect");
                return;
            }

            ValueRange Values = Program.CellDataRequest(Program.AllSheetRange);

            //Update searched postcode
            LastSearchedPostcode = PostcodeToFindString;

            string PostcodeInformation = Program.FindPostcodeInformation(Values, LastSearchedPostcode);
            
            if (PostcodeInformation == "Not Found")
            {
                DialogResult Result = MessageBox.Show("Postcode was not found! Do you wish to add it?", "Search Result", MessageBoxButtons.YesNo);

                if (Result == DialogResult.Yes)
                {
                    SaveChangesBool = false;
                    PostcodeInformationRichBox.Text = "Please enter information about this postcode";
                    LastSeachedPostcodeInformation = PostcodeInformationRichBox.Text.ToString();

                    Program.CreateNewPostcodeEntry(LastSearchedPostcode, LastSeachedPostcodeInformation, Program.AllSheetRange);
                    PostcodeInformationRichBox.Enabled = true;
                }
            }
            else
            {
                SaveChangesBool = false;
                PostcodeInformationRichBox.Enabled = true;

                PostcodeInformationRichBox.Text = PostcodeInformation;
                LastSeachedPostcodeInformation = PostcodeInformation;
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            SaveUserChanges();
        }

        private void SaveUserChanges()
        {
            PostcodeInformationRichBox.Enabled = false;

            string CellToUpdate = "B" + Program.CurrentRowSelected.ToString();
            Program.UpdatePostcodeInformation(PostcodeInformationRichBox.Text.ToString(), CellToUpdate);

            SaveChangesBool = true;
        }

        private void PostcodeInformationRichBox_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void PostcodeToFind_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindPostcode_Click(sender, new EventArgs());
            }
        }
    }
}
