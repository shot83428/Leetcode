public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if(flowerbed.Count()==1)
        {
            if(flowerbed[0]==0&&n==1){
                return true;
            }else{
                if(n==0)
                    return true;
                return false;
            }
        }
        
        
        if (flowerbed[0] == 0 && flowerbed[1] == 0)
        {
            n--;
            flowerbed[0] = 1;
        }
        for (int index = 1; index < flowerbed.Length-1; index++)
        {
            if (flowerbed[index]==0&& flowerbed[index-1] == 0 && flowerbed[index+1] == 0 )
            {
                flowerbed[index] = 1;
                n--;
            }
        }
        if (flowerbed[flowerbed.Length-1] == 0 && flowerbed[flowerbed.Length-2] == 0)
        {
            n--;
            flowerbed[0] = 1;
        }
        if (n < 1)
        {
            return true;
        }
        return false;
    }
}