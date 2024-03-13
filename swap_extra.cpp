#include<iostream>
void swap (int a,int b){
b=a+b;
a=b-a;
b=b-a;
std::cout << "After swapping inside swap:" <<std::endl;
std::cout <<"a=" << a <<std::endl;
std::cout <<"b=" << b <<std::endl;
}
int main(){
    int a,b;
    std::cout << "Enter the two numbers to be swapped:" << std::endl;
    std::cin >> a >> b;
    std::cout << "a=" << a <<std::endl;
    std::cout << "b=" << b <<std::endl;
    swap (a,b);

}
