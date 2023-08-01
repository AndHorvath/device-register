using DeviceRegister;

List<Device> devices = new() {
    new Desktop(2023, 30, 10, 40)
    {
        Capacity = 512,
        CPUType = "octa-core"
    },
    new Laptop(2022, 15.6, 2.3)
    {
        Capacity = 256,
        CPUType = "quad-core"
    }
};
foreach (Device device in devices)
{
    Console.WriteLine(device);
}