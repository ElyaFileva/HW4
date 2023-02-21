Console.Clear();
int[] array = new int[8];
PrintArray(array);
void PrintArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while (index < length)
  {
    collection[index] = new Random().Next(1, 100);
    Console.Write(collection[index] + " ");
    index++;
  }
}