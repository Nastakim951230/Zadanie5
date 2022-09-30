using System;

namespace Practika_5_zadanie5
{
    struct Users
    {
        public string Rub;
        public string Kop;
        public string Dol;
        public string Evro;
        public string Gon;
        public string Jap;
        public string Bra;
        public void show()
        {
            if (Rub == "")
            {
                Rub = "0";
            }
            if (Kop == "")
            {
                Kop = "0";
            }
            if (Dol == "")
            {
                Dol = "0";
            }
            if (Evro == "")
            {
                Evro = "0";
            }
            if (Gon == "")
            {
                Gon = "0";
            }
            if (Jap == "")
            {
                Jap = "0";
            }
            if (Bra == "")
            {
                Bra = "0";
            }
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", Rub, Kop, Dol, Evro, Gon, Jap, Bra);
        }

        public string concat()
        {
            if((Rub =="")&&(Kop==""))
            {
                try
                {
                    if (Dol != "")
                    {
                        double DolBD = Convert.ToDouble(Dol);
                        double rezul = DolBD * 58.82;
                        string rez = "" + Math.Round(rezul, 2);
                        string[] subs = rez.Split(',');
                        Rub = subs[0];
                        Kop = subs[1];
                    }
                    else Dol = "";
                    if (Evro != "")
                    {
                        double EvroBD = Convert.ToDouble(Evro);
                        double rezul = EvroBD * 55.55;
                        string rez = "" + Math.Round(rezul, 2);
                        string[] subs = rez.Split(',');
                        Rub = subs[0];
                        Kop = subs[1];
                    }
                    else Evro = "";
                    if (Gon != "")
                    {
                        double GonBD = Convert.ToDouble(Gon);
                        double rezul = GonBD * 7.69;
                        string rez = "" + Math.Round(rezul, 2);
                        string[] subs = rez.Split(',');
                        Rub = subs[0];
                        Kop = subs[1];
                    }
                    else Gon = "";
                    if (Jap != "")
                    {
                        double JapBD = Convert.ToDouble(Jap);
                        double rezul = JapBD * 0.40;
                        string rez = "" + Math.Round(rezul, 2);
                        string[] subs = rez.Split(',');
                        Rub = subs[0];
                        Kop = subs[1];
                    }
                    else Jap = "";
                    if (Bra != "")
                    {
                        double BraBD = Convert.ToDouble(Bra);
                        double rezul = BraBD * 11.11;
                        string rez = "" + Math.Round(rezul, 2);
                        string[] subs = rez.Split(',');
                        Rub = subs[0];
                        Kop = subs[1];
                    }
                    else Bra = "";
                 }
                catch
                {
                    return "Ошибка;Ошибка;Ошибка;Ошибка;Ошибка;Ошибка;Ошибка";
                }
            }
            else if((Rub == "") && (Kop != ""))
            {
                try
                {
                    double KopBD = Convert.ToDouble(Kop);
                    double Dolg = (0 + (KopBD / 100)) / 58.82;
                    double Evron = (0 + (KopBD / 100)) / 55.55;
                    double Gonn = (0 + (KopBD / 100)) / 7.69;
                    double Japn = (0 + (KopBD / 100)) / 0.40;
                    double Bran = (0 + (KopBD / 100)) / 11.11;
                    Dol = Math.Round(Dolg, 2) + "";
                    Evro = Math.Round(Evron, 2) + "";
                    Gon = Math.Round(Gonn, 2) + "";
                    Jap = Math.Round(Japn, 2) + "";
                    Bra = Math.Round(Bran, 2) + "";

                   
                }
                catch
                {
                    return "Ошибка;Ошибка;Ошибка;Ошибка;Ошибка;Ошибка;Ошибка";
                }
               
            }
            else if ((Rub != "") && (Kop == ""))
            {
                try
                {
                    double RubBD = Convert.ToDouble(Rub);
                    double Dolg = (RubBD) / 58.82;
                    double Evron = (RubBD) / 55.55;
                    double Gonn = (RubBD) / 7.69;
                    double Japn = (RubBD) / 0.40;
                    double Bran = (RubBD) / 11.11;
                    Dol = Math.Round(Dolg, 2) + "";
                    Evro = Math.Round(Evron, 2) + "";
                    Gon = Math.Round(Gonn, 2) + "";
                    Jap = Math.Round(Japn, 2) + "";
                    Bra = Math.Round(Bran, 2) + "";
                }
                catch
                {
                    return "Ошибка;Ошибка;Ошибка;Ошибка;Ошибка;Ошибка;Ошибка";
                }
            }
             else if((Rub != "") && (Kop!= ""))
            {
                try
                {
                    double RubBD=Convert.ToDouble(Rub);
                    double KopBD = Convert.ToDouble(Kop);
                    double Dolg = (RubBD + (KopBD / 100)) / 58.82;
                    double Evron = (RubBD + (KopBD / 100)) / 55.55;
                    double Gonn = (RubBD + (KopBD / 100)) / 7.69;
                    double Japn = (RubBD + (KopBD / 100)) / 0.40;
                    double Bran = (RubBD + (KopBD / 100)) / 11.11;
                    Dol = Math.Round(Dolg, 2) + "";
                    Evro = Math.Round(Evron, 2) + "";
                    Gon = Math.Round(Gonn, 2) + "";
                    Jap = Math.Round(Japn, 2) + "";
                    Bra = Math.Round(Bran, 2) + "";


                }
                catch
                {
                    return "Ошибка;Ошибка;Ошибка;Ошибка;Ошибка;Ошибка;Ошибка";
                }
            }
            else
            {
                return "Ошибка;Ошибка;Ошибка;Ошибка;Ошибка;Ошибка;Ошибка";
            }
            return Rub + ";" + Kop + ";" + Dol + ';' + Evro + ';' + Gon + ';' + Jap + ';' + Bra;

        }
    }
    internal class Program
    {

        static void getData(string path, List<Users> L)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    L.Add(new Users()
                    {
                        Rub = array[0],
                        Kop = array[1],
                        Dol = array[2],
                        Evro = array[3],
                        Gon = array[4],
                        Jap = array[5],
                        Bra = array[6]
                    });
                }
            }
        }

        static void printData(List<Users> L)
        {
            foreach (Users u in L)
            {
                u.show();
            }
        }
        static void inputData(string path, List<Users> L)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (Users u in L)
                {
                    sw.WriteLine(u.concat());
                }
            }
        }

        static void Main(string[] args)
        {
            List<Users> users = new List<Users>();
            getData("dataMoney.csv", users);
            //inputData("dataMoney.csv", users);
            //printData(users);

            List<Users> Users_izmenenie = new List<Users>();

            //Users_izmenenie.AddRange(users);
            //string paths = "Izmenenie.csv";
            //inputData(paths, Users_izmenenie);
            getData("Izmenenie.csv", Users_izmenenie);
            printData(Users_izmenenie);
        }
    }
}