using System;
using System.Collections.Generic;

public interface PhoneBook
{
    void PrintInfo();
    void SearchCriteria(string criteria);
}

public class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException(string message) : base(message) { }
}

public class EmptyFieldException : Exception
{
    public EmptyFieldException(string message) : base(message) { }
}

class Persona : PhoneBook
{
    string surname;
    string address;
    string phoneNumber;

    public Persona(string surname, string address, string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(address))
            throw new EmptyFieldException("Прізвище та адреса не можуть бути порожніми.");

        if (!IsValidPhone(phoneNumber))
            throw new InvalidPhoneNumberException("Неправильний формат номера телефону.");

        this.surname = surname;
        this.address = address;
        this.phoneNumber = phoneNumber;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[Persona] Surname: {surname}, Address: {address}, Phone Number: {phoneNumber}");
    }

    public void SearchCriteria(string criteria)
    {
        if (surname.Contains(criteria))
            PrintInfo();
    }

    private bool IsValidPhone(string phone)
    {
        return phone.StartsWith("+") && phone.Length >= 10;
    }
}

class Company : PhoneBook
{
    string name;
    string address;
    string phoneNumber;
    string fax;
    string contactPerson;

    public Company(string name, string address, string phoneNumber, string fax, string contactPerson)
    {
        this.name = name;
        this.address = address;
        this.phoneNumber = phoneNumber;
        this.fax = fax;
        this.contactPerson = contactPerson;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[Company] Name: {name}, Address: {address}, Phone: {phoneNumber}, Fax: {fax}, Contact: {contactPerson}");
    }

    public void SearchCriteria(string criteria)
    {
        if (contactPerson.Contains(criteria))
            PrintInfo();
    }
}

class Friend : PhoneBook
{
    string surname;
    string address;
    string phoneNumber;
    DateTime birthday;

    public Friend(string surname, string address, string phoneNumber, DateTime birthday)
    {
        this.surname = surname;
        this.address = address;
        this.phoneNumber = phoneNumber;
        this.birthday = birthday;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[Friend] Surname: {surname}, Address: {address}, Phone: {phoneNumber}, Birthday: {birthday.ToShortDateString()}");
    }

    public void SearchCriteria(string criteria)
    {
        if (surname.Contains(criteria))
            PrintInfo();
    }
}