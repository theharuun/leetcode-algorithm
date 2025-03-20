You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

 

Example 1:

Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.

Size, azalmayacak şekilde sıralanmış iki nums1 ve nums2 tamsayı dizisi ve sırasıyla nums1 ve nums2'deki öğelerin sayısını temsil eden iki tamsayı m ve n verilir.

Sayılar1 ve sayılar2'yi azalmayacak şekilde sıralanmış tek bir dizide birleştirin.

Son sıralanan dizi, işlev tarafından döndürülmemeli, bunun yerine nums1 dizisinin içinde saklanmalıdır. Bunu sağlamak için nums1'in uzunluğu m + n'dir; burada ilk m öğe birleştirilmesi gereken öğeleri belirtir ve son n öğe 0'a ayarlanır ve göz ardı edilmelidir. nums2'nin uzunluğu n'dir.



Örnek 1:

Giriş: sayılar1 = [1,2,3,0,0,0], m = 3, sayılar2 = [2,5,6], n = 3
Çıkış: [1,2,2,3,5,6]
Açıklama: Birleştirdiğimiz diziler [1,2,3] ve [2,5,6]'dır.
Birleştirmenin sonucu [1,2,2,3,5,6] olur ve altı çizili öğeler nums1'den gelir.
