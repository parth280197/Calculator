using System;
using System.Windows.Forms;

namespace Calculator
{
  public partial class Form1 : Form
  {
    double Number1;
    double Number2;
    string Operation;
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      Number1 = 0;
      Number2 = 0;
      txtInput.Text = Number1.ToString();
    }
    private void Btn0_Click(object sender, EventArgs e)
    {
      txtInput.Text += "0";
    }

    private void Btn1_Click(object sender, EventArgs e)
    {
      txtInput.Text += "1";
    }

    private void Btn2_Click(object sender, EventArgs e)
    {
      txtInput.Text += "2";
    }

    private void Btn3_Click(object sender, EventArgs e)
    {
      txtInput.Text += "3";
    }

    private void Btn4_Click(object sender, EventArgs e)
    {
      txtInput.Text += "4";
    }

    private void Btn5_Click(object sender, EventArgs e)
    {
      txtInput.Text += "5";
    }

    private void Btn6_Click(object sender, EventArgs e)
    {
      txtInput.Text += "6";
    }

    private void Btn7_Click(object sender, EventArgs e)
    {
      txtInput.Text += "7";
    }

    private void Btn8_Click(object sender, EventArgs e)
    {
      txtInput.Text += "8";
    }

    private void Btn9_Click(object sender, EventArgs e)
    {
      txtInput.Text += "9";
    }

    private void BtnReset_Click(object sender, EventArgs e)
    {
      txtInput.Text = "";
    }

    private void BtnDivide_Click(object sender, EventArgs e)
    {
      Operation = "/";
      Number1 = Convert.ToDouble(txtInput.Text);
      txtInput.Text = "0";
    }

    private void BtnMultiply_Click(object sender, EventArgs e)
    {
      Operation = "*";
      Number1 = Convert.ToDouble(txtInput.Text);
      txtInput.Text = "0";
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
      Operation = "+";
      Number1 = Convert.ToDouble(txtInput.Text);
      txtInput.Text = "0";
    }

    private void BtnSubtract_Click(object sender, EventArgs e)
    {
      Operation = "-";
      Number1 = Convert.ToDouble(txtInput.Text);
      txtInput.Text = "0";
    }

    private void BrnEqual_Click(object sender, EventArgs e)
    {
      Number2 = Convert.ToDouble(txtInput.Text);

      if (Operation == "+")
      {
        txtInput.Text = (Number1 + Number2).ToString();
        Number1 = (Number1 + Number2);
      }
      else if (Operation == "-")
      {
        txtInput.Text = (Number1 - Number2).ToString();
        Number1 = (Number1 - Number2);
      }
      else if (Operation == "*")
      {
        txtInput.Text = (Number1 * Number2).ToString();
        Number1 = (Number1 + Number2);
      }
      else if (Operation == "/")
      {
        if (Number2 == 0)
        {
          txtInput.Text = "Error: Devide by zero";
        }
        else
        {
          txtInput.Text = (Number1 / Number2).ToString();
          Number1 = (Number1 / Number2);
        }
      }
      else if (Operation == "^")
      {
        txtInput.Text = Math.Pow(Number1, Number2).ToString();
        Number1 = Math.Pow(Number1, Number2);
      }
      else if (Operation == "OR")
      {
        try
        {
          var num1 = Convert.ToByte(Number1.ToString(), 2);
          var num2 = Convert.ToByte(Number2.ToString(), 2);
          var result = ConvertToBinary(num1 | num2);
          txtInput.Text = result;
          Number1 = Convert.ToDouble(result);
        }
        catch
        {
          txtInput.Text = "Please Enter valid binary.[Press Reset]";
        }

      }
      else if (Operation == "AND")
      {
        try
        {
          var num1 = Convert.ToByte(Number1.ToString(), 2);
          var num2 = Convert.ToByte(Number2.ToString(), 2);
          var result = ConvertToBinary(num1 & num2);
          txtInput.Text = result;
          Number1 = Convert.ToDouble(result);
        }
        catch
        {
          txtInput.Text = "Please Enter valid binary.[Press Reset]";
        }

      }
      else if (Operation == "XOR")
      {
        try
        {
          var num1 = Convert.ToByte(Number1.ToString(), 2);
          var num2 = Convert.ToByte(Number2.ToString(), 2);
          var result = ConvertToBinary(num1 ^ num2);
          txtInput.Text = result;
          Number1 = Convert.ToDouble(result);
        }
        catch
        {
          txtInput.Text = "Please Enter valid binary.[Press Reset]";
        }
      }
    }

    private void BtnSqr_Click(object sender, EventArgs e)
    {
      Number1 = Convert.ToDouble(txtInput.Text);
      txtInput.Text = (Number1 * Number1).ToString();
      Number1 = (Number1 * Number1);
    }

    private void BtnSqrt_Click(object sender, EventArgs e)
    {
      try
      {
        Number1 = Convert.ToDouble(txtInput.Text);
        txtInput.Text = Math.Sqrt(Number1).ToString();
        Number1 = Math.Sqrt(Number1);
      }
      catch
      {
        txtInput.Text = "Math Error.[Press Reset]";
      }
    }

    private void BtnPower_Click(object sender, EventArgs e)
    {
      Operation = "^";
      Number1 = Convert.ToDouble(txtInput.Text);
      txtInput.Text = "0";
    }

    private void BtnBinary_Click(object sender, EventArgs e)
    {
      Number1 = Convert.ToDouble(ConvertToBinary(Convert.ToInt32(txtInput.Text)));
      txtInput.Text = Number1.ToString();
    }
    static string ConvertToBinary(int number)
    {
      var result = "";
      int i = 0;
      while (number > 0)
      {
        var reminder = number % 2;
        number = number / 2;
        i++;
        result = reminder.ToString() + result;
      }

      return result;
    }
    static string ConvertToDecimal(int number)
    {
      int reminder, decimalValue = 0, baseValue = 1;

      while (number > 0)
      {
        reminder = number % 10;
        decimalValue = decimalValue + reminder * baseValue;
        number = number / 10;

        baseValue = baseValue * 2;
      }
      return decimalValue.ToString();
    }

    private void BtnDecimal_Click(object sender, EventArgs e)
    {
      Number1 = Convert.ToDouble(ConvertToDecimal(Convert.ToInt32(txtInput.Text)));
      txtInput.Text = Number1.ToString();
    }

    private void BtnOr_Click(object sender, EventArgs e)
    {
      Operation = "OR";
      Number1 = Convert.ToDouble(txtInput.Text);
      txtInput.Text = "0";
    }

    private void BtnXor_Click(object sender, EventArgs e)
    {
      Operation = "XOR";
      Number1 = Convert.ToDouble(txtInput.Text);
      txtInput.Text = "0";
    }

    private void BtnAnd_Click(object sender, EventArgs e)
    {
      Operation = "AND";
      Number1 = Convert.ToDouble(txtInput.Text);
      txtInput.Text = "0";
    }
  }
}
