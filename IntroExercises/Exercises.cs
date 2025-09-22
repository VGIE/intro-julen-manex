using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroExercises
{
    public static class Exercises
    {
        //TODO #1
        //Find should return the position in array where value appears for the first time. -1 if the value isn't found or the array is empty/null
        public static int Find(int[] array, int value)
        {
            int position = 0;
            while(position < array.length){
                if(array[i] == value){
                    return position
                } else{
                    position++;
                }
            }

            return -1;
        }

        //TODO #2
        //Count should return the number of times value appears in array. 0 if the array is empty/null
        public static int Count(int[] array, int value)
        {
            int count = 0;
            int n = array.length - 1;
            for(int i = 0; i = n; i++){
                if(array.length == 0){
                    return 0;
                }else if(array[i] == value){
                    count++;
                }
            }
            
            return count;
        }

        //TODO #3
        //Find should return the position in array where value appears for the first time between positions [startIndex,endIndex]. -1 if the value isn't found or the array is empty/null
        //-1 if endIndex is less than startIndex or any of them is outside the array
        public static int Find(int[] array, int value, int startIndex, int endIndex)
        {
            if(array.length !=){
                for(int i = startIndex; i = endIndex; i++){
                    if(array[i] == value){
                        return i;
                    }
                }
            }else{
                return -1;
            }
        }

        //TODO #4
        //Count should return the number of times value appears in array between positions [startIndex,endIndex]. 0 if the value isn't found or the array is empty/null
        //0 if endIndex is less than startIndex or any of them is outside the array

        public static int Count(int[] array, int value, int startIndex, int endIndex)
        {
            int count = 0;
            for(int i = startIndex; i = endIndex; i++){
                    if(array[i] == value){
                        count++;
                    }
                }
            if(count == 0){
                return 0;
            }else{
                return count;
            }
        }

        //TODO #5
        //AreEqual should return true if both arrays have the same length and each element appears the same number of times in A and B
        //Examples:
        //  AreEqual(new int[] { 1, 1, 2}, new int[] { 1, 2, 1} => true
        //  AreEqual(new int[] { 1, 1, 2}, new int[] { 1, 2} => false
        //  AreEqual(new int[] { 1, 1, 2}, new int[] { 1, 2, 2} => false
        //  AreEqual(new int[] { 1, 1, 2}, null) => false
        //  AreEqual(null, null) => false
        public static bool AreEqual(int[] A, int[] B)
        {
            if(A.length == B.length){
                
            }else{
                return false;
            }
            
            
            
            
            
            return true;
        }
    }
}
