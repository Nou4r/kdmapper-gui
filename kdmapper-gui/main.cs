using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kdmapper_gui
{
    public partial class main : Form
    {
        static string driverPath = "", mapperPath = "";

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            richtextbox_DriverEntry.Text = "NTSTATUS DriverEntry(PDRIVER_OBJECT DriverObject, PUNICODE_STRING RegistryPath)\n{\nUNREFERENCED_PARAMETER(DriverObject);\nUNREFERENCED_PARAMETER(RegistryPath);\nKdPrintEx((0, 0, \"[Loaded] Driver has been loaded!\"));\n\nreturn STATUS_SUCCESS;\n}";
        }

        private void checkbox_allocationPtr_Click(object sender, EventArgs e)
        {
            if(checkbox_mdl.Checked)
            {
                checkbox_mdl.Checked = false;
                checkbox_ExAllocatePool.Checked = true;
            }
        }

        private void checkbox_mdl_Click(object sender, EventArgs e)
        {
            if (checkbox_ExAllocatePool.Checked)
            {
                if (checkbox_allocationPtr.Checked)
                    checkbox_allocationPtr.Checked = false;

                checkbox_ExAllocatePool.Checked = false;
            }
            checkbox_mdl.Checked = true;
        }

        private void checkbox_ExAllocatePool_Click(object sender, EventArgs e)
        {
            if (checkbox_mdl.Checked)
            {
                checkbox_mdl.Checked = false;
            }
            checkbox_ExAllocatePool.Checked = true;
        }

        private void textbox_driverPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Drivers (*.sys)|*.sys",
                Title = "Select your driver!"
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if(openFileDialog.CheckFileExists)
                    {
                        textbox_driverPath.Text = openFileDialog.FileName;
                        driverPath = openFileDialog.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, string.Format("Error: {0}", ex.ToString()), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textbox_mapperPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Executable (*.exe)|*.exe",
                Title = "Select your kdmapper!"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        textbox_mapperPath.Text = openFileDialog.FileName;
                        mapperPath = openFileDialog.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, string.Format("Error: {0}", ex.ToString()), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void printCurrentText()
        {
            if (checkbox_mdl.Checked)
                richtextbox_DriverEntry.Text = "NTSTATUS DriverEntry(PMDL mdl, PUNICODE_STRING RegistryPath)\n{\nUNREFERENCED_PARAMETER(RegistryPath);\n\nKdPrintEx((0, 0, \"[mdl] %p!\", mdl));\n\nreturn STATUS_SUCCESS;\n}";
            else if (checkbox_allocationPtr.Checked)
                richtextbox_DriverEntry.Text = "NTSTATUS DriverEntry(PVOID allocationPtr, PUNICODE_STRING RegistryPath)\n{\nUNREFERENCED_PARAMETER(RegistryPath);\n\nKdPrintEx((0, 0, \"[allocationPtr] %p!\", allocationPtr));\n\nreturn STATUS_SUCCESS;\n}";
            else if (checkbox_ExAllocatePool.Checked)
                richtextbox_DriverEntry.Text = "NTSTATUS DriverEntry(PDRIVER_OBJECT DriverObject, PUNICODE_STRING RegistryPath)\n{\nUNREFERENCED_PARAMETER(DriverObject);\nUNREFERENCED_PARAMETER(RegistryPath);\nKdPrintEx((0, 0, \"[Loaded] Driver has been loaded!\"));\n\nreturn STATUS_SUCCESS;\n}";
        }

        private void checkbox_allocationPtr_CheckedChanged(object sender, EventArgs e)
        {
            printCurrentText();
        }

        private void checkbox_mdl_CheckedChanged(object sender, EventArgs e)
        {
            printCurrentText();
        }

        private void checkbox_ExAllocatePool_CheckedChanged(object sender, EventArgs e)
        {
            printCurrentText();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(!System.IO.File.Exists(driverPath))
            {
                MessageBox.Show(null, "Please make sure driver path is valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!System.IO.File.Exists(mapperPath))
            {
                MessageBox.Show(null, "Please make sure mapper path is valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProcessStartInfo info = new ProcessStartInfo(mapperPath)
            {
                Arguments = string.Format("{0} {1} {2} {3}", checkbox_free.Checked ? "--free" : "", checkbox_allocationPtr.Checked ? "--PassAllocationPtr" : "", checkbox_mdl.Checked ? "--mdl" : "", driverPath),
                Verb = "runas"
            };
            Process.Start(info);
        }
    }
}
