/*
 * Developer: Ayana Aiken
 * Date: November 30, 2025
 * Assignment: SDC320 Course Project – Class Implementation
 * Description:
 *   Car class implementing the Vehicle interface. Supports polymorphism
 *   and stores basic running/driving behavior.
 */

public class Car : IVehicle
{
    public string m_make { get; set; }
    public string m_model { get; set; }
    public bool m_running { get; set; }
    public string m_destination { get; set; }
    
    public int Year { get; set; }
    public string Engine { get; set; }

    public Car(string make, string model, int year, string engine)
    {
        m_make = make;
        m_model = model;
        Year = year;
        Engine = engine;
        m_running = false;
        m_destination = "Nowhere yet";
    }

    public string GetMake() => m_make;
    public string GetModel() => m_model;

    public void Start() => m_running = true;
    public void Stop() => m_running = false;

    public void Drive(string destination)
    {
        m_destination = destination;
        m_running = true;
    }

    public override string ToString()
    {
        string runningStatus = m_running ? "running" : "not running";

        return $"Vehicle Type: Car\n" +
               $"Make: {m_make}\n" +
               $"Model: {m_model}\n" +
               $"Year: {Year}\n" +
               $"Engine: {Engine}\n" +
               $"The car is {runningStatus} and heading to {m_destination}.";
    }
}
