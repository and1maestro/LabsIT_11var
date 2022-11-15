#include <iostream>
using namespace std;

int main()
{
    int x1 = 0;
    int y1 = 0;
    int x2 = 11;
    int y2 = 10;
    int x3 = -11;
    int y3 = 12;
    double h = (abs(x1 * 1 + y1 * 11 - 121)) / sqrt(pow(1,2)+pow(11,2));
    cout << "Height: " << h;
    double l1 = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2)); // c
    double l2 = sqrt(pow(x3 - x1, 2) + pow(y3 - y1, 2)); // b
    double l3 = sqrt(pow(x3 - x2, 2) + pow(y3 - y2, 2)); // a
    double l = (sqrt(l3 * l2 * (l3 + l2 + l1) * (l3 + l2 - l1))) / (l3 + l2);
    cout << "\n\nBisector length: " << l << endl;
}