PrimeNumGenerator

A simple C# Windows Forms application to generate prime numbers (or test for primes).

Table of Contents

Features

Prerequisites

Getting Started

Usage

How It Works

Contributing

License

Features

User interface built using Windows Forms.

Input a number (or a range), and check if it’s prime.

Possibly list all primes up to a given number.

Simple, minimal setup.

Prerequisites

Windows OS

.NET / .NET Framework compatible with the project (check .sln for target version)

Visual Studio (or any IDE that supports C# WinForms)

Getting Started

Clone the repository:

git clone https://github.com/Srujanapolisetti/primenumgenerator.git


Open the solution file primenumgenerator.sln in Visual Studio.

Restore any missing dependencies (if any).

Build the project.

Run the application.

Usage

Enter a number and click Check Prime to see if it's prime.

Enter a limit (e.g. N) to see all prime numbers ≤ N.

Clear inputs / results as needed.

How It Works

The application uses a primality test algorithm (e.g. trial division) to check a number for factors.

For listing primes, it probably iterates through numbers up to the given limit and tests each.

The UI lets users input values, press buttons to trigger the checks, and displays results in labels or list boxes.
