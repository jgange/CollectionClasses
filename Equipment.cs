namespace character;

class Equipment
{
    public string EquipmentName {get; set;}
    public string EquipmentDescription {get; set;}
    public string EquipmentValue {get; set;}

    public Equipment(string name, string description, string value)
    {
        EquipmentName = name;
        EquipmentDescription = description;
        EquipmentValue = value;
    }

}