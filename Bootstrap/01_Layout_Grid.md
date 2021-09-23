## Layout_Grid
- Grid
- 대표 클래스
-------
### Grid
- `containers` , `rows`, `columns`을 레이아웃에 사용해 콘텐츠를 정렬함
- 전부 반응형
- 한 줄을 12등분해서 요소의 비율로 배치할 수 있도록 하는 기능

#

### 대표 클래스
🙋‍♀️ `col-숫자`  
- 12칸 중 몇 칸을 해당 요소가 차지할 것인지 설정    
- 가로 길이가 줄어들더라도 세로로 떨어지지 않음

🙋‍♀️ `col-Grid option-숫자`    
- 스케일 이하면 세로로 배치되게 설정

🙋‍[코드 Example](https://getbootstrap.com/docs/5.1/layout/grid/)

```html
<div class="row"> 
        <div class="col-6" style="background-color: aqua;">aaa</div>
        <div class="col-6" style="background-color: black;">bbb</div>
</div>
```
> <div class="row"> // class="row"가 없다면 세로로 배열이 됨
  
  #

**Grid options(default)**
- Extra small (xs)
- Small (sm)
- Medium (md)
- Large (lg)
- Extra large (xl)
- Extra extra large (xxl)

![image](https://user-images.githubusercontent.com/44824456/134505996-a5a67630-4377-4656-80a6-77acdde6cc4d.png)
(Bootstrap Docs)
