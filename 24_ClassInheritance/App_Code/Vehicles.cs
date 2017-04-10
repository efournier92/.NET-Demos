using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

/// <summary>
/// Summary description for Vehicles
/// </summary>
public class Vehicle
{
    // instance variables
    public string make;
    public string model;

    public Vehicle(string mk, string mod)
    {
        make = mk;
        model = mod;
    }

    // get vehicle make
    public string GetMake()
    {
        return make;
    }
}

public class Truck : Vehicle
{
    public Truck(string mk, string mod) : base(mk, mod) { }

    public string GetTruckMake()
    {
        return GetMake();
    }
}

public class Sedan : Vehicle
{
    public Sedan(string mk, string mod) : base(mk, mod) { }

    public string GetSedanMake()
    {
        return GetMake();
    }
}
