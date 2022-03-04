int[] nums = { -1, 0, 1, 2, -1, -4 };
IList<IList<int>> result = new List<IList<int>>();
Array.Sort(nums);
    
for (int i = 0; i < nums.Length -2; i++)
{
   if(i > 0 || nums[i] == nums[i-1] ) 
    {
      continue;
    }
    int j = i + 1;
    int k = nums.Length - 1;
    while (j < k)
    {
        if (j >(i+1) && nums[j] == nums[j-1])
        {
            j++;
            continue;
        }
         if (k < (nums.Length - 1) && nums[k] == nums[k+1])
        {
            k--;
            continue;
        }
        int sum = nums[i] + nums[j] + nums[k];
        if (sum == 0)
        {
            IList<int> newArr = new List<int>();
            newArr.Add(nums[i]);
            newArr.Add(nums[j]);
            newArr.Add(nums[k]);
            result.Add(newArr);
            k--;
            j++;
        }
        else if (sum < 0)
        {
            j++;
        }
        else
        {
            k--;
        }
    }
   
    //return result;             

    for (int l = 0; l < result.Count; l++)
    {
        Console.WriteLine("[");
        for (int m = 0; m < result.ToArray()[l].Count; m++)
        {
            Console.WriteLine(result.ToArray()[l].ToArray()[m]);

        }
        Console.WriteLine("]");
    }
}


