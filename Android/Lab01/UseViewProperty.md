## 뷰 기초 속성 활용
- xml 파일에서 레이아웃 화면 편집
```xml
<?xml version="1.0" encoding="utf-8"?>
<LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
    android:layout_width="match_parent"
    android:layout_height="match_parent"
    android:orientation="vertical" >

    <Button
        android:id="@+id/btn_visible_true"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:text="visible true" />

    <TextView
        android:id="@+id/text_visible_target"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:text="hello world"
        android:background="#FF0000"
        android:textColor="#FFFFFF"
        android:padding="16dp"
        android:visibility="invisible" />

    <Button
        android:id="@+id/btn_visible_false"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:text="visible_false" />

</LinearLayout>
```

- xml에서 만든 레이아웃을 Activity에서 자바코드로 가져와 기능 구현하기
```java
public class Lab01_3Activity extends AppCompatActivity implements View.OnClickListener {

    Button trueBtn;
    TextView targetTextView;
    Button falseBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lab01_3);

        trueBtn = findViewById(R.id.btn_visible_true);
        targetTextView = findViewById(R.id.text_visible_target);
        falseBtn = findViewById(R.id.btn_visible_false);

        trueBtn.setOnClickListener(this);
        falseBtn.setOnClickListener(this);

    }

    @Override
    public void onClick(View view) {
        if(view == trueBtn) {
            targetTextView.setVisibility(View.VISIBLE);
        }
        else if(view == falseBtn) {
            targetTextView.setVisibility(View.INVISIBLE);
        }
    }
}
```
