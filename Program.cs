namespace Protsun_Vova_PD_22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
     //Lab1
            int x;
            Console.Write("Choose, which task you want to see: ");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3: 
                    Task3();
                    break;
                case 4: 
                    Task4();
                    break;
                default:
                    Console.WriteLine("There is no such task here");
                    break;
            }

            void Task1()
            {
                int a, b = 0;
                bool neg = false;
                Console.Write("Write a big number: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                {
                    neg = true;
                    a *= -1;
                }
                while (a > 0)
                {
                    b *= 10;
                    b += a % 10;
                    a /= 10;
                }
                if (neg)
                {
                    b *= -1;
                }

                Console.Write(b);
            }

            void Task2()
            {

                Console.WriteLine("Write a line");
                string s = Console.ReadLine();
                char[] str = s.ToCharArray(); ;
                string a; 
                for (int i = str.Length - 1; i >= 0; --i)
                {
                     a = Convert.ToString(str[i]);
                     Console.Write(a);
                }
            }

            void Task3()
            {
                Console.WriteLine("Write a float number");
                int x = 0;
                string s = Console.ReadLine();
                char[] str = s.ToCharArray(); ;
                string a,b;
                for (int  i = 0; i < str.Length; ++i)
                {
                    x += 1;
                    if (str[i] == 46 || str[i] == 44)
                    {
                        break;
                    }

                }
                for (int i = x - 2; i >= 0; --i)
                {
                    a = Convert.ToString(str[i]);
                    Console.Write(a);
                }
                Console.Write(str[x-1]);
                for (int i = str.Length - 1; i >= x; --i)
                {
                    b = Convert.ToString(str[i]);
                    Console.Write(b);
                }

            }

            void Task4 ()
            {
                var arr = new int[] { 1, 2, 3, -4, 5, 9 };
                for (int i = 0; i < arr.Length / 2; ++i)
                {
                    var temp = arr[i];
                    arr[i] = arr[arr.Length - 1 - i];
                    arr[arr.Length - 1 - i] = temp;
                }
                for (int i = 0; i < arr.Length; ++i)
                {
                    Console.Write(arr[i]); Console.Write(" ");
                }
            }
            */
     //Lab2
            /*
            int x;
            Console.Write("Choose, which task you want to see: ");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5: 
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                default:
                    Console.WriteLine("There is no such task here");
                    break;
            }

            void Task1()
            {
                int a;
                bool b = false;
                Console.Write("Write a number: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    if (a / 10 < 10 && a / 10 > 0)
                    {
                        b = true;
                    }
                }
                Console.WriteLine(b);
            }

            void Task2()
            {
                int a;
                bool b = false;
                Console.Write("Write a number: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 3 == 0)
                {
                    if (a / 100 < 10 && a / 100 > 0)
                    {
                        b = true;
                    }
                }
                Console.WriteLine(b);
            }

            void Task3()
            {
                int x, y, z;
                bool b = false;
                Console.Write("Write a first number: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write a second number: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write a third number: ");
                z = Convert.ToInt32(Console.ReadLine());
                if (x == y || y == z || x == z)
                {
                    b = true;
                }
                Console.WriteLine(b);
            }

            void Task4()
            {
                int x, y, z;
                bool b = false;
                Console.Write("Write a first number: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write a second number: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write a third number: ");
                z = Convert.ToInt32(Console.ReadLine());
                if (y == x * -1 || y == z * -1 || x == y * -1 || x == z * -1 || z == x * -1 || z == y * -1)
                {
                    b = true;
                }
                Console.WriteLine(b);
            }

            void Task5()
            {
                int a;
                bool b = false;
                Console.Write("Write a three-digit number: ");
                a = Convert.ToInt32(Console.ReadLine());
                a = (a % 10) + (a / 100) + (a / 10 % 10);
                if (a % 2 == 0)
                {
                    b = true;
                }
                Console.WriteLine(b);
            }

            void Task6()
            {
                int a, x, y;
                bool b = false;
                Console.Write("Write a four-digit number: ");
                a = Convert.ToInt32(Console.ReadLine());
                x = (a / 1000) + (a / 100 % 10);
                y = (a / 10 % 10) + (a % 10);
                if (x == y)
                {
                    b = true;
                }
                Console.WriteLine(b);
            }
            */
            /*
     //Lab3
            int a = 0, b = 0;
            var arr = new int[] { 1, 2, 3, -4, 5, 3, 5, 2, 1 ,2 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] <= arr[i + 1])
                {
                    a += 1;
                }
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    b += 1;
                }
            }
            Console.Write("Number of increments: "); Console.WriteLine(a);
            Console.Write("Number of declines: "); Console.WriteLine(b);
            */
            /*
    //Lab4
            rotary_telephone r = new rotary_telephone();
            push_button_telephone pbt = new push_button_telephone();
            colorful_telephone ct = new colorful_telephone();
            smartphone s = new smartphone();
            int option;
            bool quit = true;
            Console.Write("You have a rotary telephone. ");
            while (quit)
            {
                Console.WriteLine(" Do you want to call or enter a phone number? 0 - quit, 1 - enter a number, 2 - call");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: quit = false; break;
                    case 1: r.enter_number(); break;
                    case 2: r.call_number(); break;
                    default: Console.WriteLine("Incorrect input!"); break;
                }
            }
            quit = true;
            Console.Write("Now you have a push-button telephone.");
            while (quit)
            {
                Console.WriteLine(" Do you want to call or enter a phone number? 0 - quit, 1 - enter a number using buttons, 2 - call, 3 - insert SIM card, 4 - remove SIM card");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: quit = false; break;
                    case 1: pbt.press_buttons(); break;
                    case 2: pbt.call_number(); break;
                    case 3: pbt.insert_sim_card(); break;
                    case 4: pbt.remove_sim_card(); break;
                    default: Console.WriteLine("Incorrect input!"); break;
                }
            }
            quit = true;
            Console.Write("Now you have a push-button telephone with white-black screen opitons. ");
            while (quit)
            {
                Console.WriteLine("Do you want to call or enter a phone number? 0 - quit, 1 - enter a number, 2 - call, 3 - insert SIM card, 4 - remove SIM card");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: quit = false; break;
                    case 1: ct.enter_number(); break;
                    case 2: ct.call_number(); break;
                    case 3: ct.insert_sim_card(); break;
                    case 4: ct.remove_sim_card(); break;
                    default: Console.WriteLine("Incorrect input!"); break;
                }
            }
            quit = true;
            Console.WriteLine("Now you have a push-button telephone with colorful screen and an option to upgrade to a smartphone. ");
            while (quit)
            {
                Console.WriteLine("Do you want to call or enter a phone number? 0 - quit, 1 - enter a number, 2 - call, 3 - insert SIM card, 4 - remove SIM card, 5 - switch screen color, 6 - upgrade");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: quit = false; break;
                    case 1: s.enter_number(); break;
                    case 2: s.call_number(); break;
                    case 3: s.insert_sim_card(); break;
                    case 4: s.remove_sim_card(); break;
                    case 5: s.switch_colors(); break;
                    case 6: s.upgrade(); break;
                    default: Console.WriteLine("Incorrect input!"); break;
                }
            }

            class rotary_telephone
            {
                protected string number { get; set; }
                protected bool number_entered = false;
                public void enter_number()
                {
                    Console.WriteLine("Enter a phone number: ");
                    number = Console.ReadLine();
                    number_entered = true;
                }
                public virtual void call_number()
                {
                    if (number_entered)
                        Console.WriteLine($"Calling by the number {number}...Success!");
                    else
                    {
                        Console.WriteLine("You must enter the number before calling!");
                        enter_number();
                    }
                }
            };
            class push_button_telephone : rotary_telephone
            {
                bool sim_is_inserted = false;
                public void press_buttons()
                {
                    if (sim_is_inserted)
                        enter_number();
                    else
                    {
                        Console.WriteLine("You need to insert SIM card before entering numbers!");
                        insert_sim_card();
                        press_buttons();
                    }
                }
                public override void call_number()
                {
                    if (sim_is_inserted && number_entered)
                        Console.WriteLine($"Calling by the number {number}...Success!");
                    else
                    {
                        Console.WriteLine("You must enter the number and insert SIM-card before calling!");
                        enter_number();
                        insert_sim_card();
                    }
                }
                public void insert_sim_card()
                {
                    Console.WriteLine("Insert SIM card? yes/no");
                    string check;
                    check = Console.ReadLine();
                    if (check == "yes")
                        sim_is_inserted = true;
                }
                public void remove_sim_card()
                {
                    Console.WriteLine("Remove SIM card? yes/no");
                    string check;
                    check = Console.ReadLine();
                    if (check == "yes")
                    {
                        sim_is_inserted = false;
                        Console.WriteLine("SIM card was successfully removed!");
                    }
                }
            };

            class white_black_telephone : push_button_telephone
            {
                protected bool white_black_display = true;
            };

            class colorful_telephone : white_black_telephone
            {
                protected bool colorful_screen = false;
                public void switch_colors()
                {
                    Console.WriteLine("Switch the diplay to colorful? yes/no");
                    string switcher;
                    switcher = Console.ReadLine();
                    if (switcher == "yes")
                    {
                        white_black_display = false;
                        colorful_screen = true;
                    }

                }

                public void switch_color_default()
                {
                    if (colorful_screen)
                        colorful_screen = false;
                    else
                        colorful_screen = true;
                }
            };

            class smartphone : colorful_telephone
            {
                bool no_buttons = false;
                bool good_camera = false;
                bool programs = false;
                string s_upgrade;

                public void upgrade()
                {
                    this.switch_color_default();
                    Console.WriteLine("Do you want to upgrade from push-button telephone with colorful screen to a smartphone? yes/no");
                    s_upgrade = Console.ReadLine();
                    if (s_upgrade == "yes")
                    {
                        string upgrade_options;
                        Console.WriteLine("Which of the following things do you want to upgrade (IOS or Android system will be automatically implemented)? No buttons, good camera, installed multiple programs. 1 " +
                        "to incluce a technology and 0 to pass (for example: 101 means no buttons and installed programs");
                        upgrade_options = Console.ReadLine();
                        switch (upgrade_options)
                        {
                            case "000":
                                break;
                            case "001":
                                programs = true; break;
                            case "010":
                                good_camera = true; break;
                            case "011":
                                good_camera = true;
                                programs = true; break;
                            case "100":
                                no_buttons = true; break;
                            case "101":
                                no_buttons = true;
                                programs = true;
                                break;
                            case "110":
                                no_buttons = true;
                                good_camera = true;
                                break;
                            case "111":
                                no_buttons = true;
                                good_camera = true;
                                programs = true; break;
                        }
                        Console.Write("Now you have colorful screen, IOS/Andriod system, ");
                        if (no_buttons)
                            Console.Write(" no buttons, ");
                        if (good_camera)
                            Console.Write("good camera and ");
                        if (programs)
                            Console.Write("installed programs");
                    }
                }
            }
            */
        }
    }
}












