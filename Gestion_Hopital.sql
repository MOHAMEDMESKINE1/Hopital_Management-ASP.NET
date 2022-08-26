use Gestion_Hopital
-------------------les procedures stockées Docteur ----------------------
go
--ajouter Dcoteur
alter proc Ajouter_Docteur @nom_doc varchar(30),@prenom_doc varchar(30),@date_doc date, @spec_doc varchar(30),@expe_doc int , @phone_doc varchar(30), @adresse_doc varchar(30),@doc_pass varchar(30),@doc_image image
as begin

	insert into Doctor values( @nom_doc,@prenom_doc,@date_doc,@spec_doc,@expe_doc,@phone_doc,@adresse_doc,@doc_pass,@doc_image)
end

go
--supprimer Docteur

alter proc Supprimer_Docteur @id_doc int
as begin
		
		delete from Doctor where Id_Doc = @id_doc
		
	
end

--modifier Docteur
select * from Doctor
go
alter proc Modifier_Docteur @id_doc int, @nom_doc varchar(30),@prenom_doc varchar(30),@date_doc date, @spec_doc varchar(30),@expe_doc int , @phone_doc varchar(30), @adresse_doc varchar(30),@doc_pass varchar(30),@image_doc image
as begin
	
	update Doctor set  Nom_Doc = @nom_doc , 
					   Prenom_Doc = @prenom_doc ,
					   DateNaissance_Doc = @date_doc,
					   Doc_specialite = @spec_doc,
					   Doc_experience = @expe_doc,
					   Doc_phone   = @phone_doc ,
					   Doc_addr = @adresse_doc ,
					   Doc_pass = @doc_pass,
					   Doc_Image =@image_doc
					   where Id_Doc = @id_doc
end
go
--rechercher Docteur
create proc Recherche_Docteur @nom_doc varchar(30)
as begin

	select * from Doctor where Nom_Doc = @nom_doc
	
end

go
create
---------------------------------------------------------------les procedures stockées patient   --------------------------------------------
--ajouter patient 
create proc Ajouter_Patient  @cin_pat varchar(30),@nom_pat varchar(30),@prenom_pat varchar(30),@genre_pat varchar(30), @date_pat date,@adresse_pat varchar(30),@phone_pat varchar(30),@image_pat image ,@maladie_pat int
as begin

insert into Patient values (@cin_pat,@nom_pat,@prenom_pat,@genre_pat,@date_pat,@adresse_pat,@phone_pat,@image_pat,@maladie_pat)
end
go
--supprimer patient 
create proc Supprimer_Patient @cin_pat varchar(30)
as begin
	delete from Patient where Cin_pat = @cin_pat 
end

go
--modifier patient 
create proc Modifier_Patient   @cin_pat varchar(30),@nom_pat varchar(30),@prenom_pat varchar(30),@genre_pat varchar(30), @date_pat date,@adresse_pat varchar(30),@phone_pat varchar(30), @maladie_pat int,@image_pat image
as begin
	update Patient set 
					   Nom_pat=@nom_pat,
					   Prenom_pat=@prenom_pat,
					   Genre_pat=@genre_pat,
					   DateNaissance_pat=cast(@date_pat as date),
					   Adresse_pat=@adresse_pat,
					   Phone_pat=@phone_pat,
					   Image_pat = @image_pat ,
					   Ord_Num=@maladie_pat
					where Cin_pat =@cin_pat
end
go
--rechercher patient par prenom
alter proc Recherche_Patient_Prenom @nom_pat varchar(30)
as begin
   select p.Cin_pat as 'CIN',p.Nom_pat as 'Nom' ,p.Prenom_pat as 'Prénom' ,p.Genre_pat as 'Genre' ,p.DateNaissance_pat as 'Date Naissance',p.Adresse_pat as 'Adresse',p.Phone_pat as 'Phone',o.Maladie as 'Maladie' from Patient p , Ordonnance o 
	where p.Ord_Num = o.Ord_Num and p.Nom_pat=@nom_pat
end

select * from Test_Ordonnance
go
--rechercher patient par cin
create proc Recherche_Patient_CIN @cin_pat varchar(30)
as begin
   select p.Cin_pat as 'CIN',p.Nom_pat as 'Nom' ,p.Prenom_pat as 'Prénom' ,p.Genre_pat as 'Genre' ,p.DateNaissance_pat as 'Date Naissance',p.Adresse_pat as 'Adresse',p.Phone_pat as 'Phone',o.Maladie as 'Maladie' from Patient p , Ordonnance o 
	where p.Ord_Num = o.Ord_Num and p.Cin_pat=@cin_pat
end

--affichage patient

create proc Afficher_Patient
as begin
	select p.Cin_pat as 'CIN',p.Nom_pat as 'Nom' ,p.Prenom_pat as 'Prénom' ,p.Genre_pat as 'Genre' ,p.DateNaissance_pat as 'Date Naissance',p.Adresse_pat as 'Adresse',p.Phone_pat as 'Phone',p.Image_pat as 'Image' ,o.Maladie as 'Maladie' from Patient p , Ordonnance o 
	where p.Ord_Num = o.Ord_Num
end


----------------------------------les procedures stockées agent Rendez Vous----------------------------------------------------------
--ajouter patient 
go
--ajouter Rendez_vous
create proc Ajouter_Rdv  @date_rdv date,@heure_rdv int,@id_doc int,@cin_pat varchar(30)
as begin
	insert into  Rendez_vous (Date_rdv,Heure_rdv,Id_Doc,Cin_pat) values (@date_rdv,@heure_rdv,@id_doc,@cin_pat)
end

--afficher fullname doctor
go
create proc AfficherFullName_Doc
as begin
select Id_Doc,concat(Nom_Doc,' ',Prenom_Doc) as 'Fullname' from Doctor

end

go
--modifier Rendez_vous
alter proc Modifier_Rdv  @date_rdv date,@heure_rdv int,@id_doc int,@cin_pat varchar(30)
as begin
	update Rendez_vous set Date_rdv=@date_rdv,
						   Heure_rdv=@heure_rdv,
						   @id_doc=@id_doc
						   where Cin_pat=@cin_pat
end


go
--supprimer Rendez_vous
create proc Supprimer_Rdv @cin_pat varchar(30)
as begin
	delete from Rendez_vous where Cin_pat=@cin_pat
end

--rechercher rendez_vous
--create proc Recherche_Rdv  @cin_pat varchar(30)
--as begin 
--	select * from Rendez_vous where Cin_pat=@cin_pat
--end

--Recherche_Rdv_Date
go
alter proc Recherche_Rdv_Date  @date date
as begin 
	select r.Date_rdv as 'Date',r.Heure_rdv as 'Heure',r.Cin_pat as 'Cin_pat',concat(d.Nom_Doc,' ',d.Prenom_Doc) as 'Nom Docteur'
	from Rendez_vous r inner join Doctor d
	on d.Id_Doc=r.Id_Doc where r.Date_rdv=@date
end

--Afficher_Rdv
go
alter proc Afficher_Rdv
as begin
	select r.Date_rdv as 'Date',r.Heure_rdv as 'Heure',r.Cin_pat as 'Cin_pat',concat(d.Nom_Doc,' ',d.Prenom_Doc) as 'Nom Docteur'
	from Rendez_vous r inner join Doctor d
	on d.Id_Doc=r.Id_Doc 
end

go
--rdvdoctor
alter proc rechercherRdvDoc_CIN  @cin_pat varchar(30)
as begin
	select r.Date_rdv as 'Date',r.Heure_rdv as 'Heure',r.Cin_pat as 'Cin_pat',concat(d.Nom_Doc,' ',d.Prenom_Doc) as 'Nom Docteur'
	from Rendez_vous r inner join Doctor d
	on d.Id_Doc=r.Id_Doc where r.Cin_pat=@cin_pat
end
---------------------------------------------------------------------------les procedures stockées patient   --------------------------------------------

select * from patient

create proc Ajouter_Agent @nom_ag varchar(30),@prenom_ag varchar(30),@phone_ag varchar(30),@date_ag date, @adresse_ag varchar(30) ,@password_ag varchar(30),@image_ag image
as begin
	insert into Agent values ( @nom_ag,@prenom_ag,@phone_ag,@date_ag,@adresse_ag,@password_ag,@image_ag)
end

create proc  Supprimer_Agent @id_ag int 
as begin

	delete from Agent where   Id_ag = @id_ag
end

create proc Modifier_Agent @id_ag int, @nom_ag varchar(30),@prenom_ag varchar(30),@phone_ag varchar(30),@date_ag date, @adresse_ag varchar(30) ,@password_ag varchar(30),@image_ag image
as begin
	update Agent set  Nom_ag=@nom_ag,		
					  Prenom_ag=@prenom_ag,
					  Phone_ag=@phone_ag,
					  DateNaissance_ag=@date_ag,
					  Adresse_ag=@adresse_ag,
					  Password_ag=@password_ag,
					  Image_ag=@image_ag

					  where Id_ag=@id_ag

end
select * from agent

-------------Procedures stokées medicament-------------
/*
--Afficher liste Medicament
drop proc AfficherMedicament 
as begin
	select* from Medicament
end
--recherche par id
drop proc RechercheMedicament_ID @id_medic int
as begin
select * from Medicament where Id_medic=@id_medic;
end

--recherche par id
drop proc RechercheMedicament_Nom @Nom_medic varchar(30)
as begin
select * from Medicament where Nom_medic=@Nom_medic;
end

--recherche par id
drop proc RechercheMedicament_Categorie @categorie_medic varchar(30)
as begin
select * from Medicament where Categorie_medic=@categorie_medic;
end
*/

---------- ------------------------------------------------------------------Procedures stokées Ordonnance_medicament-------- ---------------------------------------------------------------
--ajouter foreign key au table ord_medic - doctor
--alter table Ordonnance_Medicament add  id_Doc int foreign key references Doctor 

--AfficherOrdonnanceMedicament
go
alter proc AfficherOrdonnanceMedicament
as begin
	select  o.Maladie as 'Maladie',om.Nom_medic as 'Nom medicament',om.Quantite as 'Quantite',om.NbrJr as 'Nombre Jour' ,concat(d.Nom_Doc,' ',d.Prenom_Doc) as 'Nom Docteur' from Ordonnance_Medicament om,Ordonnance o  ,Doctor d
	where   o.Ord_Num=om.Ord_Num and d.Id_Doc=om.id_Doc
end


go
--RechercherOrd_Medicament_Nom
alter proc RechercherOrd_Medicament_Nom @Nom_medic varchar(30)
as begin
	select  o.Maladie as 'Maladie',om.Nom_Medic as 'Mediament',om.Quantite as 'Quantite',om.NbreJour as 'Nombre Jour' ,d.Nom_Doc as 'Nom Docteur' from Ordonnance_Medicament om,Ordonnance o  ,Doctor d
	where  o.Ord_Num=om.Ord_Num and d.Id_Doc=om.Id_medic and d.Nom_Doc=@Nom_medic
end


go
--ajouter Ordonnance_Medicament
alter proc Ajouter_Ord_Medicament   @qte int,@nbr_jr int,@nom_medic varchar(30),@ord_num int,@id_doc int
as begin
		insert into Ordonnance_Medicament values (@qte,@nbr_jr,@nom_medic,@ord_num,@id_doc)
end


--SupprimerOrd_Medicament
go
alter proc SupprimerOrd_Medicament @id_doc int
as begin
	delete from Ordonnance_Medicament where Id_Doc = @id_doc
end

--ModifierOrd_Medicament 
go
create proc ModifierOrd_Medicament   @qte int,@nbr_jr int,@nom_medic varchar(30),@ord_num int,@id_doc int
as begin
	update Ordonnance_Medicament set  
									  Quantite=@qte,
									  Nbrjr=@nbr_jr,
									  Nom_medic=@nom_medic,
									  Ord_Num=@ord_num
									  where Id_Doc=@id_doc
end

---------- ------------------------------------------------------------------Procedures stokées Test-------- ---------------------------------------------------------------
go
--AfficherTest
alter proc AfficherTest
as begin
	select t.Nom_test as 'Nom Test' ,t.Prix_test as 'Prix' ,concat(d.Nom_Doc,' ',d.Prenom_Doc) as  'Docteur'  from Test t,Doctor d
	where t.Id_Doc=d.Id_Doc
end

go
--RechercherNomTest
create proc RechercherNomTest @nom_test varchar(30)
as begin
	select t.Nom_test as 'Nom Test' ,t.Prix_test  as 'Prix' ,concat(d.Nom_Doc,' ',d.Prenom_Doc) as  'Docteur'  from Test t,Doctor d
	where t.Id_Doc=d.Id_Doc and t.Nom_test=@nom_test
end

go
create proc RechercherTestDocNom @nom_doc varchar(30)
as begin
	select t.Nom_test as 'Nom Test' ,t.Prix_test  as 'Prix' ,concat(d.Nom_Doc,' ',d.Prenom_Doc) as  'Docteur'  from Test t,Doctor d
	where t.Id_Doc=d.Id_Doc and d.Nom_Doc=@nom_doc
end



--exec RechercherTest 'scanner'
--select * from test
go
select * from Doctor

--AjouterTest
create proc AjouterTest @nom_test varchar(30),@prix_test int,@id_doc int
as begin
		insert into Test values (@nom_test,@prix_test,@id_doc)
end

go
--SupprimerTest
drop proc SupprimerTest
create proc SupprimerTest @id_doc int, @nom varchar(30)
as begin
	delete from Test where Id_Doc=@id_doc and Nom_test = @nom
end

go
--ModifierTest
create proc ModifierTest   @nom_test varchar(30),@prix_test int,@id_doc int , @nom varchar(30)
as begin,
	update Test set Nom_test=@nom_test,
					Prix_test=@prix_test
					where Id_Doc=@id_doc and Nom_test = @nom
end


