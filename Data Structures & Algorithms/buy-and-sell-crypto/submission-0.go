func maxProfit(prices []int) int {

    res := 0

    l := 0
    r := 1

    for r < len(prices){
        if prices[l] < prices[r] {
            profit := prices[r] - prices[l]
            if profit > res {
                res = profit
            }
        } else{
            l = r
        }
        r+=1
    }
    return res
        
}
