#include <iostream>
#include <iomanip>

using namespace std;

class Staff:public Employee
{
private:
    double hourlyRate;
    
public:
    Staff();
    Staff(string , string, string, int, int, int, char, double);
    double getHourlyRate();
    void setHourlyRate(double);
    void putData();
    double monthlyEarnings();
};

Staff::Staff():Employee()
{
    hourlyRate=0;
}

Staff::Staff(string fN, string lN, string i, int m, int d, int y, char s, double hR):Employee(fN,lN, i, m, d, y, s)
{
    hourlyRate=hR;
    
}

double Staff::getHourlyRate()
{
    return hourlyRate;
}

void Staff::setHourlyRate(double hR)
{
    hourlyRate=hR;
}

void Staff::putData()
{
    cout<<setprecision(2)<<fixed;
    cout<<"\nLast Name: "<<lName<<endl;
    cout<<"First Name: "<<fName<<endl;
    cout<<"ID: "<<idNum<<endl;
    cout<<"Sex: "<<sex<<endl;
    cout<<"Birth date: "<<tm_mon<<"/"<<tm_mday<<"/"<<tm_year<<endl;
    cout<<"Monthly Salary: $"<<monthlyEarnings()<<endl;

}

double Staff::monthlyEarnings()
{
    return hourlyRate*STAFF_MONTHLY_HOURS_WORKED;
}

