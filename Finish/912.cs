public class Solution {
    public void MergeSort(int[] inputs)
        {
            Divide(inputs, 0, inputs.Length - 1);
        }
        public void Divide(int[] inputs, int start, int end)
        {
            if (start == end) return;

            Divide(inputs, start, (start + end) / 2);
            Divide(inputs, (start + end) / 2 + 1, end);
            Merge(inputs, start, (start + end) / 2, end);
        }
        public void Merge(int[] inputs, int Start, int Mid, int End)
        {
            int[] left = inputs.Skip(Start).Take(Mid - Start + 1).ToArray();
            int leftIndex = 0;

            int[] right = inputs.Skip(Mid + 1).Take(End - Mid).ToArray();
            int rightIndex = 0;

            int index;
            for (index = Start; leftIndex < left.Length && rightIndex < right.Length; index++)
            {

                if (left[leftIndex] <= right[rightIndex])
                {
                    inputs[index] = left[leftIndex];
                    leftIndex++;
                }
                else if (left[leftIndex] > right[rightIndex])
                {
                    inputs[index] = right[rightIndex];
                    rightIndex++;
                }
            }
            while (leftIndex < left.Length)
            {
                inputs[index] = left[leftIndex];
                leftIndex++;
                index++;
            }
            while (rightIndex < right.Length)
            {
                inputs[index] = right[rightIndex];
                rightIndex++;
                index++;
            }
            //output(inputs);
        }
    public int[] SortArray(int[] nums) {
        MergeSort(nums);
        return nums;
    }
}

public class Solution {
    public void QuickSort(int[] inputs, int left, int right)
        {
            if (left >= right)
                return;

            int index_first = left;
            int index_last = right;

            while (index_last > index_first)
            {
                while (inputs[index_last] >= inputs[left] && index_last > index_first)
                {
                    index_last--;
                }
                while (inputs[index_first] <= inputs[left] && index_last > index_first)
                {
                    index_first++;
                }
                
                (inputs[index_last], inputs[index_first]) = (inputs[index_first], inputs[index_last]);
            }
            //if (inputs[index_first] < inputs[left])
                (inputs[index_first], inputs[left]) = (inputs[left], inputs[index_first]);

            QuickSort(inputs, left, index_first - 1);
            QuickSort(inputs, index_first + 1, right);
        }
    public int[] SortArray(int[] nums) {
        QuickSort(nums,0,nums.Length-1);
        return nums;
    }
}

public class Solution {
    public int[] SortArray(int[] nums) {
        int[] posiarr = new int[50001];
        int[] netarr = new int[50001];
        int[] result = new int[nums.Length];
        foreach(var num in nums)
        {
            if(num>-1)
                posiarr[num]++;
            else
                netarr[-1*num]++;
        }
        int resultindex= 0;
        
        for(int i=50000;i>0;i--)
        {
            if(netarr[i]>0){
                netarr[i]--;
                result[resultindex]=-1*i;
                resultindex++;
                i++;
            }
        }
        
        for(int i = 0;i<50001;i++)
        {
            if(posiarr[i]>0){
                posiarr[i]--;
                result[resultindex]=i;
                resultindex++;
                i--;
            }
        }
        return result;
    }
}