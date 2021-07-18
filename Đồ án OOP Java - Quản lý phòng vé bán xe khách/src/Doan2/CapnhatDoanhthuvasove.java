package Doan2;

import java.io.FileNotFoundException;
import java.io.IOException;

public interface CapnhatDoanhthuvasove
{		// interface này bổ sung thêm những phương thức đặc trưng phụ vụ cho các thao tác cho class Ngoại thành 
		//mà class Nội thành không có
		void Capnhatsaukhixoa(int machuyen, double giave) throws FileNotFoundException, IOException ;
		void Suasovedabanvadoanhthu(Ngoaithanh sua, int temp);
		int Searchmachuyen(int machuyen);
		Ngoaithanh ReturnNgoaithanh(int temp);
}
