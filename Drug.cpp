#include<iostream>
int main()
{
	std::string drug,illegal[]={"Cocaine","Heroin","Meth","LSD","Mandrax"},legal[]={"Alcohol","Kuber","Lyft","Cigar"},middle[]={"Kumikumi","Muratina","Bhang","Weed"};
	std::cout<<"Enter drug:";
	std::cin>>drug;
	for(auto i:illegal)
	{
		if(drug==i)
		{
			std::cout<<"Illegal drug,Estimated market value:200-800$";
		}
	}
	for(auto a:legal)
	{
		if(drug==a)
		{
			std::cout<<"Legal drug,Estimated market value:20-100$";
		}
	}
	for(auto j:middle)
	{
		if(drug==j)
		{
			std::cout<<"Legality pending...,Estimated market value:5-400$";
		}
	}
	return 0;
}
