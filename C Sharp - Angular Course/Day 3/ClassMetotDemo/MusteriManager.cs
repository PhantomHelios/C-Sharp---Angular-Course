using System;
using System.Collections.Generic;
public class MusteriManager{
    private List<Musteri> musteriler;

    public MusteriManager(){
        musteriler = new List<Musteri>();
    }

    public void add(Musteri musteri){
        musteriler.Add(musteri);
        Console.WriteLine("Musteri eklendi.");
    }

    public void list(){
        Console.WriteLine(">>>Musteriler:");
        
        foreach (Musteri m in musteriler)
            Console.WriteLine(m.getName() + " " + m.getSurname());
    }

    public void remove(int id){
        Musteri toDelete = null;
        foreach (Musteri m in musteriler){
            if (m.getID() == id){
                toDelete = m;
                break;
            }
        }

        if(toDelete != null){
            musteriler.Remove(toDelete);
            Console.WriteLine("\nMusteri silindi.");
            return;
        }

        Console.WriteLine("\nMusteri bulunamadi...");
    }
}