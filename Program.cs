using System;
using System.Collections.Generic;


namespace Assignment1
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get; set; }
        public bool IsGraduated { get; set; }

        public Member(string fn, string ln, string gd, int dob, int p, string bp, bool ig)
        {
            FirstName = fn;
            LastName = ln;
            Gender = gd;
            DateOfBirth = dob;
            PhoneNumber = p;
            BirthPlace = bp;
            Age = 2022 - dob;
            IsGraduated = ig;
        }
        
        public override string ToString()
        {
            return string.Format("Fullname: {0} {1},Gender: {2},DoB: {3},Phone: {4},BirthPlace: {5},Age: {6} Graduated: {7}", FirstName, LastName, Gender, DateOfBirth, PhoneNumber, BirthPlace, Age, (IsGraduated == false) ? "No" : "Yes");
        }
        
    }

    class Program
    {
        static void ShowMember<T>(List<T> list)
        {
            foreach(T m in list)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            List<Member> cl = new List<Member>();
            List<Member> malemembers = new List<Member>();
            List<string> fullname = new List<string>();
            List<Member> under2000 = new List<Member>();
            List<Member> is2000 = new List<Member>();
            List<Member> over2000 = new List<Member>();


            cl.Add(new Member("Nguyen", "Nam Phuong", "Male", 2001, 0943746666, "Ha noi", false));
            cl.Add(new Member("Do", "Hong Son", "Male", 2000, 0975378309, "Nam dinh", false));
            cl.Add(new Member("Nguyen", "Duc Huy", "Male", 1996, 0925206686, "Ha noi", true));
            cl.Add(new Member("Phuong", "Viet Hoang", "Male", 1999, 0702028599, "Nam dinh", false));
            cl.Add(new Member("Lai", "Quoc Long", "Male", 1997, 0354505588, "Bac ninh", true));
            cl.Add(new Member("Tran", "Chi Thanh", "Male", 2000, 0376959875, "Ha noi", false));
            cl.Add(new Member("Vu", "Quang Hiep", "Male", 2000, 0964910360, "Nghe an", false));
            cl.Add(new Member("Pham", "Duc Loc", "Male", 1999, 0343428821, "Bac ninh", false));
            cl.Add(new Member("Do", "Trung Anh", "Male", 1996, 0422061033, "Hai phong", true));
            cl.Add(new Member("Trinh", "Hong Nhung", "Female", 1999, 0123456789, "Thanh hoa", true));
            cl.Add(new Member("Dao", "Quy Vuong", "Male", 2000, 0335878777, "Ha noi", false));
            cl.Add(new Member("Bui", "Chi Huong", "Male", 2000, 0338559513, "Nghe an", false));
            cl.Add(new Member("Pham", "Thanh Long", "Male", 2000, 0944531628, "Ninh binh", false));
            cl.Add(new Member("Pham", "Duc Tien", "Male", 1998, 0963164813, "Ninh binh", false));
            cl.Add(new Member("Nguyen", "Quang Huy", "Male", 1992, 0842140392, "Ha noi", true));
            cl.Add(new Member("Pham", "Duc Tien", "Male", 1998, 0963164813, "Ninh binh", false));

            Console.WriteLine("1.-----List of male member: ");
            for (int i = 0; i < cl.Count; i++)
            {
                if (cl[i].Gender == "Male")
                {
                    malemembers.Add(cl[i]);
                }
            }
            ShowMember(malemembers);
        

            Console.WriteLine("2.-----Oldest member in class: ");
            int maxAge = 0;
            foreach (Member m in cl)
            {
                if(m.Age > maxAge)
                {
                    maxAge = m.Age;
                }
            }
            Console.WriteLine(maxAge.ToString());

            Console.WriteLine("3.-----New list with fullname only: ");
            foreach(Member m in cl)
            {
                fullname.Add(m.FirstName + " " + m.LastName);
            }

            ShowMember(fullname);

            Console.WriteLine("4.-----New 3 list: ");
            foreach(Member m in cl)
            {
                switch (m.DateOfBirth)
                {
                    case 2000:
                        is2000.Add(m);
                        break;
                    case < 2000:
                        under2000.Add(m);
                        break;
                    case > 2000:
                        over2000.Add(m);
                        break;
                }
            }
            Console.WriteLine("Birth year less than 2000: ");
            ShowMember(under2000);
            Console.WriteLine("Birth year is 2000: ");
            ShowMember(is2000);
            Console.WriteLine("Birth year greater than 2000: ");
            ShowMember(over2000);

            Console.WriteLine("5.-----First person who was born in Hanoi: ");
            int j = 0;
            while(cl[j].BirthPlace != "Ha noi")
            {
                j++;
            }
            Console.WriteLine(cl[j].ToString());
            Console.ReadKey();

        }
    }
}
