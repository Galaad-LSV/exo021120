using System;

public class Intervention
{
    #region attributs
    private static List<Intervention> collInterventions = new List<Intervention>();

    private float dureePrevue;
	private float dureeReelle;
	private string description;

    /*
     * Le statut peut-être :
     * 
     * N (Non affectée)
     * A (Affectée à la tournée)
     * E (En cours d'intervention)
     * T (Terminée)
     * 
     * */     
	private string statut;
	private Panne laPanne;

    #endregion

    #region constructeurs
    public Intervention(float dureePrevue, string description, Panne unePanne)
    {
        this.dureePrevue = dureePrevue;
        this.description = description;
        this.laPanne = unePanne;
        this.dureeReelle = 0;
        this.statut = "N";
        collInterventions.Add(this);
    }
    #endregion

    #region getters/setters
    public static List<Intervention> CollInterventions { get => collInterventions; set => collInterventions = value; }
    public float DureePrevue { get => dureePrevue; set => dureePrevue = value; }
    public float DureeReelle { get => dureeReelle; set => dureeReelle = value; }
    public string Description { get => description; set => description = value; }
    public string Statut { get => statut; set => statut = value; }
    public Panne LaPanne { get => laPanne; set => laPanne = value; }
    #endregion

    #region methodes

    /*
     * Les méthodes getStatut(), setStatut() et getLaPanne() 
     * sont juste des getters/setters présent ci-dessus
     * 
     */

    #endregion
}
