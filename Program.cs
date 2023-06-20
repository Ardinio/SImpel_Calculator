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

        addButton = CreateOperationButton("+");
        addButton.Location = new System.Drawing.Point(20, 80);
        addButton.Click += OperationButton_Click;
        this.Controls.Add(addButton);

        subtractButton = CreateOperationButton("-");
        subtractButton.Location = new System.Drawing.Point(100, 80);
        subtractButton.Click += OperationButton_Click;
        this.Controls.Add(subtractButton);

        multiplyButton = CreateOperationButton("*");
        multiplyButton.Location = new System.Drawing.Point(20, 110);
        multiplyButton.Click += OperationButton_Click;
        this.Controls.Add(multiplyButton);

        divideButton = CreateOperationButton("/");
        divideButton.Location = new System.Drawing.Point(100, 110);
        divideButton.Click += OperationButton_Click;
        this.Controls.Add(divideButton);

        resultLabel = new Label();
        resultLabel.Location = new System.Drawing.Point(20, 140);
        this.Controls.Add(resultLabel);
    }

    private Button CreateOperationButton(string text)
    {
        var button = new Button();
        button.Text = text;
        button.Width = 30;
        button.Height = 30;
        button.Font = new System.Drawing.Font(button.Font.FontFamily, 12);
        return button;
    }

    private void OperationButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string operation = button.Text;
        int num1 = Convert.ToInt32(num1TextBox.Text);
        int num2 = Convert.ToInt32(num2TextBox.Text);

        int result = 0;
        switch (operation)
        {
            case "+": // Addition
                result = num1 + num2;
                break;
            case "-": // Subtraction
                result = num1 - num2;
                break;
            case "*": // Multiplication
                result = num1 * num2;
                break;
            case "/": // Division
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    resultLabel.Text = "Error: Cannot divide by zero.";
                    return;
                }
                break;
        }

        resultLabel.Text = "Result: " + result.ToString();
    }

    static void Main()
    {
        Application.Run(new CalculatorApp());
    }
}