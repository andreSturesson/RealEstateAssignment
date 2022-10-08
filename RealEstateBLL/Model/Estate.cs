using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace RealEstateBLL.Model;

[Serializable]
public abstract class Estate : IEstate
{
    private String id;
    private Address address;
    private int size;
    private LegalForm legalForm;
    private string img;

    public Estate()
    {
        this.id = Guid.NewGuid().ToString();
    }

    public Estate(Address address, int size, LegalForm legalForm, string img)
    {
        this.id = Guid.NewGuid().ToString();
        this.address = address;
        this.size = size;
        this.legalForm = legalForm;
        this.img = img;
    }

    public String Id
    {
        get { return id; }
        set { id = value; }
    }
    public Address Address
    {
        get { return address; }
        set { address = value; }
    }
    public int Size
    {
        get { return size; }
        set { size = value; }
    }
    public LegalForm LegalForm
    {
        get { return legalForm; }
        set { legalForm = value; }
    }
    public string Img
    {
        get { return img; }
        set { img = value; }
    }

    public abstract string getObjectType();

    public abstract void Change(Estate estate); // create abstract method

    public virtual string toString()
    {
        String str = "";

        str += " " + this.Address.Street;
        str += " " + this.Address.City;
        str += "                                             " +
            "                                                        " +
            "                                                        " +
            "                                                        " +
            "                                                        " +
            this.Id.ToString();
        return str;
    }

}
