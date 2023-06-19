using System;
using System.Windows.Forms;

namespace SImpel_Calculator;

class CalculatorApp : Form
{
    private TextBox num1TextBox;
    private TextBox num2TextBox;
    private Button addButton;
    private Button subtractButton;
    private Button multiplyButton;
    private Button divideButton;
    private Label resultLabel;

    public CalculatorApp()
    {
        InitializeComponents();
    }

    private void InitializeComponents() 
    {
        num1TextBox = new TextBox();
        num1TextBox.Location = new System.Drawing.Point(20, 20);
        this.Controls.Add(num1TextBox);

        num2TextBox = new TextBox();
        num2TextBox.Location = new System.Drawing.Point(20, 50);
        this.Controls.Add(num2TextBox);

        addButton = new Button();
        addButton.Location = new System.Drawing.Point(20, 80);
        addButton.Text = "+";
        addButton.Click += AddButton_Click;
        this.Controls.Add(addButton);

        subtractButton = new Button();
        subtractButton.Location = new System.Drawing.Point(100, 80);
        subtractButton.Text = "-";
        subtractButton.Click += SubtractButton_Click;
        this.Controls.Add(subtractButton);

        multiplyButton = new Button();
        multiplyButton.Location = new System.Drawing.Point(20, 110);
        multiplyButton.Text = "*";
        multiplyButton.Click += MulitplyButton_Click;
        this.Controls.Add(multiplyButton);

        divideButton = new Button();
        divideButton.Location = new System.Drawing.Point(100, 110);
        divideButton.Text = "/";
        divideButton.Click += DivideButton_Click;
        this.Controls.Add(divideButton);

        resultLabel = new Label();
        resultLabel.Location = new System.Drawing.Point(20, 140);
        this.Controls.Add(resultLabel);
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(num1TextBox.Text);
        int num2 = Convert.ToInt32(num2TextBox.Text);
        int result = num1 + num2;
        resultLabel.Text = "Result: " + result.ToString();
    }

    private void SubtractButton_Click(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(num1TextBox.Text);
        int num2 = Convert.ToInt32(num2TextBox.Text);
        int result = num1 - num2;
        resultLabel.Text = "Result: " + result.ToString();
    }

    private void MulitplyButton_Click(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(num1TextBox.Text);
        int num2 = Convert.ToInt32(num2TextBox.Text);
        int result = num1 * num2;
        resultLabel.Text = "Result: " + result.ToString();
    }

    private void DivideButton_Click(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(num1TextBox.Text);
        int num2 = Convert.ToInt32(num2TextBox.Text);

        if (num2 != 0)
        {
            int result = num1 / num2;
            resultLabel.Text = "Result: " + result.ToString();
        }
        else
        {
            resultLabel.Text ="Error: Cannot divide by zero.";
        }
    }

    static void Main()
    {
        Application.Run(new CalculatorApp());
    }
}