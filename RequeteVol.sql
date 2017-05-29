///Sous traitance

select v.id as Vol1,af.id as Vol2,r.passager,v.avion as avion1,af.avion as avion2,v.depart,v.destination as Escale,af.destination,(((v.prixBillet+c.tarif)*t.tarif)-t.remise)+(af.prixBillet+((af.prixBillet*10)/100))  as prix from Vol v, Reservation r,AirFrance af, classe c,Types t where v.id = r.vol and v.depart = r.depart and t.nom = r.type and v.destination = af.depart and r.destination = af.destination and r.classe = c.nom

///Sous traitance 2

select r.id,r.passager,r.depart,r.destination,af.destination,r.nationalite,r.date,r.classe,r.vol,r.volretour,r.type,(((v.prixBillet+c.tarif)*t.tarif)-t.remise)+(af.prixBillet+((af.prixBillet*10)/100)) as prix from destination d, reservation r, classe c, vol v, types t,AirFrance af where r.destination = d.nom and c.nom = r.classe and v.destination = r.destination and v.depart = r.depart and t.nom = r.type and v.destination = af.depart and r.destination = af.destination and v.placeTotal>0 order by r.id ASC 

insert into Compagnie values('AF001','AV001','Air France','Paris','USA','2017-05-23 00:00:00.000','2017-05-24 00:00:00.000','30','21','224','275','450','NULL','NULL');
insert into Compagnie values('AF002','AV003','Air France','Paris','Canada','2017-05-17 00:00:00.000','2017-05-18 00:00:00.000','8','0','156','164','428','NULL','NULL');
insert into Compagnie values('AF003','AV003','Air France','Marseille','Londres','2017-06-17 00:00:00.000','2017-05-18 00:00:00.000','8','0','156','164','119','NULL','NULL');
insert into Compagnie values('AF004','AV001','Air France','Marseille','Australie','2017-05-21 00:00:00.000','2017-05-22 00:00:00.000','30','21','224','275','1006','NULL','NULL');
insert into Compagnie values('AF005','AV001','Air France','Paris','Bresil','2017-05-29 00:00:00.000','2017-05-30 00:00:00.000','30','21','224','275','762','NULL','NULL');

insert into Compagnie values('AF006','AV002','Air Mauritius','Tana','Maurice','2017-07-23 00:00:00.000','2017-07-24 00:00:00.000','8','0','62','70','401','NULL','NULL');
insert into Compagnie values('AF007','AV004','Air Mauritius','Tana','Reunion','2017-05-29 00:00:00.000','2017-05-30 00:00:00.000','12','0','62','74','368','NULL','NULL');
insert into Compagnie values('AF008','AV003','Air Mauritius','Tana','Seychele','2017-06-21 00:00:00.000','2017-06-22 00:00:00.000','8','0','156','164','401','NULL','NULL');
insert into Compagnie values('AF009','AV002','Air Mauritius','Tana','Comores','2017-06-27 00:00:00.000','2017-06-28 00:00:00.000','8','0','62','70','762','NULL','NULL');
insert into Compagnie values('AF010','AV001','Air Mauritius','Tana','Mayotes','2017-06-14 00:00:00.000','2017-06-15 00:00:00.000','30','21','224','275','762','NULL','NULL');



insert into vol values('VO001','AV004','Tana','Saint-Denis','2017-07-12 02:00:00.000','2017-07-13 06:00:00.000','12','0','62','73','341','NULL','NULL');
insert into vol values('VO002','AV003','Tana','Moroni','2017-08-22 00:00:00.000','2017-08-23 06:00:00.000','8','0','156','163','250','NULL','NULL');
insert into vol values('VO003','AV001','Tana','Paris','2017-07-30 23:00:00.000','2017-07-31 06:00:00.000','30','21','224','270','768','NULL','VO007');
insert into vol values('VO004','AV002','Tana','Marseille','2017-07-07 12:00:00.000','2017-07-07 18:00:00.000','8','0','62','63','765','NULL','VO008');
insert into vol values('VO005','AV005','Tana','Nosy-be','2017-07-13 02:00:00.000','2017-07-13 06:00:00.000','0','0','19','18','400','NULL','NULL');
insert into vol values('VO006','AV001','Tana','guangzhou','2017-07-13 02:00:00.000','2017-11-20 16:00:00.000','30','21','224','271','820','NULL','VO009');
insert into vol values('VO007','AV001','Paris','Tana','2017-08-12 00:00:00.000','2017-08-13 00:00:00.000','30','21','224','70','764','VO003','NULL');
insert into vol values('VO008','AV002','Marseille','Tana','2017-07-16 00:00:00.000','2017-07-17 00:00:00.000','8','0','62','51','761','VO004','NULL');
insert into vol values('VO009','AV001','guangzhou','Tana','2017-11-30 00:00:00.000','2017-12-01 00:00:00.000','30','21','224','275','816','VO006','NULL');
insert into vol values('VO010','AV005','Tana','Diego','2017-07-12 02:00:00.000','2017-07-13 06:00:00.000','0','0','19','19','289','NULL','NULL');
insert into vol values('VO011','AV001','Paris','Tana','2017-07-22 02:00:00.000','2017-07-23 06:00:00.000','30','21','224','274','764','NULL','NULL');


insert into soustraitance values('SO01','Air Mauritius','Economique','','','','Aller')
insert into soustraitance values('SO02','Air Mauritius','Economique','','','','Aller Retour')
insert into soustraitance values('SO03','Air Mauritius','Affaire','','','','Aller')
insert into soustraitance values('SO04','Air Mauritius','Affaire','','','','Aller Retour')
insert into soustraitance values('SO05','Air France','Economique','','','','Aller')
insert into soustraitance values('SO06','Air France','Economique','','','','Aller Retour')
insert into soustraitance values('SO07','Air France','Affaire','','','','Aller')
insert into soustraitance values('SO08','Air France','Affaire','','','','Aller Retour')

insert into mpiasa values('EMP01','Rakoto','Pilote','Homme','1000');
insert into mpiasa values('EMP02','Jerry','Pilote','Homme','1000');
insert into mpiasa values('EMP03','Randria','Mecanicien','Homme','500');
insert into mpiasa values('EMP04','Ravao','Hotesse','Femme','500');
insert into mpiasa values('EMP08','Rasoa','Hotesse','Femme','500');
insert into mpiasa values('EMP05','Balita','Mecanicien','Homme','500');
insert into mpiasa values('EMP06','Koto','Bagagiste','Homme','350');
insert into mpiasa values('EMP07','Boby','Bagagiste','Homme','350');



select c.compagnie,r.classe,COUNT(r.id) as nombre, SUM(c.prixBillet*COUNT(r.id)) as montantDu,SUM((c.prixBillet*COUNT(r.id))+(((c.prixBillet*COUNT(r.id))*10)/100)) as montantVente, r.type from Reservation r, compagnie c where r.destination = c.destination group by c.compagnie, r.classe, r.type


select c.compagnie,r.classe, count(r.id) as nombre,r.type from Reservation r, compagnie c where r.destination = c.destination group by c.compagnie, r.classe, r.type

create view nombreBillet as select c.compagnie,r.classe, count(r.id) as nombre,r.type from Reservation r, compagnie c where r.destination = c.destination group by c.compagnie, r.classe, r.type

//Tena izy amzay
select nbre.compagnie,nbre.classe,nbre.nombre,nbre.type,SUM(c.prixBillet*nbre.nombre) as montantDu,SUM((c.prixBillet*nbre.nombre)+(((c.prixBillet*nbre.nombre)*10)/100)) as montantVente from nombreBillet nbre,compagnie c where c.compagnie = nbre.compagnie group by nbre.compagnie,nbre.classe,nbre.nombre,nbre.type


//Consommation avion 1
create view consommationAvion as select av.nom,v.depart, v.destination,({fn HOUR(v.heureArrivee)}-{fn HOUR(v.heureDepart)}) as heureDeVol,av.carburant,(({fn HOUR(v.heureArrivee)}-{fn HOUR(v.heureDepart)})*av.carburant) as consommation,(({fn HOUR(v.heureArrivee)}-{fn HOUR(v.heureDepart)})*av.carburant)*0.93 as prixK from Vol v,Avion av where v.avion = av.id;

//Consommation avion 2
create view consAv as select v.depart,v.destination,av.nom,av.carburant,({fn HOUR(v.heureArrivee)}-{fn HOUR(v.heureDepart)}) as heureDeVol from Avion av,Vol v where av.id = v.avion

//somme reservation
create view SommeReservation as select r.id,av.nom,r.passager,r.destination,r.nationalite,r.date,r.classe,r.vol,r.volretour,r.type,((v.prixBillet+c.tarif)*t.tarif)-t.remise as prix from destination d, reservation r, classe c, vol v, types t,avion av where r.destination = d.nom and c.nom = r.classe and v.destination = r.destination and v.depart = r.depart and t.nom = r.type and v.avion = av.nom and v.placeTotal>0

//depense
create view depense as select SUM(c.prixK) as consommation,SUM(mp.salaire) as salaire,SUM(c.prixK)+SUM(mp.salaire) as depense from consommationAvion c, mpiasa mp

//benefice detaillé
select sum(c.prixK) as avion,SUM(mp.salaire) as salaire, sum(c.prixK)+SUM(mp.salaire) as consommation,SUM(s.prix) as reservation, sT.benefice as sousTraitance,(SUM(s.prix)-(sum(c.prixK)+SUM(mp.salaire)))+sT.benefice as benefice  from SommeReservations s, consommationAvion c,mpiasa mp,SousTraitance2 sT where c.nom = s.nom group by sT.benefice

//benefice
select sum(c.prixK)+SUM(mp.salaire) as consommation,SUM(s.prix) as reservation, SUM(s.prix)-(sum(c.prixK)+SUM(mp.salaire)) as benefice  from SommeReservations s, consommationAvion c,mpiasa mp where c.nom = s.nom

//benefice par mois
select c.CarburantTotal as avion,s.salaire,s.salaire+c.CarburantTotal as depense,r.prix as reservation,sT.TotalSousT as sousTraitance,(r.prix-(s.salaire+c.CarburantTotal))+sT.TotalSousT as benefice from SalaireTotal s,CarbuTotal c,ReservationTotal r,TotalSousT sT,Vol v where {fn MONTH(v.heureDepart)}='08' group by c.CarburantTotal,s.salaire,s.salaire+c.CarburantTotal,r.prix,sT.TotalSousT,(r.prix-(s.salaire+c.CarburantTotal))+sT.TotalSousT