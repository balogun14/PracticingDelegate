### **Project Requirement: Task Manager Console Application**  

#### **Overview**  
You are tasked with building a simple **Task Manager** console application in C#. This application will allow users to create, manage, and complete tasks. However, to challenge your foundational C# knowledge, you **must** use **delegates** and **generics** in your implementation.  

#### **Functional Requirements**  
1. **Create a Task**  
   - The user should be able to add a new task with a title, description, and priority level (Low, Medium, High).  
   - Each task will be assigned a unique ID automatically.  

2. **View Tasks**  
   - Display all tasks in a readable format, showing their **ID, Title, Description, Priority, and Status** (Pending or Completed).  

3. **Mark a Task as Completed**  
   - The user should be able to mark a task as completed using its **ID**.  

4. **Filter Tasks**  
   - The user should be able to filter tasks by priority using a **generic method**.  

5. **Execute an Action on All Tasks**  
   - Implement a **delegate** that can perform an action on all tasks.  
   - The action could be:  
     - Printing task details.  
     - Changing task priority.  
     - Deleting completed tasks.  

#### **Technical Requirements**  
1. **Use Generics**  
   - Implement a generic **TaskManager<T>** class to store and manage tasks.  
   - The class should support **adding, retrieving, and filtering** tasks.  

2. **Use Delegates**  
   - Create a **delegate** to apply actions on tasks.  
   - Pass a method as a parameter to apply a specific operation on each task.  

3. **Follow SOLID Principles**  
   - Encapsulate logic into separate classes.  
   - Keep the code structured and readable.  

#### **Bonus (If You Dare 💀)**  
- Allow users to edit task details.  
- Implement a **sorting feature** to list tasks by priority.  
- Implement **file storage** (save/load tasks to/from a file).  

#### **Example Usage**  
```plaintext
Welcome to Task Manager  
1. Add Task  
2. View Tasks  
3. Complete Task  
4. Filter Tasks by Priority  
5. Apply Action to All Tasks  
6. Exit  

Enter your choice: 1  
Enter task title: Finish Homework  
Enter description: Math exercises  
Enter priority (Low, Medium, High): High  
Task added successfully!  

Enter your choice: 2  
Tasks List:  
[1] Finish Homework - High - Pending  

Enter your choice: 3  
Enter Task ID to complete: 1  
Task marked as completed!  

Enter your choice: 6  
Goodbye!  
```

---  
This project will push you out of your comfort zone, but **you got this! 💪** 🚀