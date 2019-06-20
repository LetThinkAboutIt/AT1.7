using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * Author: Tze Yu Choi
 * ID: P459200
 * Creation Date: 2/6/2019  
 * Version: 1.0
 * 
 */

namespace AT1._6
{
    public partial class CalculatorWindow : Form
    {
        // Variable for calculation
        double processingCalculationResult = 0; // Calculating result
        OperatorSelected previousOperator; // Current operator
        bool isStart = false; // Is the calculation begin
        bool isInv = false; // Is inverse active

        public CalculatorWindow()
        {
            InitializeComponent();
        }

        // Rever the number
        private void BtnInv_Click(object sender, EventArgs e)
        {
            isInv = !isInv;

            if (isInv)
            {
                btnSin.Text = "Arcsin";
                btnCos.Text = "Arccos";
                btnTan.Text = "Atctan";
                btnSQRT.Text = "Power 2";
                btnCubeRT.Text = "Power 3";
            }
            else
            {
                btnSin.Text = "Sin";
                btnCos.Text = "Cos";
                btnTan.Text = "Tan";
                btnSQRT.Text = "SQRT";
                btnCubeRT.Text = "CubeRT";
            }
        }

        // Calculate the sin
        private void BtnSin_Click(object sender, EventArgs e)
        {
            // Get the number from the output display
            double num = String.IsNullOrEmpty(txtBoxOutput.Text) ? 0 : double.Parse(txtBoxOutput.Text);

            if (((Button)sender).Text == "Sin")
            {
                // Sine calculation
                txtBoxOutput.Text = Trigonometric.Calculaion.Sin(num).ToString();
            }
            else
            {
                // Error handler
                if (num > 1 || num < -1)
                {
                    MessageBox.Show("Invalid Input. Number must be greater than or equal to -1, but less than or equal to 1.", "Error Message");
                    txtBoxOutput.Text = "";
                    return;
                }
                // Sine calculation
                txtBoxOutput.Text = (Math.Asin(num) * 180 / Math.PI).ToString();
            }
        }

        // Calculate the tan
        private void BtnTan_Click(object sender, EventArgs e)
        {
            // Get the number from the output display
            double num = String.IsNullOrEmpty(txtBoxOutput.Text) ? 0 : double.Parse(txtBoxOutput.Text);

            if (((Button)sender).Text == "Tan")
            {
                // If input is 90
                if (Math.Abs(num) == 90)
                {
                    MessageBox.Show("Invalid Input. Number cannot equal to 90.", "Error Message");
                    txtBoxOutput.Text = "";
                    return;
                }

                // Tan calculation
                txtBoxOutput.Text = Trigonometric.Calculaion.Tan(num).ToString();
            }
            else
            {
                // Atan calculation
                txtBoxOutput.Text = Trigonometric.Calculaion.Atan(num).ToString();
            }


        }

        // Calculate the cos
        private void BtnCos_Click(object sender, EventArgs e)
        {
            // Get the number from the output display
            double num = String.IsNullOrEmpty(txtBoxOutput.Text) ? 0 : double.Parse(txtBoxOutput.Text);
            // If input is not 90, calculate
            if (((Button)sender).Text == "Cos")
            {
                if (num == 90)
                {
                    txtBoxOutput.Text = "0";
                    return;
                }
                txtBoxOutput.Text = Math.Cos((num * Math.PI) / 180).ToString();
            }
            else
            {
                // Error handler
                if (num > 1 || num < -1)
                {
                    MessageBox.Show("Invalid Input. Number must be greater than or equal to -1, but less than or equal to 1.", "Error Message");
                    txtBoxOutput.Text = "";
                    return;
                }
                // Acos calculation
                txtBoxOutput.Text = Trigonometric.Calculaion.Acos(num).ToString();
            }
        }

        // Calculate the cube root
        private void BtnCubeRT_Click(object sender, EventArgs e)
        {
            // Get the number from the output display
            double num = String.IsNullOrEmpty(txtBoxOutput.Text) ? 0 : double.Parse(txtBoxOutput.Text);

            if (((Button)sender).Text == "CubeRT")
            {
                if (num >= 0)
                {
                    // Cube root calculation
                    txtBoxOutput.Text = Algebraic.Calculation.CubeRT(num).ToString();
                }
                else
                {
                    // Cube root calculation
                    txtBoxOutput.Text = (-Algebraic.Calculation.CubeRT(num)).ToString();
                }
            }
            else
            {
                // Power 3 calculation
                txtBoxOutput.Text = Algebraic.Calculation.Pow(num, 3).ToString();
            }
        }

        // Calculate the square root
        private void BtnSQRT_Click(object sender, EventArgs e)
        {
            // Get the number from the output display
            double num = String.IsNullOrEmpty(txtBoxOutput.Text) ? 0 : double.Parse(txtBoxOutput.Text);

            if (((Button)sender).Text == "SQRT")
            {
                // If input is negative
                if (num < 0)
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtBoxOutput.Text = "Number must be positive";
                    return;
                }

                // Square root calculation
                txtBoxOutput.Text = Math.Sqrt(num).ToString();
            }
            else
            {
                // Power 2 calculation
                txtBoxOutput.Text = Algebraic.Calculation.Pow(num, 2).ToString();
            }

        }


        // Add integer 1 on output display
        private void Btn1_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Add integer 2 on output display
        private void Btn2_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Add integer 3 on output display
        private void Btn3_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Add integer 4 on output display
        private void Btn4_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Add integer 5 on output display
        private void Btn5_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Add integer 6 on output display
        private void Btn6_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Add integer 7 on output display
        private void Btn7_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Add integer 8 on output display
        private void Btn8_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Add integer 9 on output display
        private void Btn9_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Add integer 0 on output display
        private void Btn0_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Add . on output display
        private void BtnDot_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = txtBoxOutput.Text + (sender as Button).Text;
        }

        // Clear the output display
        private void BtnDel_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Clear(); // Clear output display
            processingCalculationResult = 0; // Reset the result
        }

        // Mathematically add two result together
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MidTermCalculationHandler(OperatorSelected.add);
        }

        // Subraction
        private void BtnSub_Click(object sender, EventArgs e)
        {
            MidTermCalculationHandler(OperatorSelected.sub);
        }

        // Division
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            MidTermCalculationHandler(OperatorSelected.div);
        }

        // Multiply
        private void BtnMult_Click(object sender, EventArgs e)
        {
            MidTermCalculationHandler(OperatorSelected.mult);
        }

        // Calculate the final result with equal operator
        private void Equal_Click(object sender, EventArgs e)
        {
            FinalCalculationHandler();
        }

        // Mid-term calculation with different operator
        private void MidTermCalculationHandler(OperatorSelected preOperator)
        {
            if (!isStart)
            {
                // Get the number from the output display
                processingCalculationResult = String.IsNullOrEmpty(txtBoxOutput.Text) ? 0 : double.Parse(txtBoxOutput.Text);

                previousOperator = preOperator;// Get the previous operator

                txtBoxOutput.Clear(); // Clear output display

                isStart = true; // Calculation is begun
            }
            else
            {
                Calculation(false); // Calculation method

                txtBoxOutput.Clear(); // Clear output display

                previousOperator = preOperator; // Get the previous operator
            }
        }

        // Final calculation
        private void FinalCalculationHandler()
        {
            if (!isStart)
            {
                return; // Return if not start
            }
            else
            {
                Calculation(true); // Calculation method  
                isStart = false;
            }

        }

        private void Calculation(bool isEqualBtn)
        {
            // Get the number from the output display
            double num = String.IsNullOrEmpty(txtBoxOutput.Text) ? 0 : double.Parse(txtBoxOutput.Text);

            // Verify previous operator
            switch (previousOperator)
            {
                case OperatorSelected.add:
                    processingCalculationResult += num; // Add Calculation
                    if (isEqualBtn)
                        txtBoxOutput.Text = processingCalculationResult.ToString(); // Display result is equal buttonis pressed
                    break;
                case OperatorSelected.sub:
                    processingCalculationResult -= num; // Subtract Calculation
                    if (isEqualBtn)
                        txtBoxOutput.Text = processingCalculationResult.ToString(); // Display result is equal buttonis pressed
                    break;
                case OperatorSelected.div:
                    // Divide by zero
                    if (num == 0)
                    {
                        MessageBox.Show("Cannot divide by zero", "Error Message");
                        txtBoxOutput.Text = "";
                        return;
                    }
                    processingCalculationResult /= num; // Division Calculation
                    if (isEqualBtn)
                        txtBoxOutput.Text = processingCalculationResult.ToString(); // Display result is equal buttonis pressed
                    break;
                case OperatorSelected.mult:
                    processingCalculationResult *= num; // Multiply Calculation
                    if (isEqualBtn)
                        txtBoxOutput.Text = processingCalculationResult.ToString(); // Display result is equal buttonis pressed
                    break;
                default:
                    return;
            }
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Clear();
        }
    }

    // Enum of current operator
    enum OperatorSelected
    {
        add,
        sub,
        div,
        mult
    }
}


