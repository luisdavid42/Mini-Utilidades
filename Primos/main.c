#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Soy un programa hecho por Liu!\n");
    system("pause");
    int i,j,primos=0,cantdivisores=0;
    //imprimendo primos
    for(i=3;i<100000;i++)
    {
        for(j=2;j<i;j++)
        {
            if(i%j==0)
                cantdivisores++;
        }
        if(cantdivisores==0)
        {
            primos++;
            printf("Primo #%d\t%d\n",primos,i);
            system("pause");
        }
        cantdivisores=0;
    }
    return 0;
}
