using EmployeeWageOops;

namespace EmployeeWageproblem
{
    class Program
    {
        public static void Main(string[] args)
        {

            //EmployeeCal_RegWage obj = new EmployeeCal_RegWage();
            //obj.Cal_Rwage();

            //  EmployeeCal_PartTimeWage obj= new EmployeeCal_PartTimeWage();
            // obj.Cal_Pwage();

            // EmployeeSwitchCase obj= new EmployeeSwitchCase();
            // obj.Cal_Switchwage();

            // MonthWage obj= new MonthWage();
            // obj.Cal_Monthwage();

            // LimitedWageCalculation obj= new LimitedWageCalculation();
            //obj.Cal_lmtWage();


            //EmployeeRefactoring.Cal_Wage();
            RefactoringCode obj = new RefactoringCode();
            obj.Cal_Wage("Deloitte", 20, 15, 80);
            obj.Cal_Wage("Adobe", 25, 10, 60);


        }
    }

}