class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        HashMap<String, List<String>> map = new HashMap<>();

        for (String str : strs) {
            String sortedStr = giveSorted(str);

            if (map.containsKey(sortedStr)) {
                map.get(sortedStr).add(str);
            } else {
                List<String> sList = new ArrayList<>();
                sList.add(str);
                map.put(sortedStr, sList);
            }
        }

        return new ArrayList<>(map.values());
    }

    private static String giveSorted(String str) {
        char[] chars = str.toCharArray();
        Arrays.sort(chars);
        return new String(chars);
    }
}