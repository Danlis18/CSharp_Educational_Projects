using _019_UserCollections;
using System.Collections;

UserCollection myCollection = new UserCollection();

foreach (Element item in myCollection)
{
    Console.WriteLine(item);
}

//Як працює foreach під капотом
/*IEnumerator enumerator = myCollection.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
{ 
enumerator.Reset();*/