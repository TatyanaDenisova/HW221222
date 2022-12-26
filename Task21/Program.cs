// Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int getUserValue(string message)
{
    Console.WriteLine(message);
    int resalt = int.Parse(Console.ReadLine()!);
    return resalt;
}

double getDistanceCoordinate (int UserAx, int UserAy, int UserAz, int UserBx, int UserBy, int UserBz)
{
double resalt = Math.Sqrt(Math.Pow((UserAx-UserBx),2)+Math.Pow((UserAy-UserBy),2)+Math.Pow((UserAz-UserBz),2));
return resalt;

}
int UserAx = getUserValue("Введите Ax");
int UserAy = getUserValue("Введите Ay");
int UserAz = getUserValue("Введите Az");
int UserBx = getUserValue("Введите Bx");
int UserBy = getUserValue("Введите By");
int UserBz = getUserValue("Введите Bz");

double distance = getDistanceCoordinate(UserAx, UserAy, UserAz, UserBx, UserBy, UserBz);
Console.WriteLine($"рассотяние между точками {Math.Round(distance,2)}");
