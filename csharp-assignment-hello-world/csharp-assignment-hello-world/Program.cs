public class Program
{
    public static void Main(string[] args)
    {
        /// Bài tập Operator
        Console.WriteLine("======= BAI TAP OPERATOR =======");
        // Câu 1: Phép toán giữa 2 số
        Console.WriteLine("===== CAU 1: PHEP TOAN GIUA 2 SO =====");
        Console.WriteLine("Nhap so thu nhat");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap phep toan (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        double result = 0;
        switch (op)
        {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '*':
                result = a * b;
                break;
            case '/':
                if (b != 0)
                {
                    result = a / b;
                }
                else
                {
                    Console.WriteLine("Khong the chia cho 0");
                    return;
                }
                break;
            default:
                Console.WriteLine("Phep toan khong hop le");
                return;
        }
        Console.WriteLine($"Ket qua: {a} {op} {b} = {result}");

        // Câu 2: Tính giá trị hàm x
        Console.WriteLine("===== CAU 2: TINH GIA TRI HAM X =====");
        for (int y1 = -5; y1 <= 5; y1++)
        {
            int x1 = y1 * y1 + 2 * y1 + 1;
            Console.WriteLine($"y = {y1}, x = {x1}");
        }
        // Câu 3: Tính vận tốc km/h và miles/h
        Console.WriteLine("===== CAU 3: TINH VAN TOC =====");
        Console.WriteLine("Nhap quang duong (km): ");
        double distanceKm = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap thoi gian (gio): ");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap thoi gian (phut): ");
        int minutes = Convert.ToInt32(Console.ReadLine());
        if (minutes < 0 || minutes > 59)
        {
            Console.WriteLine("So phut khong hop le");
            return;
        }
        Console.WriteLine("Nhap thoi gian (giay): ");
        int seconds = Convert.ToInt32(Console.ReadLine());
        if (seconds < 0 || seconds > 59)
        {
            Console.WriteLine("So giay khong hop le");
            return;
        }
        double totalHours = hours + (double)minutes / 60 + (double)seconds / 3600;
        double speedKmh = distanceKm / totalHours;
        double speedMph = speedKmh / 1.609;
        Console.WriteLine($"Van toc: {speedKmh:F2} km/h, {speedMph:F2} miles/h");

        // Câu 4: Tính diện tích và thể tích hình cầu
        Console.WriteLine("===== CAU 4: TINH DIEN TICH VA THE TICH HINH CAU =====");
        Console.WriteLine("Nhap ban kinh hinh cau: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double area = 4 * Math.PI * Math.Pow(r, 2);
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Dien tich hinh cau: {area:F2}");
        Console.WriteLine($"The tich hinh cau: {volume:F2}");

        // Câu 5: Kiểm tra kí tự
        Console.WriteLine("===== CAU 5: KIEM TRA KI TU =====");
        Console.WriteLine("Nhap mot ki tu: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if ("aeiouAEIOU".IndexOf(c) >= 0)
        {
            Console.WriteLine($"{c} la nguyen am");
        }
        else if (char.IsLetter(c))
        {
            Console.WriteLine($"{c} la phu am");
        }
        else if (char.IsDigit(c))
        {
            Console.WriteLine($"{c} la chu so");
        }
        else
        {
            Console.WriteLine($"{c} la ki tu dac biet");
        }

        ///  Bài tập Control Flow statements
        Console.WriteLine("======= BAI TAP CONTROL FLOW =======");
        // Câu 1: Kiểm tra số chẵn hay lẻ
        Console.WriteLine("===== CAU 1: KIEM TRA SO CHAN HAY SO LE =====");
        Console.WriteLine("Nhap mot so nguyen: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine($"{n} la so chan");
        }
        else
        {
            Console.WriteLine($"{n} la so le");
        }
        // Câu 2: Tìm số lớn nhất trong 3 số
        Console.WriteLine("===== CAU 2: TIM SO LON NHAT =====");
        Console.WriteLine("Nhap so thu nhat: ");
        double num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai: ");
        double num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so thu ba: ");
        double num3 = Convert.ToInt32(Console.ReadLine());
        double max = num1;
        if (num2 > max)
        {
            max = num2;
        }
        if (num3 > max)
        {
            max = num3;
        }
        Console.WriteLine($"So lon nhat la: {max}");

        // Câu 3: Xác định tọa độ
        Console.WriteLine("===== CAU 3: XAC DINH TOA DO =====");
        Console.WriteLine("Nhap hoanh do (x): ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap tung do (y): ");
        double y = Convert.ToDouble(Console.ReadLine());
        if (x == 0 && y == 0)
        {
            Console.WriteLine("Diem goc toa do");
        }
        else if (x == 0)
        {
            Console.WriteLine("Diem tren truc tung");
        }
        else if (y == 0)
        {
            Console.WriteLine("Diem tren truc hoanh");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Diem o goc phan tu thu 1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Diem o goc phan tu thu 2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Diem o goc phan tu thu 3");
        }
        else
        {
            Console.WriteLine("Diem o goc phan tu thu 4");
        }
        // Câu 4: Kiểm tra tam giác
        Console.WriteLine("===== CAU 4: KIEM TRA TAM GIAC =====");
        Console.WriteLine("Nhap canh thu nhat: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap canh thu hai: ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap canh thu ba: ");
        double side3 = Convert.ToDouble(Console.ReadLine());
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Do dai canh khong hop le");
        }
        else if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Day la tam giac deu");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Day la tam giac can");
            }
            else
            {
                Console.WriteLine("Day la tam giac thuong");
            }
        }
        else
        {
            Console.WriteLine("Day khong phai la tam giac");
        }
        // Câu 5: Tính trung bình và tổng 10 số
        Console.WriteLine("===== CAU 5: TINH TRUNG BINH VA TONG 10 SO =====");
        int[] arr = new int[10];
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Nhap so thu {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }
        Console.WriteLine($"Tong 10 so la: {sum}");
        Console.WriteLine($"Trung binh cong 10 so la: {(double)sum / 10}");
        // Câu 6: In bảng cửu chương
        Console.WriteLine("===== CAU 6: IN BANG CUU CHUONG =====");
        Console.WriteLine("Nhap bang cuu chuong nhan (1-10): ");
        int table = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{table} x {i} = {table * i}");
        }
        // Câu 7: Mẫu hình tam giác chứa số
        Console.WriteLine("===== CAU 7: MAU HINH TAM GIAC CHUA SO =====");
        for (int i = 1; i < 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        // Câu 8: Chuỗi Harmonic và tổng
        Console.WriteLine("===== CAU 8: CHUOI HARMONIC VA TONG =====");
        Console.WriteLine("Nhap so n: ");
        int n0 = Convert.ToInt32(Console.ReadLine());
        double harmonicSum = 0;
        for (int i = 1; i <= n0; i++)
        {
            harmonicSum += 1.0 / i;
        }
        Console.WriteLine($"Tong chuoi harmonic: {harmonicSum:F2}");
        // Câu 9: Số hoàn hảo trong khoảng
        Console.WriteLine("===== CAU 9: SO HOAN HAO TRONG KHOANG =====");
        Console.WriteLine("Nhap so gioi han: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Cac so hoan hao trong khoang tu 1 den {limit}: ");
        for (int num=2; num<=limit; num++)
        {             
            int sum0 = 0;
            for (int i=1; i<=num/2; i++)
            {
                if (num % i == 0)
                {
                    sum0 += i;
                }
            }
            if (sum0 == num)
            {
                Console.WriteLine(num);
            }
        }
        // Câu 10: Kiểm tra số nguyên tố
        Console.WriteLine("===== CAU 10: KIEM TRA SO NGUYEN TO =====");
        Console.WriteLine("Nhap mot so nguyen: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 1)
        {
            Console.WriteLine($"{number} khong phai la so nguyen to");
        }
        else
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{number} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{number} khong phai la so nguyen to");
            }
        }

    }
}
