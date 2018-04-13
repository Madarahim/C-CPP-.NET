#include <iostream>
#include <iomanip>
#include "Education.h"
#include "Salary.h"

using namespace std;

class Faculty:public Employee
{
private:
    Degree degree;
    string level;
    Education *edu;
    
public:
    Faculty();
    Faculty(string , string, string, int, int, int, char, string, Degree, string, int);
    string getLevel();
    void putData();
    double monthlyEarnings();
};

Faculty::Faculty():Employee()
{
    level="Assistant";
    edu=new Education();
}

Faculty::Faculty(string fN, string lN, string i, int m, int d, int y, char s, string l, Degree d0, string m0, int r0):Employee(fN,lN, i, m, d, y, s)
{
    if(l=="FU")
        level="Full";
        else if(l=="AO")
            level="Associate";
            else
                level="Assistant";
    
    edu=new Education(d0,m0,r0);
    
}

void Faculty::putData()
{
    cout<<setprecision(2)<<fixed;
    cout<<"\nLast Name: "<<lName<<endl;
    cout<<"First Name: "<<fName<<endl;
    cout<<"ID: "<<idNum<<endl;
    cout<<"Sex: "<<sex<<endl;
    cout<<"Birth date: "<<tm_mon<<"/" <<tm_mday<<"/"<<tm_year<<endl;
    cout<<level<<" Professor"<<endl;
    cout<<"Monthly Salary: $"<<monthlyEarnings()<<endl;
    cout<<"Degree: "<<edu->getDegree()<<endl;
    cout<<"Major: "<<edu->getMajor()<<endl;
    cout<<"Research: "<<edu->getResearchNum()<<endl<<endl;
    
}

double Faculty::monthlyEarnings()
{
    if(level=="Full")
        return FACULTY_MONTHLY_SALARY*1.4;
    else if(level=="Associate")
        return FACULTY_MONTHLY_SALARY*1.2;
    else
        return FACULTY_MONTHLY_SALARY;
}

