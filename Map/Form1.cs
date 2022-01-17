using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        DataModel dm = new DataModel();
        List<Happiness> happinessList;

        public Form1()
        {
            MessageBox.Show("Welcome to Earth Happines Application");
            MessageBox.Show("The World Happiness Report is a landmark survey of the state of global happiness . The report continues to gain global recognition as governments, organizations and civil society increasingly use happiness indicators to inform their policy-making decisions. Leading experts across fields – economics, psychology, survey analysis, national statistics, health, public policy and more – describe how measurements of well-being can be used effectively to assess the progress of nations. The reports review the state of happiness in the world today and show how the new science of happiness explains personal and national variations in happiness.");
            MessageBox.Show("The happiness scores and rankings use data from the Gallup World Poll.The columns following the happiness score estimate the extent to which each of six factors – economic production, social support, life expectancy, freedom, absence of corruption, and generosity – contribute to making life evaluations higher in each country than they are in Dystopia, a hypothetical country that has values equal to the world’s lowest national averages for each of the six factors.They have no impact on the total score reported for each country, but they do explain why some countries rank higher than others.");
            InitializeComponent();
            gbBilgi.Visible = false;
            happinessList = dm.GetHappiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geomap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>();
            foreach (var item in happinessList)
            {
                keyValues[$"{item.Alpha}"] = item.LadderScore;
            }

            //geomap.HeatMap = keyValues;
            geomap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geomap);
            geomap.Dock = DockStyle.Fill;
            geomap.LandClick += Geomap_LandClick;
        }

        private void Geomap_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            //LabelTemizle();
            foreach (var item in happinessList)
            {
                if (arg2.Id == item.Alpha)
                {
                    gbBilgi.Visible = true;
                    lblCountry.Text = item.CountryName;
                    lblRegional.Text = item.RegionalIndicator;
                    lblLadderScore.Text = item.LadderScore.ToString();
                    lblStandartErrorOfLadderScore.Text = item.StandartErrorOfLadderScore.ToString();
                    lblUpperWhisker.Text = item.UpperWhisker.ToString();
                    lblLowerWhisker.Text = item.LowerWhisker.ToString();
                    lblLoggedGdp.Text = item.LoggedGdpPerCapita.ToString();
                    lblSocialSupport.Text = item.SocialSupport.ToString();
                    lblHealthLife.Text = item.HealthyLifeExpectancy.ToString();
                    lblFreedom.Text = item.FreedomToMakeLifeChoices.ToString();
                    lblGenerosity.Text = item.Generocity.ToString();
                    lblPerceptions.Text = item.PerceptionsOfCorruption.ToString();
                    lblLadderScoreInD.Text = item.LadderScoreInDystopia.ToString();
                    lblExpLogged.Text = item.ExplainedByLogGdpPerCapita.ToString();
                    lblExpSocialSupport.Text = item.ExplainedBySocialSupport.ToString();
                    lblExpHealth.Text = item.ExplainedByHealthyLifeExpectancy.ToString();
                    lblExpFreedom.Text = item.ExplainedByFreedomToMakeLifeChoices.ToString();
                    lblExpGenerosity.Text = item.ExplainedByGenerosity.ToString();
                    lblExpPerceptions.Text = item.ExplainedByPerceptionsOfCorruption.ToString();
                    lblExpDystopia.Text = item.DystopiaResidual.ToString();
                }
            }


        }
        //public void LabelTemizle() 
        //{
        //    foreach (Control item in this.Controls)
        //    {
        //        if (item.GetType() == typeof(Label) || item.Text=="a")
        //        {
        //            item.Text = String.Empty;
        //        }


        //    }
        //}
    }
}
