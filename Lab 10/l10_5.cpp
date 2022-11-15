#include <iostream>
using namespace std;

int main()
{
    double a;
    cout << "Enter your angle (in rad): ";
    cin >> a;
    double z1 = (1 - 2 * pow(sin(a), 2)) / (1 + pow(sin(a), 2));
    double z2 = (1 - tan(a)) / (1 + tan(a));
    cout << "z1 = " << z1 << endl << "z2 = " << z2;
}