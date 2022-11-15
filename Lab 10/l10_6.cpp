#include <iostream>
using namespace std;

int main()
{
    const double k = 7.2;
    double x;
    cout << "x = ";
    cin >> x;
    double c = atan(abs(x));
    double a = c + pow(k, 2);
    double y = 3 * sin(a) + cos(2 * x);
    cout << "\nc = " << c << ", a = " << a << ", y = " << y << endl;
}

