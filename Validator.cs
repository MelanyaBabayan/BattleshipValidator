namespace Solution {
    using System;
    public class BattleshipField {
    public static bool ValidateBattlefield(int[,] field){
        int battleship=0,cruiser=0,destroyer=0,submarine=0;
        for(int i=0;i<10;i++){
           for(int j=0;j<10;j++){  
                int len=0,c1=0,c2=0;
                int k=i,m=j;
                    if(field[k,m]==1){
                      if((k+1)>=0&&(m+1)<=9&&(k+1)<=9&&(m+1)>=0){
                            if(field[k+1,m+1]==5){
                            return false;
                            }
                        }
                      if((k+1)>=0&&(m-1)<=9&&(k+1)<=9&&(m-1)>=0){
                            if(field[k+1,m-1]==5){
                            return false;
                            }
                        }
                      if((k-1)>=0&&(m+1)<=9&&(k-1)<=9&&(m+1)>=0){
                            if(field[k-1,m+1]==5){
                            return false;
                            }
                        }
                      if((k-1)>=0&&(m-1)<=9&&(k-1)<=9&&(m-1)>=0){
                            if(field[k-1,m-1]==5){
                            return false;
                            }
                        }
                        if((k+1)>=0&&(k+1)<=9){
                            if(field[k+1,m]==5){
                            return false;
                            }
                        }
                        if((k-1)>=0&&(k-1)<=9){
                            if(field[k-1,m]==5){
                            return false;
                            }
                        }
                        if((m+1)>=0&&(m+1)<=9){
                            if(field[k,m+1]==5){
                            return false;
                            }
                        }
                        if((m-1)>=0&&(m-1)<=9){
                            if(field[k,m-1]==5){
                            return false;
                            }
                        }
                        len++;
                        field[k,m]=5;
                        while(k<9&&field[k+1,m]==1){
                            len++;
                            k++;
                            field[k,m]=5;
                            c1++;
                        }
                        while(m<9&&field[k,m+1]==1){
                            if(c1!=0){
                            return false;
                            }
                            len++;
                            m++;
                            field[k,m]=5;
                            c2++;
                        }
                        if(c1>0&&c2>0){
                            return false;
                        }
                        switch(len){
                            case 1:submarine++;break;
                            case 2:destroyer++;break;
                            case 3:cruiser++;break;
                            case 4:battleship++;break;
                            default:return false;
                        }
                    }
           }
        }
        return (submarine==4&&destroyer==3&&cruiser==2&&battleship==1);
    }
      }
}