//
//  Employee.h
//  HW9~282
//
//  Created by Abdul Rahim on 4/13/18.
//  Copyright © 2018 Abdul Rahim. All rights reserved.
//

#include <iostream>
#include <iomanip>

using namespace std;

class Employee
{
protected:
    string fName, lName, idNum ;
    int tm_mon, tm_mday, tm_year;
    char sex;
    
    
public:
    Employee();
    Employee(string , string, string, int, int, int, char);
    virtual void putData() = 0;
    virtual double monthlyEarnings() = 0;

};

Employee::Employee()
{
    fName = "";
    lName = "";
    idNum = "";
    tm_mon = 0;
    tm_mday = 0;
    tm_year = 0;
    sex = '?';
}

Employee::Employee(string fN,string lN, string i, int m, int d, int y, char s)
{
    Employee::fName = fN;
    lName = lN;
    idNum = i;
    tm_mon = m;
    tm_mday = d;
    tm_year = y;
    sex = s;
    
}



