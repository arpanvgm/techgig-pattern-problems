using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
	//Write code here

    var input = int.Parse(Console.ReadLine());
    for(int i=1 ; i<=input; i++){
        var j = 1;
        while(j <= input - i){
            if(j > 1){
                Console.Write(' ');
            }
            Console.Write(' ');
            j++;
        }
        var c = 1 ;
        while(j < input + i){
            if(j > 1){
                Console.Write(' ');
            }
            Console.Write(c++);
            j++;
            if(c > i )
                break;
        }
        c = c-2;
        while(c > 0){
            Console.Write(" {0}",c--);
        }
        Console.WriteLine();
    }

    }
}
