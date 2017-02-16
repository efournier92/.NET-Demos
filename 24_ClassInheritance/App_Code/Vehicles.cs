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
    private string make;
    private string model;

    protected Vehicle(string mk, string mod)
    {
        make = mk;
        model = mod;
    }

    // get vehicle make
    protected string GetMake()
    {
        return make;
    }
}

