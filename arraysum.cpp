#include<iostream>
int main()
{
    int numb[8];
    double sum = 0;
    double count = 0;
    double average;
    std::cout << "Your numbers are:";
    for(std::size_t i=0;i<8;++i){
        std::cin >> numb[i];
    }
    std::cout << "The numbers are:";
    for(std::size_t n=0;n<8;++n){
    std::cout << numb[n] << ",";
    }
    for(std::size_t n=0;n<8;++n){
    sum=sum+numb[n];
    average=sum/8;
    }
    std::cout << "The sum is:" <<sum << std::endl;
    std::cout << "The average is:" <<average << std::endl;
    return 0;
}