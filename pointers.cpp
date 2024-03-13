#include<iostream>
int main(){
    int var=5;
    int* pointVar;
    pointVar=&var;
    std::cout <<"Var=" <<var <<std::endl;
    std::cout <<"pointVar=" <<pointVar <<std::endl;
    std::cout <<"Address of var=" <<&var <<std::endl;
    std::cout <<"Address of pointVar=" <<&pointVar <<std::endl;
    std::cout <<"Reference(details of contents of address) of pointVar=" <<*pointVar <<std::endl;
}