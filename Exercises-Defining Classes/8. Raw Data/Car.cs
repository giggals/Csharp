using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire tire;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    

    public Engine Engine
    {
        get { return this.engine; }
        set { this.engine = value; }
    }
    public Cargo Cargo
    {
        get { return this.cargo; }
        set { this.cargo = value; }
    }
    public Tire Tire
    {
        get { return this.tire; }
        set { this.tire = value; }
    }


    public Car(string model,Engine engine,Cargo cargo,Tire tire)
    {
        this.Model = model;
        this.engine = engine;
        this.cargo= cargo;
        this.tire = tire;
            
    }


}

