using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        private TaskManager taskManager = new TaskManager();
   
     
        public Form1()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {

          var task = new Task
          {


              Title = titleTexBox.Text,
              Description = descriptionTextBox.Text,
              IsCompleted = false

          };    
            taskManager.AddTask(task);
            UpdateTaskList();     
                
                


        }

      
                  
         

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem is Task selectedTask)
            {
                taskManager.RemoveTask(selectedTask.Id);
                UpdateTaskList();
            }






        }

        private void UpdateTaskList()
        {
                  
          taskListBox.Items.Clear();
                 foreach (var task in taskManager.GetTasks())
                 {
                    taskListBox.Items.Add(task);
                 }
        }



    }
}
