public class Solution {
    public int MaxArea(int[] height) {
        int result = 0;
int l = 0;
int r = height.Length - 1;
int h=0;

while (l < r)
{
    h = Math.Min(height[l], height[r]);
    result = Math.Max(result, h * (r - l));
    if (l < r && height[l] == h) l++; 
    if (l < r && height[r] == h) r--;
}
        return result;
    }
}