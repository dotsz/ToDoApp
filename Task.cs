public class Task {
    public string Name { get; set; }
    public bool isDone { get; set;} = false;
    public static int count {get; private set; }

    public Task(){
        this.Name = "";
        this.isDone = false;
        count++;
    } 

    public Task(string Name): base() {
        this.Name = Name;
    }

    public Task Initialize(string Name = "Task", bool isDone = false){
        this.Name = Name;
        this.isDone = isDone;
        return this;
    }
}

