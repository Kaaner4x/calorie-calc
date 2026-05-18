# CalorieCalc 🍎

A simple yet effective C# console application that calculates your **Basal Metabolic Rate (BMR)** and **Total Daily Energy Expenditure (TDEE)** to help you manage your daily calorie intake.

## 📖 What are BMR and TDEE?

- **Basal Metabolic Rate (BMR):** The number of calories your body needs to accomplish its most basic (basal) life-sustaining functions.
- **Total Daily Energy Expenditure (TDEE):** An estimation of how many calories you burn per day when your activity level is taken into account.

This application uses the **Mifflin-St Jeor equation**, which is widely considered one of the most accurate methods for estimating BMR:
- For Men: `BMR = (10 × weight in kg) + (6.25 × height in cm) - (5 × age in years) + 5`
- For Women: `BMR = (10 × weight in kg) + (6.25 × height in cm) - (5 × age in years) - 161`

## 🎯 Project Purpose

The main objective of this project is to implement a calorie calculator in C# that can accurately estimate the daily energy requirements of a user based on their physical attributes and lifestyle.

When a user runs the application, it:
1. **Prompts** for age, gender, height, and weight with robust input validation.
2. **Asks** for the activity level (ranging from sedentary to very active).
3. **Calculates and displays** both the BMR and TDEE in kilocalories (kcal).

## 🚀 How to Run

Follow these steps to run the application on your local machine:

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) must be installed on your system.

### Steps
1. **Clone the repository** (or download the source code):
   ```bash
   git clone https://github.com/Kaaner4x/calorie-calc.git
   ```
2. **Navigate to the project directory**:
   ```bash
   cd calorie-calc
   ```
3. **Run the application**:
   ```bash
   dotnet run
   ```
4. **Usage**: The console will prompt you to enter your age, gender (m/f), height (cm), weight (kg), and activity level. Simply type the requested information and press "Enter" to see your calculated BMR and TDEE.

## 📄 License

This project is licensed under the [MIT License](LICENSE). See the `LICENSE` file for details.
