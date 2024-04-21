string[] students = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
System.Console.WriteLine("Nhập tên bạn muốn tìm: ");
string input_name = Console.ReadLine();
bool isExist = false;
for (int i = 0; i < students.Length; i++)
 {
     if (students[i].Equals(input_name))
     {
          System.Console.WriteLine("Vị trí của sinh viên trong danh sách " + input_name + " là: " + (i + 1));
          isExist = true;
          break;
     }
}
if (!isExist)
{
       System.Console.WriteLine("Không tìm thấy đối tượng cần tìm."); 
}
