using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExcelThang
{
    public partial class Form1 : Form
    {
        public string selectedFileName;
        // Define a list of available chart types
        private SeriesChartType[] availableChartTypes = new SeriesChartType[]
        {
            SeriesChartType.Column,
            SeriesChartType.Bar,
            SeriesChartType.Line,
            SeriesChartType.Area,
            SeriesChartType.Pie
        };

        // Index to keep track of the current chart type
        private int currentChartTypeIndex = 0;

        public Form1()
        {
            InitializeComponent();
            AttachHoverEventHandlers();

            // Create a Panel to contain the chart
            Panel chartPanel = new Panel();
            chartPanel.Dock = DockStyle.Fill;
            chartPanel.AutoSize = true;
            chartPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Add the chart to the Panel
            chartPanel.Controls.Add(chart1);
            this.Controls.Add(chartPanel);

            CreateTooltips();
        }

        public void CreateTooltips()
        {
            // tooltips for chart styles

            toolTip_buttons.ToolTipTitle = "Info";
            toolTip_buttons.SetToolTip(barChartButton, "Show as bar chart.");
            toolTip_buttons.SetToolTip(pieChartButton, "Show as pie chart.");
            toolTip_buttons.SetToolTip(areaChartButton, "Show as area chart.");
            toolTip_buttons.SetToolTip(lineChartButton, "Show as line chart.");
            toolTip_buttons.SetToolTip(pointChartButton, "Show as point chart.");

            // technical buttons
            toolTip_buttons.SetToolTip(openFileButtonPanel, "Select an Excel file and convert it into a chart.");
            toolTip_buttons.SetToolTip(refreshButton, "Refresh data in the chart (currently broken!)");
            toolTip_buttons.SetToolTip(saveChartButton, "Save the chart as a PNG.");
            toolTip_buttons.SetToolTip(createTemplateExcelButton, "Create a template Excel file with a functional example of the value structure.");
            toolTip_buttons.SetToolTip(userMenuButton, "Currently Unavailable :(");
        }

        private void barChartButton_Click(object sender, EventArgs e)
        {
            SetChartType(SeriesChartType.Column);

        }

        private void pieChartButton_Click(object sender, EventArgs e)
        {
            SetChartType(SeriesChartType.Pie);

        }

        private void areaChartButton_Click(object sender, EventArgs e)
        {
            SetChartType(SeriesChartType.Area);

        }

        private void lineChartButton_Click(object sender, EventArgs e)
        {
            SetChartType(SeriesChartType.Line);

        }

        private void pointChartButton_Click(object sender, EventArgs e)
        {
            SetChartType(SeriesChartType.Point);

        }

        private void SetChartType(SeriesChartType chartType)
        {
            // Set the chart type for each series in the chart
            foreach (var series in chart1.Series)
            {
                series.ChartType = chartType;
            }
        }

        private void RefreshDataAndChart(object sender, EventArgs e)
        {
            // Ensure that a file has been selected before attempting to refresh
            if (string.IsNullOrEmpty(selectedFileName))
            {
                MessageBox.Show("Please select a file first.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadAndDisplayDataFromExcel(selectedFileName, 3); // Reload data from the Excel file
        }

        private void AttachHoverEventHandlers()
        {
            // Attach event handlers to individual panels in settingsControlsFlowLayoutPanel
            foreach (Control control in settingsControlsFlowLayoutPanel.Controls)
            {
                if (control is Panel && control.Tag != null && control.Tag.ToString() == "ButtonTag")
                {
                    // Store the original tag and custom name as a Tuple in the Tag property
                    control.Tag = Tuple.Create(control.Tag.ToString(), GetCustomName(control.Name));
                    control.MouseEnter += HoverInButton;
                    control.MouseLeave += HoverOutButton;
                }
            }
        }

        // Method to get custom name based on panel name
        private string GetCustomName(string panelName)
        {
            // Shit sucks, it's ugly and there probably is a better way to achieve this, but this is relatively simple.

            switch (panelName)
            {
                case "openFileButtonPanel":
                    return "Open File";
                case "refreshButton":
                    return "Refresh Chart";
                case "barChartButton":
                    return "Bar Chart";
                case "pieChartButton":
                    return "Pie Chart";
                case "areaChartButton":
                    return "Area Chart";
                case "lineChartButton":
                    return "Line Chart";
                case "pointChartButton":
                    return "Point Chart";
                case "saveChartButton":
                    return "Save Chart";
                case "createTemplateExcelButton":
                    return "Create Excel Template";
                case "userMenuButton":
                    return "User Menu";
                default:
                    return "Unknown Chart";
            }
        }

        private void HoverInButton(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = System.Drawing.SystemColors.ScrollBar; // Example color
                                                                     // Retrieve custom name from Tuple stored in the Tag property
            Tuple<string, string> tags = (Tuple<string, string>)panel.Tag;
            toolTip_buttons.ToolTipTitle = tags.Item2;
        }

        private void HoverOutButton(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = System.Drawing.Color.Transparent; // Example color
        }

        private void openFileButtonPanel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set default directory and file filters
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            openFileDialog.FilterIndex = 1; // Set default filter to Excel files

            // Handle FileOk event to verify the selected file
            openFileDialog.FileOk += OpenFileDialog_FileOk;

            // Show the dialog
            openFileDialog.ShowDialog();
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFileDialog = (OpenFileDialog)sender;

            // Get the selected file name without the full path
            selectedFileName = Path.GetFileName(openFileDialog.FileName);

            // Check if the selected file doesn't have the .xlsx extension
            if (Path.GetExtension(openFileDialog.FileName).ToLower() != ".xlsx")
            {
                // Display an error message
                MessageBox.Show("Only Excel files (.xlsx) are allowed.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Cancel the operation
                e.Cancel = true;
                return;
            }

            // Display the file name
            fileNameDynamic.Text = selectedFileName;

            // Set the license context for EPPlus
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Call the method to load data from Excel and display it in the chart
            LoadAndDisplayDataFromExcel(openFileDialog.FileName, 3); // Starting row (in this case, 2)
        }

        private void LoadAndDisplayDataFromExcel(string filePath, int startRow)
        {
            chart1.Series.Clear(); // Clear the chart before loading new data

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("The workbook does not contain any worksheets.", "No Worksheets Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method
                }

                // Access the first worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets.First();

                // Check if the worksheet contains any rows
                if (worksheet.Dimension == null || worksheet.Dimension.Rows < startRow)
                {
                    MessageBox.Show("The worksheet does not contain any data or does not have enough rows.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method
                }

                int rowCount = worksheet.Dimension.Rows;
                int columnCount = worksheet.Dimension.Columns;

                // Get the column index of "Name 1" (assuming it's in cell 3B)
                int columnIndexName1 = 2; // Column B (index is zero-based)

                // Get the column names from the first row (startRow)
                List<string> columnNames = new List<string>();
                for (int col = columnIndexName1; col <= columnCount; col++)
                {
                    var cell = worksheet.Cells[startRow, col];
                    string columnName = cell.Value?.ToString(); // Use null-conditional operator to handle null values
                    if (!string.IsNullOrEmpty(columnName))
                    {
                        columnNames.Add(columnName);
                    }
                    else
                    {
                        // If a cell doesn't contain a value, add a default column name
                        MessageBox.Show("Encountered an empty or null column name in column " + col, "Empty or Null Column Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        columnNames.Add("Column" + col);
                    }
                }

                // Display column names
                foreach (var columnName in columnNames)
                {
                    MessageBox.Show("Column Name: " + columnName, "Column Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Load data from the specified startRow
                for (int colIndex = 0; colIndex < columnNames.Count; colIndex++)
                {
                    var series = chart1.Series.Add(columnNames[colIndex]); // Add series with column name

                    // Load data for the corresponding column
                    for (int row = startRow + 1; row <= rowCount; row++) // Start from the row after the column names
                    {
                        double value;
                        object cellValue = worksheet.Cells[row, columnIndexName1 + colIndex].Value; // Adjust column index to match data
                        if (cellValue != null && double.TryParse(cellValue.ToString(), out value))
                        {
                            series.Points.AddY(value);
                        }
                        else
                        {
                            // Handle invalid or missing data
                            MessageBox.Show($"Encountered invalid data at row {row}, column {columnIndexName1 + colIndex}.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }


        public void SaveAsPNG_Dialog(object sender, EventArgs e)
        {
            // Show the save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = saveFileDialog.FileName;

                // Save the chart as a PNG file
                SaveChartAsPng(filePath);

                MessageBox.Show("Chart saved successfully as PNG.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SaveChartAsPng(string filePath)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Render the chart to the MemoryStream
                chart1.SaveImage(ms, ChartImageFormat.Png);

                // Write the MemoryStream to a file
                File.WriteAllBytes(filePath, ms.ToArray());
            }
        }
        private void createTemplateExcelButton_Click(object sender, EventArgs e)
        {
            // Create and configure the SaveFileDialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                // Show the SaveFileDialog
                DialogResult result = saveFileDialog.ShowDialog();

                // If the user selects a file and clicks OK
                if (result == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    try
                    {
                        // Get the project's root directory
                        string projectRootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                        // Specify the source Excel file path relative to the project's root directory
                        string sourceFilePath = Path.Combine(projectRootDirectory, "Template", "excelTemplate.xlsx");

                        // Copy the Excel file to the destination file path
                        File.Copy(sourceFilePath, destinationFilePath);

                        MessageBox.Show("Excel file copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while copying the Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
