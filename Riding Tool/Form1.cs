using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Riding_Tool
{
    public partial class Form1 : Form
    {
        private List<Rider> riders = new List<Rider>();

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_Data_Input_TextChanged(object sender, EventArgs e)
        {
            Data_DataGridView.Rows.Clear();

            string[] lines = TextBox_Data_Input.Text.Split('\n');

            foreach (string row in lines)
            {
                string [] cells = row.Split('\t');

                Data_DataGridView.Rows.Add(cells[0], cells[1], cells[2], cells[3], cells[4], cells[5], cells[6]);

                int seats = 0;

                try
                {
                    string s = Regex.Match(cells[5], @"\d+").Value;

                    seats = int.Parse(s);
                }

                catch (Exception)
                {

                }

                bool priv = false;

                if (cells[6].ToLower().Contains("yes"))
                {
                    priv = true;
                }
                
                riders.Add(new Rider(cells[2], cells[3], cells[1], cells[4], seats, priv));
            }
        }

        private void Button_Stable_Email_Click(object sender, EventArgs e)
        {
            string str = "Hi Sally,\nPlease see the following sign-ups for this week’s lessons:\nWednesday -\n\tBeginner Lesson, 4PM:\n";

            foreach (Rider r in riders)
            {
                if (r.GetGroup().ToLower().Equals("beginner"))
                {
                    str = str + SallyPrintName(r, str);
                }
            }

            str = str + "\tImprover Lesson, 5PM:\n";

            foreach (Rider r in riders)
            {
                if (r.GetGroup().ToLower().Equals("improver"))
                {
                    str = str + SallyPrintName(r, str);
                }
            }

            str = str + "Tuesday -\n\tIntermediate, 7PM:\n";

            foreach (Rider r in riders)
            {
                if (r.GetGroup().ToLower().Equals("intermediate"))
                {
                    str = str + SallyPrintName(r, str);
                }
            }

            str = str + "\tAdvanced Lesson, 6PM:\n";

            foreach (Rider r in riders)
            {
                if (r.GetGroup().ToLower().Equals("advanced"))
                {
                    str = str + SallyPrintName(r, str);
                }
            }

            str = str + "Many Thanks,\nEmily";

            Clipboard.SetText(str);
        }

        private string SallyPrintName(Rider r, string text)
        {
            if (!text.Contains(r.GetName()))
            {
                string str = "\t\t" + r.GetName();

                if (!r.GetHorse().Equals(""))
                {
                    str = str + " - " + r.GetHorse() + " please.";
                }

                str = str + "\n";

                return str;
            }

            return "";
        }

        private void Button_Stable_Subject_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Now;

            for (int i = 0; i < 7; i++)
            {
                if (dt1.DayOfWeek == DayOfWeek.Tuesday)
                {
                    break;
                }

                else
                {
                    dt1 = dt1.AddDays(1);
                }
            }

            for (int i = 0; i < 7; i++)
            {
                if (dt2.DayOfWeek == DayOfWeek.Wednesday)
                {
                    break;
                }

                else
                {
                    dt2 = dt2.AddDays(1);
                }
            }

            string [] month = dt1.ToLongDateString().Split(' ');

            string str = "Riding Schedule - " + GetDaySuffix(dt1.Day) + "/" + GetDaySuffix(dt2.Day) + " " + month[1];

            Clipboard.SetText(str);
        }

        public string GetDaySuffix(int day)
        {
            switch (day)
            {
                case 1:
                case 21:
                case 31:
                    return day + "st";
                case 2:
                case 22:
                    return day + "nd";
                case 3:
                case 23:
                    return day + "rd";
                default:
                    return day + "th";
            }
        }

        private void Button_Beginner_Email_Click(object sender, EventArgs e)
        {
            Email_Algo("Wednesday", 4, "Beginner");
        }

        private void Button_Beginner_Subject_Click(object sender, EventArgs e)
        {
            Subject_Algo("Beginner");
        }

        private void Button_Beginner_Address_Click(object sender, EventArgs e)
        {
            Address_Algo("Beginner");
        }

        private void Button_Improver_Email_Click(object sender, EventArgs e)
        {
            Email_Algo("Wednesday", 5, "Improver");
        }

        private void Button_Improver_Subject_Click(object sender, EventArgs e)
        {
            Subject_Algo("Improver");
        }

        private void Button_Improver_Address_Click(object sender, EventArgs e)
        {
            Address_Algo("Improver");
        }

        private void Button_Intermediate_Email_Click(object sender, EventArgs e)
        {
            Email_Algo("Tuesday", 7, "Intermediate");
        }

        private void Button_Intermediate_Subject_Click(object sender, EventArgs e)
        {
            Subject_Algo("Intermediate");
        }

        private void Button_Intermediate_Address_Click(object sender, EventArgs e)
        {
            Address_Algo("Intermediate");
        }

        private void Button_Advanced_Email_Click(object sender, EventArgs e)
        {
            Email_Algo("Tuesday", 6, "Advanced");
        }

        private void Button_Advanced_Subject_Click(object sender, EventArgs e)
        {
            Subject_Algo("Advanced");
        }

        private void Button_Advanced_Address_Click(object sender, EventArgs e)
        {
            Address_Algo("Advanced");
        }

        private void Email_Algo(string day, int time, string group)
        {
            string str = "";

            str = "Hi guys,\nJust confirming your " + group + " riding lesson on " + day + " at " + time + "pm!\n";

            int count = 0;

            foreach (Rider r in riders)
            {
                if (r.GetGroup().ToLower().Equals(group.ToLower()))
                {
                    count++;
                }
            }

            if (count > 4)
            {
                str = str + "It will be £18 in cash please!\n";
            }

            else
            {
                str = str + "It will be £22 in cash please!\n";
            }

            bool driver = true;

            foreach (Rider r in riders)
            {
                if (r.GetGroup().ToLower().Equals(group.ToLower()) && r.GetSeats() != 0)
                {
                    str = str + r.GetName() + ", are you still okay to drive? If so, can everybody meet at SB main entrance at " + (time - 1) + ":45pm and then you can all head down together from there!\n";
                    driver = false;
                    break;
                }
            }

            if (driver)
            {
                str = str + "Can everybody meet at main entrance at " + (time - 1) + ":45pm\n";
            }

            str = str + "Enjoy your lesson!\nEmily";

            Clipboard.SetText(str);
        }

        private void Subject_Algo(string group)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Now;

            for (int i = 0; i < 7; i++)
            {
                if (dt1.DayOfWeek == DayOfWeek.Tuesday)
                {
                    break;
                }

                else
                {
                    dt1 = dt1.AddDays(1);
                }
            }

            for (int i = 0; i < 7; i++)
            {
                if (dt2.DayOfWeek == DayOfWeek.Wednesday)
                {
                    break;
                }

                else
                {
                    dt2 = dt2.AddDays(1);
                }
            }

            string[] month = dt1.ToLongDateString().Split(' ');

            string str = "Riding Lesson Confirmation - " + GetDaySuffix(dt1.Day) + " " + month[1];

            if (group.ToLower().Equals("beginner") || group.ToLower().Equals("improver"))
            {
                month = dt2.ToLongDateString().Split(' ');
                str = "Riding Lesson Confirmation - " + GetDaySuffix(dt2.Day) + " " + month[1];
            }

            Clipboard.SetText(str);
        }

        private void Address_Algo(string group)
        {
            string str = "";

            foreach (Rider r in riders)
            {
                if (r.GetGroup().ToLower().Equals(group.ToLower()))
                {
                    string email = r.GetEmail();

                    if (!email.Contains("@"))
                    {
                        email = email + "@nottingham.ac.uk";
                    }

                    if (!str.Contains(email))
                    {
                        str = str + email + ", ";
                    }
                }
            }

            Clipboard.SetText(str);
        }
    }

    public class Rider
    {
        string name;
        string email;
        string group;
        string horse;
        int seats;
        bool priv;

        public Rider(string n, string e, string g, string h, int s, bool p)
        {
            name = n;
            email = e;
            group = g;
            horse = h;
            seats = s;
            priv = p;
        }

        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetGroup()
        {
            return group;
        }

        public string GetHorse()
        {
            return horse;
        }

        public int GetSeats()
        {
            return seats;
        }

        public bool GetPrivate()
        {
            return priv;
        }
    }
}
