public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> list = new List<List<string>>();
        Dictionary<string, List<string>> dictt = new Dictionary<string, List<string>>(); 

        for(int i =0;i<strs.Length;i++){
            string sorted = new string (strs[i].OrderBy(c => c).ToArray());
            if(dictt.ContainsKey(sorted)){
                dictt[sorted].Add(strs[i]);
            }
            else{
                List<string> subList = new List<string>();
                subList.Add(strs[i]);
                dictt[sorted] = subList;
            }
        }

        foreach(KeyValuePair<string, List<string>> kvp in dictt){
            list.Add(kvp.Value);
        }
        
        return list;
    }
}
