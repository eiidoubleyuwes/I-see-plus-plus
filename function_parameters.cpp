#include<iostream>
int add (int a, int b){
    return (a+b);
}
int main()
{
    int n1,n2;
    std::cout << "Please enter first number:" << std::endl;
    std::cin >> n1;
    std::cout << "Please enter second number:" << std::endl;
    std::cin >> n2;
    int sum = add(n1,n2);
    std::cout << "The total is:" << sum;
}