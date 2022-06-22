import System;

public class Matrix
{
    int[,] matrix;
    int size = 0;

    public Matrix(int size){
        matrix = new int[size,size];
        for (int y = 0; y < size; y++){
            for (int x = 0; x < size; x++){
                matrix[y,x] = 0;
            }
        }
        this.size = size;
    }      

    public void SetNum(int row, int column, int num){
        matrix[row,column] = num;
    }

    public int GetNum(int row, int column){
        return matrix[row, column];
    }

    public void SetMatrix(int[,] newM)
        matrix = newM;
    }

    public int[,] GetMatrix(){
        return matrix;
    }
    public int GetSize(){
        return size;
    }

    public Matrix Multiply(Matrix m){

        //return matrix
        Matrix rM = new Matrix(size);

        for (int y = 0; y < size; y++){
            for (int x = 0; x < size; x++){
                if (matrix[y,x] == 1){
                    for (int i = 0; i < size; i++){
                        if (m.GetNum(x,i) == 1){
                            rM.SetNum(y,i,1);
                        }//scan at the row in second matrix 
                    }//i - loop
                }//initial scan of row in matrix for ones
            }//y - for
        }//x - for
        return rM;


    }// Multiply

    public override String ToString(){
        String rS = "";
        for (int x = 0; x<size; x++){
            for (int y = 0; y<size; y++){
                rS += matrix[x,y] + " ";
            }
            rS += "\n";
        }
        return rS;
    }
}