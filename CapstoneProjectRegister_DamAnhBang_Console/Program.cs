// See https://aka.ms/new-console-template for more information
using CapstoneProjectRegister_DamAnhBang_Console.Repo.IRepository;
using CapstoneProjectRegister_DamAnhBang_Console.Repo.Repository;
using CapstoneProjectRegister_DamAnhBang_Console.Service.Service;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");
var services = new ServiceCollection();

// Đăng ký dịch vụ IStudent và StudentRepository
services.AddScoped<IStudent, StudentRepository>();

// Đăng ký dịch vụ StudentService
services.AddScoped<StudentService>();

var serviceProvider = services.BuildServiceProvider();
var studentService = serviceProvider.GetService<StudentService>();

// Gọi phương thức hiển thị thông tin sinh viên trong Console
studentService.ShowAllStudentsInConsole();

serviceProvider.Dispose();