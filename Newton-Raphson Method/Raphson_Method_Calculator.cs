using System;
using System.Text;
using System.Windows.Forms;
using NCalc;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
using System.Collections.Generic;
using Secant_Method.Details;

namespace Secant_Method
{
    // Main form class for the Newton-Raphson Method application
    public partial class Raphson_Method : Form
    {
        // Constructor to initialize the form components
        public Raphson_Method()
        {
            InitializeComponent();
        }

        // Event handler for the Calculate button click event
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse inputs from the text boxes
                string function = tbxFunction.Text;
                double initialGuess = double.Parse(tbxInitialGuess.Text);
                double tolerance = double.Parse(tbxTolerance.Text);

                // Clear previous result
                lblResult.Text = "";

                // Perform Newton-Raphson Method
                NewtonRaphson(function, initialGuess, tolerance);
            }
            catch (Exception ex)
            {
                // Show error message in case of exception
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Event handler for the Exit button click event
        private void pbxExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        // Event handler for the Clear All button click event
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // Clear all input text boxes and the result label
            tbxFunction.Text = "";
            tbxInitialGuess.Text = "";
            tbxTolerance.Text = "";
            lblResult.Text = "";
        }

        // Helper method to append text to the result label
        private void AppendToResult(string text)
        {
            lblResult.Text += text + Environment.NewLine;
        }

        // Method to perform the Newton-Raphson method
        private string NewtonRaphson(string function, double initialGuess, double tolerance)
        {
            // Parse the function and its derivative using MathNet.Symbolics
            var f = Expr.Parse(function);
            var df = f.Differentiate("x");

            // Convert the symbolic expressions to functions
            Func<double, double> func = x => Evaluate(f, x);
            Func<double, double> dfunc = x => Evaluate(df, x);

            double x = initialGuess; // Initialize the current guess
            int iterations = 0; // Initialize iteration counter
            const int maxIterations = 1000; // Set a maximum number of iterations

            // Iterate until the maximum number of iterations is reached
            while (iterations < maxIterations)
            {
                double fx = func(x); // Evaluate the function at the current guess
                double dfx = dfunc(x); // Evaluate the derivative at the current guess

                // Check if the derivative is too small
                if (Math.Abs(dfx) < tolerance)
                {
                    AppendToResult("Derivative is too small, stopping iteration.");
                    break;
                }

                // Update the guess using the Newton-Raphson formula
                double x1 = x - fx / dfx;

                // Calculate the estimated error
                double estimatedError = Math.Abs(x1 - x);

                // Display iteration count and estimated error
                AppendToResult($"Iteration {iterations}: x = {x1}\nEstimated Error = {estimatedError}");

                // Check if the estimated error is within tolerance
                if (estimatedError < tolerance)
                {
                    AppendToResult($"Converged to solution with tolerance {tolerance} in {iterations} iterations.");
                    return lblResult.Text; // Return the result as a string
                }

                // Update the current guess and increment the iteration counter
                x = x1;
                iterations++;
            }

            // Check if the maximum number of iterations was reached without convergence
            if (iterations >= maxIterations)
            {
                AppendToResult("Reached maximum number of iterations without convergence.");
            }

            return lblResult.Text;
        }

        // Method to evaluate a symbolic expression at a given value of x
        private double Evaluate(Expr expression, double x)
        {
            // Create a dictionary to hold the variable values
            var variables = new Dictionary<string, FloatingPoint>
            {
                { "x", x }
            };
            // Evaluate the expression with the given variables
            var result = expression.Evaluate(variables);
            // Return the real part of the result as a double
            return (double)result.RealValue;
        }

        private void lblDetails_Click(object sender, EventArgs e)
        {
            new frm_Details().Show();
        }
    }
}
