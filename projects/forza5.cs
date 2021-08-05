using System;

namespace ConsoleApp3 { 

    class main
    {
        public static void Main(string[] args)
        {

            ConsoleKeyInfo cki;
            string atual, inicio= "a";
            string m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14;

            Console.WriteLine(" |  ___|   ___    _ __   ____   __ _    | ___|");
            Console.WriteLine(" | |_     / _ |  | '__| |_  /  / _` |   |___ | ");
            Console.WriteLine(" |  _|   | (_) | | |     / /  | (_| |    ___) |");
            Console.WriteLine(" |_|      |___/  |_|    /___|  |__,_|   |____/ ");
            Console.WriteLine("\nPressione espaço para continuar...");
            cki = Console.ReadKey(true);
            switch (cki.Key)
            {
                case ConsoleKey.Spacebar:
                    goto inicio;
            }
        inicio:
            Console.Clear();
            Console.WriteLine("Controles:\nseta direita para acelerar\nseta esquerda para dar ré.");
            Console.WriteLine("Apenas um clique por vez.\n\n");
            Console.WriteLine("Pressione espaço para começar a partida.");

            m1 = "__________________________________________________________\n" +
             "  __\n" +
             " |__K\n"+
             " o  o\n" +
             "__________________________________________________________";
            m2 = "__________________________________________________________\n" +
             "      __\n" +
             "     |__K\n" +
             "     o  o\n" +
             "__________________________________________________________";
            m3 = "__________________________________________________________\n" +
             "          __\n" +
             "         |__K\n" +
             "         o  o\n" +
             "__________________________________________________________";
            m4 = "__________________________________________________________\n" +
             "              __\n" +
             "             |__K\n" +
             "             o  o\n" +
             "__________________________________________________________";
            m5 = "__________________________________________________________\n" +
             "                  __\n" +
             "                 |__K\n" +
             "                 o  o\n" +
             "__________________________________________________________";
            m6 = "__________________________________________________________\n" +
             "                      __\n" +
             "                     |__K\n" +
             "                     o  o\n" +
             "__________________________________________________________";
            m7 = "__________________________________________________________\n" +
             "                          __\n" +
             "                         |__K\n" +
             "                         o  o\n" +
             "__________________________________________________________";
            m8 = "__________________________________________________________\n" +
             "                              __\n" +
             "                             |__K\n" +
             "                             o  o\n" +
             "__________________________________________________________";
            m9 = "__________________________________________________________\n" +
             "                                  __\n" +
             "                                 |__K\n" +
             "                                 o  o\n" +
             "__________________________________________________________";
            m10 = "__________________________________________________________\n" +
             "                                      __\n" +
             "                                     |__K\n" +
             "                                     o  o\n" +
             "__________________________________________________________";
            m11 = "__________________________________________________________\n" +
             "                                          __\n" +
             "                                         |__K\n" +
             "                                         o  o\n" +
             "__________________________________________________________";
            m12 = "__________________________________________________________\n" +
             "                                              __\n" +
             "                                             |__K\n" +
             "                                             o  o\n" +
             "__________________________________________________________";
            m13 = "__________________________________________________________\n" +
             "                                                  __\n" +
             "                                                 |__K\n" +
             "                                                 o  o\n" +
             "__________________________________________________________";
            m14 = "__________________________________________________________\n" +
             "                                                      __\n" +
             "                                                     |__K\n" +
             "                                                     o  o\n" +
             "__________________________________________________________";
            atual = inicio;
            movimento:
            cki = Console.ReadKey(true);
            switch (cki.Key)
            {
                case ConsoleKey.Spacebar:
                    if (atual == inicio)
                    {
                        Console.Clear();
                        atual = m1;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    goto movimento;
                case ConsoleKey.RightArrow:
                    if (atual == m1)
                    {
                        Console.Clear();
                        atual = m2;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m2)
                    {
                        Console.Clear();
                        atual = m3;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m3)
                    {
                        Console.Clear();
                        atual = m4;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m4)
                    {
                        Console.Clear();
                        atual = m5;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m5)
                    {
                        Console.Clear();
                        atual = m6;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m6)
                    {
                        Console.Clear();
                        atual = m7;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m7)
                    {
                        Console.Clear();
                        atual = m8;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m8)
                    {
                        Console.Clear();
                        atual = m9;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m9)
                    {
                        Console.Clear();
                        atual = m10;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m10)
                    {
                        Console.Clear();
                        atual = m11;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m11)
                    {
                        Console.Clear();
                        atual = m12;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m12)
                    {
                        Console.Clear();
                        atual = m13;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m13)
                    {
                        Console.Clear();
                        atual = m14;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m14)
                    {
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    if (atual == m1)
                    {
                        Console.Clear();
                        atual = m2;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m2)
                    {
                        Console.Clear();
                        atual = m1;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m3)
                    {
                        Console.Clear();
                        atual = m2;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m4)
                    {
                        Console.Clear();
                        atual = m3;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m5)
                    {
                        Console.Clear();
                        atual = m4;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m6)
                    {
                        Console.Clear();
                        atual = m5;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m7)
                    {
                        Console.Clear();
                        atual = m6;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m8)
                    {
                        Console.Clear();
                        atual = m7;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m9)
                    {
                        Console.Clear();
                        atual = m8;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m10)
                    {
                        Console.Clear();
                        atual = m9;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m11)
                    {
                        Console.Clear();
                        atual = m10;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m12)
                    {
                        Console.Clear();
                        atual = m11;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m13)
                    {
                        Console.Clear();
                        atual = m12;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    else if (atual == m14)
                    {
                        Console.Clear();
                        atual = m13;
                        Console.WriteLine(atual);
                        goto movimento;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    goto movimento;
                case ConsoleKey.DownArrow:
                    goto movimento;
            }    
        }
    }

}
