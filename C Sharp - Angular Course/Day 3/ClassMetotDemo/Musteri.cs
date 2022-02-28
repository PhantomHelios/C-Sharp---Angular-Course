public class Musteri{
    private int id;
    private string name, surname;

    public Musteri(int id, string name, string surname){
        this.id = id;
        this.name = name;
        this.surname = surname;
    }

    public int getID(){
        return id;
    }

    public string getName(){
        return name;
    }

    public string getSurname(){
        return surname;
    }
}