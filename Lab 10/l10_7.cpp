#include <iostream>
using namespace std;

int main()
{
    double y, n;
    cout << "y = ";
    cin >> y;
    cout << "n = ";
    cin >> n;
    double x = pow(y, 2) + (0.5 * n + 4.8) / (sin(y));
    if (sin(y) != 0)
        cout << "The answer is " << x;
    else
        cout << "Division by zero. Correct your data.";
}
