using System.Text;
using System.Text.Json;
using System.Xml.Linq;

namespace Task_App
{

    public partial class TaskApp : Form
    {


        public TaskApp()
        {
            InitializeComponent();
            /// <summary>
            ///  Loop through the dictionary and concatenate its contents
            /// </summary>
            StringBuilder sb = new StringBuilder();

            LoadTasks();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            dgTaskList.Rows.Add(txtTaskDescription.Text, cbPriority.Text, dtFinishingDate.Value);
            var newJson = new Task(txtTaskDescription.Text, cbPriority.Text, dtFinishingDate.Value);

            CreateJson(newJson);


            ClearFields();

        }

        public void ClearFields()
        {
            txtTaskDescription.Text = string.Empty;
            cbPriority.Text = string.Empty;

        }

        private void CreateJson(Task taskObj)
        {

            string getPath = CurrentPath.GetPath();

            string newPath = getPath + "taskList.json";

            // Combine the directory and file name to get the full file path
            string filePath = Path.Combine(getPath, "taskList.json");



            if (File.Exists(filePath))
            {

                // Read the contents of the existing JSON file
                string json = File.ReadAllText(filePath);


                // Deserialize the JSON into a list of objects
                var jsonList = JsonSerializer.Deserialize<List<Task>>(json);

                //Adding new obj to the exitented List
                jsonList.Add(taskObj);

                // Serialize data to JSON
                string objTojson = JsonSerializer.Serialize(jsonList);

                // re-Write JSON string to file
                File.WriteAllText(newPath, objTojson);
            }
            else
            {
                List<Task> dataCollection = new List<Task>();
                dataCollection.Add(taskObj);
                // Serialize data to JSON
                string objTojson = JsonSerializer.Serialize(dataCollection);


                // Create/Write JSON string to file
                File.WriteAllText(newPath, objTojson);
            }

        }

        private void LoadTasks()
        {

            string getPath = CurrentPath.GetPath();

            string newPath = getPath + "taskList.json";

            // Combine the directory and file name to get the full file path
            string filePath = Path.Combine(getPath, "taskList.json");

            if (File.Exists(filePath))
            {

                // Read the contents of the existing JSON file
                string json = File.ReadAllText(filePath);


                // Deserialize the JSON into a list of objects
                var jsonList = JsonSerializer.Deserialize<List<Task>>(json);


                foreach (Task task in jsonList)
                {
                    dgTaskList.Rows.Add(task.TaskDescription, task.Priority, task.Date);
                }
            }
        }

        public class Task
        {
            public string TaskDescription { get; set; }
            public string Priority { get; set; }
            public DateTime Date { get; set; }

            public Task(string taskDescription, string priority, DateTime date)
            {
                TaskDescription = taskDescription;
                Priority = priority;
                Date = date;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
            dtFinishingDate.Value = DateTime.Now;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgTaskList.CurrentRow.Index;
            Task updatedTask = new Task(txtTaskDescription.Text, cbPriority.Text, dtFinishingDate.Value);

            // Update the task in the JSON file
            UpdateJson(index, updatedTask);

            // Update the task in the DataGridView
            dgTaskList.Rows[index].SetValues(updatedTask.TaskDescription, updatedTask.Priority, updatedTask.Date);

            ClearFields();
        }
        
        private void UpdateJson(int index, Task updatedTask)
        {
            string filePath = Path.Combine(CurrentPath.GetPath(), "taskList.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var jsonList = JsonSerializer.Deserialize<List<Task>>(json);

                if (jsonList != null && index >= 0 && index < jsonList.Count)
                {
                    jsonList[index] = updatedTask;
                    string updatedJson = JsonSerializer.Serialize(jsonList);
                    File.WriteAllText(filePath, updatedJson);
                }
            }
        }

        private void SaveCSVFile(string csvfileName)
        {

        }


        private void btnSaveAs_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(Path.Combine(CurrentPath.GetPath(), "taskList.json"));
                File.WriteAllText(saveFileDialog.FileName, json);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgTaskList.CurrentRow != null)
            {
                int index = dgTaskList.CurrentRow.Index;

                // Delete the task from the JSON file
                DeleteJson(index);

                // Delete the task from the DataGridView
                dgTaskList.Rows.RemoveAt(index);

                // Refresh the DataGridView to update the display
                dgTaskList.Refresh();
            }
        }

        private void DeleteJson(int index)
        {
            string filePath = Path.Combine(CurrentPath.GetPath(), "taskList.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var jsonList = JsonSerializer.Deserialize<List<Task>>(json);

                if (jsonList != null && index >= 0 && index < jsonList.Count)
                {
                    jsonList.RemoveAt(index);
                    string updatedJson = JsonSerializer.Serialize(jsonList);
                    File.WriteAllText(filePath, updatedJson);
                }
            }
        }

        private void btnSearchTask_Click(object sender, EventArgs e)
        {
            string searchQuery = txtTaskDescription.Text.ToLower();

            foreach (DataGridViewRow row in dgTaskList.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().Contains(searchQuery))
                {
                    // Select the row that matches the search query
                    dgTaskList.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
    }
}

