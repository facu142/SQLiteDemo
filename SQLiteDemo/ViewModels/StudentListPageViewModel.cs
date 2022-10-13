using Microsoft.Toolkit.Mvvm.Input;
using SQLiteDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModels
{
    public class StudentListPageViewModel
    {
        [ICommand]
        public async void AddUpdateStudent()
        {
            await AppShell.Current.GoToAsync(nameof(AddUpdateStudentDetail));
        }
    }
}
