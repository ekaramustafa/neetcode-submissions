class TimeMap {
    private HashMap<String, ArrayList<Pair>> map;

    public TimeMap() {
        map = new HashMap<>();
    }
    
    public void set(String key, String value, int timestamp) {
        map.computeIfAbsent(key, k -> new ArrayList<>())
           .add(new Pair(value, timestamp));
    }
    
    public String get(String key, int timestamp) {
        if (!map.containsKey(key)) {
            return "";
        }

        ArrayList<Pair> list = map.get(key);

        int low = 0;
        int high = list.size() - 1;
        
        while (low < high) {
            int mid = low + (high - low + 1) / 2; // upper mid

            Pair pair = list.get(mid);
            int pairTimestamp = pair.getTimestamp();
            
            if (pairTimestamp == timestamp) {
                return pair.getValue();
            } else if (pairTimestamp > timestamp) {
                high = mid - 1;
            } else {
                low = mid;
            }
        }
        
        Pair answer = list.get(low);

        if (answer.getTimestamp() <= timestamp) {
            return answer.getValue();
        }

        return "";
    }
}

class Pair {
    private String value;
    private int timestamp;

    public Pair(String value, int timestamp) {
        this.value = value;
        this.timestamp = timestamp;
    }

    public String getValue() {
        return value;
    }

    public int getTimestamp() {
        return timestamp;
    }
}