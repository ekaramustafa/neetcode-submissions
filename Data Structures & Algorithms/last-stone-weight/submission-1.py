import heapq
class Solution:
    def lastStoneWeight(self, stones: List[int]) -> int:
        max_heap = [-x for x in stones]
        heapq.heapify(max_heap)

        while len(max_heap) > 1:
            largest = heapq.heappop(max_heap)
            second_largest = heapq.heappop(max_heap)
            if largest == second_largest:
                continue
            else:
                heapq.heappush(max_heap, abs(largest - second_largest))
        
        return abs(max_heap[0]) if len(max_heap) > 0 else 0
        

        