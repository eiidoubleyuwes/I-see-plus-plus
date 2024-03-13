#include <iostream>
int main(){
	int n,x,factorial=1;
	std::cout << "Enter a number:";
	std::cin >>n;
	if(n<0)
	{
		std::cout << "The number is invalid!!" << std::endl;
	}
	else{
		for(x=1; x<=n; ++x){
		factorial=factorial*n;
		std::cout << "Factoral at" << x << " is:" << factorial << std::endl;
		}
		}

}