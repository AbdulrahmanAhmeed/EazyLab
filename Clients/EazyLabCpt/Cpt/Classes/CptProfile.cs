using EazyLabClient;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.SmartCards;
using Newtonsoft;
using Newtonsoft.Json;
using EazyLab.Classes;
using EazyLab.Model;
using EazyLab.Instrumentation.Standard;
namespace EazyLab.Cpt.Classes
{
    public class CptProfile : Entity
    {
        public enum ProfileSource { Temp1, Temp2, Temp3, Temp4, Temp5, Temp6, Current, Power, Energy }


        /// <summary>
        /// The include string.
        /// all BSonexpression sepated by ','
        /// </summary>
        public const string IncludeString = "$.TempZones";

        public double MaxCurrent { set; get; }

        public double MinPowerFactor { set; get; }
        public bool RejectIfPowerFactor { set; get; }
        public bool RejectIfCurrent { set; get; }
        public int UpperLimitRGP { set; get; }
        public int LowerLimitRGP { set; get; }
        public ProfileSource Source { set; get; }
        public List<CptTempZone> TempZones { set; get; }
        public string JsonString { get; set; }
        [BsonCtor]
        public ValueDouble UpperLimit { set; get; } = new ValueDouble(0);
        [BsonCtor]
        public ValueDouble LowerLimit { set; get; } = new ValueDouble(0);
        [BsonCtor]
        public PlotSubscriber LowerLimitSubs { set; get; }
        [BsonCtor]
        public PlotSubscriber UpperLimitSubs { set; get; }
        [BsonCtor]
        public CptProfile()
        {
            if (JsonString == null) JsonString = String.Empty;
            TempZones = (List<CptTempZone>)JsonConvert.DeserializeObject<List<CptTempZone>>(JsonString);
            if (TempZones == null) TempZones = new List<CptTempZone>();
            Id = 1;
            // BsonMapper.Global.Entity<CptTempProfile>().DbRef(x => x.TempZones, "CptTempZone");
            UpperLimit.UnitsText = "°c";
            
            UpperLimit.Max = 50;
            UpperLimit.Min = -50;
            LowerLimit.UnitsText = "°c";
            LowerLimit.Max = 50;
            LowerLimit.Min = -50;
        }


        public void InitializeSubscribers(PlotYAxis axis)
        {

            try
            {
                UpperLimit.TagName= "UpperLimit" + Source.ToString();
                LowerLimit.TagName =  "LowerLimit" + Source.ToString();
                if(LowerLimitRGP == 0) LowerLimitSubs = new PlotSubscriber(LowerLimit, axis, -0.5f);
                else LowerLimitSubs = new PlotSubscriber(LowerLimit, axis, System.Drawing.Color.FromArgb(LowerLimitRGP));
                if(UpperLimitRGP == 0) UpperLimitSubs = new PlotSubscriber(UpperLimit, axis, 0.5f);
                else UpperLimitSubs = new PlotSubscriber(UpperLimit, axis, System.Drawing.Color.FromArgb(UpperLimitRGP));

            }
            catch (Exception ex)
            { 
                LoggerFile.WriteException(ex);
            }

        }



        internal CptTempZone GetZone(int index)
        {
            return TempZones[index];
        }

        public void Add(CptTempZone zone)
        {
            if (zone == null) { return; }

            for (int i = 0; i < TempZones.Count; i++)
            {
                if (TempZones[i].Time == zone.Time) TempZones.RemoveAt(i);
            }
            TempZones.Add(zone);
            JsonString = JsonConvert.SerializeObject(TempZones, Formatting.Indented);
        }

        public void Del(CptTempZone zone)
        {
            if (zone == null) { return; }

            for (int i = 0; i < TempZones.Count; i++)
            {
                if (TempZones[i].Time == zone.Time) TempZones.RemoveAt(i);
            }
            JsonString = JsonConvert.SerializeObject(TempZones);
        }
        public void Del(int indx)
        {
            if (indx < TempZones.Count && indx >= 0)
            {
                TempZones.RemoveAt(indx);
                JsonString = JsonConvert.SerializeObject(TempZones, Formatting.Indented);
            }

        }
        public void DelByTime(double time)
        {
            var i = TempZones.FindIndex(x => x.Time == time);
            if (i >= 0) { TempZones.RemoveAt(i); }
        }

        /// <summary>
        /// Updates the limits.
        /// </summary>
        /// <param name="time">The time in minuits.</param>
        public void UpdateLimits(double time)
        {
            CptTempZone z1 = null, z2 = null;

            int i = 0;
            for (i = 0; i < TempZones.Count; i++)
            {
                if (TempZones[i].Time == time)
                {
                    z1 = TempZones[i];
                    z2 = TempZones[i];
                    UpperLimit = z1.Upper;
                    LowerLimit = z1.Lower;
                    break ;

                }
                if (TempZones[i].Time > time)
                {
                    z1 = TempZones[i-1];
                    z2= TempZones[i];
                    break;
                }


            }

            
            try
            {
                UpperLimit = (time - z1.Time) * (z2.Upper - z1.Upper) / (z2.Time - z1.Time) + z1.Upper;
                LowerLimit = (time - z1.Time) * (z2.Lower - z1.Lower) / (z2.Time - z1.Time) + z1.Lower;
                UpperLimitSubs.Value = UpperLimit;
                LowerLimitSubs.Value = LowerLimit;
            }
            catch (Exception e) { 
                LoggerFile.WriteException(e);
            }


        }



    }
}
