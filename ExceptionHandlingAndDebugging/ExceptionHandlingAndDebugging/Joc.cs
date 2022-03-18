using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAndDebugging
{
    public class Joc
    {
        private string team1, team2;
        private int no_goals1, no_goals2;
        private int no_corners;

        public Joc(string team1, string team2)
        {
            this.team1 = team1;
            this.team2 = team2;
            no_goals1 = no_goals2 = no_corners = 0;
        }
        public override string ToString()
        {
            return $"{team1} - {team2}: {no_goals1} - {no_goals2}\nTotal corners: {no_corners}";
        }
        public void simuleaza()
        {
            Minge minge = new Minge(50, 50);
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    Console.WriteLine($"{team1} - {team2}: Mingea se afla la coordonatele ({minge.XProperty}, {minge.YProperty})");
                    minge.suteaza();
                }
                catch (Out out_ex)
                {
                    Console.WriteLine(out_ex);
                    minge = new Minge(minge.XProperty, minge.YProperty);
                }
                catch (Corner corner_ex)
                {
                    Console.WriteLine(corner_ex);
                    no_corners++;
                    int x = minge.XProperty;
                    int y;
                    if (minge.YProperty < 20) { y = 0; }
                        else { y = 50; }
                    minge = new Minge(x, y);

                }
                catch (Gol gol_ex)
                {
                    Console.WriteLine(gol_ex);
                    if (minge.XProperty == 100)
                    {
                        no_goals1++;
                    }
                    else no_goals2++;
                    minge = new Minge(50, 50);
                }

                
            }
        }

    }
}
