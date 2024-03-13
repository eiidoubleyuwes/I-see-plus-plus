#include<iostream>
int main(){
    int numb[7];
    std::cout << "Your numbers are:";
    for(std::size_t i=0;i<7;i++){
        std::cin >> numb[i];
    }
    std::cout << "The numbers are:" << std::endl;
    for(std::size_t n=0;n<7;++n){
    std::cout << numb[n] << "->" <<std::endl;
    }
    return 0;
}