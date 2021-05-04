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
        while(j < input-i){
            if(j > 1){
                Console.Write(' ');
            }
            Console.Write(' ');
            j++;
        }
        var c  = 1;
        while(j <= input){
            if(j > 1){
                Console.Write(' ');
            }
            Console.Write(c);
            j++;c++;
        }
        Console.WriteLine();
    }


    }
}
