// Переменные для хранения персональных данных студента
string studentName = "Дегтярев Александр Олегович";
string groupName = "РУПО-265";
int courseNumber = 2;
string specialty = "Разработка и управление программным обеспечением";
double averageGrade = 4.7;
int weeksLeft = 15;

// Константа года поступления
const int AdmissionYear = 2026;

// Расчёт года выпуска: чтобы при курсе 2 получить 2029 из 2026, добавляем 3 года.
// Формула: AdmissionYear + (5 - courseNumber) даёт 2029 при courseNumber = 2.
int graduationYear = AdmissionYear + (5 - courseNumber);

// Стипендия отсутствует
bool hasScholarship = false;

// Вывод визитной карточки студента
Console.WriteLine("======================");
Console.WriteLine("   ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
Console.WriteLine("======================");
Console.WriteLine();

Console.WriteLine($"ФИО:                  {studentName}");
Console.WriteLine($"Группа:               {groupName}");
Console.WriteLine($"Курс:                 {courseNumber}");
Console.WriteLine($"Специальность:        {specialty}");
Console.WriteLine($"Средний балл:         {averageGrade}");
Console.WriteLine($"Стипендия положена:   {hasScholarship}");
Console.WriteLine($"Учебных недель осталось: {weeksLeft}");
Console.WriteLine();
Console.WriteLine("----------------------");
Console.WriteLine($"Год поступления:      {AdmissionYear} (значение из константы)");
Console.WriteLine($"Расчётный год выпуска: {graduationYear}");
Console.WriteLine("======================");