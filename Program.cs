using sokning;

void Main(){
    List<Person> personlista = new List<Person>();
    personlista.Add(new Person(1, "Darth Vader"));
    personlista.Add(new Person(30, "Luke Skykalker"));
    personlista.Add(new Person(42, "Han Solo"));
    personlista.Add(new Person(55, "Leia Organa"));
    personlista.Add(new Person(73, "Lando Calrissian"));
    personlista.Add(new Person(94, "C3P0"));
    personlista.Add(new Person(100, "R2D2"));

    Console.WriteLine("Ange personnummer att söka efter: ");
    int nyckel = Convert.ToInt32(Console.ReadLine());
    int index = BinSearch(personlista, nyckel);
    if (index != -1) {
        Console.WriteLine(personlista[index].Namn);
    } else {
        Console.WriteLine("Personen finns inte i listan");
    }
}

int LinSearch(List<Person> pl, int key){
    for(int i = 0; i < pl.Count; i++){
        if (key == pl[i].Personnr){
            return i;
        }
    }
    return -1;
}

int BinSearch(List<Person> pl, int key) {
    int l = 0;
    int mid;
    int r = pl.Count - 1;
    while (l <= r) {
        mid = (l+r)/2;
        if (key > pl[mid].Personnr){
            l = mid+1;
        } else if (key < pl[mid].Personnr){
            r = mid-1;
        } else {
            return mid;
        }
    }
    return -1;
}
static void bubbleSort(int[] arr, int n){
    int i, j, temp;
    bool swapped;
    for (i = 0; i < n - 1; i++) {
        swapped = false;
        for (j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                swapped = true;
            }
        }

        if (swapped == false)
            break;
    }
}

Main();