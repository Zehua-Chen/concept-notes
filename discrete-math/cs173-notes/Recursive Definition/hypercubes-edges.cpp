#include <cmath>
#include <iostream>

using namespace std;

int V(int n)
{
    return pow(2, n);
}

int E(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return 2 * E(n - 1) + V(n - 1);
}

int main()
{
    cout << "E(13) = " << E(13) << endl;
    return 0;
}