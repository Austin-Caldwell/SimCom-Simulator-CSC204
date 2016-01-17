// CSC 204 P01 - Austin Caldwell and Joshua Scheidler - 2016
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
            string parsedProgram = "";
            int lineNumber = 0;

            try
            {
                if (fileChosen == DialogResult.OK)
                {
                    StreamReader textReader = new StreamReader(openTextFileDialog.FileName);
                    List<Assembly> AssemText = new List<Assembly>();

                    while ((progLine = textReader.ReadLine()) != null)
                    {
                        if (!progLine.StartsWith("."))  // Line of Program Contains NO Preprocessor Directive
                        {
                            string[] revisedProgLineItems;
                            revisedProgLineItems = Parser(progLine);        // Pass in for parsing the current line of the program being read

                            if (revisedProgLineItems.Length == 3)   // If the program line has label (or empty label), opcode, and variable
                            {
                                AssemText.Add(new Assembly(revisedProgLineItems[0], revisedProgLineItems[1], revisedProgLineItems[2]));
                            }
                            else  // If the program line has label (or empty label) and opcode, but no variable
                            {
                                AssemText.Add(new Assembly(revisedProgLineItems[0], revisedProgLineItems[1], ""));
                            }

                            lineNumber++;               // Count line of actual program code
                        }
                        else if (progLine.StartsWith(".DATA"))  // Line of Program is a .DATA Preprocessor Directive
                        {
                            //VariableParser(progLine);
                        }
                        else { }    // Line of Program is a Preprocessor Directive or Error
                    }

                    // For Debugging Purposes ********
                    StreamReader testRead = new StreamReader(openTextFileDialog.FileName);
                    MessageBox.Show(testRead.ReadToEnd());
                    // *******************************

                    textReader.Close();

                    foreach (Assembly a in AssemText)
                    {
                        parsedProgram += (a.Label + "\t" + a.Opcode + "\t" + a.Variable + "\n");    // Format labels, opcodes, and variables from Assembly objects for display
                    }

                    progTextBox.Text = parsedProgram;   // Display parsed program in text box on screen
                }
                else
                {
                    MessageBox.Show("Unable to open specified file.  Please try again.");
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

        private string[] Parser(string progLine)    // Referencing http://stackoverflow.com/questions/858756/how-to-parse-a-text-file-with-c-sharp - Samir Talwar
        {
            string[] progLineItems = progLine.Split('\t', ' ');
            List<string> itemList = progLineItems.ToList();     // Convert the string array to a list of strings

            foreach (string s in itemList)    // Go through items in list, looking only for text desired
            {
                if (s.Equals(" ") || s.Equals("\t")) // Do not save any items in array that are a SPACE or TAB
                {
                    itemList.Remove(s);
                }
                else
                {
                    // For Debugging Purposes *****
                    MessageBox.Show(s);
                    progTextBox.Text += (s + " ");
                    // ****************************
                }
            }

            string[] revisedProgLineItems = itemList.ToArray();     // Convert list of strings back into string array for use in calling function

            return revisedProgLineItems;    // Return the string array
        }

        private string[] VariableParser(string progLine)
        {
            string[] progLineDataItems = progLine.Split('\t', ' ');

            return progLineDataItems;
        }
    }
}
