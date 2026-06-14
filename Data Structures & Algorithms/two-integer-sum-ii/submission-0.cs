public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        Dictionary<int, int> map = new Dictionary<int,int>();

        for(int i =0;i<numbers.Length;i++){
            if(map.ContainsKey(target - numbers[i])){
                int[] result = new int[2];
                result[0] = map[target-numbers[i]] + 1;
                result[1] = i + 1;
                return result;
            }
            map[numbers[i]] = i;
        }
        
        return null;
    }
}
