using System;
using System.Collections.Generic;
using System.Linq;

namespace BugSpark
{
    public class Algorithms
    {
        public int LongestMountain(int[] A) {
            var len = A.Length;
            var increase = new int[len];
            var decrease = new int[len];

            for(int i=1;i<len;i++){
                if(A[i] > A[i-1])
                    increase[i] = increase[i-1] + 1;
            }

            for(int i=len-2;i>=0;i--){
                if(A[i] > A[i+1])
                    decrease[i] = decrease[i+1] + 1;
            }

            var ans = 0;
            for(int i=0;i<len;i++){
                if(increase[i] > 0 && decrease[i] > 0)
                    ans = Math.Max(ans, increase[i] + decrease[i] + 1);
            }

            return ans >=3 ? ans : 0;
        }
        
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var set = new HashSet<string>(wordList);
            if (!set.Contains(endWord)) return 0;
            var q = new Queue<string>();
            q.Enqueue(beginWord);
            var step = 0;
            while (q.Count() > 0)
            {
                step++;
                var cnt = q.Count();
                for (int i = 0; i < cnt; i++)
                {
                    var w = q.Dequeue();
                    var chArr = w.ToCharArray();
                    for (int j = 0; j < w.Length; j++)
                    {
                        var w_c = w[j];
                        for (var c = 'a'; c <= 'z'; c++)
                        {
                            if (c == w_c) continue;
                            chArr[j] = c;
                            var tmp_s = new string(chArr);
                            if (!set.Contains(tmp_s)) continue;
                            if (endWord.Equals(tmp_s)) return step + 1;
                            set.Remove(tmp_s);
                            q.Enqueue(tmp_s);
                        }

                        chArr[j] = w[j];
                    }
                }
            }

            return 0;
        }
    }
}