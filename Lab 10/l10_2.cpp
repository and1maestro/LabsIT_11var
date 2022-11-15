#include <iostream>
using namespace std;

int main()
{
    double S;
    cout << "Square of the circle: ";
    cin >> S;
    double r = sqrt(S / 3.14);
    cout << "\nSquare of the square: " << 2 * pow(r, 2) << ", perimeter: " << 8 * r << endl;
}