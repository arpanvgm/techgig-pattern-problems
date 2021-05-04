using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
	//Write code here
    var input = int.Parse(Console.ReadLine());
    for(int i = 0 ; i < input ; i++){
        var j = 1;
        while(j <= i+1){
            if(j > 1){
                Console.Write(' ');
            }
            Console.Write(j);
            j++;
        }
       
        Console.WriteLine();
    }

    }
}
