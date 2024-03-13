#include<iostream>
int main()
{
	int n,factoral=1;
	std::cout<<"Enter positive integer:";
	std::cin>>n;
	if(n<0)
	std::cout<<"Error,does not exist";
	else;{
	for(int i=1;i<n;++i)
		factoral*=i;
	}
	std::cout<<"Factorial"<<n<<factoral;
	return 0;
}