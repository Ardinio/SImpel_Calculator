using System;
using System.Windows.Forms;

namespace SImpel_Calculator;

class CalculatorApp : Form
{
    private Button[] numberButtons;
    private Button addButton;
    private Button subtractButton;
    private Button multiplyButton;
    private Button divideButton;
    private Button equalsButton;
    private Button resetButton;
    public Label resultLabel;

    private string num1Input;
    private string num2Input;
    private string currentOperation;

    public CalculatorApp()
    {
        CalculatorUI.InitializeComponents(this);
        ResetCalculator();
    }

    private void ResetCalculator()
    {
        num1Input = "";
        num2Input = "";
        currentOperation = "";
        resultLabel.Text = "Enter number 1";
    }

    public void NumberButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (currentOperation == "")
        {
            num1Input += button.Text;
            resultLabel.Text = "Number 1: " + num1Input;
        }
        else
        {
            num2Input += button.Text;
            resultLabel.Text = "Number 2: " + num2Input;
        }
    }

    public void OperationButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentOperation = button.Text;
        resultLabel.Text = "Enter number 2";
    }

    public void EqualsButton_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(num1Input, out int num1) || !int.TryParse(num2Input, out int num2))
        {
            resultLabel.Text = "Invalid number input!";
            return;
        }

        int result = 0;
        switch (currentOperation)
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

    public void ResetButton_Click(object sender, EventArgs e)
    {
        ResetCalculator();
    }

    static void Main()
    {
        Application.Run(new CalculatorApp());
    }
}