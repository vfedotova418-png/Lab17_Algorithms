int[] array = [5, 4, 5, 3, 4];
int max = array[0];
for (int i = 0; i <5; i++) {
    if (array[i] > max) {
        max = array[i];
    }
}
Console.WriteLine($"{max}");