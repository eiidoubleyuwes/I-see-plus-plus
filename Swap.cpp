#include<iostream>
int main()
{
	int a,b,temp;
	std::cout<<"Enter a:";
	std::cin>>a;
	std::cout<<"Enter b:";
	std::cin>>b;
	std::cout<<"Before swapping:"<<endl;
	std::cout<<"a="<<a<<",b="<<b<<endl;
	temp=a,a=b,b=temp;
	std::cout<<"After swapping:"<<endl;
	std::cout<<"a="<<a<<",b="<<b<<endl;
	return 0;
}
