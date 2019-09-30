using System;
using System.Collections.Generic;
using System.ComponentModel;
using HydrationStationV1.Models;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace HydrationStationV1
{
    public partial class StatsPage : ContentPage
    {
        /// <summary>
        /// Constructs the page that displays the stats of water intake.
        /// </summary>
        /// <param name="">The week entry.</param>
        public StatsPage()
        {
            InitializeComponent();

            WeekEntry week = new WeekEntry();

            //Test data.
            week.updateIntakeForDay(2075, "monday");
            week.updateIntakeForDay(1098, "tuesday");
            week.updateIntakeForDay(1453, "wednesday");
            week.updateIntakeForDay(2034, "thursday");
            week.updateIntakeForDay(1875, "friday");
            week.updateIntakeForDay(2000, "saturday");
            week.updateIntakeForDay(1943, "sunday");
            createBarChart(week);
        }

        /// <summary>
        /// Creates a bar chart for the week's entries to display on this
        /// page.
        /// </summary>
        /// <param name="week">The week entry.</param>
        public void createBarChart(WeekEntry week)
        {
            var entries = new[]
            {
                new Microcharts.Entry(week.getMondayIntake())
                {
                    Color = SKColor.Parse("#4169E1"),
                    Label = "Mon",
                    ValueLabel = week.getMondayIntake().ToString()
                },
                new Microcharts.Entry(week.getTuesdayIntake())
                {
                    Color = SKColor.Parse("#4169E1"),
                    Label = "Tue",
                    ValueLabel = week.getTuesdayIntake().ToString()
                },
                new Microcharts.Entry(week.getWednesdayIntake())
                {
                    Color = SKColor.Parse("#4169E1"),
                    Label = "Wed",
                    ValueLabel = week.getWednesdayIntake().ToString()
                },
                new Microcharts.Entry(week.getThursdayIntake())
                {
                    Color = SKColor.Parse("#4169E1"),
                    Label = "Thu",
                    ValueLabel = week.getThursdayIntake().ToString()
                },
                new Microcharts.Entry(week.getFridayIntake())
                {
                    Color = SKColor.Parse("#4169E1"),
                    Label = "Fri",
                    ValueLabel = week.getFridayIntake().ToString()
                },
                new Microcharts.Entry(week.getSaturdayIntake())
                {
                    Color = SKColor.Parse("#4169E1"),
                    Label = "Sat",
                    ValueLabel = week.getSaturdayIntake().ToString()
                },
                new Microcharts.Entry(week.getSundayIntake())
                {
                    Color = SKColor.Parse("#4169E1"),
                    Label = "Sun",
                    ValueLabel = week.getSundayIntake().ToString()
                }
            };

            //Configuration for bar chart format.
            var chart = new BarChart()
            {
                Entries = entries,
                MaxValue = 2700,
                LabelTextSize = 30,
                Margin = 40
            };
            this.chartView.Chart = chart;
        }
    }
}
