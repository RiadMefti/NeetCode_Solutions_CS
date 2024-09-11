namespace NeetCode_CS.Array_Hashing;

public class DuplicateInteger
{ 
    // Time complexity  O(n2)
    // Space complexity O(1)
    public static bool HasDuplicate1(int[] nums)
    {

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i+1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
                
            }
        }

        return false;

    }
    
    
    // Time complexity  O(nlogn)
    // Space complexity O(1)
    public static bool HasDuplicate2(int[] nums)
    {
        Array.Sort(nums);

        foreach (var k in nums)
        {
            Console.WriteLine(k);
        }

        for (var i = 0; i < nums.Length -1; i++)
        {
            if (nums[i]== nums[i+1])
            {
                return true;
            }
        }

        return false;
        
    }
    
    
    // Time complexity  O(n)
    // Space complexity O(n)
    public static bool HasDuplicate3(int[] nums)
    {
        var numHash = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (numHash.ContainsValue(nums[i]))
            {
                return true;
            }
            
            numHash.Add(i,nums[i]);
        }

        return false;

    }
}