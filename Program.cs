Random random = new Random();
string[] firstNames = new string[] { "firstName1", "firstName2", "firstName3", "firstName4", "firstName5", "firstName6", "firstName7", "firstName8", "firstName9", "firstName10" };
string[] middleNames = new string[] { "middleName1", "middleName2", "middleName3", "middleName4", "middleName5", "middleName6", "middleName7", "middleName8", "middleName9", "middleName10" };
string[] lastNames = new string[] { "lastName1", "lastName2", "lastName3", "lastName4", "lastName5", "lastName6", "lastName7", "lastName8", "lastName9", "lastName10" };
string[] jobs = new string[10] { "Dentist", "Accountant", "Construction Worker", "Chef", "Baby Sitter", "Architect", "Teacher", "Baseball Player", "Cowboy", "Surgeon" };
int[] hourlyWages = new int[10] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
int[] salarys = new int[]{  hourlyWages[0]*2000, hourlyWages[1]*2000, hourlyWages[2]*2000, hourlyWages[3]*2000, hourlyWages[4]*2000,
                            hourlyWages[5]*2000, hourlyWages[6]*2000, hourlyWages[7]*2000, hourlyWages[8]*2000, hourlyWages[9]*2000, };
int lineNumber = 1;

for (int z = 0; z < 10; z++)
{
    for (int x = 0; x < 10; x++)
    {
        for (int y = 0; y < 10; y++)
        {
            Console.WriteLine($"{lineNumber++}: {firstNames[z]} {middleNames[x]} {lastNames[y]} | {jobs[^(x + 1)]} | Hourly Pay: {hourlyWages[y]} | {salarys[y]}");
        }
    }
}