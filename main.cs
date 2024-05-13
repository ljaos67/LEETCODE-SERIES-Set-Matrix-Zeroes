public class Solution {
    public void SetZeroes(int[][] matrix) 
    {
        int n = matrix.Length;
        int m = matrix[0].Length;
        List<int> rows = new List<int>();
        List<int> cols = new List<int>();
        bool addRow = false;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if(matrix[i][j] == 0)
                {
                    cols.Add(j);
                    addRow = true;
                }
            }
            if(addRow)
            {
                rows.Add(i);
                addRow = false;
            }
        }
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if(cols.Contains(j) || rows.Contains(i))
                {
                    matrix[i][j] = 0;
                }
            }
        }   
    }
}
