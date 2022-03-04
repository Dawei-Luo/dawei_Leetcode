int[] nums = { 1, 3, 5, 6 };
int target = 2;


int l = 0, r = nums.Length - 1;
int mid = -1;
while(l<=r)
{
    mid = (l + r) / 2;
    if (target == nums[mid])
    {
        Console.WriteLine(mid);
    }
    if (target > nums[mid])
    {
        l = mid + 1;
    }
    else
    {
        
        r = mid - 1;
    }
    
}
Console.WriteLine(l);



