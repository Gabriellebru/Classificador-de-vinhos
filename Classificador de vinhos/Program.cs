using System;
using System.Collections.Generic;
using Classificador_de_vinhosML.Model;

namespace Classificador_de_vinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<ModelInput>() 
            {
                new ModelInput()
                {
                    Fixed_acidity = 7.4F,
                    Volatile_acidity = 0.7F,
                    Citric_acid = 0F,
                    Residual_sugar = 1.9F,
                    Chlorides = 0.076F,
                    Free_sulfur_dioxide = 11,
                    Total_sulfur_dioxide = 34F,
                    Density = 0.9978F,
                    PH = 3.51F,
                    Sulphates = 0.56F,
                    Alcohol = @"9.4",
                    Quality = 5F
                }, // red
                new ModelInput()
                {
                    Fixed_acidity = 7F,
                    Volatile_acidity = 0.27F,
                    Citric_acid = 0.36F,
                    Residual_sugar = 20.7F,
                    Chlorides = 0.045F,
                    Free_sulfur_dioxide = 45,
                    Total_sulfur_dioxide = 170F,
                    Density = 1.001F,
                    PH = 3F,
                    Sulphates = 0.45F,
                    Alcohol = @"8.8",
                    Quality = 6F
                }, // white
                new ModelInput()
                {
                    Fixed_acidity = 7.4F,
                    Volatile_acidity = 0.7F,
                    Citric_acid = 0F,
                    Residual_sugar = 1.9F,
                    Chlorides = 0.076F,
                    Free_sulfur_dioxide = 11,
                    Total_sulfur_dioxide = 34F,
                    Density = 0.9978F,
                    PH = 3.51F,
                    Sulphates = 0.56F,
                    Alcohol = @"9.4",
                    Quality = 5F
                }, // red
                new ModelInput()
                {
                    Fixed_acidity = 7.2F,
                    Volatile_acidity = 0.23F,
                    Citric_acid = 0.32F,
                    Residual_sugar = 8.5F,
                    Chlorides = 0.058F,
                    Free_sulfur_dioxide = 47,
                    Total_sulfur_dioxide = 186F,
                    Density = 0.9956F,
                    PH = 3.19F,
                    Sulphates = 0.4F,
                    Alcohol = @"9.9",
                    Quality = 6F
                }, // white
                new ModelInput()
                {
                    Fixed_acidity = 7.4F,
                    Volatile_acidity = 0.7F,
                    Citric_acid = 0F,
                    Residual_sugar = 1.9F,
                    Chlorides = 0.076F,
                    Free_sulfur_dioxide = 11,
                    Total_sulfur_dioxide = 34F,
                    Density = 0.9978F,
                    PH = 3.51F,
                    Sulphates = 0.56F,
                    Alcohol = @"9.4",
                    Quality = 5F
                }  // red
            };

            List<ModelOutput> results = ConsumeModel.Predicts(inputs);
            ConsumeModel.ShowResults(results);
        }
    }
}
