using System;
					
public class Program
{
	public static void Main()
	{
		int[] testcase1 = new int[] {2,5,7};
		int[] testcase2 = new int[] {2,4,8,90,77,54};
		int[] testcase3 = new int[] {2,-1,0,-1,3};
		int[] testcase4 = new int[] {1,4,2,10,-2,7,-5,90};
		int[] aryResult = NextGreatestInArray(testcase4);
		for(int i = 0; i < aryResult.Length; i++)
		{
			Console.WriteLine(aryResult[i]);
		}
	}

	public static int[] NextGreatestInArray(int[] ary)
	{
		int[] aryFiltered = new int[ary.Length];
		for(int i = 0; i < ary.Length; i++)
		{
			int intCurrentElement = ary[i];
			int intX = intCurrentElement;
			int intRevisions = 0;

			if(i == ary.Length - 1)
				intX = -1;
			else
			{
				for(int j = i+1; j < ary.Length; j++)
				{
					if(ary[j] > intCurrentElement)
					{
						if(intRevisions <= 0)
						{
							intX = ary[j];
							intRevisions++;
						}
						else if(ary[j] < intX)
						{
							intX = ary[j];
							intRevisions++;
						}
					}
					else if(intRevisions <= 0 && ary[j] < intCurrentElement)
						intX = -1;
				}
			}
			aryFiltered[i] = intX;
		}		
		return aryFiltered;
	}
}