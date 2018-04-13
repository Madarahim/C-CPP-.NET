#include <iostream>
#include <iomanip>

using namespace std;

class Partime:public Staff
{
private:
    int hoursPerWeek;
    
public:
    Partime();
    Partime(string , string, string, int, int, int, char, double, int);
    int getHoursPerWeek();
    void setHoursPerWeek();
    void putData();
    double monthlyEarnings();
};

Partime::Partime():Staff()
{
    hoursPerWeek=0;
}

Partime::Partime(string fN, string lN, string i, int m, int d, int y, char s, double hR, int h):Staff(fN,lN, i, m, d, y, s, hR)
{
    hoursPerWeek=h;
    
}




void Partime::putData()
{
    cout<<"\nLast Name: "<<lName<<endl;
    cout<<"First Name: "<<fName<<endl;
    cout<<"ID: "<<idNum<<endl;
    cout<<"Sex: "<<sex<<endl;
    cout<<"Birth date: "<<tm_mon<<"/"<<tm_mday<<"/"<<tm_year<<endl;
    cout<<"Hours Worked per Month: "<<4*hoursPerWeek<<endl;
    cout<<setprecision(2)<<fixed;
    cout<<"Monthly Salary: $"<<monthlyEarnings()<<endl;
    
}

double Partime::monthlyEarnings()
{
   
    return hoursPerWeek*4*Staff::getHourlyRate();
}

