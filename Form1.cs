using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_FinalProject_ASG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //instantiating all objects needed
        GroupBox ToBox = new GroupBox();
        GroupBox FromBox = new GroupBox();
        RadioButton rdoToCelsius = new RadioButton();
        RadioButton rdoToFarenheit = new RadioButton();
        RadioButton rdoFromCelsius = new RadioButton();
        RadioButton rdoFromFarenheit = new RadioButton();

        RadioButton rdoToMeters = new RadioButton();
        RadioButton rdoToKilometers = new RadioButton();
        RadioButton rdoToFeet = new RadioButton();
        RadioButton rdoToMiles = new RadioButton();

        RadioButton rdoToKilogram = new RadioButton();
        RadioButton rdoToPounds = new RadioButton();
        RadioButton rdoToGram = new RadioButton();
        RadioButton rdoToOunce = new RadioButton();

        RadioButton rdoFromMeters = new RadioButton();
        RadioButton rdoFromKilometers = new RadioButton();
        RadioButton rdoFromFeet = new RadioButton();
        RadioButton rdoFromMiles = new RadioButton();

        RadioButton rdoFromKilogram = new RadioButton();
        RadioButton rdoFromPound = new RadioButton();
        RadioButton rdoFromGram = new RadioButton();
        RadioButton rdoFromOunce = new RadioButton();

        //formatting Containers and Radio Buttons
       


        private void cboWhatMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            string measure = cboWhatMeasure.GetItemText(cboWhatMeasure.SelectedItem);// gets combobox measure and puts it into a string
                                                                            //creating Container and formatting on form

            FromBox.Text = "From";
            FromBox.Location = new Point(120, 200);
            FromBox.Size = new Size(515, 50);
            this.Controls.Add(FromBox);

            ToBox.Text = "To";
            ToBox.Location = new Point(120, 250);
            ToBox.Size = new Size(515, 50);
            this.Controls.Add(ToBox);

            //if temp is selected places radio buttons on form

            if (measure.Equals("Temperature"))
            {
                rdoFromCelsius.Text = "Celsius";
                rdoFromCelsius.Location = new Point(15, 15);
                rdoFromCelsius.Size = new Size(60, 20);
                FromBox.Controls.Add(rdoFromCelsius);

                rdoFromFarenheit.Text = "Farenheit";
                rdoFromFarenheit.Location = new Point(80, 15);
                rdoFromFarenheit.Size = new Size(100, 20);
                FromBox.Controls.Add(rdoFromFarenheit);


                rdoToCelsius.Text = "Celsius";
                rdoToCelsius.Location = new Point(15, 15);
                rdoToCelsius.Size = new Size(60, 20);
                ToBox.Controls.Add(rdoToCelsius);

                rdoToFarenheit.Text = "Farenheit";
                rdoToFarenheit.Location = new Point(80, 15);
                rdoToFarenheit.Size = new Size(100, 20);
                ToBox.Controls.Add(rdoToFarenheit);


            }


            else if (measure.Equals("Length"))
            {
                rdoFromMeters.Text = "Meters";
                rdoFromMeters.Location = new Point(15, 15);
                rdoFromMeters.Size = new Size(60, 20);
                FromBox.Controls.Add(rdoFromMeters);

                rdoFromFeet.Text = "Feet";
                rdoFromFeet.Location = new Point(80, 15);
                rdoFromFeet.Size = new Size(60, 20);
                FromBox.Controls.Add(rdoFromFeet);

                rdoFromKilometers.Text = "Kilometers";
                rdoFromKilometers.Location = new Point(150, 15);
                rdoFromKilometers.Size = new Size(90, 20);
                FromBox.Controls.Add(rdoFromKilometers);


                rdoFromMiles.Text = "Miles";
                rdoFromMiles.Location = new Point(250, 15);
                rdoFromMiles.Size = new Size(90, 20);
                FromBox.Controls.Add(rdoFromMiles);


                rdoToMeters.Text = "Meters";
                rdoToMeters.Location = new Point(15, 15);
                rdoToMeters.Size = new Size(60, 20);
                ToBox.Controls.Add(rdoToMeters);

                rdoToFeet.Text = "Feet";
                rdoToFeet.Location = new Point(80, 15);
                rdoToFeet.Size = new Size(60, 20);
                ToBox.Controls.Add(rdoToFeet);

                rdoToKilometers.Text = "Kilometers";
                rdoToKilometers.Location = new Point(150, 15);
                rdoToKilometers.Size = new Size(90, 20);
                ToBox.Controls.Add(rdoToKilometers);


                rdoToMiles.Text = "Miles";
                rdoToMiles.Location = new Point(250, 15);
                rdoToMiles.Size = new Size(90, 20);
                ToBox.Controls.Add(rdoToMiles);


            }

            else if (measure.Equals("Weight"))
            {
                rdoFromKilogram.Text = "Kilograms";
                rdoFromKilogram.Location = new Point(15, 15);
                rdoFromKilogram.Size = new Size(75, 20);
                FromBox.Controls.Add(rdoFromKilogram);

                rdoFromPound.Text = "Pounds";
                rdoFromPound.Location = new Point(95, 15);
                rdoFromPound.Size = new Size(60, 20);
                FromBox.Controls.Add(rdoFromPound);

                rdoFromGram.Text = "Grams";
                rdoFromGram.Location = new Point(165, 15);
                rdoFromGram.Size = new Size(60, 20);
                FromBox.Controls.Add(rdoFromGram);


                rdoFromOunce.Text = "Ounces";
                rdoFromOunce.Location = new Point(250, 15);
                rdoFromOunce.Size = new Size(90, 20);
                FromBox.Controls.Add(rdoFromOunce);


                rdoToKilogram.Text = "Kilograms";
                rdoToKilogram.Location = new Point(15, 15);
                rdoToKilogram.Size = new Size(75, 20);
                ToBox.Controls.Add(rdoToKilogram);

                rdoToPounds.Text = "Pounds";
                rdoToPounds.Location = new Point(95, 15);
                rdoToPounds.Size = new Size(60, 20);
                ToBox.Controls.Add(rdoToPounds);

                rdoToGram.Text = "Grams";
                rdoToGram.Location = new Point(165, 15);
                rdoToGram.Size = new Size(60, 20);
                ToBox.Controls.Add(rdoToGram);


                rdoToOunce.Text = "Ounces";
                rdoToOunce.Location = new Point(250, 15);
                rdoToOunce.Size = new Size(90, 20);
                ToBox.Controls.Add(rdoToOunce);


            }



        }
        private void button1_click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string measure = cboWhatMeasure.GetItemText(cboWhatMeasure.SelectedItem);
            if (measure.Equals("Temperature"))
            {
                calcTempConversion();//temperature converssion
            }
            else if (measure.Equals("Length"))
            {
                calcLengthConversion();  //length conversion
            }
            else if (measure.Equals("Weight"))
            {
                calcWeightConversion(); // weight conversion

            }
        }
        //calculating temperature
        private void calcTempConversion()
        {
            int numConv = int.Parse(txtAmountToBeConverted.Text);

            int cel = 0, fr = 0;
            String farenheit = " Degrees Farenheit";
            String celsius = " Degrees Celsius";
            if (rdoFromCelsius.Checked ==true  && rdoToFarenheit.Checked ==true)
            {
             fr = (numConv * 9) / 5 + 32;//converting celsius to farenheit
                fr.ToString();
                String labelOutput = String.Concat(fr, farenheit);
                lblConversionOutput.Text = labelOutput;
               
            }
            else if (rdoFromFarenheit.Checked == true && rdoToCelsius.Checked == true)
            {
                cel = (numConv - 32) * 5 / 9;  //converting farenheit to celsius
                cel.ToString();
                String labelOutput = String.Concat(cel, celsius);
                lblConversionOutput.Text = labelOutput;

            }
            else if (rdoFromFarenheit.Checked == true && rdoToFarenheit.Checked == true)
            {
               numConv.ToString();// allowing for two farenheits to be picked
                String labelOutput = String.Concat(numConv, farenheit);
                lblConversionOutput.Text = labelOutput;

            }
            else if (rdoFromCelsius.Checked == true && rdoToCelsius.Checked == true)
            {
                numConv.ToString();// allowing for two farenheits to be picked
                String labelOutput = String.Concat(numConv, celsius);
                lblConversionOutput.Text = labelOutput;
            }



        }//end tempconversion

        private void calcLengthConversion()
        {
            double numConv = double.Parse(txtAmountToBeConverted.Text);

            double met = 0, ft = 0, kilo = 0, mi = 0;
            String meters = " Meters";
            String feet = " Feet";
            String kilometers = " Kilometers";
            String miles = " Miles";

            if (rdoFromMeters.Checked == true && rdoToFeet.Checked == true)
            {
                ft = numConv * 3.2;//converting meters to feet
                ft.ToString();
                String labelOutput = String.Concat(ft, feet);
                lblConversionOutput.Text = labelOutput;

            }
            if (rdoFromMeters.Checked == true && rdoToMeters.Checked == true)
            {

                numConv.ToString();//displaying meters to meters
                String labelOutput = String.Concat(numConv, meters);
                lblConversionOutput.Text = labelOutput;

            }
            if (rdoFromMeters.Checked == true && rdoToKilometers.Checked == true)
            {
                kilo = numConv / 1000;//converting meters to kilometers
                kilo.ToString();
                String labelOutput = String.Concat(kilo, kilometers);
                lblConversionOutput.Text = labelOutput;

            }
            if (rdoFromMeters.Checked == true && rdoToMiles.Checked == true)
            {
                mi = numConv / 1609.344;//converting meters to miles
                mi = Math.Round(mi, 2);// rounding to two decimal places
                mi.ToString();

                String labelOutput = String.Concat(mi, miles);
                lblConversionOutput.Text = labelOutput;

            }

            //From Feet

            if (rdoFromFeet.Checked == true && rdoToMeters.Checked == true)
            {
                met = numConv / 3.2808399;//converting feet to meters
                met = Math.Round(met, 4);
                met.ToString();
                String labelOutput = String.Concat(met, meters);
                lblConversionOutput.Text = labelOutput;

            }

            if (rdoFromFeet.Checked == true && rdoToFeet.Checked == true)
            {

                numConv.ToString();//displaying Feet to Feet
                String labelOutput = String.Concat(numConv, feet);
                lblConversionOutput.Text = labelOutput;

            }

            if (rdoFromFeet.Checked == true && rdoToKilometers.Checked == true)
            {
                kilo = numConv / 3280.8399;//converting feet to meters
                kilo = Math.Round(kilo, 4);
                kilo.ToString();
                String labelOutput = String.Concat(kilo, kilometers);
                lblConversionOutput.Text = labelOutput;

            }
            if (rdoFromFeet.Checked == true && rdoToMiles.Checked == true)
            {
                mi = numConv / 5280;//converting feet to Miles
                mi = Math.Round(mi, 4);
                mi.ToString();
                String labelOutput = String.Concat(mi, miles);
                lblConversionOutput.Text = labelOutput;

            }

            //FROM KIlometers

            if (rdoFromKilometers.Checked == true && rdoToMeters.Checked == true)
            {
                met = numConv * 1000;//converting kilometers to feet
                met.ToString();
                String labelOutput = String.Concat(met, meters);
                lblConversionOutput.Text = labelOutput;


            }

            if (rdoFromKilometers.Checked == true && rdoToFeet.Checked == true)
            {
                ft = numConv * 3280.8399;//converting kilometers to feet
                ft = Math.Round(ft, 4);
                ft.ToString();
                String labelOutput = String.Concat(ft, feet);
                lblConversionOutput.Text = labelOutput;


            }

            if (rdoFromKilometers.Checked == true && rdoToKilometers.Checked == true)
            {
                numConv.ToString();//displaying Kilometers to Kilometers
                String labelOutput = String.Concat(numConv, kilometers);
                lblConversionOutput.Text = labelOutput;


            }

            if (rdoFromKilometers.Checked == true && rdoToMiles.Checked == true)
            {
                mi = numConv/ 1.609344;//converting kilometers to miles
                mi = Math.Round(mi, 4);
                mi.ToString();
                String labelOutput = String.Concat(mi, miles);
                lblConversionOutput.Text = labelOutput;


            }

            //From Miles

            if (rdoFromMiles.Checked == true && rdoToMeters.Checked == true)
            {
                met= numConv* 1609.344;//converting Miles to Meters
                met = Math.Round(met, 4);
                met.ToString();
                String labelOutput = String.Concat(met, meters);
                lblConversionOutput.Text = labelOutput;


            }
            if (rdoFromMiles.Checked == true && rdoToFeet.Checked == true)
            {
                ft = numConv * 5280;//converting Miles to feet
                ft.ToString();
                String labelOutput = String.Concat(ft, feet);
                lblConversionOutput.Text = labelOutput;


            }

            if (rdoFromMiles.Checked == true && rdoToKilometers.Checked == true)
            {
                mi = numConv * 1.609344;//converting Miles to kilometers
                mi = Math.Round(mi, 4);
                mi.ToString();
                String labelOutput = String.Concat(mi, miles);
                lblConversionOutput.Text = labelOutput;


            }
            if (rdoFromMiles.Checked == true && rdoToMiles.Checked == true)
            {
                numConv.ToString();//displaying miles to miles
                String labelOutput = String.Concat(numConv, miles);
                lblConversionOutput.Text = labelOutput;
            }

            }//end calcLengthConverision

        private void calcWeightConversion()
        {
            double numConv = double.Parse(txtAmountToBeConverted.Text);

            double lbs = 0, g = 0, kg = 0, oz = 0;
            String pounds = " Pounds";
            String grams = " Grams";
            String kilograms = " Kilograms";
            String ounces = " Ounces";

            //FRom kilograms

            if (rdoFromKilogram.Checked == true && rdoToKilogram.Checked == true)
            {
                numConv.ToString();//displaying kilograms to kilograms
                String labelOutput = String.Concat(numConv, kilograms);
                lblConversionOutput.Text = labelOutput;


            }
            if (rdoFromKilogram.Checked == true && rdoToPounds.Checked == true)
            {
                lbs = numConv * 2.20462262;//converting kilograms to pounds
                lbs = Math.Round(lbs, 4);
                lbs.ToString();
                String labelOutput = String.Concat(lbs, pounds);
                lblConversionOutput.Text = labelOutput;

            }
            if (rdoFromKilogram.Checked == true && rdoToGram.Checked == true)
            {
                g = numConv *1000;//converting kilograms to graams
                g.ToString();
                String labelOutput = String.Concat(g, grams);
                lblConversionOutput.Text = labelOutput;

            }

            //frompound
            if (rdoFromPound.Checked == true && rdoToKilogram.Checked == true)
            {
                kg = numConv / 2.20462262;//converting pounds oto kilograms
                kg = Math.Round(kg, 4);
                kg.ToString();
                String labelOutput = String.Concat(kg,kilograms);
                lblConversionOutput.Text = labelOutput;

            }
            if (rdoFromPound.Checked == true && rdoToPounds.Checked == true)
            {
                numConv.ToString();//displaying pounds to pounds
                String labelOutput = String.Concat(numConv, pounds);
                lblConversionOutput.Text = labelOutput;

            }
            if (rdoFromPound.Checked == true && rdoToGram.Checked == true)
            {
                g = numConv * 453.59237;//converting pounds oto grams
                g = Math.Round(g, 4);
                g.ToString();
                String labelOutput = String.Concat(g, grams);
                lblConversionOutput.Text = labelOutput;

            }

            if (rdoFromPound.Checked == true && rdoToOunce.Checked == true)
            {
               oz= numConv * 16;//converting pounds oto ounces
              
                oz.ToString();
                String labelOutput = String.Concat(oz, ounces);
                lblConversionOutput.Text = labelOutput;

            }

            //fromGrams
            if (rdoFromGram.Checked == true && rdoToKilogram.Checked == true)
            {
                kg = numConv / 1000;//converting grams to kilograms
                kg = Math.Round(kg, 4);
                kg.ToString();
                String labelOutput = String.Concat(kg, kilograms);
                lblConversionOutput.Text = labelOutput;

            }

            if (rdoFromGram.Checked == true && rdoToPounds.Checked == true)
            {
                lbs = numConv /453.59237;//converting pounds oto grams
                lbs= Math.Round(lbs, 4);
                lbs.ToString();
                String labelOutput = String.Concat(lbs,pounds);
                lblConversionOutput.Text = labelOutput;

            }
            if (rdoFromGram.Checked == true && rdoToGram.Checked == true)
            {
                numConv.ToString();//displaying Grams to Grams
                String labelOutput = String.Concat(numConv, grams);
                lblConversionOutput.Text = labelOutput;

            }

            if (rdoFromGram.Checked == true && rdoToOunce.Checked == true)
            {
                oz = numConv / 28.3495231;//converting grams to ounces
                oz = Math.Round(oz, 4);
                oz.ToString();
                String labelOutput = String.Concat(oz, ounces);
                lblConversionOutput.Text = labelOutput;

            }

            //from Ounces
            if (rdoFromOunce.Checked == true && rdoToKilogram.Checked == true)
            {
                kg = numConv / 35.273962;//converting grams to ounces
                kg = Math.Round(kg, 4);
                kg.ToString();
                String labelOutput = String.Concat(kg, kilograms);
                lblConversionOutput.Text = labelOutput;

            }

            if (rdoFromOunce.Checked == true && rdoToPounds.Checked == true)
            {
                lbs = numConv /16;//converting ounces to pounds
                lbs = Math.Round(lbs, 4);
                lbs.ToString();
                String labelOutput = String.Concat(lbs, pounds);
                lblConversionOutput.Text = labelOutput;

            }

            if (rdoFromOunce.Checked == true && rdoToGram.Checked == true)
            {
                g = numConv * 28.3495231;//converting ounces to grams
                g = Math.Round(g, 4);
                g.ToString();
                String labelOutput = String.Concat(g, grams);
                lblConversionOutput.Text = labelOutput;

            }
            if (rdoFromOunce.Checked == true && rdoToOunce.Checked == true)
            {
                numConv.ToString();//displaying  ounces to punces
                String labelOutput = String.Concat(numConv, ounces);
                lblConversionOutput.Text = labelOutput;

            }


        }//ENN CalcWeightConversion


    }//end form
 }
