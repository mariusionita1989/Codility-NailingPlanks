# Codility-NailingPlanks
 You are given two non-empty arrays A and B consisting of N integers.</br> 
 These arrays represent N planks.</br> 
 More precisely, A[K] is the start and B[K] the end of the K−th plank.</br> 
 Next, you are given a non-empty array C consisting of M integers.</br>  
 This array represents M nails.</br>
 More precisely, C[I] is the position where you can hammer in the I−th nail.</br> 
 We say that a plank (A[K], B[K]) is nailed if there exists a nail C[I] such that A[K] ≤ C[I] ≤ B[K].</br> 
 The goal is to find the minimum number of nails that must be used until all the planks are nailed.</br>  
 In other words, you should find a value J such that all planks will be nailed after using only the first J nails.</br>  
 More precisely, for every plank (A[K], B[K]) such that 0 ≤ K < N, there should exist a nail C[I] such that I < J and A[K] ≤ C[I] ≤ B[K].

 For example, given arrays A, B such that:</br> 
 A[0] = 1    B[0] = 4</br> 
 A[1] = 4    B[1] = 5</br> 
 A[2] = 5    B[2] = 9</br> 
 A[3] = 8    B[3] = 10</br> 
 four planks are represented: [1, 4], [4, 5], [5, 9] and [8, 10].

 Given array C such that:</br> 
 C[0] = 4</br> 
 C[1] = 6</br> 
 C[2] = 7</br> 
 C[3] = 10</br> 
 C[4] = 2</br> 
 if we use the following nails:</br> 
 0, then planks [1, 4] and [4, 5] will both be nailed.</br> 
 0, 1, then planks [1, 4], [4, 5] and [5, 9] will be nailed.</br> 
 0, 1, 2, then planks [1, 4], [4, 5] and [5, 9] will be nailed.</br> 
 0, 1, 2, 3, then all the planks will be nailed.</br> 
 Thus, four is the minimum number of nails that, used sequentially, allow all the planks to be nailed.

 Write a function:</br> 
 class Solution { public int solution(int[] A, int[] B, int[] C); }</br> 
 that, given two non-empty arrays A and B consisting of N integers and a non-empty array C consisting of M integers,</br> 
 returns the minimum number of nails that, used sequentially, allow all the planks to be nailed.
 If it is not possible to nail all the planks, the function should return −1.

 For example, given arrays A, B, C such that:</br> 
 A[0] = 1    B[0] = 4</br> 
 A[1] = 4    B[1] = 5</br> 
 A[2] = 5    B[2] = 9</br> 
 A[3] = 8    B[3] = 10</br> 

 C[0] = 4</br> 
 C[1] = 6</br> 
 C[2] = 7</br> 
 C[3] = 10</br> 
 C[4] = 2</br> 
 the function should return 4, as explained above.

 Write an efficient algorithm for the following assumptions:</br>
 N and M are integers within the range [1..30,000];</br>
 each element of arrays A, B and C is an integer within the range [1..2*M];</br>
 A[K] ≤ B[K].
