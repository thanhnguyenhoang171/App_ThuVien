# BT_QTCSDL_App_ThuVien
<h2> Bài tập nhóm cho môn Quản trị cơ sở dữ liệu - App quản lý thư viện </h2>
<p>Nhóm đã xây dựng nên Ứng dụng quản lý thư viện theo mô hình 3 lớp.</p>
<p>Phần mềm bao gồm quản lý Sách, Thẻ Thư Viện, Mượn Trả với các chức năng Thêm, Sửa, Xoá</p>
<p>Mối quan hệ 1-N được thể hiện giữa Thẻ Thư Viện với Mượn Trả và Sách với Mượn Trả. Do đó, khi xoá dữ liệu của thực thể cha thì dữ liệu của thực thể con cũng bị xoá theo.</p>
<h3>Hướng dẫn chạy phần mềm</h3>
<ul>
  <li>Dùng file SQLQuanLyThuVien.sql để thực hiện việc tạo Database, các bảng, dữ liệu và các ràng buộc.</li>
  <li>Vào trong đường dẫn App_QLThuVien/DAO/DataProvider.cs để thay đổi connectionString theo đúng máy của mình </li>
</ul>
