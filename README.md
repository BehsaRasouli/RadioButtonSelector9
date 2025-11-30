A simple Windows Forms application that displays which radio button the user selected when pressing a button.
# 🎛️ RadioButton Selector App

This Windows Forms application demonstrates how to work with **RadioButtons** in C#.  
Users can select one of the available options, and by clicking a button, the selected item will be displayed on the screen.

---

## ✨ Features

- ✔️ Lets the user choose between multiple RadioButtons  
- ✔️ Shows the selected option when clicking the **Select** button  
- ✔️ Error handling when no option is selected  
- ✔️ Clean UI perfect for beginners learning WinForms  

---

## 🖥️ How It Works

1. The user selects one of the radio buttons  
2. Clicks the **Show Selection** button  
3. The app displays which option was chosen  

If no option is selected, the app warns the user by showing the message:  
**"No item selected!"**
![RadioButtonSelector](https://github.com/user-attachments/assets/ea5d0544-096f-43bc-a5bc-900dfcd1464d)

---

## 🧩 Code Example

```csharp
private void button1_Click(object sender, EventArgs e)
{
    if (radioButton1.Checked)
        label1.Text = "1" + radioButton1.Text;
    else if (radioButton2.Checked)
        label1.Text = "2" + radioButton1.Text;
    else if (radioButton3.Checked)
        label1.Text = "3" + radioButton1.Text;
    else

        label1.Text = "No item selected!";
}
Purpose of the Project

This small project is an excellent example for beginners to:

Understand how RadioButtons work

Learn how to check which option is selected

Practice basic event-handling in C# WinForms

👩‍💻 Developer

Created by Behsa Rasouli
