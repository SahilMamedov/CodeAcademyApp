using Business.Services;
using Entities.Models;
using System;
using Utilities.Helper;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Extention.Print(ConsoleColor.Green, "Welcome");

            while (true)
            {
                GroupService groupService = new GroupService();
                Extention.Print(ConsoleColor.Cyan, "1-Create Group\n" +
                    "2-Update Group\n" +
                    "3-Remove Group\n" +
                    "4-Get Group\n" +
                    "5-GetAll Group");
                string num = Console.ReadLine();
                int input;
                bool IsNum = int.TryParse(num, out input);
                if (IsNum && input < 7 && input > 0)
                {
                    switch (input)
                    {
                        case 1:
                            
                        EnterName:
                            Extention.Print(ConsoleColor.Red, "Group name");
                            string name = Console.ReadLine();
                            Extention.Print(ConsoleColor.Red, "Group Size");
                            string groupSize = Console.ReadLine();
                            int size;

                            bool isSize = int.TryParse(groupSize, out size);
                            if (isSize)
                            {
                                Group group = new Group
                                {
                                    Name = name,
                                    MaxSize = size
                                };
                                groupService.Create(group);
                                Extention.Print(ConsoleColor.Green, $"{group.Name} creted");
                            }
                            else
                            {
                                Extention.Print(ConsoleColor.Red, "Duzgun daxil edin");
                                goto EnterName;
                            }

                            break;
                        case 5:
                            string name2 = Console.ReadLine();

                            Group list = groupService.GetGroup(name2);


                            Extention.Print(ConsoleColor.Green, $"{list.Name}");

                            break;

                    }
                }



            }


        }
    }
}
