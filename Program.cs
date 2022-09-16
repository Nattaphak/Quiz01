class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 Shop infomation.");
        Console.WriteLine("2 Co-founder's information.");
        Console.WriteLine("3 Shop staff information.");
        Console.WriteLine("4 Shop income and expenses information.");
        Console.WriteLine("Please Enter Number To Select Menu.");
        int number = int.Parse(Console.ReadLine());

        for(int i = 5 ; number <= 5;)
        {
            if(number == 1)
            {
                ShopInfo shopinfo = new ShopInfo();
                Console.WriteLine(shopinfo.Capital());
                Console.WriteLine(shopinfo.BranchName());
                Console.WriteLine(shopinfo.Address());

                Console.WriteLine("1 Shop infomation.");
                Console.WriteLine("2 Co-founder's information.");
                Console.WriteLine("3 Shop staff information.");
                Console.WriteLine("4 Shop income and expenses information.");
                Console.WriteLine("Please Enter Number To Select Menu.");
                number = int.Parse(Console.ReadLine());
            }

            else if(number == 2)
            {
                CoFounder co = new CoFounder();
                Console.WriteLine(co.MemberOne());
                Console.WriteLine(co.MemberTwo());
                Console.WriteLine(co.MemberThree());

                Console.WriteLine("1 Shop infomation.");
                Console.WriteLine("2 Co-founder's information.");
                Console.WriteLine("3 Shop staff information.");
                Console.WriteLine("4 Shop income and expenses information.");
                Console.WriteLine("Please Enter Number To Select Menu.");
                number = int.Parse(Console.ReadLine());
            }

            else if(number == 3)
            {
                Staff staff = new Staff();
                Console.WriteLine(staff.Staff01());
                Console.WriteLine(staff.Staff02());
                Console.WriteLine(staff.Staff03());
                Console.WriteLine(staff.Staff04());
                Console.WriteLine(staff.Staff05());

                Console.WriteLine("1 Shop infomation.");
                Console.WriteLine("2 Co-founder's information.");
                Console.WriteLine("3 Shop staff information.");
                Console.WriteLine("4 Shop income and expenses information.");
                Console.WriteLine("Please Enter Number To Select Menu.");
                number = int.Parse(Console.ReadLine());
            }

            else if (number == 4)
            {
                InEx inex = new InEx();
                Console.WriteLine(inex.Revenue());
                Console.WriteLine(inex.Expenses());
                Console.WriteLine(inex.Balance());

                Console.WriteLine("1 Shop infomation.");
                Console.WriteLine("2 Co-founder's information.");
                Console.WriteLine("3 Shop staff information.");
                Console.WriteLine("4 Shop income and expenses information.");
                Console.WriteLine("Please Enter Number To Select Menu.");
                number = int.Parse(Console.ReadLine());
            }

            else
            {
                break;
            }
        }
        


    }
}
