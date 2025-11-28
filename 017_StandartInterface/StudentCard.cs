namespace _017_StandartInterface
{
    class StudentCard : ICloneable
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public object Clone()
        {
            /*return new StudentCard { 
                Number = this.Number, Series = this.Series 
            };*/

            return this.MemberwiseClone(); //неглибоке клонування - це створення поверхневої копії об'єкта
        }

        public override string ToString()
        {
            return $"Student card: {Series} {Number} ";
        }
    }
}
