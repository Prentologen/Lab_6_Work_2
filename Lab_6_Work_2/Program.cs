using System;

class MathOperations
{
    public static T Add<T>(T a, T b)
    {
        dynamic result = a + b;
        return result;
    }

    public static T Subtract<T>(T a, T b)
    {
        dynamic result = a - b;
        return result;
    }

    public static T Multiply<T>(T a, T b)
    {
        dynamic result = a * b;
        return result;
    }
}


int integerA = 5;
int integerB = 3;
double doubleA = 2.5;
double doubleB = 1.2;
int[] arrayA = { 1, 2, 3 };
int[] arrayB = { 4, 5, 6 };

int resultAddInt = MathOperations.Add(integerA, integerB);  // Результат: 8
double resultAddDouble = MathOperations.Add(doubleA, doubleB);  // Результат: 3.7
int[] resultAddArray = MathOperations.Add(arrayA, arrayB);  // Результат: [5, 7, 9]

int resultSubtractInt = MathOperations.Subtract(integerA, integerB);  // Результат: 2
double resultSubtractDouble = MathOperations.Subtract(doubleA, doubleB);  // Результат: 1.3
int[] resultSubtractArray = MathOperations.Subtract(arrayA, arrayB);  // Результат: [-3, -3, -3]

int resultMultiplyInt = MathOperations.Multiply(integerA, integerB);  // Результат: 15
double resultMultiplyDouble = MathOperations.Multiply(doubleA, doubleB);  // Результат: 3.0
int[] resultMultiplyArray = MathOperations.Multiply(arrayA, arrayB);  // Результат: [4, 10, 18]