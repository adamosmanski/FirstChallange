/*
 * Mikołaj musi odwiedzić 3 miasta o współrzędnych (1,1), (4,5), (11,5) w podanej kolejności.
 * Mikołaj startuje z punktu(1,1) spod stacji paliw ;)
 * Na 10 jednostek odległości jego sanie zużywają 20 litrów magicznego paliwa.
 * 
 * 
 * Ile paliwa potrzebuje na całą trasę? Do policzenia przygotuj odpowiedni kod.
 * Obliczony wynik wypisz na ekranie.
 *
 * Oblicz w kodzie dystans miedzy miastami, a nastepnie policz niezbedną ilosc paliwa.
 * Do obliczenia dystansu przygotuj odpowiednią funkcję.
 * Do obliczeń matematycznych użyj funkcji z biblioteki Twojego jezyka.
 */
double firstCityX = 1;
double firstCityY = 1;
double secondCityX = 4;
double secondCityY = 5;
double thirdCityX = 11;
double thirdCityY = 5;
double DistanceBetweenFirstAndSecond = DistanceBetweenCities(firstCityX, firstCityY, secondCityX, secondCityY);
double DistanceBetweenSecondAndThird = DistanceBetweenCities(secondCityX, secondCityY, thirdCityX, thirdCityY);

double FullDistance = DistanceBetweenFirstAndSecond + DistanceBetweenSecondAndThird;
double NeededPetrol = FullDistance / 10;
Console.WriteLine($"Needed petrol: {NeededPetrol}");

static double DistanceBetweenCities(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
