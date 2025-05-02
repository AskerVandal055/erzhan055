using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace real_estate
{
class Cinematography
public string director; public string title; public string studio; public int year;
public Cinematography(string Director, string Title, string Studio, int Year)
this.director = Director;
this.title = Title;
this.studio = Studio;
this.year = Year
static void Main(string] args)
{
Cinematography Movie1 = new Cinematography("Favreau", "Ironman", "Marvel Studio", 2008);
Cinematography Movie2 = new Cinematography("Letterier", "The Incredible Hulk", "Marvel Studio", 2008);
Cinematography Movie = new Cinematography("Favreau", "Iron man2", "Marvel Studio", 2010);
Cinematography Movie4 = new Cinematography("Branagh", "Thor", "Marvel Studio", 1899);
Console.WriteLine(Movie director + " " + Movie.title + " " + Movie.studio + " " + Movie.year);
Console.WriteLine(Movie2 director + " " + Movie2.title + " " + Movie studio + " " + Movie.year);
Console.WriteLine(Movie director + " " + Movie.title + " " + Movie.studio + " " + Movie3.year);
Console WriteLine(Movie4.director+" " + Movie.title +" " + Movie studio +""+ Movie4.year);
Console.ReadLine);