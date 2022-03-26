using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        string operation = ""; // Global operasyon ismi değişkeni
        double result; // Num1,Num2 yerine result ve txtDisplay.Text ile çalışılacak.
        // result sonuç değeri olabilir, ilk girilen sayı olabilir. Bundan dolayı txtDisplay.Text duruma göre
        // hem 1. hem 2. sayı olabilir.
        bool performedOperation = false; // Ekrana bir işlem yapıldıktan sonra sayı girilince önceki sayı 
        // silinmeli ve yerine basılan değerler girilmeli.
        bool displayHasErrorText = false; // Ekranda sayı yerine hata mesajının olup olmadığının bool değeri
        List<Double> memoryList = new(); // Hafızaya kaydedilen bütün değerler
        int memoryIndex; // index ile çalışmamız gerektiği için memoryIndex değişkeni
        double memory; // Duruma göre ilgili indexteki memory değeri değişebilir. Bu yüzden ayrı bir değişken de gerekli
        public Form2()
        {
            InitializeComponent();
        }

        private void Off_Operation(object sender, EventArgs e)
        {
            Application.Exit(); // Off butonuna basılınca uygulamanın kapatılması
        }

        private void Numeric_Values(object sender, EventArgs e)
        {
            CheckDisplayText();

            if (txtDisplay.Text == "0" || performedOperation) txtDisplay.Clear();

            performedOperation = false;

            Button button = (Button)sender;

            if (button.Text == ",")
            {
                if (!txtDisplay.Text.Contains(',')) txtDisplay.Text += button.Text;
            }
            else txtDisplay.Text += button.Text;
        }

        private void OpClear(object sender, EventArgs e)
        {
            CheckDisplayText();


            if (txtDisplay.Text == "0")
            {
                lblOp.Text = "";
                listBoxMemory.Visible = false;
            }
            else txtDisplay.Text = "0";
            result = 0;
        }

        private void SingleNumber_Operations(object sender, EventArgs e)
        {
            CheckDisplayText();

            Button button = (Button)sender;

            switch (button.Text)
            {
                case "⌫":
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                    if (txtDisplay.Text == "") txtDisplay.Text = "0";
                    break;
                case "±":
                    if (txtDisplay.Text == "0")
                    {
                        txtDisplay.Text = "Sıfır ile işlem yapılamaz";
                        displayHasErrorText = true;
                        break;
                    }

                    double v = Double.Parse(txtDisplay.Text);
                    txtDisplay.Text = (-v).ToString();

                    break;
                case "1/x":
                    if (txtDisplay.Text == "0")
                    {
                        //txtDisplay.TextAlign = HorizontalAlignment.Center;
                        txtDisplay.Text = "Sıfıra bölünemez";
                        displayHasErrorText = true;
                        break;
                    }
                    lblOp.Text = $"1/({txtDisplay.Text})";

                    txtDisplay.Text = (1 / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "x²":
                    double displayText = Double.Parse(txtDisplay.Text);

                    lblOp.Text = $"{txtDisplay.Text}²";

                    txtDisplay.Text = ((displayText * displayText)).ToString();
                    break;
                case "√":

                    lblOp.Text = $"√({txtDisplay.Text})";

                    txtDisplay.Text = Math.Sqrt(Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            performedOperation = true;


        }

        private void Operational_Function(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                if (operation == button.Text)
                {
                    lblOp.Text = result + " " + operation;
                    bEquals.PerformClick();

                }
                else
                { //
                    operation = button.Text;
                    lblOp.Text = result + " " + operation;
                }
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(txtDisplay.Text);
                lblOp.Text = result + " " + operation;

            }

            performedOperation = true;

        }

        private void OpEquals_Click(object sender, EventArgs e)
        {

            CheckDisplayText();

            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "x":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "÷":

                    string checkResult = (result / Double.Parse(txtDisplay.Text)).ToString();
                    if (checkResult == "∞" || checkResult == "NaN")
                    {
                        //txtDisplay.TextAlign = HorizontalAlignment.Center;

                        txtDisplay.Text = "Sıfıra bölünemez";
                        displayHasErrorText = true;

                        break;
                    }

                    txtDisplay.Text = checkResult;
                    break;
                case "%":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text) / 100).ToString();
                    break;
                default:
                    break;
            }

            if (displayHasErrorText)
            {
                DisableButtons();
            }
            else
            {
                result = Double.Parse(txtDisplay.Text);
                //lblOp.Text = (result + " " + operation);
            }
            lblOp.Text = (result + " " + operation);
            performedOperation = true;
        }

        private void Memory_Operations(object sender, EventArgs e)
        {
            listBoxMemory.Items.Clear(); // 

            Button button = (Button)sender;

            operation = button.Text;
            switch (operation)
            {
                case "MC":
                    txtDisplay.Text = "0";
                    memory = 0;
                    memoryIndex = 0;
                    if (memoryList.Count > 0) memoryList.Clear();

                    bOpMemoryRead.Enabled = false;
                    bOpMemoryClear.Enabled = false;
                    bOpMemoryList.Enabled = false;
                    break;

                case "MR":
                    txtDisplay.Text = memory.ToString();
                    break;
                case "M+":
                    if (memoryList.Count == 0 /*|| !memoryList.Contains(Double.Parse(txtDisplay.Text))*/)
                    {
                        memory += Double.Parse(txtDisplay.Text);
                        memoryList.Add(memory);
                        memoryIndex = 0;

                    }
                    else
                    {
                        if (memoryList.IndexOf(Double.Parse(txtDisplay.Text)) != memory)
                        {
                            memory += Double.Parse(txtDisplay.Text);
                            memoryList[memoryIndex] = memory;
                        }
                        else
                        {
                            memoryIndex = memoryList.IndexOf(memory);
                            memory += Double.Parse(txtDisplay.Text);
                            memoryList[memoryIndex] = memory;
                        }

                    }
                    bOpMemoryRead.Enabled = true;
                    bOpMemoryClear.Enabled = true;
                    bOpMemoryList.Enabled = true;

                    break;

                case "M-":
                    if (memoryList.Count == 0 /*|| !memoryList.Contains(Double.Parse(txtDisplay.Text))*/)
                    {
                        memory -= Double.Parse(txtDisplay.Text);
                        memoryList.Add(memory);
                        memoryIndex = 0;

                    }
                    else
                    {
                        if (memoryList.IndexOf(Double.Parse(txtDisplay.Text)) != memory)
                        {
                            memory -= Double.Parse(txtDisplay.Text);
                            memoryList[memoryIndex] = memory;
                        }
                        else
                        {
                            memoryIndex = memoryList.IndexOf(memory);
                            memory -= Double.Parse(txtDisplay.Text);
                            memoryList[memoryIndex] = memory;
                        }
                    }
                    bOpMemoryRead.Enabled = true;
                    bOpMemoryClear.Enabled = true;
                    bOpMemoryList.Enabled = true;
                    break;

                case "MS":
                    double parsedText = Double.Parse(txtDisplay.Text);
                    memory = parsedText; // !!! 

                    memoryList.Add(parsedText);
                    memoryIndex = memoryList.IndexOf(parsedText);
                    bOpMemoryClear.Enabled = true;
                    bOpMemoryRead.Enabled = true;
                    bOpMemoryList.Enabled = true;
                    break;

                case "M↓":
                    for (int i = 0; i < memoryList.Count; i++)
                    {
                        listBoxMemory.Items.Add(memoryList[i]);
                    }
                    listBoxMemory.Visible = true;
                    break;

                default:
                    break;
            }
            performedOperation = true;

        }

        private void Buttons_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            switch (e.KeyChar.ToString())
            {
                case "0":
                    bNumber0.PerformClick();
                    break;
                case "1":
                    bNumber1.PerformClick();
                    break;
                case "2":
                    bNumber2.PerformClick();
                    break;
                case "3":
                    bNumber3.PerformClick();
                    break;
                case "4":
                    bNumber4.PerformClick();
                    break;
                case "5":
                    bNumber5.PerformClick();
                    break;
                case "6":
                    bNumber6.PerformClick();
                    break;
                case "7":
                    bNumber7.PerformClick();
                    break;
                case "8":
                    bNumber8.PerformClick();
                    break;
                case "9":
                    bNumber9.PerformClick();
                    break;
                case "+":
                    bOpPlus.PerformClick();
                    break;
                case "-":
                    bOpMinus.PerformClick();
                    break;
                case "x":
                    bOpMultiplication.PerformClick();
                    break;
                case "/":
                    bOpDivide.PerformClick();
                    break;
                case "1/x":
                    bOpDivideX.PerformClick();
                    break;
                case "x²":
                    bOpExponent.PerformClick();
                    break;
                case "√":
                    bOpSquareRoot.PerformClick();
                    break;
                case "%":
                    bOpPercent.PerformClick();
                    break;
                case "\b": // Backspace
                    bOpBackspace.PerformClick();
                    break;

                default:
                    break;
            }
        }

        private void Buttons_KeyDown(object sender, KeyEventArgs e)
        {


            //MessageBox.Show(e.KeyValue.ToString());
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.KeyCode == Keys.L) bOpMemoryClear.PerformClick();
                if (e.KeyCode == Keys.R) bOpMemoryRead.PerformClick();
                if (e.KeyCode == Keys.P) bOpMemoryPlus.PerformClick();
                if (e.KeyCode == Keys.Q) bOpMinus.PerformClick();
                if (e.KeyCode == Keys.M) bOpMemorySave.PerformClick();
            }

            if (Control.ModifierKeys == Keys.Shift) {
                if (e.KeyCode == Keys.D0) bEquals.PerformClick();

            }

            switch (e.KeyData.ToString())
            {
                case "DELETE":
                    bOpClear.PerformClick();
                    break;
                default:
                    break;
            }



        }

        private void CheckDisplayText()
        {
            if (displayHasErrorText)
            {
                txtDisplay.Text = "0";
                lblOp.Text = "";
                result = 0;

                performedOperation = false;
                displayHasErrorText = false;

                bOpPercent.Enabled = true;
                bOpDivideX.Enabled = true;
                bOpDivide.Enabled = true;
                bOpExponent.Enabled = true;
                bOpMinus.Enabled = true;
                bOpMultiplication.Enabled = true;
                bOpPlus.Enabled = true;
                bPoint.Enabled = true;
                bOpSquareRoot.Enabled = true;
                bOpPlusMinus.Enabled = true;
                bEquals.Enabled = true;

                return;
            }
        }


        private void DisableButtons()
        {
            bOpPercent.Enabled = false;
            bOpDivideX.Enabled = false;
            bOpDivide.Enabled = false;
            bOpExponent.Enabled = false;
            bOpMinus.Enabled = false;
            bOpMultiplication.Enabled = false;
            bOpPlus.Enabled = false;
            bPoint.Enabled = false;
            bOpSquareRoot.Enabled = false;
            bOpPlusMinus.Enabled = false;
            bEquals.Enabled = false;
        }
    }
}
