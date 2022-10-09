namespace Arvosanat{
class Gradation
    
    {
        int countOfGrades = 0;
        string[] nameOfGrades;
        string name = " ";
        public Gradation(int countOfGrades)
        {
            this.countOfGrades = countOfGrades;
            nameOfGrades = new string[countOfGrades];
            NameOfGrades(countOfGrades);
        }

        public void NameOfGrades(int countOfNames)
        {
            for (int i = 0; i < countOfNames; i++)
            {
                Console.Write($"{i}: ");
                this.name = Console.ReadLine();
                this.nameOfGrades[i] = this.name; 
            }
        }

        public string ReturnNameOfGrade(int indexOfGrade)
        {   
            if (nameOfGrades.Length == 0)
            {
                return "Gradation system is not";
            }
            return nameOfGrades[indexOfGrade];
        
        }

    }
}