using System;
using System.Threading.Tasks;

public class Example
{

   public static void Main()
    
   {
        Console.WriteLine("Oi se atente a tabela a seguir! Espere 2.3 segundos!");
      var t = Task.Run(async delegate
              {
                 await Task.Delay(TimeSpan.FromSeconds(2.3));
                 return 42;
              });
      t.Wait();
Console.WriteLine("byte Armazena 1 Byte na sua ram (Só armazena os valores true e false!");
     Console.WriteLine("bool Armazena 1 byte na sua RAM (Apenas amarzena um valor de 0 a 255");
     Console.WriteLine("sbyte Armazena  1 Byte na sua RAM(de -128 a 127");
     Console.WriteLine("short Armazena 2 bytes na sua RAM (de -32768 a 32767");
     Console.WriteLine("ushort Armazena 2 bytes na sua RAM (de 0 a 65535");
     Console.WriteLine("int 4 Armazena 4 bytes na sua RAM (de -2147483648 a 2147483647");
     Console.WriteLine("uint Armazena 4 bytes na sua RAM (de 0 a 4294967295)");
     Console.WriteLine("long Armazena 8 bytes na sua RAM (de -9223372036854775808L a 9223372036854775807L)");
     Console.WriteLine("ulong Armazena 8 bytes na sua RAM (de 0 a 18446744073709551615)");
     Console.WriteLine("float Armazena 4 bytes na sua RAM (Números até 10 elevado a 38. Exemplos: 10.0, 12.33)");
     Console.WriteLine("double Armazena 8 bytes na sua RAM (Números até 10 elevado a 308. Exemplos: 10.0, 12.33");
     Console.WriteLine("decimal Armazena FUCKING 16 bytes na sua RAM então cuidado! (números com até 28 casas decimais. Exemplos: 10.991m, 33.333m");
     Console.WriteLine("char Armazena 2 bytes na sua RAM (Caracteres delimitados por aspas simples. Exemplos: 'a', 'c'' 'b'");
                 Console.WriteLine("O programa irá fechar em 2 minutos!");      
var           c = Task.Run(async delegate{

                 await Task.Delay(TimeSpan.FromSeconds(119));
                 return 42;
              });
      c.Wait();         
      Console.WriteLine("Fechando...");
      var d = Task.Run(async delegate
              {
                 await Task.Delay(TimeSpan.FromSeconds(1));
                 return 42;
              });
              d.Wait();
   }
   
}