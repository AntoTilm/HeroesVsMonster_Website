using Exo_Linq_Context;

Console.WriteLine("Exercice Linq");
Console.WriteLine("*************");

DataContext context = new DataContext();

#region 1.Select

#region Exercice 1.1
// Ecrire une requête pour présenter, pour chaque étudiant, le nom de l’étudiant, la date de naissance, le login et le résultat pour l’année de l’ensemble des étudiants.
//var StudentInfos1 = context.Students.Select(s => new { FullName = s.First_Name + " " + s.Last_Name, BirthDate = s.BirthDate.ToShortDateString(), s.Login, s.Year_Result });

//var StudentInfos1 = from s in context.Students
//                    select new { FullName = s.First_Name + " " + s.Last_Name, BirthDate = s.BirthDate.ToShortDateString(), s.Login, s.Year_Result };

//foreach(var studentInfo in StudentInfos1)
//{
//    Console.WriteLine($"{studentInfo.FullName} - {studentInfo.BirthDate} - {studentInfo.Login} - {studentInfo.Year_Result} ");
//}

#endregion

#region Exercice 1.2
// Ecrire une requête pour présenter, pour chaque étudiant, son nom complet (nom et prénom séparés par un espace), son id et sa date de naissance.
//var StudentInfos2 = context.Students.Select(s => new { FullName = s.First_Name + " " + s.Last_Name, Id = s.Student_ID, BirthDate = s.BirthDate.ToShortDateString() });

//var StudentInfos2 = from s in context.Students
//                    select new { FullName = s.First_Name + " " + s.Last_Name, Id = s.Student_ID, BirthDate = s.BirthDate.ToShortDateString() };


//foreach (var studentInfo in StudentInfos2)
//{
//    Console.WriteLine($"{studentInfo.Id} - {studentInfo.FullName} - {studentInfo.BirthDate} ");
//}

#endregion

#region Exercice 1.3 
// Ecrire une requête pour présenter, pour chaque étudiant, dans une seule chaine de caractère l’ensemble des données relatives à un étudiant séparées par le symbole |.

//IEnumerable<string> StudentInfoString = context.Students.Select(s => $"{s.Section_ID} | {s.First_Name} | {s.Last_Name} | {s.Login} | {s.Section_ID} | {s.BirthDate} | {s.Year_Result} | {s.Course_ID} |");

//IEnumerable<string> StudentInfoString = from s in context.Students
//                                        select $"{s.Section_ID} | {s.First_Name} | {s.Last_Name} | {s.Login} | {s.Section_ID} | {s.BirthDate} | {s.Year_Result} | {s.Course_ID} |";


//foreach (string studentInfo in StudentInfoString)
//{
//    Console.WriteLine(studentInfo);
//}

#endregion

#endregion

#region 2.Where & OrderBy

#region Exercice 2.1 
// Pour chaque étudiant né avant 1955, donner le nom, le résultat annuel et le statut. Le statut prend la valeur « OK » si l’étudiant à obtenu au moins 12 comme résultat annuel et « KO » dans le cas contraire.
//var StudentStatus = context.Students
//                        .Where(s => s.BirthDate.Year < 1955)
//                        .Select(s => new
//                        {
//                            s.Last_Name,
//                            s.Year_Result,
//                            Status = s.Year_Result >= 12 ? "OK" : "KO"
//                        });

//var StudentStatus = from s in context.Students
//                    where s.BirthDate.Year < 1955
//                    select new
//                    {
//                        s.Last_Name,
//                        s.Year_Result,
//                        Status = s.Year_Result >= 12 ? "OK" : "KO"
//                    };

//foreach (var student in StudentStatus)
//{
//    Console.WriteLine(student);
//}

#endregion

#region Exercice 2.2 
// Donner pour chaque étudiant entre 1955 et 1965 le nom, le résultat annuel et la catégorie à laquelle il appartient. La catégorie est fonction du résultat annuel obtenu ; un résultat inférieur à 10 appartient à la catégorie « inférieure », un résultat égal à 10 appartient à la catégorie « neutre », un résultat autre appartient à la catégorie « supérieure ».

//var StudentCategory = context.Students
//                        .Where(s => s.BirthDate.Year > 1955 && s.BirthDate.Year < 1965)
//                        .Select(s => new
//                        {
//                            s.Last_Name,
//                            s.Year_Result,
//                            Category = s.Year_Result < 10 ? "Inférieure" : s.Year_Result == 10 ? "Neutre" : "Supérieure"
//                        });

//foreach(var student in StudentCategory)
//{
//    Console.WriteLine(student);
//}

#endregion

#region Exercice 2.3
// Ecrire une requête pour présenter le nom, l’id de section et de tous les étudiants qui ont un nom de famille qui termine par r.
//var NameSectionId = context.Students
//                        .Where(s => s.Last_Name.EndsWith('r'))
//                        .Select(s => new { s.Last_Name, s.Section_ID });

//foreach (var student in NameSectionId)
//{
//    Console.WriteLine(student);
//}

#endregion

#region Exercice 2.4 
// Ecrire une requête pour présenter le nom et le résultat annuel classé par résultats annuels décroissant de tous les étudiants qui ont obtenu un résultat annuel inférieur ou égal à 3.
//var StudentResult = context.Students
//                    .Where(s => s.Year_Result <= 3)
//                    .OrderByDescending(s => s.Year_Result)
//                    .Select(s => new { s.Last_Name, s.Year_Result });

//var StudentResult = from s in context.Students
//                    where s.Year_Result <= 3
//                    orderby s.Year_Result descending
//                    select new { s.Last_Name, s.Year_Result };

//foreach (var student in StudentResult)
//{
//    Console.WriteLine(student);
//}

#endregion

#region Exercice 2.5 
// Ecrire une requête pour présenter le nom complet (nom et prénom séparés par un espace) et le résultat annuel classé par nom croissant sur le nom de tous les étudiants appartenant à la section 1110.
//var FullNameResultat1110 = context.Students
//                            .Where(s => s.Section_ID == 1110)
//                            .OrderBy(s => s.Last_Name)
//                            .Select(s => new { FullName = s.Last_Name + " " + s.First_Name, s.Year_Result });

//foreach(var student in FullNameResultat1110)
//{
//    Console.WriteLine(student);
//}

#endregion

#region Exercice 2.6
// Ecrire une requête pour présenter le nom, l’id de section et le résultat annuel classé par ordre croissant sur la section de tous les étudiants appartenant aux sections 1010 et 1020 ayant un résultat annuel qui n’est pas compris entre 12 et 18.
//var NameSectionYearResult = context.Students
//                            .Where( s => new int[]{ 1010, 1020}.Contains(s.Section_ID) /*(s.Section_ID == 1010 || s.Section_ID == 1020)*/
//                            && ( s.Year_Result < 12 || s.Year_Result > 18  ))
//                            .OrderBy(s => s.Section_ID)
//                            .Select(s => new { s.Last_Name, s.Section_ID, s.Year_Result });

//foreach(var student in NameSectionYearResult)
//{
//    Console.WriteLine(student);
//}

#endregion

#region Exercice 2.7 
// Ecrire une requête pour présenter le nom, l’id de section et le résultat annuel sur 100 (nommer la colonne ‘result_100’) classé par ordre décroissant du résultat de tous les étudiants appartenant aux sections commençant par 13 et ayant un résultat annuel sur 100 inférieur ou égal à 60
var StudentYearResult100 = context.Students
                            /*.Where(s => s.Section_ID.ToString().Substring(0, 2) == "13" && s.Year_Result * 5 <= 60)*/
                            .Where(s => s.Section_ID.ToString().StartsWith("13") && s.Year_Result * 5 <= 60)
                            .OrderByDescending(s => s.Year_Result)
                            .Select(s => new { s.Last_Name, s.Section_ID, Result = s.Year_Result * 5 });

//foreach(var student in StudentYearResult100)
//{
//    Console.WriteLine(student);
//}

#endregion

#endregion

#region 3.Count, Min, Max, Sum & Average

#region Exercice 3.1
// Donner le résultat annuel moyen pour l’ensemble des étudiants.
//double AverageYearResult = context.Students.Average(s => s.Year_Result);
//Console.WriteLine($"La moyenne de l'ensemble des étudiants est de {AverageYearResult}");
#endregion

#region Exercice 3.2
// Donner le plus haut résultat annuel obtenu par un étudiant.
//int MaxYearResult = context.Students.Max(s  => s.Year_Result);
//Console.WriteLine($"Le plus haut résultat annuel est de { MaxYearResult }");
#endregion

#region Exercice 3.3
// Donner la somme des résultats annuels.
//int TotalYearResults = context.Students.Sum(s => s.Year_Result);
//Console.WriteLine($"La somme des résultats annuels est de { TotalYearResults }");
#endregion

#region Exercice 3.4
// Donner le résultat annuel le plus faible.
//int MinYearResult = context.Students.Min(s => s.Year_Result);
//Console.WriteLine($"Le plus bas résultat annuel est de { MinYearResult }");
#endregion

#region Exercice 3.5
// Donner le nombre de lignes qui composent la séquence « Students » ayant obtenu un résultat annuel impair.
//int NbStudentYearResultOdd = context.Students.Count(s => s.Year_Result % 2 == 1);
// Ca fait pareil ↓ en plus décomposé
//int NbStudentYearResultOdd2 = context.Students.Where(s => s.Year_Result % 2 == 1).Count(); 

//Console.WriteLine($"Nombre d'étudiants ayant obtenu un résultat impair : {NbStudentYearResultOdd}");
#endregion

#endregion




#region 4 Opérateurs « GroupBy», « Join» et «GroupJoin»

#region 4.1 Donner pour chaque section, le résultat maximum (« Max_Result ») obtenu par les étudiants.

//var studentMaxResultPerSection = context.Students
//    .GroupBy(s => s.Section_ID)
//    .Select(s => new { SectionId = s.Key, MaxYearResult = s.Max(stu => stu.Year_Result) });

//foreach (var section in studentMaxResultPerSection)
//{
//  Console.WriteLine($"La section {section.SectionId} a pour valeur max {section.MaxYearResult}");
//}

#endregion

#region 4.2 Donner pour toutes les sections commençant par 10, le résultat annuel moyen (« AVGResult ») obtenu par les étudiants

var sectionStart10 = context.Students
    .Where(s => s.Section_ID.ToString().StartsWith("10"))
    .GroupBy(s => s.Section_ID)
    .Select(s => new { SectionId = s.Key, AverageYearResult = s.Average(stu => stu.Year_Result) });

foreach (var section in sectionStart10)
{
  Console.WriteLine($"La section {section.SectionId} a pour valeur moyenne {section.AverageYearResult}");
}


#endregion

#endregion


