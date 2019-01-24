
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Calculation
    {
        
    }
        public class Results
        {
            public string BMI_Txt { get; set; }
            public string PerfectWeight_Txt { get; set; }
            public string BonesWeight_Txt { get; set; }



            public static Results Calculate(string weightTxt, string heightTxt, string gender)
            {
                
                    Results results = new Results();

                    int height = Int32.Parse(heightTxt);
                    double weight = double.Parse(weightTxt);


                    //Calculate the BMI values ​​entered
                    double calc = (weight / (Math.Pow((double)(height), 2)) * 10000);
                    //Result of the calculation of BMI
                    results.BMI_Txt = Math.Round(calc, 3).ToString() + "%";

                    //Determination gender
                    //For male
                    if (gender == "male")
                    {
                        string resultPerfect = (((float)(height)) - 100 + " Kg");
                        //Result of the calculation of PerfectWeight for male
                        results.PerfectWeight_Txt = resultPerfect;
                    }
                    //For female
                    else if (gender == "female")
                    {
                        string resultPerfect = (((float)(height)) - 110) + " Kg";
                        //Result of the calculation of PerfectWeight for female
                        results.PerfectWeight_Txt = resultPerfect;
                    }

                    //Calculate the BonesWeight values ​​entered
                    string resultBones = (((float)(weight) / 100d) * 20d) + " Kg";
                    //Result of the calculation of BonesWeight
                    results.BonesWeight_Txt = resultBones;

                    return results;


            }
                
        }
}
