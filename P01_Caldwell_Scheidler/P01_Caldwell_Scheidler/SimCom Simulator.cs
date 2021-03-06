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
using System.Text.RegularExpressions;

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
            string parsedProgram = "";
            string parsedData = "";
            int lineNumber = 0;

            try
            {
                if (fileChosen == DialogResult.OK)
                {
                    StreamReader textReader = new StreamReader(openTextFileDialog.FileName);
                    List<Assembly> AssemText = new List<Assembly>();
                    List<Data> DataText = new List<Data>();
                    List<Label> Labels = new List<Label>();

                    while ((progLine = textReader.ReadLine()) != null)
                    {
                        if (!progLine.StartsWith("."))  // Line of Program Contains NO Preprocessor Directive
                        {
                            lineNumber++;               // Count line of actual program code
                            string[] revisedProgLineItems;

                            // Edit the string so that all leading/trailing whitespaces are removed and any whitespace characters between the code parts are replaced by a single whitespace character
                            string progLineTrimmed = progLine.Trim();
                            string progLineNormalized = Regex.Replace(progLineTrimmed, @"(\s)\s+", "$1");   // Thanks to F.B. ten Kate on http://stackoverflow.com/questions/206717/how-do-i-replace-multiple-spaces-with-a-single-space-in-c

                            revisedProgLineItems = Parser(progLineNormalized);    // Pass in for parsing the current line of the program being read

                            if (revisedProgLineItems.Length == 3)       // If the program line has label (or empty label), opcode, and variable
                            {
                                AssemText.Add(new Assembly(revisedProgLineItems[0], revisedProgLineItems[1], revisedProgLineItems[2]));
                                if (revisedProgLineItems[0] != "")      // If there is a meaninful label for the line, add that label and line number to the list of labels
                                {
                                    Labels.Add(new Label(revisedProgLineItems[0], lineNumber));
                                }
                                else { }        // If no meaningful label, do nothing and move on to next line of program
                            }
                            else if (revisedProgLineItems.Length == 1 && revisedProgLineItems[0] != "" && !revisedProgLineItems[0].Contains(':'))
                            {
                                // Program line has no label, no space/tab before opcode, and no variable
                                AssemText.Add(new Assembly("", revisedProgLineItems[0], ""));
                            }
                            else if (revisedProgLineItems[0] != "" && !revisedProgLineItems[0].Contains(':'))
                            {
                                // Program line has no label and no space/tab before opcode
                                AssemText.Add(new Assembly("", revisedProgLineItems[0], revisedProgLineItems[1]));
                            }
                            else  // If the program line has label (or empty label) and opcode, but no variable
                            {
                                AssemText.Add(new Assembly(revisedProgLineItems[0], revisedProgLineItems[1], ""));
                                if (revisedProgLineItems[0] != "")      // If there is a meaninful label for the line, add that label and line number to the list of labels
                                {
                                    Labels.Add(new Label(revisedProgLineItems[0], lineNumber));
                                }
                                else { }    // If no meaningful label, do nothing and move on to next line of program
                            }
                        }
                        else if (progLine.StartsWith(".DATA") || progLine.StartsWith(".Data") || progLine.StartsWith(".data"))  // Line of Program is a .DATA Preprocessor Directive
                        {
                            string[] revisedProgLineDataItems;
                            revisedProgLineDataItems = VariableParser(progLine);    // Pass in for parsing the current .DATA line of the program being read

                            DataText.Add(new Data(revisedProgLineDataItems[1], int.Parse(revisedProgLineDataItems[2])));
                        }
                        else { }    // Line of Program is a Preprocessor Directive or Error
                    }

                    // For Debugging Purposes ********
                    StreamReader testRead = new StreamReader(openTextFileDialog.FileName);
                    MessageBox.Show("Program Selected:\n" + testRead.ReadToEnd());
                    // *******************************

                    textReader.Close();

                    foreach (Assembly a in AssemText)
                    {
                        parsedProgram += (a.Label + "\t" + a.Opcode + "\t" + a.Variable + "\n");    // Format labels, opcodes, and variables from Assembly objects for display
                    }

                    foreach (Data d in DataText)
                    {
                        parsedData += (d.Name + "\t" + d.Value.ToString() + "\n");      // Format names and values from Data objects for display
                    }

                    progTextBox.Text = parsedProgram;   // Display parsed program in Program text box on form
                    varTextBox.Text = parsedData;       // Display parsed .DATA information in Variables text box on form

                    // For Debugging Purposes ********
                    string labelsToPrint = "";
                    foreach (var x in Labels)
                    {
                        labelsToPrint += "Label Name: " + x.Name + " - " + "Label Line #: " + x.Value + "\n";
                    }
                    MessageBox.Show(labelsToPrint);
                    MessageBox.Show("Program has compiled!");
                    // *******************************
                }
                else
                {
                    MessageBox.Show("Please select a file to open.");
                }
            }
            catch (Exception ex)    // Show error if unable to open file specified or parser error
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string[] Parser(string progLine)    // Use to parse lines which do NOT start with a "." - Referencing http://stackoverflow.com/questions/858756/how-to-parse-a-text-file-with-c-sharp - Samir Talwar
        {
            string[] progLineItems = progLine.Split('\t', ' ');
            List<string> itemList = progLineItems.ToList();     // Convert the string array to a list of strings

            foreach (string s in itemList)    // Go through items in list, looking only for text desired
            {
                if (s.Equals(" ") || s.Equals("\t")) // Do not save any items in array that are a SPACE or TAB; replace with empty string
                {
                    itemList.Remove(s);
                }
                else
                {
                    // For Debugging Purposes *****
                    //MessageBox.Show(s);
                    //progTextBox.Text += (s + " ");
                    // ****************************
                }
            }

            string[] revisedProgLineItems = itemList.ToArray();     // Convert list of strings back into string array for use in calling function

            return revisedProgLineItems;    // Return the string array
        }

        private string[] VariableParser(string progLine)    // Use to parse lines starting with .DATA
        {
            string[] progLineDataItems = progLine.Split('\t', ' ');
            List<string> dataList = progLineDataItems.ToList();     // Convert the string array to a list of strings

            foreach (string s in dataList)    // Go through items in list, looking only for text desired
            {
                if (s.Equals(" ") || s.Equals("\t")) // Do not save any items in array that are a SPACE or TAB; replace with empty string
                {
                    dataList.Remove(s);
                }
                else
                {
                    // For Debugging Purposes *****
                    //MessageBox.Show(s + " is text related to a DATA ITEM");
                    //varTextBox.Text += (s + "\n");
                    // ****************************
                }
            }

            string[] revisedProgLineDataItems = dataList.ToArray();     // Convert list of strings back into string array for use in calling function

            return revisedProgLineDataItems;   // Return the string array for .DATA items
        }
    }
}
