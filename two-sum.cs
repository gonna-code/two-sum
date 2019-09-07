public class Solution {

    public int[] TwoSum(int[] nums, int target ) {

        for ( var i = 0; i < nums.Count(); i++ ) {

            var current = nums[i];

            for ( var j = i + 1; j < nums.Count(); j++ ) {

                var other = nums[j];

                if ( current + other == target ) {
                    return new int[] { i, j };
                }
            }
                
        }
       return new int[] { 0, 1 };
    }
}