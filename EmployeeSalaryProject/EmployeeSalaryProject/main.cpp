//
//  main.cpp
//  EmployeeSalaryProject
//
//  Created by Abdul Rahim on 4/13/18.
//  Copyright © 2018 Abdul Rahim. All rights reserved.
//

#include <iostream>
#include "Employee.h"
#include "Faculty.h"
#include "Staff.h"
#include "Partime.h"

int main(int argc, char** argv) {
    
    Employee *e[10];
    
    cout<<"ALL EMPLOYEES"<<endl;
    cout<<"~~~~~~~~~~~~~~~~~~~~~~~"<<endl;
    e[0]= new Faculty("Abdul", "Rahim", "12345", 6, 30, 1994, 'M', "AO", MS, "Computer Science", 4);
    e[1]= new Faculty("Monkey D.","Luffy", "10101", 5, 5, 1996, 'M', "AS", MS, "Being An Idiot", 0);
    e[2]= new Staff("Prince", "Sanji", "01010", 3, 2, 1994, 'M', 50);
    e[3]= new Partime("Roronoa","Zoro", "88888", 11, 11, 1994, 'M', 35,30);
    e[4]= new Faculty("Phoung","Nguyen", "00000", 12, 26, 1992, 'M', "FU", PhD, "Best Teacher", 10);
    e[5]= new Partime("Nico", "Robin", "22222", 2, 6, 1985, 'F', 20,35);
    e[6]= new Staff("Kobe", "Bryant", "24824", 8, 23, 1979, 'M', 35);
    e[7]= new Staff("John", "Cena","18374",9,22,1978,'M',40);
    e[8]= new Partime("Nico", "Robin", "22222", 2, 6, 1985, 'F', 30,15);
    
    
    e[0]->putData();
    e[1]->putData();
    e[2]->putData();
    e[3]->putData();
    e[4]->putData();
    e[5]->putData();
    e[6]->putData();
    e[7]->putData();
    e[8]->putData();
    
    
    double totalAll=0.0, pTotal=0.0;
    
    cout<<"\n\nSTAFF"<<endl;
    cout<<"~~~~~~~~~~~~~~~~~~~~~~~"<<endl;
    
    for(int i=0;i<9;i++)
    {
        if(typeid(*e[i])==typeid(Staff))
        {
            e[i]->putData();
            totalAll+=e[i]->monthlyEarnings();
        }
        /*
         Staff *x=dynamic_cast<Staff *>(e[i]);
         x->putData();
         */
    }
    
    cout<<"\n\nFACULTY"<<endl;
    cout<<"~~~~~~~~~~~~~~~~~~~~~~~"<<endl;
    
    for(int i=0;i<9;i++)
    {
        if(typeid(*e[i])==typeid(Faculty))
        {
            e[i]->putData();
            totalAll+=e[i]->monthlyEarnings();
        }
    }
    
    cout<<"\n\Partime"<<endl;
    cout<<"~~~~~~~~~~~~~~~~~~~~~~~"<<endl;
    
    for(int i=0;i<9;i++)
    {
        if(typeid(*e[i])==typeid(Partime))
        {
            e[i]->putData();
            totalAll+=e[i]->monthlyEarnings();
            pTotal+=e[i]->monthlyEarnings();
        }
    }
    
    cout<<"\n\n\nTotal Monthly Salary for All Partime: $"<<pTotal;
    
    cout<<"\n\n\nTotal Monthly Salary for All Employees: $"<<totalAll<<endl;
    
    return 0;
}

