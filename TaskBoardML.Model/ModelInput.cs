// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace TaskBoardML.Model
{
    public class ModelInput
    {
        [ColumnName("Risk"), LoadColumn(0)]
        public string Risk { get; set; }


        [ColumnName("IslemTipi"), LoadColumn(1)]
        public string IslemTipi { get; set; }


        [ColumnName("Oncelik"), LoadColumn(2)]
        public string Oncelik { get; set; }


        [ColumnName("TeknikUzman"), LoadColumn(3)]
        public string TeknikUzman { get; set; }


        [ColumnName("Sure"), LoadColumn(4)]
        public float Sure { get; set; }


    }
}
