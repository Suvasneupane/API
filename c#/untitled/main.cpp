#include <iostream>

// TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
using namespace std;
int main() {
// int a;
//     cout<< "enter a number ";
//     cin>>a;
//
//     if (a%2==0) {
//         cout<<"the number is even";
//     }
//     else
//         cout<<"the number is odd";


    //
    //
    // int percentage;
    // cout<<"enter the enter the percentage";
    // cin>>percentage;
    //
    // if (percentage>90) {
    //     cout<<"A+";
    // }
    //  else if (percentage>80 ) {
    //      cout<<"A";
    //  }
    //  else if (percentage>70 ) {
    //      cout<<"B+";
    //  }
    //  else if (percentage>60 ) {
    //      cout<<"B";
    //  }
    //  else if (percentage>50 ) {
    //      cout<<"C+";
    //  }
    //  else if (percentage>40 ) {
    //      cout<<"C";
    //  }
    //  else if (percentage>30 ) {
    //      cout<<"D";
    //  }
    // else {
    //     cout<<"failed ";
    // }







    int age;
    int job;
    cout<<"enter the age";
    cin>>age;
    cout<<"enter the job";
    cin>>job;


    if (age>21) {
        cout<<"underage";
        if (job>0) {
            cout<<"job";
        }
    } else
        cout<<"berojgar";



    return 0;
    // TIP See CLion help at <a href="https://www.jetbrains.com/help/clion/">jetbrains.com/help/clion/</a>. Also, you can try interactive lessons for CLion by selecting 'Help | Learn IDE Features' from the main menu.
}