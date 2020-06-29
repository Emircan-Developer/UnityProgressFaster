public class Build {
    public int IncomePerSecond;
    public int id;
    public int returnCount;
    public Build(int id){
        this.id = id;
        if(this.id == 0){
            returnCount = 3;
            IncomePerSecond = 1;
            
        }
        else{
            returnCount = id * 3;

            IncomePerSecond = id * 5;
        }
    }
}