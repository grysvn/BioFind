using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

using HtmlAgilityPack;

namespace BioFind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("WARNING!  This will clear the list!  Are you sure you want to do this?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                wordList.Items.Clear();
            else
                return;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ofd.FileName;
                List<string> words = new List<string>();
                if (path.Split(new string[] { "." }, StringSplitOptions.None)[1] == "txt")
                {
                    StreamReader reader = new StreamReader(path);
                    while (!reader.EndOfStream)
                        words.Add(reader.ReadLine());
                }
                foreach (string word in words)
                    wordList.Items.Add(new ListViewItem(word));
            }
            get.Enabled = true;
        }

        private void showExample_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To properly load the file, just make a text file with each word on it's own line.  No other extra characters.");
        }

        private void get_Click(object sender, EventArgs e)
        {
            string temp = get.Text;
            get.Text += " (busy)";
            MessageBox.Show("The application will hang for a small period of time depending on the size of the list.");
            int missed = 0;
            int total = 0;
            foreach (ListViewItem item in wordList.Items)
            {
                bool found = true;
                string word = item.Text.ToLower().Replace(" ", "_");
                string baseURI = "http://www.biology-online.org/dictionary/";
                string html = new WebClient().DownloadString(baseURI + word);
                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(html);
                HtmlNode element = document.GetElementbyId("bo-content");
                string definition = "NO DEFINITION FOUND!!!  ADD IT YOURSELF!!!"; //placeholder for definition
                //no definition found
                if (element.InnerHtml.Contains("noarticletext") || element.InnerText == string.Empty)
                {
                    item.SubItems.Add("NO DEFINITION FOUND!!!  ADD IT YOURSELF!!!");
                    missed++;
                }
                //definition found
                else if (element.InnerHtml.Contains("<p>"))
                {
                    foreach (HtmlNode child in element.ChildNodes)
                    {
                        string childText = child.InnerText;
                        if (childText.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length <= 2 || childText.Contains("noun") || childText.Contains("plural"))
                            continue;
                        else
                        {
                            definition = childText;
                            found = true;
                            break;
                        }

                    }
                }
                else
                    found = false;
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, definition));
                if (!found)
                    missed++;
                total++;
            }
            get.Text = temp;
            clean.Enabled = true;
            save.Enabled = true;
            MessageBox.Show(missed.ToString() + " definitions out of " + total.ToString() + " weren't found.");
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.Write));
                foreach (ListViewItem item in wordList.Items)
                {
                    writer.WriteLine(item.Text + " - " + item.SubItems[1].Text);
                    writer.WriteLine();
                }
                writer.Close();
            }
            else
                return;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in wordList.Items)
            {
                string text = item.SubItems[1].Text;
                if (text.StartsWith("(1)"))
                    text = text.Replace("(1)", "");
                if (text.StartsWith("1."))
                    text = text.Replace("1.", "");
                text = text.Trim(new char[] { ' ', '.', ','});
                text = text.Trim();
                item.SubItems[1].Text = text;
            }
        }

        private string MatchTester(Match match) {
            if (match.Success)
                return "";
            else
                return match.Value;
        }
    }
}
