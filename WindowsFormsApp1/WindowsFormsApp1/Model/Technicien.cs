using System;

public class Technicien
{
    #region attributs
    public static List<Technicien> CollClassStation = new List<Technicien>();
    private int _id;
    private string _nom;
    private string _prenom;
    public List<Tournee> lesTournees;
    #endregion

    #region constructeurs
    public Technicien(int id, string nom, string prenom)
    {
        this._id = id;
        this._nom = nom;
        this._prenom = prenom;
        CollClassStation.Add(this);
    }
    #endregion

    #region getters/setters

    #endregion

    #region methodes
    #endregion


}
