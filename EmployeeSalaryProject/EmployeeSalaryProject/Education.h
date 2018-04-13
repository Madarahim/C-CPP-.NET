#include <iostream>
#include <iomanip>

#include "Degree.h"
using namespace std;



class Education
{
private:
    int rNum;
    Degree degree;
    string major;
    
public:
    Education();
    Education(Degree, string, int);
    string getMajor();
    int getResearchNum();
    string getDegree();
};

Education::Education(Degree d, string m, int r){

    degree=d;
    major=m;
    rNum=r;
}


Education::Education(){
    
    degree=MS;
    major="Drop-Out";
    rNum=0;
    
    /*
    int o;
    cout<<"Enter the degree MS(1) or PhD(2):"<<endl;
    cin>>o;
    
    if(o==1)
        degree=MS;
    else
        degree=PhD;
    cout<<"Enter the Major: "<<endl;
    getline(cin,major);
    
    cout<<"Enter the Research Number: "<<endl;
    cin>>rNum;
    cout<<"\n\n";
     */
}

string Education::getMajor()
{
    return major;
}

int Education::getResearchNum()
{
    return rNum;
}

string Education::getDegree()
{
    if(degree==0)
        return "MS";
    else
        return "PhD";
}





