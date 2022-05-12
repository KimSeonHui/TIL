# Two Pointers 투 포인터
리스트에서 서로 다른 위치를 가리키는 두개의 포인터를 사용해 리스트를 조작하는 알고리즘 
- 리스트의 처음부터 끝까지 반복하며 문제 풀 수 O, 공간/시간적으로 가장 효율적인 방법은 아닐 수도 있음
   - 알고리즘 문제에서 시간초과가 나는 경우도!
- `two pointer`는 한 번 루프에서 두가지 요소를 조작할 수 있기 때문에 더 효율적인 방법
   - 완전탐색 문제에서 시간초과 날 때 대안으로 사용할 수 있음!

![image](https://user-images.githubusercontent.com/44824456/168065257-09b9f803-2d9f-4f80-9c8c-1b2754647f58.png)


> 📌 **주로 사용하는 패턴**
> - 처음과 끝에서부터 각각 시작하는 포인터가 서로 만날 때까지 반복할 때
> - 느리게 움직이는 포인터 하나와 두배로 빠르게 움직이는 포인터를 사용할 때

<br />

### 대표적인 문제
- **leet code**
   - [Reverse String](https://leetcode.com/problems/reverse-string/)
   - [Move zero](https://leetcode.com/problems/move-zeroes/)
   - [Rotate Array](https://leetcode.com/problems/rotate-array/)
   - [Two Sum II](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/)

<br />

## 복잡도
**Time Complexity** : `O(N)` - 두 포인터가 서로 다른 위치를 가르키지만 리스트의 모든 요소를 한번씩 모두 가리키기 때문에

<br />

## 참고
- [two pointers](https://algodaily.com/lessons/using-the-two-pointer-technique)
- [투 포인트 알고리즘](https://github.com/WooVictory/Ready-For-Tech-Interview/blob/master/Algorithm/%ED%88%AC%ED%8F%AC%EC%9D%B8%ED%84%B0%20%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98.md)
