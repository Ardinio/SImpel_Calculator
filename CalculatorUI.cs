namespace SImpel_Calculator;

class CalculatorUI
{
    public static void InitializeComponents(CalculatorApp form)
    {
        var numberButtons = new Button[10];
        for (int i = 0; i < 10; i++)
        {
            numberButtons[i] = CreateNumberButton(i.ToString());
            numberButtons[i].Location = new System.Drawing.Point(20 + (i % 3) * 40, 140 + (i / 3) * 40);
            numberButtons[i].Click += form.NumberButton_Click;
            form.Controls.Add(numberButtons[i]);
        }

        var addButton = CreateOperationButton("+");
        addButton.Location = new System.Drawing.Point(20, 80);
        addButton.Click += form.OperationButton_Click;
        form.Controls.Add(addButton);

        var subtractButton = CreateOperationButton("-");
        subtractButton.Location = new System.Drawing.Point(100, 80);
        subtractButton.Click += form.OperationButton_Click;
        form.Controls.Add(subtractButton);

        var multiplyButton = CreateOperationButton("*");
        multiplyButton.Location = new System.Drawing.Point(20, 110);
        multiplyButton.Click += form.OperationButton_Click;
        form.Controls.Add(multiplyButton);

        var divideButton = CreateOperationButton("/");
        divideButton.Location = new System.Drawing.Point(100, 110);
        divideButton.Click += form.OperationButton_Click;
        form.Controls.Add(divideButton);

        var equalsButton = new Button();
        equalsButton.Text = "=";
        equalsButton.Width = 30;
        equalsButton.Height = 30;
        equalsButton.Font = new System.Drawing.Font(equalsButton.Font.FontFamily, 12);
        equalsButton.Location = new System.Drawing.Point(180, 180);
        equalsButton.Click += form.EqualsButton_Click;
        form.Controls.Add(equalsButton);

        var resetButton = new Button();
        resetButton.Text = "AC";
        resetButton.Width = 60;
        resetButton.Height = 30;
        resetButton.Font = new System.Drawing.Font(resetButton.Font.FontFamily, 12);
        resetButton.Location = new System.Drawing.Point(140, 140);
        resetButton.Click += form.ResetButton_Click;
        form.Controls.Add(resetButton);

        var resultLabel = new Label();
        resultLabel.Location = new System.Drawing.Point(20, 20);
        resultLabel.Size = new System.Drawing.Size(200, 50);
        resultLabel.Font = new System.Drawing.Font(resultLabel.Font.FontFamily, 14);
        resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        form.Controls.Add(resultLabel);
        form.resultLabel = resultLabel;
    }

    private static Button CreateNumberButton(string text)
    {
        var button = new Button();
        button.Text = text;
        button.Width = 30;
        button.Height = 30;
        button.Font = new System.Drawing.Font(button.Font.FontFamily, 12);
        return button;
    }

    private static Button CreateOperationButton(string text)
    {
        var button = new Button();
        button.Text = text;
        button.Width = 30;
        button.Height = 30;
        button.Font = new System.Drawing.Font(button.Font.FontFamily, 12);
        return button;
    }

}