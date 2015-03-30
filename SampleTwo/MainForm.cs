using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpConfig;

namespace SampleTwo
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
//            SettingsManager.LoadSettings();   
            UpdateControlsFromSettings();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            SettingsManager.LoadSettings();   
            UpdateControlsFromSettings();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            UpdateSettingsFromContols();
            SettingsManager.SaveSettings();
        }

        private void bLoadBinary_Click(object sender, EventArgs e)
        {
            SettingsManager.LoadBinarySettings();
            UpdateControlsFromSettings();
        }

        private void bSaveBinary_Click(object sender, EventArgs e)
        {
            UpdateSettingsFromContols();
            SettingsManager.SaveBinarySettings();
        }

        private void bLoadSecure_Click(object sender, EventArgs e)
        {
            SettingsManager.LoadSecureSettings();
            UpdateControlsFromSettings();
        }

        private void bSaveSecure_Click(object sender, EventArgs e)
        {
            UpdateSettingsFromContols();
            SettingsManager.SaveSecureSettings();
        }

        private void UpdateControlsFromSettings()
        {
            listBoxOne.Items.Clear();
            textBox1One.Text = SettingsManager.AppSettingsOne.TextBox1Value;
            textBox2One.Text = SettingsManager.AppSettingsOne.TextBox2Value;
            checkBox1One.Checked = SettingsManager.AppSettingsOne.checkBox1Value;
            checkBox2One.Checked = SettingsManager.AppSettingsOne.checkBox2Value;
            if (SettingsManager.AppSettingsOne.listBoxValues != null)
                foreach (var listBoxValue in SettingsManager.AppSettingsOne.listBoxValues)
                {
                    listBoxOne.Items.Add(listBoxValue);
                }

            listBoxTwo.Items.Clear();
            textBox1Two.Text = SettingsManager.AppSettingsTwo.TextBox1Value;
            textBox2Two.Text = SettingsManager.AppSettingsTwo.TextBox2Value;
            checkBox1Two.Checked = SettingsManager.AppSettingsTwo.checkBox1Value;
            checkBox2Two.Checked = SettingsManager.AppSettingsTwo.checkBox2Value;
            if (SettingsManager.AppSettingsTwo.listBoxValues != null)
                foreach (var listBoxValue in SettingsManager.AppSettingsTwo.listBoxValues)
                {
                    listBoxTwo.Items.Add(listBoxValue);
                }

            textBox1One.Enabled = checkBox1One.Checked;
            textBox2One.Enabled = checkBox2One.Checked;
            textBox1Two.Enabled = checkBox1Two.Checked;
            textBox2Two.Enabled = checkBox2Two.Checked;
        }

        private void UpdateSettingsFromContols()
        {
            SettingsManager.AppSettingsOne.TextBox1Value = textBox1One.Text;
            SettingsManager.AppSettingsOne.TextBox2Value = textBox2One.Text;
            SettingsManager.AppSettingsOne.checkBox1Value = checkBox1One.Checked;
            SettingsManager.AppSettingsOne.checkBox2Value = checkBox2One.Checked;
            SettingsManager.AppSettingsOne.listBoxValues = listBoxOne.Items.Cast<string>().ToArray();

            SettingsManager.AppSettingsTwo.TextBox1Value = textBox1Two.Text;
            SettingsManager.AppSettingsTwo.TextBox2Value = textBox2Two.Text;
            SettingsManager.AppSettingsTwo.checkBox1Value = checkBox1Two.Checked;
            SettingsManager.AppSettingsTwo.checkBox2Value = checkBox2Two.Checked;
            SettingsManager.AppSettingsTwo.listBoxValues = listBoxTwo.Items.Cast<string>().ToArray();
        }

        #region CheckBoxes operations

        private void checkBox1One_CheckedChanged(object sender, EventArgs e)
        {
            textBox1One.Enabled = checkBox1One.Checked;
        }

        private void checkBox2One_CheckedChanged(object sender, EventArgs e)
        {
            textBox2One.Enabled = checkBox2One.Checked;
        }

        private void checkBox1Two_CheckedChanged(object sender, EventArgs e)
        {
            textBox1Two.Enabled = checkBox1Two.Checked;
        }

        private void checkBox2Two_CheckedChanged(object sender, EventArgs e)
        {
            textBox2Two.Enabled = checkBox2Two.Checked;
        }

        #endregion

        #region ListBoxes operations

        private void bAddToListBoxOne_Click(object sender, EventArgs e)
        {
            listBoxOne.Items.Add(tbValueForListBoxOne.Text);
            tbValueForListBoxOne.Text = "";
        }

        private void bRemoveFromListBoxOne_Click(object sender, EventArgs e)
        {
            listBoxOne.Items.Remove(listBoxOne.SelectedItem);
        }

        private void bAddToListBoxTwo_Click(object sender, EventArgs e)
        {
            listBoxTwo.Items.Add(tbValueForListBoxTwo.Text);
            tbValueForListBoxTwo.Text = "";
        }

        private void bRemoveFromListBoxTwo_Click(object sender, EventArgs e)
        {
            listBoxTwo.Items.Remove(listBoxTwo.SelectedItem);
        }

        #endregion


    }
}
