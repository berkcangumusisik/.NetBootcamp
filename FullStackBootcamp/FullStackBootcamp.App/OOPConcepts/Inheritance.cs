﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App.OOPConcepts.Inheritance
{
    public class Person
{
    protected string X { get; set; }
    public string FirstName { get; set; } = default!;

    string? _lastName;


    public string FullName => $"{FirstName} {_lastName}";
    public int Age { get; set; }

    public string? LastName
    {
        get => _lastName;
        set => _lastName = value!.ToUpper();
    }

    public bool Validate()
    {
        if (LastName.Length > 7)
        {
            //throw new exception
            return false;
        }


        if (Age > 40)
        {
            //throw new exception
            return false;
        }

        return true;
    }
}


public class Teacher : Person
{
    public Teacher()
    {
        var teacher = new Teacher();
        teacher.X = "x";
    }

    public string Type { get; set; } = default!;
}

public class Student : Person
{
}


public class Manager : Teacher
{
    public Manager()
    {
    }
}


internal class PersonService
{
    public void SavePerson(Person person)
    {
        if (!person.Validate())
        {
        }


        //save to database
    }
}
}


/*
 Inheritance (Kalıtım) : Bir class'ın başka bir class'tan özelliklerini almasıdır.
 - Base Class (Ana Sınıf) : Kalıtım veren sınıf.
 - Derived Class (Türetilmiş Sınıf) : Kalıtım alan sınıf.
 
 
internal : Sadece bulunduğu proje içerisinde erişilebilir.
protected : Sadece bulunduğu proje içerisinde ve kalıtım alan sınıflar içerisinde erişilebilir.
 */
