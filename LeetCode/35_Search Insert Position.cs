public class Solution_35
{
    public int SearchInsert(int[] nums, int target)
    {

        int l = 0, r = nums.Length - 1;
        int mid = 0;
        while (l <= r)
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

        return l;
    }
}