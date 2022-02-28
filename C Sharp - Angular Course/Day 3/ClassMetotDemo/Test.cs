using System;
public class Test{
    public static void Main(String[] args) {
        MusteriManager mm = new MusteriManager();

        mm.add(new Musteri(1, "Ali", "Dogan"));
        mm.add(new Musteri(2, "Veli", "Son"));
        mm.add(new Musteri(3, "Ahmet", "Dinler"));
        mm.add(new Musteri(4, "Mehmet", "Kara"));

        mm.list();

        mm.remove(3);
    }
}