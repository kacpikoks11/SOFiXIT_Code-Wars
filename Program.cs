class Solution{

    static int Main(){
        Console.WriteLine(Material(new int[]{6, 4, 2, 0, 3, 2, 0, 3, 1, 4, 5, 3, 2, 7, 5, 3, 0, 1, 2, 1, 3, 4, 6, 8, 1, 3}));
        Console.WriteLine(Material(new int[]{6, 2, 1, 1, 8, 0, 5, 5, 0, 1, 8, 9, 6, 9, 4, 8, 0, 0}));
        Console.WriteLine(Material(new int[]{1,0,2,1,0,1,3,2,1,2,1}));
        Console.WriteLine(Material(new int[]{4,2,0,3,2,5}));
        Console.WriteLine(Material(new int[]{1,0,2,1,0,3,1,0,1,2}));

        return 0;
    }

    static int Material(int[] spaceship){
        int sum = 0;
        int space = 0;
        for(int i = 0; i < spaceship.Count(); ++i){
            int h = spaceship[i];
            do{
                space = 0;
                for(int j = i + 1; j < spaceship.Count(); ++j){ 
                    if(h <= spaceship[j]){
                        space += h * (j - i - 1);
                        i = j - 1;
                        break;
                    }
                    space -= spaceship[j];
                }
                h--;
            }
            while(space < 0);
            sum += space;
        }
        return sum;
    }
}