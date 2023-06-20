using System;
using System.Windows.Forms;

class CalculatorApp : Form
{
    private Button[] numberButtons;
    private Button addButton;
    private Button subtractButton;
    private Button multiplyButton;
    private Button divideButton;
    private Button equalsButton;
    private Button resetButton;
    private Label resultLabel;

    private string num1Input;
    private string num2Input;
    private string currentOperation;

    public CalculatorApp()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        numberButtons = new Button[10];
        for (int i = 0; i < 10; i++)
        {
            numberButtons[i] = CreateNumberButton(i.ToString());
            numberButtons[i].Location = new System.Drawing.Point(20 + (i % 3) * 40, 140 + (i / 3) * 40);
            numberButtons[i].Click += NumberButton_Click;
            this.Controls.Add(numberButtons[i]);
        }

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

        equalsButton = new Button();
        equalsButton.Text = "=";
        equalsButton.Width = 30;
        equalsButton.Height = 30;
        equalsButton.Font = new System.Drawing.Font(equalsButton.Font.FontFamily, 12);
        equalsButton.Location = new System.Drawing.Point(180, 180);
        equalsButton.Click += EqualsButton_Click;
        this.Controls.Add(equalsButton);

        resetButton = new Button();
        resetButton.Text = "AC";
        resetButton.Width = 60;
        resetButton.Height = 30;
        resetButton.Font = new System.Drawing.Font(resetButton.Font.FontFamily, 12);
        resetButton.Location = new System.Drawing.Point(140, 140);
        resetButton.Click += ResetButton_Click;
        this.Controls.Add(resetButton);

        resultLabel = new Label();
        resultLabel.Location = new System.Drawing.Point(20, 20);
        resultLabel.Size = new System.Drawing.Size(200, 50);
        resultLabel.Font = new System.Drawing.Font(resultLabel.Font.FontFamily, 14);
        resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(resultLabel);

        ResetCalculator();
    }

    private Button CreateNumberButton(string text)
    {
        var button = new Button();
        button.Text = text;
        button.Width = 30;
        button.Height = 30;
        button.Font = new System.Drawing.Font(button.Font.FontFamily, 12);
        return button;
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

    private void ResetCalculator()
    {
        num1Input = "";
        num2Input = "";
        currentOperation = "";
        resultLabel.Text = "Enter number 1";
    }

    private void NumberButton_Click(object sender, EventArgs e)
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

    private void OperationButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentOperation = button.Text;
        resultLabel.Text = "Enter number 2";
    }

    private void EqualsButton_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(num1Input, out int num1) || !int.TryParse(num2Input, out int num2))
        {
            resultLabel.Text = "Invalid number input!";
            ResetCalculator();
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
                    ResetCalculator();
                    return;
                }
                break;
        }

        resultLabel.Text = "Result: " + result.ToString();
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        ResetCalculator();
    }

    static void Main()
    {
        Application.Run(new CalculatorApp());
    }
}