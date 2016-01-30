

#include "stdafx.h"
#include "stdlib.h";
#include <Windows.h>;
#include <iostream>
#include <cstdio>
#include <ctime>
using namespace std;

#define array_Size 2000000
//Wykorzystamy program do znajdywanie oraz sortowania danych w tablicy porównamy czas ich działania 
long listOfValues[array_Size];
void initArray();
void quicksort(long tablica[], int x, int y);
int findLargestValue();
int _tmain(int argc, _TCHAR* argv[])
{
clock_t startTime = clock();
initArray();	
findLargestValue();
quicksort(listOfValues,0,array_Size);
clock_t endTime = clock();
clock_t clockTicksTaken = endTime - startTime;
double timeInSeconds = clockTicksTaken ;
	printf("Czas dzialania milisekundach: %f \n",timeInSeconds );

	system("pause");
}
int findLargestValue()
{
	int maxValue=listOfValues[0];
	for(int i=1;i<array_Size-1;i++)
	{
		if(maxValue<listOfValues[i])
		{
			maxValue=listOfValues[i];
		}
	}
		return maxValue;
}
void initArray()
{
	for(int i=0;i<array_Size-1;i++)
	{
		listOfValues[i]=rand();
	}
}
void quicksort(long tablica[], int x, int y)
{
	int i,j,v,temp;
	i=x;
	j=y;
	v=tablica[div(x+y,2).quot];
	do
		{
			while (tablica[i]<v) i++;
				while (v<tablica[j]) j--;
					if (i<=j)
						{
							temp=tablica[i];
							tablica[i]=tablica[j];
							tablica[j]=temp;
							i++;
							j--;
						}
		}
				while (i<=j);
					if (x<j) quicksort(tablica,x,j);
					if (i<y) quicksort(tablica,i,y);


}
