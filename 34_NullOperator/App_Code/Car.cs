using System;

public class Car
{
    public string MakeModel { get; set; }
    public string PreviousOwner { get; set; }
    
    public Car(string makeModel, string previousOwner)
    {
        MakeModel = makeModel;
        PreviousOwner = previousOwner;
    }
}