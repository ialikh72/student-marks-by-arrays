using System;
class Mar
{
    
    static void Main()
    {float sum;
        float avg= marks( out sum);
        Console.WriteLine("avg is:"+ avg);
        Console.WriteLine("total is:"+ sum);
    }
    static float marks(out float sum)
    {
       float[] marks =new float[5];
        for(int i=0;i<marks.Length;i++)
        {
            Console.WriteLine("Enter the marks of {0} subject:",i+1);
            marks[i]=float.Parse(Console.ReadLine());
        }
        sum=marks[0]+marks[1]+marks[2]+marks[3]+marks[4];
       float avg=sum/5;
       return avg;
    }
}