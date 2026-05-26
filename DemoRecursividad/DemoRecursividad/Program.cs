// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int n = 5;
int suma = SumaNEnteros(n);
Console.WriteLine($"La suma de los primeros {n} enteros es: {suma}"); //interpolacino de cadenas
Console.WriteLine("La suma de los primeros " + n + " enteros es: " + suma); // concatenacion de cadenas

long factorial = Factorial(n);
Console.WriteLine($"El factorial de {n} es: {factorial}");

int fibo = fibonacci(n);
Console.WriteLine($"El numero {n} de la serie de Fibonacci es: {fibo}");

static int SumaNEnteros(int n)
{
    if(n == 1) return 1;            // Caso base
    return n + SumaNEnteros(n - 1); // Caso recursivo
}

static long Factorial(long n)
{
    if(n == 0) return 1;
    return (n * Factorial(n - 1));
}

static int fibonacci(int n)
{
    if(n == 0 || n == 1 ) return n;
    return fibonacci(n - 1) + fibonacci(n - 2);
}