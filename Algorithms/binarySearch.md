# Binary Search 이진 탐색
정렬되어 있는 리스트에서 특정 원소의 위치를 찾을 때 사용하는 알고리즘
- 정렬된 리스트에서만 사용할 수 있음
- 한 번 검색할 때마다 검색해야 되는 범위가 반으로 줄기 때문에 속도가 빠름

<br />

> 📌 **logic**
> - 중간값과 찾고자 하는 값을 비교
>   - 찾는 값 < 중간값 이면, 중간값 이전까지 범위 안에서 찾기
>   - 찾는 값 > 중간값 이면, 중간값 이후 범위에서부터 찾기
> - 값을 찾을 때까지 위 단계를 반복
> - 검색이 끝났다면 찾는 값이 리스트에 없는 것

![image](https://user-images.githubusercontent.com/44824456/167810646-36ac2f89-71a3-4914-8b50-a8b7f7d2aa28.png)


## 복잡도
**Time Complexity**: `O(log(n))` - 다음 반복마다 검색해야 하는 범위가 반으로 줄기 때문에


---
## 참고
- [Binary Search](https://github.com/trekhleb/javascript-algorithms/tree/master/src/algorithms/search/binary-search)
- [위키백과](https://ko.wikipedia.org/wiki/%EC%9D%B4%EC%A7%84_%EA%B2%80%EC%83%89_%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98)
