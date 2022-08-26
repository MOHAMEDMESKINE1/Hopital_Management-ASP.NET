﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hopita_Ibn_Sina_Management
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Gestion_HopitalEntities1 : DbContext
    {
        public Gestion_HopitalEntities1()
            : base("name=Gestion_HopitalEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Ordonnance> Ordonnance { get; set; }
        public virtual DbSet<Ordonnance_Medicament> Ordonnance_Medicament { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Patient_web> Patient_web { get; set; }
        public virtual DbSet<Rendez_vous> Rendez_vous { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Test_Ordonnance> Test_Ordonnance { get; set; }
    
        public virtual ObjectResult<Afficher_Patient_Result> Afficher_Patient()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Afficher_Patient_Result>("Afficher_Patient");
        }
    
        public virtual ObjectResult<Afficher_Rdv_Result> Afficher_Rdv()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Afficher_Rdv_Result>("Afficher_Rdv");
        }
    
        public virtual ObjectResult<AfficherFullName_Doc_Result> AfficherFullName_Doc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AfficherFullName_Doc_Result>("AfficherFullName_Doc");
        }
    
        public virtual int AfficherMedic()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AfficherMedic");
        }
    
        public virtual ObjectResult<AfficherOrdonnanceMedicament_Result> AfficherOrdonnanceMedicament()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AfficherOrdonnanceMedicament_Result>("AfficherOrdonnanceMedicament");
        }
    
        public virtual ObjectResult<AfficherTest_Result> AfficherTest()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AfficherTest_Result>("AfficherTest");
        }
    
        public virtual int Ajouter_Agent(string nom_ag, string prenom_ag, string phone_ag, Nullable<System.DateTime> date_ag, string adresse_ag, string password_ag, byte[] image_ag)
        {
            var nom_agParameter = nom_ag != null ?
                new ObjectParameter("nom_ag", nom_ag) :
                new ObjectParameter("nom_ag", typeof(string));
    
            var prenom_agParameter = prenom_ag != null ?
                new ObjectParameter("prenom_ag", prenom_ag) :
                new ObjectParameter("prenom_ag", typeof(string));
    
            var phone_agParameter = phone_ag != null ?
                new ObjectParameter("phone_ag", phone_ag) :
                new ObjectParameter("phone_ag", typeof(string));
    
            var date_agParameter = date_ag.HasValue ?
                new ObjectParameter("date_ag", date_ag) :
                new ObjectParameter("date_ag", typeof(System.DateTime));
    
            var adresse_agParameter = adresse_ag != null ?
                new ObjectParameter("adresse_ag", adresse_ag) :
                new ObjectParameter("adresse_ag", typeof(string));
    
            var password_agParameter = password_ag != null ?
                new ObjectParameter("password_ag", password_ag) :
                new ObjectParameter("password_ag", typeof(string));
    
            var image_agParameter = image_ag != null ?
                new ObjectParameter("image_ag", image_ag) :
                new ObjectParameter("image_ag", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ajouter_Agent", nom_agParameter, prenom_agParameter, phone_agParameter, date_agParameter, adresse_agParameter, password_agParameter, image_agParameter);
        }
    
        public virtual int Ajouter_Docteur(string nom_doc, string prenom_doc, Nullable<System.DateTime> date_doc, string spec_doc, Nullable<int> expe_doc, string phone_doc, string adresse_doc, string doc_pass, byte[] doc_image)
        {
            var nom_docParameter = nom_doc != null ?
                new ObjectParameter("nom_doc", nom_doc) :
                new ObjectParameter("nom_doc", typeof(string));
    
            var prenom_docParameter = prenom_doc != null ?
                new ObjectParameter("prenom_doc", prenom_doc) :
                new ObjectParameter("prenom_doc", typeof(string));
    
            var date_docParameter = date_doc.HasValue ?
                new ObjectParameter("date_doc", date_doc) :
                new ObjectParameter("date_doc", typeof(System.DateTime));
    
            var spec_docParameter = spec_doc != null ?
                new ObjectParameter("spec_doc", spec_doc) :
                new ObjectParameter("spec_doc", typeof(string));
    
            var expe_docParameter = expe_doc.HasValue ?
                new ObjectParameter("expe_doc", expe_doc) :
                new ObjectParameter("expe_doc", typeof(int));
    
            var phone_docParameter = phone_doc != null ?
                new ObjectParameter("phone_doc", phone_doc) :
                new ObjectParameter("phone_doc", typeof(string));
    
            var adresse_docParameter = adresse_doc != null ?
                new ObjectParameter("adresse_doc", adresse_doc) :
                new ObjectParameter("adresse_doc", typeof(string));
    
            var doc_passParameter = doc_pass != null ?
                new ObjectParameter("doc_pass", doc_pass) :
                new ObjectParameter("doc_pass", typeof(string));
    
            var doc_imageParameter = doc_image != null ?
                new ObjectParameter("doc_image", doc_image) :
                new ObjectParameter("doc_image", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ajouter_Docteur", nom_docParameter, prenom_docParameter, date_docParameter, spec_docParameter, expe_docParameter, phone_docParameter, adresse_docParameter, doc_passParameter, doc_imageParameter);
        }
    
        public virtual int Ajouter_Ord_Medicament(Nullable<int> qte, Nullable<int> nbr_jr, string nom_medic, Nullable<int> ord_num, Nullable<int> id_doc)
        {
            var qteParameter = qte.HasValue ?
                new ObjectParameter("qte", qte) :
                new ObjectParameter("qte", typeof(int));
    
            var nbr_jrParameter = nbr_jr.HasValue ?
                new ObjectParameter("nbr_jr", nbr_jr) :
                new ObjectParameter("nbr_jr", typeof(int));
    
            var nom_medicParameter = nom_medic != null ?
                new ObjectParameter("nom_medic", nom_medic) :
                new ObjectParameter("nom_medic", typeof(string));
    
            var ord_numParameter = ord_num.HasValue ?
                new ObjectParameter("ord_num", ord_num) :
                new ObjectParameter("ord_num", typeof(int));
    
            var id_docParameter = id_doc.HasValue ?
                new ObjectParameter("id_doc", id_doc) :
                new ObjectParameter("id_doc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ajouter_Ord_Medicament", qteParameter, nbr_jrParameter, nom_medicParameter, ord_numParameter, id_docParameter);
        }
    
        public virtual int Ajouter_Patient(string cin_pat, string nom_pat, string prenom_pat, string genre_pat, Nullable<System.DateTime> date_pat, string adresse_pat, string phone_pat, byte[] image_pat, Nullable<int> maladie_pat)
        {
            var cin_patParameter = cin_pat != null ?
                new ObjectParameter("cin_pat", cin_pat) :
                new ObjectParameter("cin_pat", typeof(string));
    
            var nom_patParameter = nom_pat != null ?
                new ObjectParameter("nom_pat", nom_pat) :
                new ObjectParameter("nom_pat", typeof(string));
    
            var prenom_patParameter = prenom_pat != null ?
                new ObjectParameter("prenom_pat", prenom_pat) :
                new ObjectParameter("prenom_pat", typeof(string));
    
            var genre_patParameter = genre_pat != null ?
                new ObjectParameter("genre_pat", genre_pat) :
                new ObjectParameter("genre_pat", typeof(string));
    
            var date_patParameter = date_pat.HasValue ?
                new ObjectParameter("date_pat", date_pat) :
                new ObjectParameter("date_pat", typeof(System.DateTime));
    
            var adresse_patParameter = adresse_pat != null ?
                new ObjectParameter("adresse_pat", adresse_pat) :
                new ObjectParameter("adresse_pat", typeof(string));
    
            var phone_patParameter = phone_pat != null ?
                new ObjectParameter("phone_pat", phone_pat) :
                new ObjectParameter("phone_pat", typeof(string));
    
            var image_patParameter = image_pat != null ?
                new ObjectParameter("image_pat", image_pat) :
                new ObjectParameter("image_pat", typeof(byte[]));
    
            var maladie_patParameter = maladie_pat.HasValue ?
                new ObjectParameter("maladie_pat", maladie_pat) :
                new ObjectParameter("maladie_pat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ajouter_Patient", cin_patParameter, nom_patParameter, prenom_patParameter, genre_patParameter, date_patParameter, adresse_patParameter, phone_patParameter, image_patParameter, maladie_patParameter);
        }
    
        public virtual int Ajouter_Rdv(Nullable<System.DateTime> date_rdv, Nullable<int> heure_rdv, Nullable<int> id_doc, string cin_pat)
        {
            var date_rdvParameter = date_rdv.HasValue ?
                new ObjectParameter("date_rdv", date_rdv) :
                new ObjectParameter("date_rdv", typeof(System.DateTime));
    
            var heure_rdvParameter = heure_rdv.HasValue ?
                new ObjectParameter("heure_rdv", heure_rdv) :
                new ObjectParameter("heure_rdv", typeof(int));
    
            var id_docParameter = id_doc.HasValue ?
                new ObjectParameter("id_doc", id_doc) :
                new ObjectParameter("id_doc", typeof(int));
    
            var cin_patParameter = cin_pat != null ?
                new ObjectParameter("cin_pat", cin_pat) :
                new ObjectParameter("cin_pat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ajouter_Rdv", date_rdvParameter, heure_rdvParameter, id_docParameter, cin_patParameter);
        }
    
        public virtual int ajouter_rePatient_web(string cin, string nom, string prenom, string tele, Nullable<System.DateTime> date_re)
        {
            var cinParameter = cin != null ?
                new ObjectParameter("cin", cin) :
                new ObjectParameter("cin", typeof(string));
    
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var teleParameter = tele != null ?
                new ObjectParameter("tele", tele) :
                new ObjectParameter("tele", typeof(string));
    
            var date_reParameter = date_re.HasValue ?
                new ObjectParameter("date_re", date_re) :
                new ObjectParameter("date_re", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ajouter_rePatient_web", cinParameter, nomParameter, prenomParameter, teleParameter, date_reParameter);
        }
    
        public virtual int AjouterTest(string nom_test, Nullable<int> prix_test, Nullable<int> id_doc)
        {
            var nom_testParameter = nom_test != null ?
                new ObjectParameter("nom_test", nom_test) :
                new ObjectParameter("nom_test", typeof(string));
    
            var prix_testParameter = prix_test.HasValue ?
                new ObjectParameter("prix_test", prix_test) :
                new ObjectParameter("prix_test", typeof(int));
    
            var id_docParameter = id_doc.HasValue ?
                new ObjectParameter("id_doc", id_doc) :
                new ObjectParameter("id_doc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AjouterTest", nom_testParameter, prix_testParameter, id_docParameter);
        }
    
        public virtual int Modifier_Agent(Nullable<int> id_ag, string nom_ag, string prenom_ag, string phone_ag, Nullable<System.DateTime> date_ag, string adresse_ag, string password_ag, byte[] image_ag)
        {
            var id_agParameter = id_ag.HasValue ?
                new ObjectParameter("id_ag", id_ag) :
                new ObjectParameter("id_ag", typeof(int));
    
            var nom_agParameter = nom_ag != null ?
                new ObjectParameter("nom_ag", nom_ag) :
                new ObjectParameter("nom_ag", typeof(string));
    
            var prenom_agParameter = prenom_ag != null ?
                new ObjectParameter("prenom_ag", prenom_ag) :
                new ObjectParameter("prenom_ag", typeof(string));
    
            var phone_agParameter = phone_ag != null ?
                new ObjectParameter("phone_ag", phone_ag) :
                new ObjectParameter("phone_ag", typeof(string));
    
            var date_agParameter = date_ag.HasValue ?
                new ObjectParameter("date_ag", date_ag) :
                new ObjectParameter("date_ag", typeof(System.DateTime));
    
            var adresse_agParameter = adresse_ag != null ?
                new ObjectParameter("adresse_ag", adresse_ag) :
                new ObjectParameter("adresse_ag", typeof(string));
    
            var password_agParameter = password_ag != null ?
                new ObjectParameter("password_ag", password_ag) :
                new ObjectParameter("password_ag", typeof(string));
    
            var image_agParameter = image_ag != null ?
                new ObjectParameter("image_ag", image_ag) :
                new ObjectParameter("image_ag", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Modifier_Agent", id_agParameter, nom_agParameter, prenom_agParameter, phone_agParameter, date_agParameter, adresse_agParameter, password_agParameter, image_agParameter);
        }
    
        public virtual int Modifier_Docteur(Nullable<int> id_doc, string nom_doc, string prenom_doc, Nullable<System.DateTime> date_doc, string spec_doc, Nullable<int> expe_doc, string phone_doc, string adresse_doc, string doc_pass, byte[] image_doc)
        {
            var id_docParameter = id_doc.HasValue ?
                new ObjectParameter("id_doc", id_doc) :
                new ObjectParameter("id_doc", typeof(int));
    
            var nom_docParameter = nom_doc != null ?
                new ObjectParameter("nom_doc", nom_doc) :
                new ObjectParameter("nom_doc", typeof(string));
    
            var prenom_docParameter = prenom_doc != null ?
                new ObjectParameter("prenom_doc", prenom_doc) :
                new ObjectParameter("prenom_doc", typeof(string));
    
            var date_docParameter = date_doc.HasValue ?
                new ObjectParameter("date_doc", date_doc) :
                new ObjectParameter("date_doc", typeof(System.DateTime));
    
            var spec_docParameter = spec_doc != null ?
                new ObjectParameter("spec_doc", spec_doc) :
                new ObjectParameter("spec_doc", typeof(string));
    
            var expe_docParameter = expe_doc.HasValue ?
                new ObjectParameter("expe_doc", expe_doc) :
                new ObjectParameter("expe_doc", typeof(int));
    
            var phone_docParameter = phone_doc != null ?
                new ObjectParameter("phone_doc", phone_doc) :
                new ObjectParameter("phone_doc", typeof(string));
    
            var adresse_docParameter = adresse_doc != null ?
                new ObjectParameter("adresse_doc", adresse_doc) :
                new ObjectParameter("adresse_doc", typeof(string));
    
            var doc_passParameter = doc_pass != null ?
                new ObjectParameter("doc_pass", doc_pass) :
                new ObjectParameter("doc_pass", typeof(string));
    
            var image_docParameter = image_doc != null ?
                new ObjectParameter("image_doc", image_doc) :
                new ObjectParameter("image_doc", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Modifier_Docteur", id_docParameter, nom_docParameter, prenom_docParameter, date_docParameter, spec_docParameter, expe_docParameter, phone_docParameter, adresse_docParameter, doc_passParameter, image_docParameter);
        }
    
        public virtual int Modifier_Patient(string cin_pat, string nom_pat, string prenom_pat, string genre_pat, Nullable<System.DateTime> date_pat, string adresse_pat, string phone_pat, Nullable<int> maladie_pat, byte[] image_pat)
        {
            var cin_patParameter = cin_pat != null ?
                new ObjectParameter("cin_pat", cin_pat) :
                new ObjectParameter("cin_pat", typeof(string));
    
            var nom_patParameter = nom_pat != null ?
                new ObjectParameter("nom_pat", nom_pat) :
                new ObjectParameter("nom_pat", typeof(string));
    
            var prenom_patParameter = prenom_pat != null ?
                new ObjectParameter("prenom_pat", prenom_pat) :
                new ObjectParameter("prenom_pat", typeof(string));
    
            var genre_patParameter = genre_pat != null ?
                new ObjectParameter("genre_pat", genre_pat) :
                new ObjectParameter("genre_pat", typeof(string));
    
            var date_patParameter = date_pat.HasValue ?
                new ObjectParameter("date_pat", date_pat) :
                new ObjectParameter("date_pat", typeof(System.DateTime));
    
            var adresse_patParameter = adresse_pat != null ?
                new ObjectParameter("adresse_pat", adresse_pat) :
                new ObjectParameter("adresse_pat", typeof(string));
    
            var phone_patParameter = phone_pat != null ?
                new ObjectParameter("phone_pat", phone_pat) :
                new ObjectParameter("phone_pat", typeof(string));
    
            var maladie_patParameter = maladie_pat.HasValue ?
                new ObjectParameter("maladie_pat", maladie_pat) :
                new ObjectParameter("maladie_pat", typeof(int));
    
            var image_patParameter = image_pat != null ?
                new ObjectParameter("image_pat", image_pat) :
                new ObjectParameter("image_pat", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Modifier_Patient", cin_patParameter, nom_patParameter, prenom_patParameter, genre_patParameter, date_patParameter, adresse_patParameter, phone_patParameter, maladie_patParameter, image_patParameter);
        }
    
        public virtual int Modifier_Rdv(Nullable<System.DateTime> date_rdv, Nullable<int> heure_rdv, Nullable<int> id_doc, string cin_pat)
        {
            var date_rdvParameter = date_rdv.HasValue ?
                new ObjectParameter("date_rdv", date_rdv) :
                new ObjectParameter("date_rdv", typeof(System.DateTime));
    
            var heure_rdvParameter = heure_rdv.HasValue ?
                new ObjectParameter("heure_rdv", heure_rdv) :
                new ObjectParameter("heure_rdv", typeof(int));
    
            var id_docParameter = id_doc.HasValue ?
                new ObjectParameter("id_doc", id_doc) :
                new ObjectParameter("id_doc", typeof(int));
    
            var cin_patParameter = cin_pat != null ?
                new ObjectParameter("cin_pat", cin_pat) :
                new ObjectParameter("cin_pat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Modifier_Rdv", date_rdvParameter, heure_rdvParameter, id_docParameter, cin_patParameter);
        }
    
        public virtual int ModifierOrd_Medicament(Nullable<int> qte, Nullable<int> nbr_jr, string nom_medic, Nullable<int> ord_num, Nullable<int> id_doc)
        {
            var qteParameter = qte.HasValue ?
                new ObjectParameter("qte", qte) :
                new ObjectParameter("qte", typeof(int));
    
            var nbr_jrParameter = nbr_jr.HasValue ?
                new ObjectParameter("nbr_jr", nbr_jr) :
                new ObjectParameter("nbr_jr", typeof(int));
    
            var nom_medicParameter = nom_medic != null ?
                new ObjectParameter("nom_medic", nom_medic) :
                new ObjectParameter("nom_medic", typeof(string));
    
            var ord_numParameter = ord_num.HasValue ?
                new ObjectParameter("ord_num", ord_num) :
                new ObjectParameter("ord_num", typeof(int));
    
            var id_docParameter = id_doc.HasValue ?
                new ObjectParameter("id_doc", id_doc) :
                new ObjectParameter("id_doc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifierOrd_Medicament", qteParameter, nbr_jrParameter, nom_medicParameter, ord_numParameter, id_docParameter);
        }
    
        public virtual int ModifierTest(string nom_test, Nullable<int> prix_test, Nullable<int> id_doc)
        {
            var nom_testParameter = nom_test != null ?
                new ObjectParameter("nom_test", nom_test) :
                new ObjectParameter("nom_test", typeof(string));
    
            var prix_testParameter = prix_test.HasValue ?
                new ObjectParameter("prix_test", prix_test) :
                new ObjectParameter("prix_test", typeof(int));
    
            var id_docParameter = id_doc.HasValue ?
                new ObjectParameter("id_doc", id_doc) :
                new ObjectParameter("id_doc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifierTest", nom_testParameter, prix_testParameter, id_docParameter);
        }
    
        public virtual ObjectResult<Recherche_Docteur_Result> Recherche_Docteur(string nom_doc)
        {
            var nom_docParameter = nom_doc != null ?
                new ObjectParameter("nom_doc", nom_doc) :
                new ObjectParameter("nom_doc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Recherche_Docteur_Result>("Recherche_Docteur", nom_docParameter);
        }
    
        public virtual ObjectResult<Recherche_Patient_CIN_Result> Recherche_Patient_CIN(string cin_pat)
        {
            var cin_patParameter = cin_pat != null ?
                new ObjectParameter("cin_pat", cin_pat) :
                new ObjectParameter("cin_pat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Recherche_Patient_CIN_Result>("Recherche_Patient_CIN", cin_patParameter);
        }
    
        public virtual ObjectResult<Recherche_Patient_Prenom_Result> Recherche_Patient_Prenom(string nom_pat)
        {
            var nom_patParameter = nom_pat != null ?
                new ObjectParameter("nom_pat", nom_pat) :
                new ObjectParameter("nom_pat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Recherche_Patient_Prenom_Result>("Recherche_Patient_Prenom", nom_patParameter);
        }
    
        public virtual ObjectResult<Recherche_Rdv_Date_Result> Recherche_Rdv_Date(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Recherche_Rdv_Date_Result>("Recherche_Rdv_Date", dateParameter);
        }
    
        public virtual ObjectResult<RechercherNomTest_Result> RechercherNomTest(string nom_test)
        {
            var nom_testParameter = nom_test != null ?
                new ObjectParameter("nom_test", nom_test) :
                new ObjectParameter("nom_test", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RechercherNomTest_Result>("RechercherNomTest", nom_testParameter);
        }
    
        public virtual int RechercherOrd_Medicament_Nom(string nom_medic)
        {
            var nom_medicParameter = nom_medic != null ?
                new ObjectParameter("Nom_medic", nom_medic) :
                new ObjectParameter("Nom_medic", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RechercherOrd_Medicament_Nom", nom_medicParameter);
        }
    
        public virtual ObjectResult<rechercherRdvDoc_CIN_Result> rechercherRdvDoc_CIN(string cin_pat)
        {
            var cin_patParameter = cin_pat != null ?
                new ObjectParameter("cin_pat", cin_pat) :
                new ObjectParameter("cin_pat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rechercherRdvDoc_CIN_Result>("rechercherRdvDoc_CIN", cin_patParameter);
        }
    
        public virtual ObjectResult<RechercherTestDocNom_Result> RechercherTestDocNom(string nom_doc)
        {
            var nom_docParameter = nom_doc != null ?
                new ObjectParameter("nom_doc", nom_doc) :
                new ObjectParameter("nom_doc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RechercherTestDocNom_Result>("RechercherTestDocNom", nom_docParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int Supprimer_Agent(Nullable<int> id_ag)
        {
            var id_agParameter = id_ag.HasValue ?
                new ObjectParameter("id_ag", id_ag) :
                new ObjectParameter("id_ag", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Supprimer_Agent", id_agParameter);
        }
    
        public virtual int Supprimer_Docteur(Nullable<int> id_doc)
        {
            var id_docParameter = id_doc.HasValue ?
                new ObjectParameter("id_doc", id_doc) :
                new ObjectParameter("id_doc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Supprimer_Docteur", id_docParameter);
        }
    
        public virtual int Supprimer_Patient(string cin_pat)
        {
            var cin_patParameter = cin_pat != null ?
                new ObjectParameter("cin_pat", cin_pat) :
                new ObjectParameter("cin_pat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Supprimer_Patient", cin_patParameter);
        }
    
        public virtual int Supprimer_Rdv(string cin_pat)
        {
            var cin_patParameter = cin_pat != null ?
                new ObjectParameter("cin_pat", cin_pat) :
                new ObjectParameter("cin_pat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Supprimer_Rdv", cin_patParameter);
        }
    
        public virtual int SupprimerOrd_Medicament(Nullable<int> id_doc)
        {
            var id_docParameter = id_doc.HasValue ?
                new ObjectParameter("id_doc", id_doc) :
                new ObjectParameter("id_doc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SupprimerOrd_Medicament", id_docParameter);
        }
    
        public virtual int SupprimerTest(Nullable<int> id_doc)
        {
            var id_docParameter = id_doc.HasValue ?
                new ObjectParameter("id_doc", id_doc) :
                new ObjectParameter("id_doc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SupprimerTest", id_docParameter);
        }
    }
}
