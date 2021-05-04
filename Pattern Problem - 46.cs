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
            Console.Write("  ");
            j++;
        }
        var c = 1;
        while(c <=i){
            if(c > 1){
                Console.Write(' ');
            }
            Console.Write((char)(c++ + 64));
        }
        c--;
        while(c>1){
            Console.Write(" {0}",(char)(--c + 64));
        }
       
        
        Console.WriteLine();
    }

    }
}
