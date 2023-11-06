int n = 5;
int x = 3;
int k = 1;
int m = 1;
double sum = 0;
double pr = 1;
for (int i = k; i <= n; i++)
{
    sum += (Math.Pow(-3, (3 * k) + 1)) / (2 * (Math.Pow((k - 2), (3 * k) + 1)));
}
Console.WriteLine(sum);
for (int i = m; i <= k + 2; i++)
{
    pr *= (Math.Pow(m, 3) - 8) / (m - 4);
}
Console.WriteLine($"{pr:F2}");
Console.WriteLine($"{sum * pr:F2}");
