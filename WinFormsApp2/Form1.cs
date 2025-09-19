using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Changed to PascalCase
        {
            try
            {
                int numDigits = int.Parse(txtDigits.Text);

                if (numDigits < 1)
                {
                    MessageBox.Show("Please enter a valid number of digits.");
                    return;
                }

                BigInteger prime = GenerateRandomPrime(numDigits);
                lblPrimeResult.Text = prime.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private BigInteger GenerateRandomPrime(int numDigits)
        {
            Random random = new Random();
            BigInteger lowerBound = BigInteger.Pow(10, numDigits - 1);
            BigInteger upperBound = BigInteger.Pow(10, numDigits) - 1;
            BigInteger candidate;

            do
            {
                candidate = GenerateRandomNumberBetween(lowerBound, upperBound, random);
            }
            while (!IsPrime(candidate));

            return candidate;
        }

        private static BigInteger Sqrt(BigInteger number)
        {
            if (number == 0) return 0;
            if (number > 0)
            {
                BigInteger n = number / 2 + 1;
                BigInteger n1 = (n + number / n) / 2;
                while (n1 < n)
                {
                    n = n1;
                    n1 = (n + number / n) / 2;
                }
                return n;
            }

            // Handle negative numbers (though primes cannot be negative, it's good to avoid errors)
            throw new ArithmeticException("Cannot calculate the square root of a negative number.");
        }

        private BigInteger GenerateRandomNumberBetween(BigInteger lower, BigInteger upper, Random random)
        {
            byte[] bytes = upper.ToByteArray();
            BigInteger randomNumber;

            do
            {
                random.NextBytes(bytes);
                bytes[bytes.Length - 1] &= (byte)0x7F; // Force positive number
                randomNumber = new BigInteger(bytes);
            }
            while (randomNumber < lower || randomNumber > upper);

            return randomNumber;
        }

        private bool IsPrime(BigInteger number)
        {
            if (number < 2) return false;

            BigInteger sqrt = Sqrt(number); // Use the custom Sqrt method

            for (BigInteger i = 2; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void lblPrimeResult_Click(object sender, EventArgs e)
        {

        }

        private void txtDigits_TextChanged(object sender, EventArgs e)
        {

        }
    }
}