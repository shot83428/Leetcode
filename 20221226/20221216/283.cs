public class Solution {
    public void MoveZeroes(int[] nums) {
        int index=0;
        foreach(var val in nums)
        {
            if(val!=0){
                nums[index]=val;
                index++;
            }
        }
        for(;index<nums.Length;index++){
            nums[index]=0;
        }
    }
}