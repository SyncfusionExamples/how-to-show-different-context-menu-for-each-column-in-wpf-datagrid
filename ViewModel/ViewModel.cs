using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace SfDataGridDemo {
    internal class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Model> employeelist;

        public ViewModel()
        {
            employeelist = new ObservableCollection<Model>();
            for (int i = 0; i < 5; i++)
            {

                employeelist.Add(new Model
                {
                    EmployeeID = 101,
                    EmployeeName = "Jacobs",
                    EmployeeAge = 25,
                    EmployeeSalary = 20000,
                    City="Belgium"
                });
                employeelist.Add(new Model
                {
                    EmployeeID = 102,
                    EmployeeName = "Antony",
                    EmployeeAge = 32,
                    EmployeeSalary = 21000,
                    City = "Bracke"
                });
                employeelist.Add(new Model
                {
                    EmployeeID = 103,
                    EmployeeName = "Markus",
                    EmployeeAge = 45,
                    EmployeeSalary = 22000,
                    City = "Arhus"
                });
                employeelist.Add(new Model
                {
                    EmployeeID = 104,
                    EmployeeName = "Antony",
                    EmployeeAge = 26,
                    EmployeeSalary = 23000,
                    City = "Montreal"
                });
                employeelist.Add(new Model
                {
                    EmployeeID = 105,
                    EmployeeName = "Bergius",
                    EmployeeAge = 29,
                    EmployeeSalary = 24000,
                    City = "Oulu"
                });
                employeelist.Add(new Model
                {
                    EmployeeID = 106,
                    EmployeeName = "Thomas",
                    EmployeeAge = 38,
                    EmployeeSalary = 25000,
                    City = "Torino"
                });
                employeelist.Add(new Model
                {
                    EmployeeID = 107,
                    EmployeeName = "Martin",
                    EmployeeAge = 32,
                    EmployeeSalary = 35000,
                    City = "Lille"
                });
                employeelist.Add(new Model
                {
                    EmployeeID = 108,
                    EmployeeName = "Christopher",
                    EmployeeAge = 32,
                    EmployeeSalary = 34000,
                    City = "Geneve"
                });
                employeelist.Add(new Model
                {
                    EmployeeID = 109,
                    EmployeeName = "Bradman Toy",
                    EmployeeAge = 38,
                    EmployeeSalary = 35000,
                    City = "Strasbourg"
                });
            }
            GetEmployeeNames();
        }

        public ObservableCollection<Model> EmployeeDetails 
        {
            get { return employeelist; }
            set { value = employeelist; }
        }

        private ObservableCollection<string> employeeNames = new ObservableCollection<string>();
        public ObservableCollection<string> EmployeeNames
        {
            get { return employeeNames; }
            set { value = employeeNames; }
        }

        public void GetEmployeeNames()
        {
            EmployeeNames = new ObservableCollection<string>();
            foreach (var data in EmployeeDetails)
                EmployeeNames.Add(data.EmployeeName.ToString());
        }
        private void RaisePropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}