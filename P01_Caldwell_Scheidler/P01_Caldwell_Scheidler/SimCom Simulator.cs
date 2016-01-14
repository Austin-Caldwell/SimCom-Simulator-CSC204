﻿// CSC 204 P01 - Austin Caldwell and Joshua Scheidler - 2016
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P01_Caldwell_Scheidler
{
    public partial class SimComSimulator : Form
    {
        public SimComSimulator()
        {
            InitializeComponent();
        }

        private void openTextFileToolStripMenuItem_Click(object sender, EventArgs e)    // Referencing: https://msdn.microsoft.com/en-us/library/aa984392%28v=vs.71%29.aspx
        {
            DialogResult fileChosen;
            fileChosen = openTextFileDialog.ShowDialog();
            string progLine;
            int lineNumber;

            if (fileChosen == DialogResult.OK)
            {
                StreamReader textReader = new StreamReader(openTextFileDialog.FileName);
                List<Assembly> AssemText = new List<Assembly>();

                while ((progLine = textReader.ReadLine()) != null)
                {
                    if (!progLine.StartsWith("."))  // Line of Program Contains NO Preprocessor Directive
                    {
                        if (!progLine.StartsWith("   ") && !progLine.StartsWith(" "))   // Line of Program HAS LABEL
                        {
                            Parser(progLine);
                        }
                        else // Line of Program has NO LABEL
                        {
                            Parser(progLine);
                        }

                        lineNumber++;       // Count line of actual program code
                    }
                    else if (progLine.StartsWith(".DATA"))  // Line of Program is a .DATA Preprocessor Directive
                    {

                    }
                    else { }    // Line of Program is a Preprocessor Directive or Error
                }

                //MessageBox.Show(textReader.ReadToEnd()); // For Debugging Purposes
                
                textReader.Close();
                progTextBox.Text = File.ReadAllText(openTextFileDialog.FileName);
            }

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Parser(string progLine)    // Referencing http://stackoverflow.com/questions/858756/how-to-parse-a-text-file-with-c-sharp - Samir Talwar
        {
            string[] items = progLine.Split('\t', ' ');
            List<string> itemList = items.ToList();     // Convert the string array to a list of strings

            foreach (var x in itemList)    // Go through items in list, looking only for text desired
            {
                if (x.Contains(' ') || x.Contains(" ")) // Do not save any items in array that are a SPACE or TAB
                {
                    itemList.Remove(x);
                }
                else
                {

                }
                AssemText.Add(new Assembly());
            }
        }
    }
}
