package com.example.test.Controller;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.test.MainActivity;
import com.example.test.NguonApi;
import com.example.test.R;

public class QuenMatKhauActivity extends AppCompatActivity {
    private TextView mtextViewDangNhap;
    private EditText edtEmail,medtPassNew, medtRePass;
    private Button BttTiepTuc;

    NguonApi nguonApi = new NguonApi();

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_quen_mat_khau);
        nguonApi.nguon();

        Anhxa();

        mtextViewDangNhap.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });
        BttTiepTuc.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                HashQuenMk();
            }
        });
    }

    private void HashQuenMk(){
        
    }

    private void Anhxa(){
        mtextViewDangNhap = findViewById(R.id.textViewDangNhap);
        BttTiepTuc = findViewById(R.id.bttTiepTucQuenMk);
        edtEmail = findViewById(R.id.editGmail);
        medtPassNew = findViewById(R.id.editPass);
        medtRePass = findViewById(R.id.editRe_Pass);
    }
}
