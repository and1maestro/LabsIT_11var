#include <iostream>
using namespace std;

int main()
{
    double p1, p2, p3, t;
    cout << "Enter the productivity of the first pipe (l/h): ";
    cin >> p1;
    cout << "Enter the productivity of the second pipe: ";
    cin >> p2;
    cout << "Enter the productivity of the third pipe: ";
    cin >> p3;
    cout << "Enter the time that passed (in hours): ";
    cin >> t;
    cout << endl << "There are " << (p1 + p2 + p3) * t << " litres of water in the pool.\n";
}